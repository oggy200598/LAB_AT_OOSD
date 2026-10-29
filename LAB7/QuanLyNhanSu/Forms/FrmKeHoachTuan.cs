
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmKeHoachTuan : Form
    {
        private readonly KeHoachService service = new KeHoachService();

        public FrmKeHoachTuan()
        {
            InitializeComponent();
        }

        private void FrmKeHoachTuan_Load(object sender, EventArgs e)
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
            cboPhongBan.DataSource = service.LayPhongBan();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";
            cboPhongBan.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvKeHoach.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvKeHoach.Columns["MaKeHoach"] != null)
                dgvKeHoach.Columns["MaKeHoach"].HeaderText = "Mã kế hoạch";

            if (dgvKeHoach.Columns["MaPhongBan"] != null)
                dgvKeHoach.Columns["MaPhongBan"].Visible = false;

            if (dgvKeHoach.Columns["TenPhongBan"] != null)
                dgvKeHoach.Columns["TenPhongBan"].HeaderText = "Phòng ban";

            if (dgvKeHoach.Columns["NgayBatDau"] != null)
            {
                dgvKeHoach.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
                dgvKeHoach.Columns["NgayBatDau"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvKeHoach.Columns["NgayKetThuc"] != null)
            {
                dgvKeHoach.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
                dgvKeHoach.Columns["NgayKetThuc"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvKeHoach.Columns["NguoiLap"] != null)
                dgvKeHoach.Columns["NguoiLap"].HeaderText = "Người lập";

            if (dgvKeHoach.Columns["NgayLap"] != null)
            {
                dgvKeHoach.Columns["NgayLap"].HeaderText = "Ngày lập";
                dgvKeHoach.Columns["NgayLap"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvKeHoach.Columns["NoiDung"] != null)
                dgvKeHoach.Columns["NoiDung"].HeaderText = "Nội dung";

            if (dgvKeHoach.Columns["TrangThai"] != null)
                dgvKeHoach.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void LamMoiNhapLieu()
        {
            txtMaKeHoach.Clear();
            txtNguoiLap.Clear();
            txtNoiDung.Clear();

            cboPhongBan.SelectedIndex = -1;
            cboTrangThai.SelectedItem = "Đã lập";

            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddDays(6);
            dtpNgayLap.Value = DateTime.Today;

            txtMaKeHoach.ReadOnly = false;
            dgvKeHoach.ClearSelection();
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
            if (cboTrangThai.SelectedIndex < 0)
                return null;

            return cboTrangThai.SelectedItem.ToString();
        }

        private void dtpNgayBatDau_ValueChanged(
            object sender, EventArgs e)
        {
            DateTime gioiHan =
                dtpNgayKetThuc.MaxDate.Date.AddDays(-6);

            if (dtpNgayBatDau.Value.Date > gioiHan)
                return;

            dtpNgayKetThuc.Value =
                dtpNgayBatDau.Value.Date.AddDays(6);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaKeHoach.Text,
                    LayMaPhongBan(),
                    dtpNgayBatDau.Value,
                    txtNguoiLap.Text,
                    dtpNgayLap.Value,
                    txtNoiDung.Text,
                    LayTrangThai());

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Thêm kế hoạch tuần thành công!",
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
                    txtMaKeHoach.Text,
                    LayMaPhongBan(),
                    dtpNgayBatDau.Value,
                    txtNguoiLap.Text,
                    dtpNgayLap.Value,
                    txtNoiDung.Text,
                    LayTrangThai());

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật kế hoạch thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kế hoạch cần sửa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKeHoach.Text))
            {
                MessageBox.Show("Vui lòng chọn kế hoạch cần xóa.");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa kế hoạch này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                int soDong = service.Xoa(txtMaKeHoach.Text);

                if (soDong > 0)
                {
                    MessageBox.Show("Xóa kế hoạch thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kế hoạch cần xóa.");
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
                dgvKeHoach.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvKeHoach.ClearSelection();
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

        private void dgvKeHoach_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvKeHoach.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaKeHoach.Text =
                Convert.ToString(row.Cells["MaKeHoach"].Value);

            cboPhongBan.SelectedValue =
                Convert.ToString(row.Cells["MaPhongBan"].Value);

            dtpNgayBatDau.Value =
                Convert.ToDateTime(row.Cells["NgayBatDau"].Value);

            dtpNgayKetThuc.Value =
                Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);

            txtNguoiLap.Text =
                Convert.ToString(row.Cells["NguoiLap"].Value);

            dtpNgayLap.Value =
                Convert.ToDateTime(row.Cells["NgayLap"].Value);

            txtNoiDung.Text =
                Convert.ToString(row.Cells["NoiDung"].Value);

            cboTrangThai.SelectedItem =
                Convert.ToString(row.Cells["TrangThai"].Value);

            txtMaKeHoach.ReadOnly = true;
        }

        private void ThongBaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý kế hoạch tuần",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
