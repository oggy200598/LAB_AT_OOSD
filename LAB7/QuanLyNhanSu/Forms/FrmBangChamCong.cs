
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmBangChamCong : Form
    {
        private readonly ChamCongService service = new ChamCongService();

        public FrmBangChamCong()
        {
            InitializeComponent();
        }

        private void FrmBangChamCong_Load(object sender, EventArgs e)
        {
            try
            {
                TaiPhongBan();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void TaiPhongBan()
        {
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";
            cboPhongBan.DataSource = service.LayPhongBan();
            cboPhongBan.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvBangChamCong.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvBangChamCong.Columns["MaBangChamCong"] != null)
                dgvBangChamCong.Columns["MaBangChamCong"].HeaderText =
                    "Mã bảng chấm công";

            if (dgvBangChamCong.Columns["MaPhongBan"] != null)
                dgvBangChamCong.Columns["MaPhongBan"].Visible = false;

            if (dgvBangChamCong.Columns["TenPhongBan"] != null)
                dgvBangChamCong.Columns["TenPhongBan"].HeaderText =
                    "Phòng ban";

            if (dgvBangChamCong.Columns["Thang"] != null)
                dgvBangChamCong.Columns["Thang"].HeaderText = "Tháng";

            if (dgvBangChamCong.Columns["Nam"] != null)
                dgvBangChamCong.Columns["Nam"].HeaderText = "Năm";

            if (dgvBangChamCong.Columns["NgayLap"] != null)
            {
                dgvBangChamCong.Columns["NgayLap"].HeaderText = "Ngày lập";
                dgvBangChamCong.Columns["NgayLap"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvBangChamCong.Columns["NguoiLap"] != null)
                dgvBangChamCong.Columns["NguoiLap"].HeaderText =
                    "Người lập";

            if (dgvBangChamCong.Columns["TrangThai"] != null)
                dgvBangChamCong.Columns["TrangThai"].HeaderText =
                    "Trạng thái";
        }

        private void LamMoiNhapLieu()
        {
            txtMaBangChamCong.Clear();
            txtNguoiLap.Clear();

            cboPhongBan.SelectedIndex = -1;
            cboTrangThai.SelectedItem = "Đã lập";

            nudThang.Value = DateTime.Today.Month;
            nudNam.Value = DateTime.Today.Year;
            dtpNgayLap.Value = DateTime.Today;

            txtMaBangChamCong.ReadOnly = false;
            dgvBangChamCong.ClearSelection();
            txtMaBangChamCong.Focus();
        }

        private string LayMaPhongBan()
        {
            if (cboPhongBan.SelectedValue == null ||
                cboPhongBan.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(cboPhongBan.SelectedValue);
        }

        private string LayTrangThai()
        {
            return cboTrangThai.SelectedIndex >= 0
                ? cboTrangThai.SelectedItem.ToString()
                : null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaBangChamCong.Text,
                    LayMaPhongBan(),
                    (int)nudThang.Value,
                    (int)nudNam.Value,
                    dtpNgayLap.Value,
                    txtNguoiLap.Text,
                    LayTrangThai());

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Thêm bảng chấm công thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

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
                    txtMaBangChamCong.Text,
                    LayMaPhongBan(),
                    (int)nudThang.Value,
                    (int)nudNam.Value,
                    dtpNgayLap.Value,
                    txtNguoiLap.Text,
                    LayTrangThai());

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật bảng chấm công thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bảng chấm công cần sửa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBangChamCong.Text))
            {
                MessageBox.Show("Vui lòng chọn bảng chấm công cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bảng chấm công này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaBangChamCong.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa bảng chấm công thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bảng chấm công cần xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa bảng chấm công. Bảng có thể đang có chi tiết chấm công.\n"
                    + ex.Message,
                    "Lỗi xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBangChamCong.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvBangChamCong.ClearSelection();
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
                TaiPhongBan();
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

        private void dgvBangChamCong_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvBangChamCong.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaBangChamCong.Text =
                Convert.ToString(row.Cells["MaBangChamCong"].Value);

            cboPhongBan.SelectedValue =
                Convert.ToString(row.Cells["MaPhongBan"].Value);

            nudThang.Value =
                Convert.ToDecimal(row.Cells["Thang"].Value);

            nudNam.Value =
                Convert.ToDecimal(row.Cells["Nam"].Value);

            dtpNgayLap.Value =
                Convert.ToDateTime(row.Cells["NgayLap"].Value);

            txtNguoiLap.Text =
                Convert.ToString(row.Cells["NguoiLap"].Value);

            cboTrangThai.SelectedItem =
                Convert.ToString(row.Cells["TrangThai"].Value);

            txtMaBangChamCong.ReadOnly = true;
        }

        private void ThongBaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý bảng chấm công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
