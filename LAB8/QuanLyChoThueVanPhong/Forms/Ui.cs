using System;
using System.Data;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Forms
{
    internal static class Ui
    {
        public static DataGridView Grid()
        {
            return new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells,
                RowHeadersVisible = false,
                BackgroundColor = System.Drawing.SystemColors.Window
            };
        }

        public static Button Button(string text, EventHandler onClick, int width = 130)
        {
            var control = new Button { Text = text, Width = width, Height = 30, Margin = new Padding(4) };
            control.Click += onClick;
            return control;
        }

        public static FlowLayoutPanel Actions(params Control[] controls)
        {
            var panel = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 42, Padding = new Padding(6), AutoSize = false };
            panel.Controls.AddRange(controls);
            return panel;
        }

        public static void Bind(ComboBox combo, string sql)
        {
            var table = Database.Query(sql);
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.DisplayMember = "Ten";
            combo.ValueMember = "Ma";
            combo.DataSource = table;
        }

        public static string Selected(ComboBox combo)
        {
            return combo.SelectedValue == null || combo.SelectedValue is DataRowView ? null : Convert.ToString(combo.SelectedValue);
        }

        public static void Run(Action action, Action refresh = null)
        {
            try
            {
                action();
                if (refresh != null) refresh();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Line(TableLayoutPanel panel, string title, Control control, int row)
        {
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34));
            panel.Controls.Add(new Label { Text = title, TextAlign = System.Drawing.ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, row);
            control.Dock = DockStyle.Fill;
            control.Margin = new Padding(3);
            panel.Controls.Add(control, 1, row);
        }

        public static DateTimePicker Date(DateTime date)
        {
            return new DateTimePicker { Format = DateTimePickerFormat.Short, Value = date.Date };
        }

        public static NumericUpDown Number(int min, int max, int initial)
        {
            return new NumericUpDown { Minimum = min, Maximum = max, Value = initial, Width = 100 };
        }
    }
}
