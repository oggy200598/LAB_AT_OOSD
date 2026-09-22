using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService service = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();

            dgvNV.ClearSelection();
            dgvNV.CurrentCell = null;

            dgvTL.ClearSelection();
            dgvTL.CurrentCell = null;

            dgvNXB.ClearSelection();
            dgvNXB.CurrentCell = null;

            Load += FrmDanhMuc_Load;
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            cboNVPhai.Items.Clear();
            cboNVPhai.Items.Add("Nam");
            cboNVPhai.Items.Add("Nữ");
            cboNVPhai.Items.Add("Khác");
            cboNVPhai.SelectedIndex = 0;

            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                TaiNhanVien();
                TaiTheLoai();
                TaiNhaXuatBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể kết nối hoặc đọc dữ liệu từ SQL Server.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TaiNhanVien()
        {
            DataTable data = service.LayNhanVien();

            dgvNV.AutoGenerateColumns = false;

            if (dgvNV.Columns.Count >= 7)
            {
                dgvNV.Columns[0].DataPropertyName = "MaNhanVien";
                dgvNV.Columns[1].DataPropertyName = "Ho";
                dgvNV.Columns[2].DataPropertyName = "Ten";
                dgvNV.Columns[3].DataPropertyName = "Phai";
                dgvNV.Columns[4].DataPropertyName = "NgaySinh";
                dgvNV.Columns[5].DataPropertyName = "ChucVu";
                dgvNV.Columns[6].DataPropertyName = "SoDienThoai";
            }

            dgvNV.DataSource = data;
            dgvNV.ClearSelection();
            dgvNV.CurrentCell = null;
        }

        private void TaiTheLoai()
        {
            DataTable data = service.LayTheLoai();

            dgvTL.AutoGenerateColumns = false;

            if (dgvTL.Columns.Count >= 2)
            {
                dgvTL.Columns[0].DataPropertyName = "MaTheLoai";
                dgvTL.Columns[1].DataPropertyName = "TenTheLoai";
            }

            dgvTL.DataSource = data;
            dgvTL.ClearSelection();
            dgvTL.CurrentCell = null;
        }

        private void TaiNhaXuatBan()
        {
            DataTable data = service.LayNhaXuatBan();

            dgvNXB.AutoGenerateColumns = false;

            if (dgvNXB.Columns.Count >= 3)
            {
                dgvNXB.Columns[0].DataPropertyName = "MaNhaXuatBan";
                dgvNXB.Columns[1].DataPropertyName = "DiaChi";
                dgvNXB.Columns[2].DataPropertyName = "SoDienThoai";
            }

            dgvNXB.DataSource = data;
            dgvNXB.ClearSelection();
            dgvNXB.CurrentCell = null;
        }

        private bool KiemTraNhanVien()
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.");
                txtNVMa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNVHo.Text))
            {
                MessageBox.Show("Vui lòng nhập họ.");
                txtNVHo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNVTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên.");
                txtNVTen.Focus();
                return false;
            }

            return true;
        }

        private bool KiemTraTheLoai()
        {
            if (string.IsNullOrWhiteSpace(txtTLMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thể loại.");
                txtTLMa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTLTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.");
                txtTLTen.Focus();
                return false;
            }

            return true;
        }

        private bool KiemTraNhaXuatBan()
        {
            if (string.IsNullOrWhiteSpace(txtNXBMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà xuất bản.");
                txtNXBMa.Focus();
                return false;
            }

            return true;
        }

        private void btnNVThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhanVien())
                return;

            try
            {
                service.ThemNhanVien(
                    txtNVMa.Text.Trim(),
                    txtNVHo.Text.Trim(),
                    txtNVTen.Text.Trim(),
                    cboNVPhai.Text,
                    dtNVNgaySinh.Value.Date,
                    txtNVChucVu.Text.Trim(),
                    txtNVSDT.Text.Trim());

                MessageBox.Show(
                    "Thêm nhân viên thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiNhanVien();

                txtNVMa.Clear();
                txtNVHo.Clear();
                txtNVTen.Clear();
                txtNVChucVu.Clear();
                txtNVSDT.Clear();
                txtNVMa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm nhân viên.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNVCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhanVien())
                return;

            try
            {
                service.CapNhatNhanVien(
                    txtNVMa.Text.Trim(),
                    txtNVHo.Text.Trim(),
                    txtNVTen.Text.Trim(),
                    cboNVPhai.Text,
                    dtNVNgaySinh.Value.Date,
                    txtNVChucVu.Text.Trim(),
                    txtNVSDT.Text.Trim());

                MessageBox.Show(
                    "Cập nhật nhân viên thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật nhân viên.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text))
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                service.XoaNhanVien(txtNVMa.Text.Trim());

                MessageBox.Show(
                    "Xóa nhân viên thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiNhanVien();

                txtNVMa.Clear();
                txtNVHo.Clear();
                txtNVTen.Clear();
                txtNVChucVu.Clear();
                txtNVSDT.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa nhân viên.\n\nCó thể nhân viên đang được tham chiếu bởi phiếu mượn hoặc phiếu phạt.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNVMoi_Click(object sender, EventArgs e)
        {
            txtNVMa.Clear();
            txtNVHo.Clear();
            txtNVTen.Clear();
            txtNVChucVu.Clear();
            txtNVSDT.Clear();
            cboNVPhai.SelectedIndex = 0;
            dtNVNgaySinh.Value = DateTime.Today;

            dgvNV.ClearSelection();
            dgvNV.CurrentCell = null;

            txtNVMa.Focus();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvNV.Rows[e.RowIndex];

            txtNVMa.Text = Convert.ToString(row.Cells[0].Value);
            txtNVHo.Text = Convert.ToString(row.Cells[1].Value);
            txtNVTen.Text = Convert.ToString(row.Cells[2].Value);
            cboNVPhai.Text = Convert.ToString(row.Cells[3].Value);

            if (row.Cells[4].Value != null &&
                row.Cells[4].Value != DBNull.Value)
            {
                dtNVNgaySinh.Value = Convert.ToDateTime(row.Cells[4].Value);
            }

            txtNVChucVu.Text = Convert.ToString(row.Cells[5].Value);
            txtNVSDT.Text = Convert.ToString(row.Cells[6].Value);

            txtNVMa.ReadOnly = true;
        }

        private void btnTLThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraTheLoai())
                return;

            try
            {
                service.ThemTheLoai(
                    txtTLMa.Text.Trim(),
                    txtTLTen.Text.Trim());

                MessageBox.Show(
                    "Thêm thể loại thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiTheLoai();

                txtTLMa.Clear();
                txtTLTen.Clear();
                txtTLMa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm thể loại.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTLCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraTheLoai())
                return;

            try
            {
                service.CapNhatTheLoai(
                    txtTLMa.Text.Trim(),
                    txtTLTen.Text.Trim());

                MessageBox.Show(
                    "Cập nhật thể loại thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiTheLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật thể loại.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTLXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTLMa.Text))
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa thể loại này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                service.XoaTheLoai(txtTLMa.Text.Trim());

                MessageBox.Show(
                    "Xóa thể loại thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiTheLoai();

                txtTLMa.Clear();
                txtTLTen.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa thể loại.\n\nCó thể thể loại đang được sử dụng bởi sách.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTLMoi_Click(object sender, EventArgs e)
        {
            txtTLMa.Clear();
            txtTLTen.Clear();

            dgvTL.ClearSelection();
            dgvTL.CurrentCell = null;

            txtTLMa.ReadOnly = false;
            txtTLMa.Focus();
        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvTL.Rows[e.RowIndex];

            txtTLMa.Text = Convert.ToString(row.Cells[0].Value);
            txtTLTen.Text = Convert.ToString(row.Cells[1].Value);

            txtTLMa.ReadOnly = true;
        }

        private void btnNXBThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhaXuatBan())
                return;

            try
            {
                service.ThemNhaXuatBan(
                    txtNXBMa.Text.Trim(),
                    txtNXBDiaChi.Text.Trim(),
                    txtNXBSDT.Text.Trim());

                MessageBox.Show(
                    "Thêm nhà xuất bản thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiNhaXuatBan();

                txtNXBMa.Clear();
                txtNXBDiaChi.Clear();
                txtNXBSDT.Clear();
                txtNXBMa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm nhà xuất bản.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNXBCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhaXuatBan())
                return;

            try
            {
                service.CapNhatNhaXuatBan(
                    txtNXBMa.Text.Trim(),
                    txtNXBDiaChi.Text.Trim(),
                    txtNXBSDT.Text.Trim());

                MessageBox.Show(
                    "Cập nhật nhà xuất bản thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiNhaXuatBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật nhà xuất bản.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNXBXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNXBMa.Text))
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa nhà xuất bản này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                service.XoaNhaXuatBan(txtNXBMa.Text.Trim());

                MessageBox.Show(
                    "Xóa nhà xuất bản thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiNhaXuatBan();

                txtNXBMa.Clear();
                txtNXBDiaChi.Clear();
                txtNXBSDT.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa nhà xuất bản.\n\nCó thể nhà xuất bản đang được sử dụng bởi sách.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNXBMoi_Click(object sender, EventArgs e)
        {
            txtNXBMa.Clear();
            txtNXBDiaChi.Clear();
            txtNXBSDT.Clear();

            dgvNXB.ClearSelection();
            dgvNXB.CurrentCell = null;

            txtNXBMa.ReadOnly = false;
            txtNXBMa.Focus();
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvNXB.Rows[e.RowIndex];

            txtNXBMa.Text = Convert.ToString(row.Cells[0].Value);
            txtNXBDiaChi.Text = Convert.ToString(row.Cells[1].Value);
            txtNXBSDT.Text = Convert.ToString(row.Cells[2].Value);

            txtNXBMa.ReadOnly = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtNVNgaySinh_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}