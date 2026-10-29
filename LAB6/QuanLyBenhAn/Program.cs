using System;
using System.Windows.Forms;
using QuanLyBenhAn_GiaHuy.Forms;
namespace QuanLyBenhAn_GiaHuy { internal static class Program { [STAThread] static void Main() { Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false); Application.Run(new FrmMain()); } } }
