using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmHopDong : Form
    {
        private readonly ComboBox customer = new ComboBox();
        private readonly ComboBox manager = new ComboBox();
        private readonly DateTimePicker start = Ui.Date(DateTime.Today);
        private readonly NumericUpDown months = Ui.Number(6, 120, 6);
        private readonly ComboBox paymentMethod = new ComboBox();
        private readonly TextBox terms = new TextBox();
        private readonly CheckBox confirmed = new CheckBox { Text = "Xác nhận đã nhận đủ tiền thuê 6 tháng đầu" };
        private readonly Label summary = new Label { AutoSize = true };
        private readonly DataGridView rooms = Ui.Grid();
        private readonly DataGridView contracts = Ui.Grid();

        public FrmHopDong()
        {
            Text = "Ký hợp đồng thuê";
            Width = 1170;
            Height = 740;
            var tabs = new TabControl { Dock = DockStyle.Fill };
            var create = new TabPage("Lập hợp đồng và thu trước 6 tháng");
            var history = new TabPage("Danh sách hợp đồng");
            tabs.TabPages.Add(create);
            tabs.TabPages.Add(history);
            Controls.Add(tabs);
            var fields = new TableLayoutPanel { Dock = DockStyle.Top, ColumnCount = 4, RowCount = 4, Height = 170, Padding = new Padding(8) };
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145));
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145));
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            AddField(fields, 0, 0, "Khách hàng:", customer);
            AddField(fields, 2, 0, "Nhân viên quản lý:", manager);
            AddField(fields, 0, 1, "Ngày bắt đầu thuê:", start);
            AddField(fields, 2, 1, "Số tháng thuê:", months);
            AddField(fields, 0, 2, "Đã thu bằng:", paymentMethod);
            AddField(fields, 2, 2, "Điều khoản:", terms);
            fields.Controls.Add(confirmed, 1, 3);
            fields.SetColumnSpan(confirmed, 3);
            paymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            paymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            paymentMethod.SelectedIndex = 0;
            var actions = Ui.Actions(
                Ui.Button("Tìm phòng trống", (s, e) => RefreshRooms(), 170),
                Ui.Button("Ký và thu đủ 6 tháng", (s, e) => Sign(), 200),
                summary);
            summary.Margin = new Padding(18, 12, 0, 0);
            create.Controls.Add(rooms);
            create.Controls.Add(actions);
            create.Controls.Add(fields);
            rooms.AutoGenerateColumns = true;
            rooms.DataBindingComplete += (s, e) => Summarize();
            rooms.CellValueChanged += (s, e) => Summarize();
            rooms.CurrentCellDirtyStateChanged += (s, e) => { if (rooms.IsCurrentCellDirty) rooms.CommitEdit(DataGridViewDataErrorContexts.Commit); };
            var historyActions = Ui.Actions(
                Ui.Button("Tải danh sách", (s, e) => RefreshContracts()),
                Ui.Button("Thanh lý hợp đồng", (s, e) => Liquidate(), 170));
            history.Controls.Add(contracts);
            history.Controls.Add(historyActions);
            start.ValueChanged += (s, e) => { if (IsHandleCreated) RefreshRooms(); };
            months.ValueChanged += (s, e) => { if (IsHandleCreated) RefreshRooms(); };
            Load += (s, e) => Ui.Run(() =>
            {
                Ui.Bind(customer, "SELECT MaKH AS Ma,MaKH+N' - '+TenKH AS Ten FROM dbo.KhachHang ORDER BY TenKH");
                Ui.Bind(manager, "SELECT MaNVQL AS Ma,MaNVQL+N' - '+HoTen AS Ten FROM dbo.NhanVienQuanLy ORDER BY HoTen");
                RefreshRooms();
                RefreshContracts();
            });
        }

        private void AddField(TableLayoutPanel layout, int x, int y, string name, Control value)
        {
            layout.Controls.Add(new Label { Text = name, Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleLeft }, x, y);
            value.Dock = DockStyle.Fill;
            layout.Controls.Add(value, x + 1, y);
        }

        private void RefreshRooms()
        {
            Ui.Run(() =>
            {
                var data = HopDongService.AvailableRooms(start.Value.Date, (int)months.Value);
                rooms.DataSource = null;
                rooms.Columns.Clear();
                rooms.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Chon", HeaderText = "Chọn", Width = 50 });
                rooms.DataSource = data;
                Summarize();
            });
        }

        private void Summarize()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in rooms.Rows)
                if (Convert.ToBoolean(row.Cells["Chon"].Value ?? false)) total += Convert.ToDecimal(row.Cells["GiaThue"].Value);
            summary.Text = "Tiền thuê/tháng: " + total.ToString("N0") + " | Trả trước 6 tháng: " + (total * 6).ToString("N0") + " đồng";
        }

        private void Sign()
        {
            Ui.Run(() =>
            {
                var ids = new List<string>();
                foreach (DataGridViewRow row in rooms.Rows)
                    if (Convert.ToBoolean(row.Cells["Chon"].Value ?? false)) ids.Add(Convert.ToString(row.Cells["MaPhong"].Value));
                if (!confirmed.Checked) throw new InvalidOperationException("Phải xác nhận đã thu đủ tiền thuê 6 tháng đầu mới được ký hợp đồng.");
                if (MessageBox.Show("Xác nhận đã nhận đủ tiền thuê 6 tháng cho " + ids.Count + " phòng?",
                    "Xác nhận thu tiền", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                string id = HopDongService.SignContract(Ui.Selected(customer), Ui.Selected(manager), start.Value, (int)months.Value,
                    ids, terms.Text, Convert.ToString(paymentMethod.SelectedItem));
                MessageBox.Show("Đã lưu hợp đồng, hóa đơn và thanh toán: " + id);
                confirmed.Checked = false;
                RefreshRooms();
                RefreshContracts();
            });
        }

        private void RefreshContracts()
        {
            Ui.Run(() => contracts.DataSource = HopDongService.ListContracts());
        }

        private void Liquidate()
        {
            if (contracts.CurrentRow == null) { MessageBox.Show("Chọn hợp đồng cần thanh lý."); return; }
            string id = Convert.ToString(contracts.CurrentRow.Cells["MaHD"].Value);
            if (MessageBox.Show("Thanh lý hợp đồng " + id + "?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Ui.Run(() => { HopDongService.Liquidate(id); RefreshContracts(); MessageBox.Show("Đã thanh lý hợp đồng."); });
        }
    }
}
