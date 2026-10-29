
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmQuyetDinhLuong : Form
    {
        private readonly QuyetDinhLuongService service =
            new QuyetDinhLuongService();

        public FrmQuyetDinhLuong()
        {
            InitializeComponent();
        }

        private void FrmQuyetDinhLuong_Load(object sender, EventArgs e)
        {
            try
            {
                TaiNhanVien();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void TaiNhanVien()
        {
            cboNhanVien.DataSource = service.LayNhanVien();
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvQuyetDinhLuong.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvQuyetDinhLuong.Columns["MaQDL"] != null)
                dgvQuyetDinhLuong.Columns["MaQDL"].HeaderText =
                    "Mã quyết định";

            if (dgvQuyetDinhLuong.Columns["SoQuyetDinh"] != null)
                dgvQuyetDinhLuong.Columns["SoQuyetDinh"].HeaderText =
                    "Số quyết định";

            if (dgvQuyetDinhLuong.Columns["MaNV"] != null)
                dgvQuyetDinhLuong.Columns["MaNV"].HeaderText =
                    "Mã nhân viên";

            if (dgvQuyetDinhLuong.Columns["HoTen"] != null)
                dgvQuyetDinhLuong.Columns["HoTen"].HeaderText =
                    "Họ tên";

            if (dgvQuyetDinhLuong.Columns["NgayQuyetDinh"] != null)
            {
                dgvQuyetDinhLuong.Columns["NgayQuyetDinh"].HeaderText =
                    "Ngày quyết định";
                dgvQuyetDinhLuong.Columns["NgayQuyetDinh"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvQuyetDinhLuong.Columns["NgayHieuLuc"] != null)
            {
                dgvQuyetDinhLuong.Columns["NgayHieuLuc"].HeaderText =
                    "Ngày hiệu lực";
                dgvQuyetDinhLuong.Columns["NgayHieuLuc"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvQuyetDinhLuong.Columns["LuongCoBan"] != null)
            {
                dgvQuyetDinhLuong.Columns["LuongCoBan"].HeaderText =
                    "Lương cơ bản";
                dgvQuyetDinhLuong.Columns["LuongCoBan"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvQuyetDinhLuong.Columns["PhuCapLuong"] != null)
            {
                dgvQuyetDinhLuong.Columns["PhuCapLuong"].HeaderText =
                    "Phụ cấp lương";
                dgvQuyetDinhLuong.Columns["PhuCapLuong"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvQuyetDinhLuong.Columns["PhuCapDocHai"] != null)
            {
                dgvQuyetDinhLuong.Columns["PhuCapDocHai"].HeaderText =
                    "Phụ cấp độc hại";
                dgvQuyetDinhLuong.Columns["PhuCapDocHai"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvQuyetDinhLuong.Columns["NoiDung"] != null)
                dgvQuyetDinhLuong.Columns["NoiDung"].HeaderText =
                    "Nội dung";
        }

        private void LamMoiNhapLieu()
        {
            txtMaQDL.Clear();
            txtSoQuyetDinh.Clear();
            txtLuongCoBan.Text = "0";
            txtPhuCapLuong.Text = "0";
            txtPhuCapDocHai.Text = "0";
            txtNoiDung.Clear();

            dtpNgayQuyetDinh.Value = DateTime.Today;
            dtpNgayHieuLuc.Value = DateTime.Today;

            cboNhanVien.SelectedIndex = -1;
            txtMaQDL.ReadOnly = false;

            lblTongLuong.Text = "Tổng lương + phụ cấp: 0";
            dgvQuyetDinhLuong.ClearSelection();
        }

        private string LayMaNhanVien()
        {
            if (cboNhanVien.SelectedValue == null ||
                cboNhanVien.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(cboNhanVien.SelectedValue);
        }

        private decimal LaySoTien(TextBox textBox)
        {
            decimal soTien;

            if (!decimal.TryParse(
                textBox.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out soTien))
            {
                throw new Exception(
                    "Giá trị tiền phải là số hợp lệ: " + textBox.Name);
            }

            if (soTien < 0)
                throw new Exception("Lương và phụ cấp không được âm.");

            return soTien;
        }

        private void CapNhatTongLuong(object sender, EventArgs e)
        {
            decimal luong = 0;
            decimal phuCap = 0;
            decimal docHai = 0;

            bool hopLe =
                decimal.TryParse(txtLuongCoBan.Text,
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture, out luong)
                && decimal.TryParse(txtPhuCapLuong.Text,
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture, out phuCap)
                && decimal.TryParse(txtPhuCapDocHai.Text,
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture, out docHai);

            lblTongLuong.Text = hopLe
                ? "Tổng lương + phụ cấp: " +
                  (luong + phuCap + docHai).ToString("N0")
                : "Tổng lương + phụ cấp: Chưa hợp lệ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaQDL.Text,
                    txtSoQuyetDinh.Text,
                    LayMaNhanVien(),
                    dtpNgayQuyetDinh.Value,
                    dtpNgayHieuLuc.Value,
                    LaySoTien(txtLuongCoBan),
                    LaySoTien(txtPhuCapLuong),
                    LaySoTien(txtPhuCapDocHai),
                    txtNoiDung.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm quyết định lương thành công!");
                    TaiDuLieu();
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Sua(
                    txtMaQDL.Text,
                    txtSoQuyetDinh.Text,
                    LayMaNhanVien(),
                    dtpNgayQuyetDinh.Value,
                    dtpNgayHieuLuc.Value,
                    LaySoTien(txtLuongCoBan),
                    LaySoTien(txtPhuCapLuong),
                    LaySoTien(txtPhuCapDocHai),
                    txtNoiDung.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật quyết định lương thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quyết định cần sửa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaQDL.Text))
            {
                MessageBox.Show("Vui lòng chọn quyết định cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa quyết định lương này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaQDL.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa quyết định thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quyết định cần xóa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvQuyetDinhLuong.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvQuyetDinhLuong.ClearSelection();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Clear();
                TaiNhanVien();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvQuyetDinhLuong_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvQuyetDinhLuong.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaQDL.Text =
                Convert.ToString(row.Cells["MaQDL"].Value);

            txtSoQuyetDinh.Text =
                Convert.ToString(row.Cells["SoQuyetDinh"].Value);

            cboNhanVien.SelectedValue =
                Convert.ToString(row.Cells["MaNV"].Value);

            dtpNgayQuyetDinh.Value =
                Convert.ToDateTime(row.Cells["NgayQuyetDinh"].Value);

            dtpNgayHieuLuc.Value =
                Convert.ToDateTime(row.Cells["NgayHieuLuc"].Value);

            txtLuongCoBan.Text =
                Convert.ToDecimal(row.Cells["LuongCoBan"].Value)
                    .ToString("N0");

            txtPhuCapLuong.Text =
                Convert.ToDecimal(row.Cells["PhuCapLuong"].Value)
                    .ToString("N0");

            txtPhuCapDocHai.Text =
                Convert.ToDecimal(row.Cells["PhuCapDocHai"].Value)
                    .ToString("N0");

            txtNoiDung.Text =
                Convert.ToString(row.Cells["NoiDung"].Value);

            txtMaQDL.ReadOnly = true;
        }

        private void ThongBaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý quyết định lương",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
