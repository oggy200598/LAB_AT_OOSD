using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmSach : Form
    {
        private readonly SachService service = new SachService();

        public FrmSach()
        {
            InitializeComponent();

            dgvSach.ClearSelection();
            dgvSach.CurrentCell = null;

            Load += FrmSach_Load;
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                TaiTheLoai();
                TaiNhaXuatBan();
                TaiDanhSachSach();
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

        private void TaiTheLoai()
        {
            DataTable data = service.LayTheLoai();

            cboTheLoai.DataSource = data;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
            cboTheLoai.SelectedIndex = -1;
        }

        private void TaiNhaXuatBan()
        {
            DataTable data = service.LayNhaXuatBan();

            cboNXB.DataSource = data;
            cboNXB.DisplayMember = "MaNhaXuatBan";
            cboNXB.ValueMember = "MaNhaXuatBan";
            cboNXB.SelectedIndex = -1;
        }

        private void TaiDanhSachSach()
        {
            DataTable data = service.LayDanhSach();

            dgvSach.AutoGenerateColumns = false;

            if (dgvSach.Columns.Count >= 6)
            {
                dgvSach.Columns[0].DataPropertyName = "MaDauSach";
                dgvSach.Columns[1].DataPropertyName = "TenSach";
                dgvSach.Columns[2].DataPropertyName = "NamXuatBan";
                dgvSach.Columns[3].DataPropertyName = "SoLuongHienCo";
                dgvSach.Columns[4].DataPropertyName = "MaTheLoai";
                dgvSach.Columns[5].DataPropertyName = "MaNhaXuatBan";
            }

            dgvSach.DataSource = data;

            dgvSach.ClearSelection();
            dgvSach.CurrentCell = null;
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách.");
                txtMa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách.");
                txtTen.Focus();
                return false;
            }

            if (numNam.Value <= 0)
            {
                MessageBox.Show("Năm xuất bản không hợp lệ.");
                numNam.Focus();
                return false;
            }

            if (numSoLuong.Value < 0)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0.");
                numSoLuong.Focus();
                return false;
            }

            if (cboTheLoai.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại.");
                cboTheLoai.Focus();
                return false;
            }

            if (cboNXB.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản.");
                cboNXB.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            try
            {
                service.ThemSach(
                    txtMa.Text.Trim(),
                    txtTen.Text.Trim(),
                    Convert.ToInt32(numNam.Value),
                    Convert.ToInt32(numSoLuong.Value),
                    cboTheLoai.SelectedValue.ToString(),
                    cboNXB.SelectedValue.ToString());

                MessageBox.Show(
                    "Thêm sách thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDanhSachSach();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm sách.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            try
            {
                service.CapNhatSach(
                    txtMa.Text.Trim(),
                    txtTen.Text.Trim(),
                    Convert.ToInt32(numNam.Value),
                    Convert.ToInt32(numSoLuong.Value),
                    cboTheLoai.SelectedValue.ToString(),
                    cboNXB.SelectedValue.ToString());

                MessageBox.Show(
                    "Cập nhật sách thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDanhSachSach();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật sách.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sách này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                service.XoaSach(txtMa.Text.Trim());

                MessageBox.Show(
                    "Xóa sách thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDanhSachSach();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa sách.\n\nCó thể sách đang được sử dụng trong phiếu mượn.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMa.Clear();
            txtTen.Clear();

            numNam.Value = DateTime.Today.Year;
            numSoLuong.Value = 0;

            cboTheLoai.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;

            txtMa.ReadOnly = false;

            dgvSach.ClearSelection();
            dgvSach.CurrentCell = null;

            txtMa.Focus();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSach.Rows[e.RowIndex];

            txtMa.Text = Convert.ToString(row.Cells[0].Value);
            txtTen.Text = Convert.ToString(row.Cells[1].Value);

            if (row.Cells[2].Value != null &&
                row.Cells[2].Value != DBNull.Value)
            {
                numNam.Value = Convert.ToDecimal(row.Cells[2].Value);
            }

            if (row.Cells[3].Value != null &&
                row.Cells[3].Value != DBNull.Value)
            {
                numSoLuong.Value = Convert.ToDecimal(row.Cells[3].Value);
            }

            string maTheLoai = Convert.ToString(row.Cells[4].Value);
            string maNXB = Convert.ToString(row.Cells[5].Value);

            cboTheLoai.SelectedValue = maTheLoai;
            cboNXB.SelectedValue = maNXB;

            txtMa.ReadOnly = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}