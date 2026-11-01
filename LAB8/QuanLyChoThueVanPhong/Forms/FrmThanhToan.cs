using System;
using System.Globalization;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmThanhToan : Form
    {
        private readonly DataGridView debts = Ui.Grid();
        private readonly DataGridView history = Ui.Grid();
        private readonly TextBox amount = new TextBox { Width = 145 };
        private readonly ComboBox method = new ComboBox { Width = 130, DropDownStyle = ComboBoxStyle.DropDownList };

        public FrmThanhToan()
        {
            Text = "Thu tiền thuê và dịch vụ";
            Width = 1110;
            Height = 720;
            var tabs = new TabControl { Dock = DockStyle.Fill };
            var duesTab = new TabPage("Hóa đơn còn nợ");
            var historyTab = new TabPage("Lịch sử thanh toán");
            tabs.TabPages.Add(duesTab);
            tabs.TabPages.Add(historyTab);
            Controls.Add(tabs);
            method.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            method.SelectedIndex = 0;
            var actions = Ui.Actions(
                new Label { Text = "Số tiền:", AutoSize = true, Margin = new Padding(6, 12, 2, 0) }, amount,
                new Label { Text = "Hình thức:", AutoSize = true, Margin = new Padding(6, 12, 2, 0) }, method,
                Ui.Button("Thu tiền", (s, e) => Pay()),
                Ui.Button("Thu hết công nợ", (s, e) => FillAmount(), 155),
                Ui.Button("Làm mới", (s, e) => RefreshList()));
            duesTab.Controls.Add(debts);
            duesTab.Controls.Add(actions);
            historyTab.Controls.Add(history);
            historyTab.Controls.Add(Ui.Actions(Ui.Button("Làm mới", (s, e) => RefreshList())));
            debts.SelectionChanged += (s, e) => FillAmount();
            Load += (s, e) => RefreshList();
        }
        private void RefreshList()
        {
            Ui.Run(() =>
            {
                debts.DataSource = ThanhToanService.Debts();
                history.DataSource = ThanhToanService.Payments();
                FillAmount();
            });
        }
        private void FillAmount()
        {
            if (debts.CurrentRow != null && debts.CurrentRow.Cells["ConNo"].Value != null)
                amount.Text = Convert.ToDecimal(debts.CurrentRow.Cells["ConNo"].Value).ToString("0.##");
        }
        private void Pay()
        {
            if (debts.CurrentRow == null) { MessageBox.Show("Chọn hóa đơn cần thanh toán."); return; }
            Ui.Run(() =>
            {
                decimal money;
                if (!decimal.TryParse(amount.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out money) &&
                    !decimal.TryParse(amount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out money))
                    throw new InvalidOperationException("Số tiền nhập không hợp lệ.");
                string type = Convert.ToString(debts.CurrentRow.Cells["Loai"].Value);
                string billId = Convert.ToString(debts.CurrentRow.Cells["MaHoaDon"].Value);
                string receipt = ThanhToanService.Pay(type, billId, money, Convert.ToString(method.SelectedItem));
                MessageBox.Show("Đã thu tiền. Mã biên lai: " + receipt);
                RefreshList();
            });
        }
    }
}
