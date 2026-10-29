
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmPhongBan : Form
    {
        private readonly PhongBanService service = new PhongBanService();

        public FrmPhongBan()
        {
            InitializeComponent();
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                dgvPhongBan.DataSource = service.LayDanhSach();
                dgvPhongBan.ClearSelection();
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

        private void LamMoiNhapLieu()
        {
            txtMaPhongBan.Clear();
            txtTenPhongBan.Clear();
            txtDiaDiem.Clear();
            txtSoDienThoai.Clear();
            txtMoTa.Clear();

            txtMaPhongBan.ReadOnly = false;
            txtMaPhongBan.Focus();

            dgvPhongBan.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaPhongBan.Text,
                    txtTenPhongBan.Text,
                    txtDiaDiem.Text,
                    txtSoDienThoai.Text,
                    txtMoTa.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Thêm phòng ban thành công!",
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
                    "Không thể thêm phòng ban",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Sua(
                    txtMaPhongBan.Text,
                    txtTenPhongBan.Text,
                    txtDiaDiem.Text,
                    txtSoDienThoai.Text,
                    txtMoTa.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Cập nhật phòng ban thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng ban cần sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Không thể sửa phòng ban",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhongBan.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng ban cần xóa.");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phòng ban này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                int soDong = service.Xoa(txtMaPhongBan.Text);

                if (soDong > 0)
                {
                    MessageBox.Show("Xóa phòng ban thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng ban cần xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa phòng ban. Phòng ban có thể đang được sử dụng trong dữ liệu khác.\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPhongBan.DataSource =
                    service.TimKiem(txtTimKiem.Text.Trim());

                dgvPhongBan.ClearSelection();
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
            this.Close();
        }

        private void dgvPhongBan_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPhongBan.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaPhongBan.Text =
                Convert.ToString(row.Cells["MaPhongBan"].Value);

            txtTenPhongBan.Text =
                Convert.ToString(row.Cells["TenPhongBan"].Value);

            txtDiaDiem.Text =
                Convert.ToString(row.Cells["DiaDiem"].Value);

            txtSoDienThoai.Text =
                Convert.ToString(row.Cells["SoDienThoai"].Value);

            txtMoTa.Text =
                Convert.ToString(row.Cells["MoTa"].Value);

            txtMaPhongBan.ReadOnly = true;
        }
    }
}
