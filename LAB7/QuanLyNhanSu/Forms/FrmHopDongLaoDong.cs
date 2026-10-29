
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmHopDongLaoDong : Form
    {
        private readonly HopDongService service = new HopDongService();

        public FrmHopDongLaoDong()
        {
            InitializeComponent();
        }

        private void FrmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            try
            {
                TaiNhanVien();
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

        private void TaiNhanVien()
        {
            cboNhanVien.DataSource = service.LayNhanVien();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvHopDong.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvHopDong.Columns["MaHopDong"] != null)
                dgvHopDong.Columns["MaHopDong"].HeaderText = "Mã hợp đồng";

            if (dgvHopDong.Columns["SoHopDong"] != null)
                dgvHopDong.Columns["SoHopDong"].HeaderText = "Số hợp đồng";

            if (dgvHopDong.Columns["MaNV"] != null)
                dgvHopDong.Columns["MaNV"].Visible = false;

            if (dgvHopDong.Columns["HoTen"] != null)
                dgvHopDong.Columns["HoTen"].HeaderText = "Nhân viên";

            if (dgvHopDong.Columns["LoaiHopDong"] != null)
                dgvHopDong.Columns["LoaiHopDong"].HeaderText = "Loại hợp đồng";

            if (dgvHopDong.Columns["NgayKy"] != null)
            {
                dgvHopDong.Columns["NgayKy"].HeaderText = "Ngày ký";
                dgvHopDong.Columns["NgayKy"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvHopDong.Columns["NgayBatDau"] != null)
            {
                dgvHopDong.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
                dgvHopDong.Columns["NgayBatDau"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvHopDong.Columns["NgayKetThuc"] != null)
            {
                dgvHopDong.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
                dgvHopDong.Columns["NgayKetThuc"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvHopDong.Columns["NoiDungHopDong"] != null)
                dgvHopDong.Columns["NoiDungHopDong"].HeaderText =
                    "Nội dung hợp đồng";

            if (dgvHopDong.Columns["TrangThai"] != null)
                dgvHopDong.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void LamMoiNhapLieu()
        {
            txtMaHopDong.Clear();
            txtSoHopDong.Clear();
            txtNoiDungHopDong.Clear();

            cboNhanVien.SelectedIndex = -1;
            cboLoaiHopDong.SelectedIndex = -1;
            cboTrangThai.SelectedItem = "Có hiệu lực";

            dtpNgayKy.Value = DateTime.Today;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddYears(1);
            dtpNgayKetThuc.Checked = false;

            txtMaHopDong.ReadOnly = false;
            dgvHopDong.ClearSelection();
            txtMaHopDong.Focus();
        }

        private string LayMaNhanVien()
        {
            if (cboNhanVien.SelectedValue == null ||
                cboNhanVien.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(cboNhanVien.SelectedValue);
        }

        private string LayLoaiHopDong()
        {
            if (cboLoaiHopDong.SelectedIndex < 0)
                return null;

            return cboLoaiHopDong.SelectedItem.ToString();
        }

        private string LayTrangThai()
        {
            if (cboTrangThai.SelectedIndex < 0)
                return null;

            return cboTrangThai.SelectedItem.ToString();
        }

        private DateTime? LayNgayKetThuc()
        {
            if (!dtpNgayKetThuc.Checked)
                return null;

            return dtpNgayKetThuc.Value.Date;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaHopDong.Text,
                    txtSoHopDong.Text,
                    LayMaNhanVien(),
                    LayLoaiHopDong(),
                    dtpNgayKy.Value,
                    dtpNgayBatDau.Value,
                    LayNgayKetThuc(),
                    txtNoiDungHopDong.Text,
                    LayTrangThai());

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm hợp đồng thành công!");
                    TaiDuLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi thêm hợp đồng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Sua(
                    txtMaHopDong.Text,
                    txtSoHopDong.Text,
                    LayMaNhanVien(),
                    LayLoaiHopDong(),
                    dtpNgayKy.Value,
                    dtpNgayBatDau.Value,
                    LayNgayKetThuc(),
                    txtNoiDungHopDong.Text,
                    LayTrangThai());

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật hợp đồng thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hợp đồng cần sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi sửa hợp đồng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHopDong.Text))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hợp đồng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaHopDong.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa hợp đồng thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hợp đồng cần xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa hợp đồng. Hợp đồng có thể đang được sử dụng trong hồ sơ bảo hiểm hoặc dữ liệu liên quan.\n"
                    + ex.Message,
                    "Lỗi xóa hợp đồng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHopDong.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvHopDong.ClearSelection();
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
                TaiNhanVien();
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

        private void dgvHopDong_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvHopDong.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaHopDong.Text =
                Convert.ToString(row.Cells["MaHopDong"].Value);

            txtSoHopDong.Text =
                Convert.ToString(row.Cells["SoHopDong"].Value);

            cboNhanVien.SelectedValue =
                Convert.ToString(row.Cells["MaNV"].Value);

            cboLoaiHopDong.SelectedItem =
                Convert.ToString(row.Cells["LoaiHopDong"].Value);

            dtpNgayKy.Value =
                Convert.ToDateTime(row.Cells["NgayKy"].Value);

            dtpNgayBatDau.Value =
                Convert.ToDateTime(row.Cells["NgayBatDau"].Value);

            object ngayKetThuc = row.Cells["NgayKetThuc"].Value;

            if (ngayKetThuc == null || ngayKetThuc == DBNull.Value)
            {
                dtpNgayKetThuc.Value = DateTime.Today;
                dtpNgayKetThuc.Checked = false;
            }
            else
            {
                dtpNgayKetThuc.Value =
                    Convert.ToDateTime(ngayKetThuc);
                dtpNgayKetThuc.Checked = true;
            }

            txtNoiDungHopDong.Text =
                Convert.ToString(row.Cells["NoiDungHopDong"].Value);

            cboTrangThai.SelectedItem =
                Convert.ToString(row.Cells["TrangThai"].Value);

            txtMaHopDong.ReadOnly = true;
        }
    }
}
