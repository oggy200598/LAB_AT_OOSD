
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmQuyetDinhTuyenDung : Form
    {
        private readonly TuyenDungService service = new TuyenDungService();

        public FrmQuyetDinhTuyenDung()
        {
            InitializeComponent();
        }

        private void FrmQuyetDinhTuyenDung_Load(object sender, EventArgs e)
        {
            try
            {
                TaiDanhMuc();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDanhMuc()
        {
            cboNhanVien.DataSource = service.LayNhanVien();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.SelectedIndex = -1;

            cboPhongBan.DataSource = service.LayPhongBan();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";
            cboPhongBan.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvTuyenDung.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvTuyenDung.Columns["MaQDTD"] != null)
                dgvTuyenDung.Columns["MaQDTD"].HeaderText = "Mã QĐ";

            if (dgvTuyenDung.Columns["SoQuyetDinh"] != null)
                dgvTuyenDung.Columns["SoQuyetDinh"].HeaderText = "Số quyết định";

            if (dgvTuyenDung.Columns["NgayQuyetDinh"] != null)
            {
                dgvTuyenDung.Columns["NgayQuyetDinh"].HeaderText = "Ngày quyết định";
                dgvTuyenDung.Columns["NgayQuyetDinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvTuyenDung.Columns["MaNV"] != null)
                dgvTuyenDung.Columns["MaNV"].HeaderText = "Mã NV";

            if (dgvTuyenDung.Columns["HoTen"] != null)
                dgvTuyenDung.Columns["HoTen"].HeaderText = "Nhân viên";

            if (dgvTuyenDung.Columns["MaPhongBan"] != null)
                dgvTuyenDung.Columns["MaPhongBan"].Visible = false;

            if (dgvTuyenDung.Columns["TenPhongBan"] != null)
                dgvTuyenDung.Columns["TenPhongBan"].HeaderText = "Phòng ban";

            if (dgvTuyenDung.Columns["NgayBatDauThuViec"] != null)
            {
                dgvTuyenDung.Columns["NgayBatDauThuViec"].HeaderText = "Bắt đầu thử việc";
                dgvTuyenDung.Columns["NgayBatDauThuViec"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvTuyenDung.Columns["NgayKetThucThuViec"] != null)
            {
                dgvTuyenDung.Columns["NgayKetThucThuViec"].HeaderText = "Kết thúc thử việc";
                dgvTuyenDung.Columns["NgayKetThucThuViec"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvTuyenDung.Columns["LuongThuViec"] != null)
            {
                dgvTuyenDung.Columns["LuongThuViec"].HeaderText = "Lương thử việc";
                dgvTuyenDung.Columns["LuongThuViec"].DefaultCellStyle.Format = "N0";
            }

            if (dgvTuyenDung.Columns["NoiDung"] != null)
                dgvTuyenDung.Columns["NoiDung"].HeaderText = "Nội dung";

            if (dgvTuyenDung.Columns["DieuKhoan"] != null)
                dgvTuyenDung.Columns["DieuKhoan"].HeaderText = "Điều khoản";
        }

        private void LamMoiNhapLieu()
        {
            txtMaQDTD.Clear();
            txtSoQuyetDinh.Clear();
            txtLuongThuViec.Text = "0";
            txtNoiDung.Clear();
            txtDieuKhoan.Clear();

            dtpNgayQuyetDinh.Value = DateTime.Today;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddMonths(2);

            cboNhanVien.SelectedIndex = -1;
            cboPhongBan.SelectedIndex = -1;

            txtMaQDTD.ReadOnly = false;
            dgvTuyenDung.ClearSelection();
        }

        private string LayGiaTri(ComboBox combo)
        {
            if (combo.SelectedValue == null ||
                combo.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(combo.SelectedValue);
        }

        private decimal LayLuong()
        {
            decimal luong;

            if (!decimal.TryParse(
                txtLuongThuViec.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out luong))
            {
                throw new Exception("Lương thử việc phải là số hợp lệ.");
            }

            if (luong < 0)
                throw new Exception("Lương thử việc không được âm.");

            return luong;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaQDTD.Text,
                    txtSoQuyetDinh.Text,
                    dtpNgayQuyetDinh.Value,
                    LayGiaTri(cboNhanVien),
                    LayGiaTri(cboPhongBan),
                    dtpNgayBatDau.Value,
                    dtpNgayKetThuc.Value,
                    LayLuong(),
                    txtNoiDung.Text,
                    txtDieuKhoan.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm quyết định tuyển dụng thành công!");
                    TaiDuLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm quyết định",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Sua(
                    txtMaQDTD.Text,
                    txtSoQuyetDinh.Text,
                    dtpNgayQuyetDinh.Value,
                    LayGiaTri(cboNhanVien),
                    LayGiaTri(cboPhongBan),
                    dtpNgayBatDau.Value,
                    dtpNgayKetThuc.Value,
                    LayLuong(),
                    txtNoiDung.Text,
                    txtDieuKhoan.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật quyết định thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quyết định cần sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sửa quyết định",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaQDTD.Text))
            {
                MessageBox.Show("Vui lòng chọn quyết định cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa quyết định tuyển dụng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaQDTD.Text);

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
                MessageBox.Show(ex.Message, "Lỗi xóa quyết định",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTuyenDung.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvTuyenDung.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Clear();
                TaiDanhMuc();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi làm mới",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTuyenDung_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvTuyenDung.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaQDTD.Text =
                Convert.ToString(row.Cells["MaQDTD"].Value);

            txtSoQuyetDinh.Text =
                Convert.ToString(row.Cells["SoQuyetDinh"].Value);

            dtpNgayQuyetDinh.Value =
                Convert.ToDateTime(row.Cells["NgayQuyetDinh"].Value);

            cboNhanVien.SelectedValue =
                Convert.ToString(row.Cells["MaNV"].Value);

            cboPhongBan.SelectedValue =
                Convert.ToString(row.Cells["MaPhongBan"].Value);

            dtpNgayBatDau.Value =
                Convert.ToDateTime(row.Cells["NgayBatDauThuViec"].Value);

            dtpNgayKetThuc.Value =
                Convert.ToDateTime(row.Cells["NgayKetThucThuViec"].Value);

            txtLuongThuViec.Text =
                Convert.ToDecimal(row.Cells["LuongThuViec"].Value)
                    .ToString("N0");

            txtNoiDung.Text =
                Convert.ToString(row.Cells["NoiDung"].Value);

            txtDieuKhoan.Text =
                Convert.ToString(row.Cells["DieuKhoan"].Value);

            txtMaQDTD.ReadOnly = true;
        }
    }
}
