using System;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmBangLuong : Form
    {
        private readonly BangLuongService service =
            new BangLuongService();

        public FrmBangLuong()
        {
            InitializeComponent();
        }

        private void FrmBangLuong_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                dgvBangLuong.DataSource = service.LayDanhSach();
                DinhDangBang();
                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void DinhDangBang()
        {
            if (dgvBangLuong.Columns["MaBangLuong"] != null)
                dgvBangLuong.Columns["MaBangLuong"].HeaderText =
                    "Mã bảng lương";

            if (dgvBangLuong.Columns["Thang"] != null)
                dgvBangLuong.Columns["Thang"].HeaderText = "Tháng";

            if (dgvBangLuong.Columns["Nam"] != null)
                dgvBangLuong.Columns["Nam"].HeaderText = "Năm";

            if (dgvBangLuong.Columns["NgayLap"] != null)
            {
                dgvBangLuong.Columns["NgayLap"].HeaderText = "Ngày lập";
                dgvBangLuong.Columns["NgayLap"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvBangLuong.Columns["NguoiLap"] != null)
                dgvBangLuong.Columns["NguoiLap"].HeaderText = "Người lập";

            if (dgvBangLuong.Columns["TongTienLuong"] != null)
            {
                dgvBangLuong.Columns["TongTienLuong"].HeaderText =
                    "Tổng tiền lương";
                dgvBangLuong.Columns["TongTienLuong"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvBangLuong.Columns["TrangThai"] != null)
                dgvBangLuong.Columns["TrangThai"].HeaderText =
                    "Trạng thái";
        }

        private void LamMoiNhapLieu()
        {
            txtMaBangLuong.Clear();
            txtNguoiLap.Clear();

            nudThang.Value = DateTime.Today.Month;
            nudNam.Value = DateTime.Today.Year;
            dtpNgayLap.Value = DateTime.Today;
            nudTongTienLuong.Value = 0;
            cboTrangThai.SelectedItem = "Đã lập";

            txtMaBangLuong.ReadOnly = false;
            dgvBangLuong.ClearSelection();
            txtMaBangLuong.Focus();
        }

        private void Luu(bool laThem)
        {
            int ketQua = laThem
                ? service.Them(
                    txtMaBangLuong.Text,
                    (int)nudThang.Value,
                    (int)nudNam.Value,
                    dtpNgayLap.Value,
                    txtNguoiLap.Text,
                    nudTongTienLuong.Value,
                    cboTrangThai.Text)
                : service.Sua(
                    txtMaBangLuong.Text,
                    (int)nudThang.Value,
                    (int)nudNam.Value,
                    dtpNgayLap.Value,
                    txtNguoiLap.Text,
                    nudTongTienLuong.Value,
                    cboTrangThai.Text);

            if (ketQua > 0)
            {
                MessageBox.Show(
                    laThem
                        ? "Thêm bảng lương thành công!"
                        : "Cập nhật bảng lương thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy bảng lương cần sửa.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Luu(true);
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Luu(false);
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBangLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn bảng lương cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bảng lương này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaBangLuong.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa bảng lương thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bảng lương cần xóa.");
                }
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBangLuong.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvBangLuong.ClearSelection();
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
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

        private void dgvBangLuong_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvBangLuong.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaBangLuong.Text =
                Convert.ToString(row.Cells["MaBangLuong"].Value);

            nudThang.Value =
                Convert.ToDecimal(row.Cells["Thang"].Value);

            nudNam.Value =
                Convert.ToDecimal(row.Cells["Nam"].Value);

            dtpNgayLap.Value =
                Convert.ToDateTime(row.Cells["NgayLap"].Value);

            txtNguoiLap.Text =
                Convert.ToString(row.Cells["NguoiLap"].Value);

            nudTongTienLuong.Value =
                Convert.ToDecimal(row.Cells["TongTienLuong"].Value);

            cboTrangThai.SelectedItem =
                Convert.ToString(row.Cells["TrangThai"].Value);

            txtMaBangLuong.ReadOnly = true;
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý bảng lương",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}