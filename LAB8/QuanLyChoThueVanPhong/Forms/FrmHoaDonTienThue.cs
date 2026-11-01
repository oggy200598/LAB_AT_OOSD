using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmHoaDonTienThue : Form
    {
        private readonly DataGridView grid = Ui.Grid();
        public FrmHoaDonTienThue()
        {
            Text = "Hóa đơn tiền thuê - thu từ tháng thứ 7";
            Width = 1120;
            Height = 690;
            Controls.Add(grid);
            Controls.Add(Ui.Actions(
                Ui.Button("Lập hóa đơn đến hôm nay", (s, e) => Generate(), 200),
                Ui.Button("Làm mới", (s, e) => RefreshList())));
            Load += (s, e) => RefreshList();
        }
        private void RefreshList() { Ui.Run(() => grid.DataSource = HoaDonService.RentBills()); }
        private void Generate()
        {
            Ui.Run(() =>
            {
                int count = HoaDonService.GenerateRent(DateTime.Today);
                RefreshList();
                MessageBox.Show("Đã lập " + count + " hóa đơn tiền thuê mới. Hạn thanh toán là đầu tháng thuê.");
            });
        }
    }
}
