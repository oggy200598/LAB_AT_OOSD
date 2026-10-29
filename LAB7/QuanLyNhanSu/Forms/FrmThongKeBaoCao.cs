using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmThongKeBaoCao : Form
    {
        private readonly ThongKeService service = new ThongKeService();

        public FrmThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void FrmThongKeBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                cboNhom.SelectedIndex = 0;

                cboPhongBan.DisplayMember = "TenPhongBan";
                cboPhongBan.ValueMember = "MaPhongBan";

                DataTable danhSach = service.LayPhongBan();

                DataRow dongTatCa = danhSach.NewRow();
                dongTatCa["MaPhongBan"] = "";
                dongTatCa["TenPhongBan"] = "Tất cả phòng ban";

                danhSach.Rows.InsertAt(dongTatCa, 0);

                cboPhongBan.DataSource = danhSach;
                cboPhongBan.SelectedIndex = 0;

                nudThang.Value = DateTime.Today.Month;
                nudNam.Value = DateTime.Today.Year;

                CapNhatBoLoc();
                ThucHienThongKe();
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void cboNhom_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CapNhatBoLoc();
        }

        private void CapNhatBoLoc()
        {
            bool thongKeNhanVien = cboNhom.Text == "Nhân viên";

            cboPhanLoai.Enabled = thongKeNhanVien;
            nudThang.Enabled = !thongKeNhanVien;
            nudNam.Enabled = !thongKeNhanVien;

            if (thongKeNhanVien)
            {
                cboPhanLoai.Items.Clear();
                cboPhanLoai.Items.Add("Phòng ban");
                cboPhanLoai.Items.Add("Giới tính");
                cboPhanLoai.Items.Add("Trạng thái");
                cboPhanLoai.SelectedIndex = 0;
            }
            else
            {
                cboPhanLoai.Items.Clear();
                cboPhanLoai.Items.Add("Theo phòng ban");
                cboPhanLoai.SelectedIndex = 0;
            }

            lblKetQua.Text = "Chọn Thống kê để xem kết quả.";
        }

        private string LayMaPhongBan()
        {
            if (cboPhongBan.SelectedValue == null ||
                cboPhongBan.SelectedValue is DataRowView)
                return "";

            return Convert.ToString(cboPhongBan.SelectedValue);
        }

        private void ThucHienThongKe()
        {
            DataTable ketQua = service.ThongKe(
                cboNhom.Text,
                cboPhanLoai.Text,
                (int)nudThang.Value,
                (int)nudNam.Value,
                LayMaPhongBan());

            dgvThongKe.DataSource = ketQua;

            DinhDangBang();

            lblKetQua.Text =
                "Số nhóm kết quả: " + ketQua.Rows.Count;

            decimal tongTien = 0;
            string cotTong = null;

            if (ketQua.Columns.Contains("TongThucLanh"))
                cotTong = "TongThucLanh";
            else if (ketQua.Columns.Contains("TongLuongThuViec"))
                cotTong = "TongLuongThuViec";

            if (cotTong != null)
            {
                foreach (DataRow row in ketQua.Rows)
                {
                    if (row[cotTong] != DBNull.Value)
                        tongTien += Convert.ToDecimal(row[cotTong]);
                }

                lblKetQua.Text +=
                    "     Tổng tiền: " + tongTien.ToString("N2");
            }

            dgvThongKe.ClearSelection();
        }

        private void DinhDangBang()
        {
            dgvThongKe.AutoGenerateColumns = true;

            foreach (DataGridViewColumn cot in dgvThongKe.Columns)
            {
                string ten = cot.Name;

                if (ten == "MaPhongBan")
                    cot.HeaderText = "Mã phòng ban";
                else if (ten == "TenPhongBan")
                    cot.HeaderText = "Phòng ban";
                else if (ten == "NhomThongKe")
                    cot.HeaderText = "Nhóm thống kê";
                else if (ten == "SoNhanVien")
                    cot.HeaderText = "Số nhân viên";
                else if (ten == "ChinhThuc")
                    cot.HeaderText = "Chính thức";
                else if (ten == "ThuViec")
                    cot.HeaderText = "Thử việc";
                else if (ten == "NghiViec")
                    cot.HeaderText = "Nghỉ việc";
                else if (ten == "SoQuyetDinh")
                    cot.HeaderText = "Số quyết định";
                else if (ten == "SoNhanVienTuyen")
                    cot.HeaderText = "Nhân viên tuyển";
                else if (ten == "TongLuongThuViec")
                    cot.HeaderText = "Tổng lương thử việc";
                else if (ten == "SoLuotChamCong")
                    cot.HeaderText = "Lượt chấm công";
                else if (ten == "CoMat")
                    cot.HeaderText = "Có mặt";
                else if (ten == "VangMat")
                    cot.HeaderText = "Vắng mặt";
                else if (ten == "NghiPhep")
                    cot.HeaderText = "Nghỉ phép";
                else if (ten == "NghiLe")
                    cot.HeaderText = "Nghỉ lễ";
                else if (ten == "TongGioLam")
                    cot.HeaderText = "Tổng giờ làm";
                else if (ten == "SoQuyetDinhKhenThuong")
                    cot.HeaderText = "Quyết định thưởng";
                else if (ten == "TongTienThuong")
                    cot.HeaderText = "Tổng tiền thưởng";
                else if (ten == "SoQuyetDinhKyLuat")
                    cot.HeaderText = "Quyết định kỷ luật";
                else if (ten == "TongTienPhat")
                    cot.HeaderText = "Tổng tiền phạt";
                else if (ten == "SoNhanVienCoLuong")
                    cot.HeaderText = "Nhân viên có lương";
                else if (ten == "TongLuongCoBan")
                    cot.HeaderText = "Tổng lương cơ bản";
                else if (ten == "TongPhuCap")
                    cot.HeaderText = "Tổng phụ cấp";
                else if (ten == "TongPhuTroi")
                    cot.HeaderText = "Tổng phụ trội";
                else if (ten == "TongKhauTru")
                    cot.HeaderText = "Tổng khấu trừ";
                else if (ten == "TongThucLanh")
                    cot.HeaderText = "Tổng thực lãnh";

                if (ten.StartsWith("Tong") &&
                    ten != "TongGioLam")
                {
                    cot.DefaultCellStyle.Format = "N2";
                    cot.DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleRight;
                }

                if (ten == "TongGioLam")
                    cot.DefaultCellStyle.Format = "N2";
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                ThucHienThongKe();
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                cboNhom.SelectedIndex = 0;
                cboPhongBan.SelectedIndex = 0;
                nudThang.Value = DateTime.Today.Month;
                nudNam.Value = DateTime.Today.Year;

                CapNhatBoLoc();
                ThucHienThongKe();
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            DataTable bang = dgvThongKe.DataSource as DataTable;

            if (bang == null || bang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV (*.csv)|*.csv";
                dialog.FileName = "ThongKe_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    StringBuilder noiDung = new StringBuilder();

                    for (int i = 0; i < dgvThongKe.Columns.Count; i++)
                    {
                        if (i > 0)
                            noiDung.Append(",");

                        noiDung.Append(
                            GiaTriCSV(dgvThongKe.Columns[i].HeaderText));
                    }

                    noiDung.AppendLine();

                    foreach (DataRow row in bang.Rows)
                    {
                        for (int i = 0; i < bang.Columns.Count; i++)
                        {
                            if (i > 0)
                                noiDung.Append(",");

                            noiDung.Append(
                                GiaTriCSV(Convert.ToString(row[i])));
                        }

                        noiDung.AppendLine();
                    }

                    File.WriteAllText(
                        dialog.FileName,
                        noiDung.ToString(),
                        new UTF8Encoding(true));

                    MessageBox.Show(
                        "Xuất báo cáo thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    BaoLoi(ex);
                }
            }
        }

        private string GiaTriCSV(string giaTri)
        {
            string text = giaTri ?? "";

            return "\"" + text.Replace("\"", "\"\"") + "\"";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi thống kê - báo cáo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}