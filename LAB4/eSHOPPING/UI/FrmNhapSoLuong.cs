using System;
using System.Windows.Forms;

namespace eSHOPPING.UI
{
    public partial class FrmNhapSoLuong : Form
    {
        public int Quantity { get { return (int)num.Value; } }

        public FrmNhapSoLuong(int current, int max)
        {
            InitializeComponent();
            num.Maximum = max > 0 ? max : 1;
            num.Value = Math.Min(Math.Max(current > 0 ? current : 1, 1), num.Maximum);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
