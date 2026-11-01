using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmChiTietHopDong : Form
    {
        private readonly DataGridView grid = Ui.Grid();
        public FrmChiTietHopDong()
        {
            Text = "Danh sách phòng thuê theo hợp đồng";
            Width = 1030;
            Height = 640;
            Controls.Add(grid);
            Controls.Add(Ui.Actions(Ui.Button("Làm mới", (s, e) => RefreshList())));
            Load += (s, e) => RefreshList();
        }
        private void RefreshList() { Ui.Run(() => grid.DataSource = HopDongService.ListDetails()); }
    }
}
