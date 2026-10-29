
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChiTietPhanCong : Form
    {
        private readonly PhanCongService service = new PhanCongService();

        public FrmChiTietPhanCong()
        {
            InitializeComponent();
        }

        private void FrmChiTietPhanCong_Load(object sender, EventArgs e)
        {
            try
            {
                TaiDanhMuc();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void TaiDanhMuc()
        {
            cboKeHoach.DisplayMember = "TenKeHoach";
            cboKeHoach.ValueMember = "MaKeHoach";
            cboKeHoach.DataSource = service.LayKeHoach();
            cboKeHoach.SelectedIndex = -1;

            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.DataSource = service.LayNhanVien();
            cboNhanVien.SelectedIndex = -1;

            cboCaLamViec.DisplayMember = "TenCa";
            cboCaLamViec.ValueMember = "MaCa";
            cboCaLamViec.DataSource = service.LayCaLamViec();
            cboCaLamViec.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvPhanCong.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvPhanCong.Columns["MaPhanCong"] != null)
                dgvPhanCong.Columns["MaPhanCong"].HeaderText =
                    "Mã phân công";

            if (dgvPhanCong.Columns["MaKeHoach"] != null)
                dgvPhanCong.Columns["MaKeHoach"].HeaderText =
                    "Kế hoạch tuần";

            if (dgvPhanCong.Columns["MaNV"] != null)
                dgvPhanCong.Columns["MaNV"].HeaderText = "Mã NV";

            if (dgvPhanCong.Columns["HoTen"] != null)
                dgvPhanCong.Columns["HoTen"].HeaderText = "Họ tên";

            if (dgvPhanCong.Columns["MaCa"] != null)
                dgvPhanCong.Columns["MaCa"].Visible = false;

            if (dgvPhanCong.Columns["TenCa"] != null)
                dgvPhanCong.Columns["TenCa"].HeaderText = "Ca làm việc";

            if (dgvPhanCong.Columns["NgayLamViec"] != null)
            {
                dgvPhanCong.Columns["NgayLamViec"].HeaderText =
                    "Ngày làm việc";
                dgvPhanCong.Columns["NgayLamViec"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvPhanCong.Columns["NoiDungCongViec"] != null)
                dgvPhanCong.Columns["NoiDungCongViec"].HeaderText =
                    "Nội dung công việc";

            if (dgvPhanCong.Columns["GhiChu"] != null)
                dgvPhanCong.Columns["GhiChu"].HeaderText = "Ghi chú";
        }

        private void LamMoiNhapLieu()
        {
            txtMaPhanCong.Clear();
            txtNoiDungCongViec.Clear();
            txtGhiChu.Clear();

            cboKeHoach.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            cboCaLamViec.SelectedIndex = -1;

            dtpNgayLamViec.Value = DateTime.Today;
            txtMaPhanCong.ReadOnly = false;

            dgvPhanCong.ClearSelection();
            txtMaPhanCong.Focus();
        }

        private string LayGiaTri(ComboBox combo)
        {
            if (combo.SelectedValue == null ||
                combo.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(combo.SelectedValue);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaPhanCong.Text,
                    LayGiaTri(cboKeHoach),
                    LayGiaTri(cboNhanVien),
                    LayGiaTri(cboCaLamViec),
                    dtpNgayLamViec.Value,
                    txtNoiDungCongViec.Text,
                    txtGhiChu.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm phân công thành công!");
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
                    txtMaPhanCong.Text,
                    LayGiaTri(cboKeHoach),
                    LayGiaTri(cboNhanVien),
                    LayGiaTri(cboCaLamViec),
                    dtpNgayLamViec.Value,
                    txtNoiDungCongViec.Text,
                    txtGhiChu.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật phân công thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phân công cần sửa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhanCong.Text))
            {
                MessageBox.Show("Vui lòng chọn phân công cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phân công này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaPhanCong.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa phân công thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phân công cần xóa.");
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
                dgvPhanCong.DataSource =
                    service.TimKiem(txtTimKiem.Text);
                DinhDangBang();
                dgvPhanCong.ClearSelection();
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
                TaiDanhMuc();
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

        private void dgvPhanCong_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPhanCong.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaPhanCong.Text =
                Convert.ToString(row.Cells["MaPhanCong"].Value);

            cboKeHoach.SelectedValue =
                Convert.ToString(row.Cells["MaKeHoach"].Value);

            cboNhanVien.SelectedValue =
                Convert.ToString(row.Cells["MaNV"].Value);

            cboCaLamViec.SelectedValue =
                Convert.ToString(row.Cells["MaCa"].Value);

            dtpNgayLamViec.Value =
                Convert.ToDateTime(row.Cells["NgayLamViec"].Value);

            txtNoiDungCongViec.Text =
                Convert.ToString(row.Cells["NoiDungCongViec"].Value);

            txtGhiChu.Text =
                Convert.ToString(row.Cells["GhiChu"].Value);

            txtMaPhanCong.ReadOnly = true;
        }

        private void ThongBaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý phân công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void lblNoiDungCongViec_Click(object sender, EventArgs e)
        {

        }
    }
}
