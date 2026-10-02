using System;
using System.Windows.Forms;
using eSHOPPING.UI;

namespace eSHOPPING
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show(
                    e.Exception.Message,
                    "Lỗi hệ thống",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Lỗi không xác định",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            };

            Application.Run(new FrmSanPham());
        }
    }
}