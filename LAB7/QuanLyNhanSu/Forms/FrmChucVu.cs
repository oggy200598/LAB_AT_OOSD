
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChucVu : Form
    {
        private readonly ChucVuService service = new ChucVuService();

        public FrmChucVu()
        {
            InitializeComponent();
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                dgvChucVu.DataSource = service.LayDanhSach();
                DinhDangBang();
                LamMoiNhapLieu();
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

        private void DinhDangBang()
        {
            if (dgvChucVu.Columns["MaChucVu"] != null)
                dgvChucVu.Columns["MaChucVu"].HeaderText = "Mã chức vụ";

            if (dgvChucVu.Columns["TenChucVu"] != null)
                dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên chức vụ";

            if (dgvChucVu.Columns["MoTa"] != null)
                dgvChucVu.Columns["MoTa"].HeaderText = "Mô tả";

            if (dgvChucVu.Columns["PhuCapChucVu"] != null)
            {
                dgvChucVu.Columns["PhuCapChucVu"].HeaderText =
                    "Phụ cấp chức vụ";

                dgvChucVu.Columns["PhuCapChucVu"].DefaultCellStyle.Format =
                    "N0";

                dgvChucVu.Columns["PhuCapChucVu"]
                    .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void LamMoiNhapLieu()
        {
            txtMaChucVu.Clear();
            txtTenChucVu.Clear();
            txtMoTa.Clear();
            txtPhuCapChucVu.Text = "0";

            txtMaChucVu.ReadOnly = false;
            dgvChucVu.ClearSelection();
            txtMaChucVu.Focus();
        }

        private decimal LayPhuCap()
        {
            decimal phuCap;

            if (!decimal.TryParse(
                txtPhuCapChucVu.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out phuCap))
            {
                throw new Exception("Phụ cấp chức vụ phải là số hợp lệ.");
            }

            if (phuCap < 0)
                throw new Exception("Phụ cấp chức vụ không được âm.");

            return phuCap;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaChucVu.Text,
                    txtTenChucVu.Text,
                    txtMoTa.Text,
                    LayPhuCap());

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Thêm chức vụ thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    TaiDuLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi thêm chức vụ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Sua(
                    txtMaChucVu.Text,
                    txtTenChucVu.Text,
                    txtMoTa.Text,
                    LayPhuCap());

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Cập nhật chức vụ thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chức vụ cần sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi sửa chức vụ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChucVu.Text))
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa chức vụ này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaChucVu.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa chức vụ thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chức vụ cần xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa chức vụ. Chức vụ có thể đang được sử dụng.\n"
                    + ex.Message,
                    "Lỗi xóa chức vụ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvChucVu.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvChucVu.ClearSelection();
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
            txtTimKiem.Clear();
            TaiDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvChucVu_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvChucVu.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaChucVu.Text =
                Convert.ToString(row.Cells["MaChucVu"].Value);

            txtTenChucVu.Text =
                Convert.ToString(row.Cells["TenChucVu"].Value);

            txtMoTa.Text =
                Convert.ToString(row.Cells["MoTa"].Value);

            decimal phuCap = Convert.ToDecimal(
                row.Cells["PhuCapChucVu"].Value);

            txtPhuCapChucVu.Text = phuCap.ToString("N0");

            txtMaChucVu.ReadOnly = true;
        }
    }
}
