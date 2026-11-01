using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmHoaDonDichVu : Form
    {
        private readonly NumericUpDown month = Ui.Number(1, 12, DateTime.Today.AddMonths(-1).Month);
        private readonly NumericUpDown year = Ui.Number(2000, 2100, DateTime.Today.AddMonths(-1).Year);
        private readonly DataGridView grid = Ui.Grid();

        public FrmHoaDonDichVu()
        {
            Text = "Hóa đơn dịch vụ cuối tháng";
            Width = 1080;
            Height = 685;
            var actions = Ui.Actions(
                new Label { Text = "Tháng:", AutoSize = true, Margin = new Padding(6, 12, 0, 0) }, month,
                new Label { Text = "Năm:", AutoSize = true, Margin = new Padding(6, 12, 0, 0) }, year,
                Ui.Button("Lập hóa đơn", (s, e) => Generate(), 140),
                Ui.Button("Làm mới", (s, e) => RefreshList()));
            Controls.Add(grid);
            Controls.Add(actions);
            Load += (s, e) => RefreshList();
        }
        private void RefreshList() { Ui.Run(() => grid.DataSource = HoaDonService.ServiceBills()); }
        private void Generate()
        {
            Ui.Run(() =>
            {
                int result = HoaDonService.GenerateServices((int)month.Value, (int)year.Value);
                RefreshList();
                MessageBox.Show("Đã lập " + result + " hóa đơn dịch vụ cho kỳ " + month.Value + "/" + year.Value + ".");
            });
        }
    }
}
