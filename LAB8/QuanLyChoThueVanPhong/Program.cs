using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Forms;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Database.Initialize(Database.ConnectionString);
            }
            catch
            {
                using (var setup = new FrmKetNoi())
                {
                    if (setup.ShowDialog() != DialogResult.OK) return;
                }
            }
            Application.Run(new FrmMain());
        }
    }
}
