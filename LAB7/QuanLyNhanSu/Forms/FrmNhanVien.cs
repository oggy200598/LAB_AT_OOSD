
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmNhanVien : Form
    {
        private readonly NhanVienService service = new NhanVienService();

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                TaiPhongBan();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi tải dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TaiPhongBan()
        {
            DataTable dt = service.LayDanhSachPhongBan();

            cboPhongBan.DataSource = dt;
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";
            cboPhongBan.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvNhanVien.DataSource = service.LayDanhSach();

            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvNhanVien.Columns["MaNV"] != null)
                dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";

            if (dgvNhanVien.Columns["HoTen"] != null)
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";

            if (dgvNhanVien.Columns["NgaySinh"] != null)
            {
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvNhanVien.Columns["GioiTinh"] != null)
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";

            if (dgvNhanVien.Columns["DiaChi"] != null)
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";

            if (dgvNhanVien.Columns["SoDienThoai"] != null)
                dgvNhanVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";

            if (dgvNhanVien.Columns["Email"] != null)
                dgvNhanVien.Columns["Email"].HeaderText = "Email";

            if (dgvNhanVien.Columns["NgayVaoLam"] != null)
            {
                dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày vào làm";
                dgvNhanVien.Columns["NgayVaoLam"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvNhanVien.Columns["TrangThai"] != null)
                dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";

            if (dgvNhanVien.Columns["MaPhongBan"] != null)
                dgvNhanVien.Columns["MaPhongBan"].Visible = false;

            if (dgvNhanVien.Columns["TenPhongBan"] != null)
                dgvNhanVien.Columns["TenPhongBan"].HeaderText = "Phòng ban";
        }

        private void LamMoiNhapLieu()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();

            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            dtpNgayVaoLam.Value = DateTime.Today;
            dtpNgayVaoLam.Checked = false;

            cboGioiTinh.SelectedIndex = -1;
            cboTrangThai.SelectedItem = "Thử việc";
            cboPhongBan.SelectedIndex = -1;

            txtMaNV.ReadOnly = false;
            dgvNhanVien.ClearSelection();
            txtMaNV.Focus();
        }

        private string LayMaPhongBan()
        {
            if (cboPhongBan.SelectedValue == null ||
                cboPhongBan.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(cboPhongBan.SelectedValue);
        }

        private string LayGioiTinh()
        {
            if (cboGioiTinh.SelectedIndex < 0)
                return null;

            return cboGioiTinh.SelectedItem.ToString();
        }

        private string LayTrangThai()
        {
            if (cboTrangThai.SelectedIndex < 0)
                return null;

            return cboTrangThai.SelectedItem.ToString();
        }

        private DateTime? LayNgayVaoLam()
        {
            if (!dtpNgayVaoLam.Checked)
                return null;

            return dtpNgayVaoLam.Value.Date;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaNV.Text,
                    txtHoTen.Text,
                    dtpNgaySinh.Value,
                    LayGioiTinh(),
                    txtDiaChi.Text,
                    txtSoDienThoai.Text,
                    txtEmail.Text,
                    LayNgayVaoLam(),
                    LayTrangThai(),
                    LayMaPhongBan());

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    TaiDuLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi thêm nhân viên",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Sua(
                    txtMaNV.Text,
                    txtHoTen.Text,
                    dtpNgaySinh.Value,
                    LayGioiTinh(),
                    txtDiaChi.Text,
                    txtSoDienThoai.Text,
                    txtEmail.Text,
                    LayNgayVaoLam(),
                    LayTrangThai(),
                    LayMaPhongBan());

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi sửa nhân viên",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaNV.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa nhân viên. Nhân viên có thể đang có hợp đồng, quyết định hoặc dữ liệu liên quan.\n"
                    + ex.Message,
                    "Lỗi xóa nhân viên",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvNhanVien.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi tìm kiếm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Clear();
                TaiPhongBan();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi làm mới",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvNhanVien_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaNV.Text =
                Convert.ToString(row.Cells["MaNV"].Value);

            txtHoTen.Text =
                Convert.ToString(row.Cells["HoTen"].Value);

            txtDiaChi.Text =
                Convert.ToString(row.Cells["DiaChi"].Value);

            txtSoDienThoai.Text =
                Convert.ToString(row.Cells["SoDienThoai"].Value);

            txtEmail.Text =
                Convert.ToString(row.Cells["Email"].Value);

            dtpNgaySinh.Value =
                Convert.ToDateTime(row.Cells["NgaySinh"].Value);

            object ngayVaoLam = row.Cells["NgayVaoLam"].Value;

            if (ngayVaoLam == null || ngayVaoLam == DBNull.Value)
            {
                dtpNgayVaoLam.Checked = false;
                dtpNgayVaoLam.Value = DateTime.Today;
            }
            else
            {
                dtpNgayVaoLam.Value = Convert.ToDateTime(ngayVaoLam);
                dtpNgayVaoLam.Checked = true;
            }

            string gioiTinh =
                Convert.ToString(row.Cells["GioiTinh"].Value);

            if (string.IsNullOrWhiteSpace(gioiTinh))
                cboGioiTinh.SelectedIndex = -1;
            else
                cboGioiTinh.SelectedItem = gioiTinh;

            cboTrangThai.SelectedItem =
                Convert.ToString(row.Cells["TrangThai"].Value);

            cboPhongBan.SelectedValue =
                Convert.ToString(row.Cells["MaPhongBan"].Value);

            txtMaNV.ReadOnly = true;
        }
    }
}
