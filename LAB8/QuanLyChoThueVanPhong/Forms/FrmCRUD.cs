using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Forms
{
    public enum FieldKind { Text, Number, Money, Date, Lookup, Options }

    public class FieldDef
    {
        public string Column { get; private set; }
        public string Label { get; private set; }
        public FieldKind Kind { get; private set; }
        public bool Required { get; private set; }
        public string Source { get; private set; }

        public FieldDef(string column, string label, FieldKind kind = FieldKind.Text, bool required = false, string source = null)
        {
            Column = column;
            Label = label;
            Kind = kind;
            Required = required;
            Source = source;
        }
    }

    public class FrmCRUD : Form
    {
        private readonly string table;
        private readonly string key;
        private readonly List<FieldDef> fields;
        private readonly Dictionary<string, Control> controls = new Dictionary<string, Control>();
        private readonly DataGridView grid = Ui.Grid();
        private readonly TextBox filter = new TextBox { Width = 180 };
        private string currentKey;

        public FrmCRUD(string title, string tableName, string keyName, params FieldDef[] definitions)
        {
            Text = title;
            table = tableName;
            key = keyName;
            fields = definitions.ToList();
            Width = 1100;
            Height = 690;
            var root = new Panel { Dock = DockStyle.Fill };
            Controls.Add(root);
            var formHeight = ((fields.Count + 2) / 3) * 66 + 18;
            var fieldsArea = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = formHeight,
                ColumnCount = 3,
                RowCount = (fields.Count + 2) / 3,
                AutoScroll = true,
                Padding = new Padding(8)
            };
            for (int x = 0; x < 3; x++) fieldsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333f));
            for (int i = 0; i < fields.Count; i++)
            {
                FieldDef field = fields[i];
                Control input = NewControl(field);
                controls.Add(field.Column, input);
                var part = new Panel { Dock = DockStyle.Fill };
                var label = new Label { Text = field.Label + (field.Required ? " *" : ""), Left = 4, Top = 2, Width = 290 };
                input.SetBounds(4, 24, 290, 26);
                input.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                part.Controls.Add(label);
                part.Controls.Add(input);
                fieldsArea.Controls.Add(part, i % 3, i / 3);
            }
            var actions = Ui.Actions(
                Ui.Button("Thêm", (s, e) => Save(false)),
                Ui.Button("Sửa", (s, e) => Save(true)),
                Ui.Button("Xóa", (s, e) => Delete()),
                Ui.Button("Làm mới", (s, e) => { Clear(); RefreshList(); }),
                new Label { Text = "Tìm:", AutoSize = true, Margin = new Padding(12, 12, 0, 0) }, filter,
                Ui.Button("Tìm kiếm", (s, e) => ApplyFilter(), 90));
            filter.Margin = new Padding(4, 8, 4, 4);
            root.Controls.Add(grid);
            root.Controls.Add(actions);
            root.Controls.Add(fieldsArea);
            grid.SelectionChanged += SelectRow;
            Load += (s, e) => Ui.Run(RefreshList);
        }

        private Control NewControl(FieldDef field)
        {
            if (field.Kind == FieldKind.Date) return Ui.Date(DateTime.Today);
            if (field.Kind == FieldKind.Lookup)
            {
                var combo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
                try { Ui.Bind(combo, field.Source); } catch { }
                return combo;
            }
            if (field.Kind == FieldKind.Options)
            {
                var combo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
                combo.Items.AddRange(field.Source.Split('|').Cast<object>().ToArray());
                if (combo.Items.Count > 0) combo.SelectedIndex = 0;
                return combo;
            }
            return new TextBox { MaxLength = field.Column.StartsWith("Ma") ? 24 : 1000 };
        }

        private object Value(FieldDef field)
        {
            Control input = controls[field.Column];
            if (field.Kind == FieldKind.Date) return ((DateTimePicker)input).Value.Date;
            if (field.Kind == FieldKind.Lookup) return Ui.Selected((ComboBox)input) ?? (object)DBNull.Value;
            if (field.Kind == FieldKind.Options) return ((ComboBox)input).SelectedItem ?? (object)DBNull.Value;
            string text = ((TextBox)input).Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                if (field.Required) throw new InvalidOperationException("Chưa nhập " + field.Label + ".");
                return DBNull.Value;
            }
            if (field.Kind == FieldKind.Number)
            {
                int n;
                if (!int.TryParse(text, out n)) throw new InvalidOperationException(field.Label + " phải là số nguyên.");
                return n;
            }
            if (field.Kind == FieldKind.Money)
            {
                decimal value;
                if (!decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out value) &&
                    !decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
                    throw new InvalidOperationException(field.Label + " phải là số hợp lệ.");
                return value;
            }
            return text;
        }

        private void Save(bool edit)
        {
            Ui.Run(() =>
            {
                if (edit && currentKey == null) throw new InvalidOperationException("Chọn dòng cần sửa.");
                if (!edit && currentKey != null && Convert.ToString(Value(fields[0])) == currentKey)
                    throw new InvalidOperationException("Bấm Làm mới trước khi thêm bản ghi khác.");
                var values = fields.ToDictionary(f => f.Column, f => Value(f));
                ValidateRecord(values, edit);
                var parms = fields.Select(f => Database.P("@" + f.Column, values[f.Column])).ToArray();
                if (edit)
                {
                    var updateColumns = fields.Where(f => f.Column != key).ToList();
                    string set = string.Join(",", updateColumns.Select(f => "[" + f.Column + "]=@" + f.Column));
                    Database.Execute("UPDATE dbo.[" + table + "] SET " + set + " WHERE [" + key + "]=@oldKey",
                        parms.Concat(new[] { Database.P("@oldKey", currentKey) }).ToArray());
                }
                else
                {
                    string cols = string.Join(",", fields.Select(f => "[" + f.Column + "]"));
                    string args = string.Join(",", fields.Select(f => "@" + f.Column));
                    Database.Execute("INSERT INTO dbo.[" + table + "](" + cols + ") VALUES(" + args + ")", parms);
                }
                Clear();
                RefreshList();
            });
        }

        protected virtual void ValidateRecord(Dictionary<string, object> values, bool edit) { }

        private void Delete()
        {
            if (currentKey == null) { MessageBox.Show("Chọn dòng cần xóa."); return; }
            if (MessageBox.Show("Xóa bản ghi " + currentKey + "?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Ui.Run(() =>
            {
                Database.Execute("DELETE FROM dbo.[" + table + "] WHERE [" + key + "]=@id", Database.P("@id", currentKey));
                Clear();
                RefreshList();
            });
        }

        private void RefreshList()
        {
            var data = Database.Query("SELECT * FROM dbo.[" + table + "] ORDER BY [" + key + "] DESC");
            grid.DataSource = data;
            currentKey = null;
            grid.ClearSelection();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var view = grid.DataSource as DataTable;
            if (view == null) return;
            string term = filter.Text.Replace("'", "''").Replace("[", "[[]").Replace("%", "[%]").Replace("*", "[*]");
            view.DefaultView.RowFilter = string.IsNullOrWhiteSpace(term) ? "" : string.Join(" OR ",
                view.Columns.Cast<DataColumn>().Where(c => c.DataType == typeof(string)).Select(c =>
                    "CONVERT([" + c.ColumnName + "], 'System.String') LIKE '%" + term + "%'"));
        }

        private void SelectRow(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0 || grid.SelectedRows[0].DataBoundItem == null) return;
            var row = grid.SelectedRows[0].DataBoundItem as DataRowView;
            if (row == null) return;
            currentKey = Convert.ToString(row[key]);
            foreach (FieldDef field in fields)
            {
                object value = row[field.Column];
                Control control = controls[field.Column];
                if (field.Kind == FieldKind.Date) ((DateTimePicker)control).Value = value == DBNull.Value ? DateTime.Today : Convert.ToDateTime(value);
                else if (field.Kind == FieldKind.Lookup) ((ComboBox)control).SelectedValue = value;
                else if (field.Kind == FieldKind.Options) ((ComboBox)control).SelectedItem = Convert.ToString(value);
                else ((TextBox)control).Text = value == DBNull.Value ? "" : Convert.ToString(value);
            }
            if (controls[key] is TextBox) ((TextBox)controls[key]).ReadOnly = true;
        }

        private void Clear()
        {
            currentKey = null;
            foreach (FieldDef field in fields)
            {
                Control input = controls[field.Column];
                if (input is TextBox) { ((TextBox)input).Clear(); ((TextBox)input).ReadOnly = false; }
                else if (input is DateTimePicker) ((DateTimePicker)input).Value = DateTime.Today;
                else if (input is ComboBox && ((ComboBox)input).Items.Count > 0) ((ComboBox)input).SelectedIndex = 0;
            }
            grid.ClearSelection();
        }
    }
}
