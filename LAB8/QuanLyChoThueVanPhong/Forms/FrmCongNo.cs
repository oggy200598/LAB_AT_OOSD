using System;
using System.Data;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmCongNo : Form
    {
        private readonly DataGridView grid = Ui.Grid();
        private readonly Label total = new Label { AutoSize = true, Margin = new Padding(8, 12, 0, 0) };
        public FrmCongNo()
        {
            Text = "Công nợ thuê phòng và dịch vụ";
            Width = 1060;
            Height = 650;
            Controls.Add(grid);
            Controls.Add(Ui.Actions(Ui.Button("Cập nhật công nợ", (s, e) => RefreshList(), 170), total));
            Load += (s, e) => RefreshList();
        }
        private void RefreshList()
        {
            Ui.Run(() =>
            {
                var data = ThanhToanService.Debts();
                grid.DataSource = data;
                decimal due = 0;
                foreach (DataRow row in data.Rows) due += Convert.ToDecimal(row["ConNo"]);
                total.Text = "Tổng công nợ: " + due.ToString("N0") + " đồng";
            });
        }
    }
}
