using System;
using System.Globalization;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmSuDungDichVu : Form
    {
        private readonly ComboBox detail = new ComboBox();
        private readonly ComboBox service = new ComboBox();
        private readonly NumericUpDown month = Ui.Number(1, 12, DateTime.Today.AddMonths(-1).Month);
        private readonly NumericUpDown year = Ui.Number(2000, 2100, DateTime.Today.AddMonths(-1).Year);
        private readonly TextBox quantity = new TextBox();
        private readonly DataGridView grid = Ui.Grid();

        public FrmSuDungDichVu()
        {
            Text = "Ghi nhận sử dụng dịch vụ";
            Width = 1090;
            Height = 705;
            var form = new TableLayoutPanel { Dock = DockStyle.Top, Height = 183, ColumnCount = 2, RowCount = 5, Padding = new Padding(9) };
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170));
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Ui.Line(form, "Phòng theo hợp đồng:", detail, 0);
            Ui.Line(form, "Dịch vụ:", service, 1);
            Ui.Line(form, "Tháng:", month, 2);
            Ui.Line(form, "Năm:", year, 3);
            Ui.Line(form, "Số lượng sử dụng:", quantity, 4);
            Controls.Add(grid);
            Controls.Add(Ui.Actions(
                Ui.Button("Ghi nhận", (s, e) => Save()),
                Ui.Button("Xóa dòng chưa lập HĐ", (s, e) => Delete(), 190),
                Ui.Button("Làm mới", (s, e) => RefreshList())));
            Controls.Add(form);
            Load += (s, e) => Ui.Run(() =>
            {
                Ui.Bind(detail, "SELECT MaCTHD AS Ma,MaPhong+N' / '+MaHD AS Ten FROM dbo.ChiTietHopDong ORDER BY MaPhong");
                Ui.Bind(service, "SELECT MaDV AS Ma,TenDV AS Ten FROM dbo.DichVu ORDER BY TenDV");
                RefreshList();
            });
        }

        private void RefreshList() { Ui.Run(() => grid.DataSource = DichVuService.UsageList()); }
        private void Save()
        {
            Ui.Run(() =>
            {
                decimal amount;
                if (!decimal.TryParse(quantity.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out amount) &&
                    !decimal.TryParse(quantity.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out amount))
                    throw new InvalidOperationException("Số lượng không hợp lệ.");
                string id = DichVuService.Record(Ui.Selected(detail), Ui.Selected(service), (int)month.Value, (int)year.Value, amount);
                MessageBox.Show("Đã ghi nhận sử dụng dịch vụ: " + id);
                quantity.Clear();
                RefreshList();
            });
        }

        private void Delete()
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Chọn dòng cần xóa."); return; }
            string id = Convert.ToString(grid.CurrentRow.Cells["MaSDDV"].Value);
            if (MessageBox.Show("Xóa dòng " + id + "?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Ui.Run(() => { DichVuService.Remove(id); RefreshList(); });
        }
    }
}
