using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmQuyetDinhKyLuat : Form
    {
        private readonly KyLuatService service = new KyLuatService();

        public FrmQuyetDinhKyLuat()
        {
            InitializeComponent();
        }

        private void FrmQuyetDinhKyLuat_Load(object sender, EventArgs e)
        {
            try
            {
                TaiDanhMuc();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void TaiDanhMuc()
        {
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.DataSource = service.LayNhanVien();
            cboNhanVien.SelectedIndex = -1;

            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";
            cboPhongBan.DataSource = service.LayPhongBan();
            cboPhongBan.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvQuyetDinh.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvQuyetDinh.Columns["MaQDKL"] != null)
                dgvQuyetDinh.Columns["MaQDKL"].HeaderText =
                    "Mã quyết định";

            if (dgvQuyetDinh.Columns["SoQuyetDinh"] != null)
                dgvQuyetDinh.Columns["SoQuyetDinh"].HeaderText =
                    "Số quyết định";

            if (dgvQuyetDinh.Columns["NgayQuyetDinh"] != null)
            {
                dgvQuyetDinh.Columns["NgayQuyetDinh"].HeaderText =
                    "Ngày quyết định";
                dgvQuyetDinh.Columns["NgayQuyetDinh"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvQuyetDinh.Columns["LoaiDoiTuong"] != null)
                dgvQuyetDinh.Columns["LoaiDoiTuong"].HeaderText =
                    "Loại đối tượng";

            if (dgvQuyetDinh.Columns["MaNV"] != null)
                dgvQuyetDinh.Columns["MaNV"].Visible = false;

            if (dgvQuyetDinh.Columns["HoTen"] != null)
                dgvQuyetDinh.Columns["HoTen"].HeaderText = "Nhân viên";

            if (dgvQuyetDinh.Columns["MaPhongBan"] != null)
                dgvQuyetDinh.Columns["MaPhongBan"].Visible = false;

            if (dgvQuyetDinh.Columns["TenPhongBan"] != null)
                dgvQuyetDinh.Columns["TenPhongBan"].HeaderText =
                    "Phòng ban";

            if (dgvQuyetDinh.Columns["LyDoKyLuat"] != null)
                dgvQuyetDinh.Columns["LyDoKyLuat"].HeaderText =
                    "Lý do kỷ luật";

            if (dgvQuyetDinh.Columns["HinhThucKyLuat"] != null)
                dgvQuyetDinh.Columns["HinhThucKyLuat"].HeaderText =
                    "Hình thức kỷ luật";

            if (dgvQuyetDinh.Columns["SoTienPhat"] != null)
            {
                dgvQuyetDinh.Columns["SoTienPhat"].HeaderText =
                    "Số tiền phạt";
                dgvQuyetDinh.Columns["SoTienPhat"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvQuyetDinh.Columns["NguoiKy"] != null)
                dgvQuyetDinh.Columns["NguoiKy"].HeaderText =
                    "Người ký";
        }

        private void LamMoiNhapLieu()
        {
            txtMaQDKL.Clear();
            txtSoQuyetDinh.Clear();
            txtLyDoKyLuat.Clear();
            txtHinhThucKyLuat.Clear();
            txtNguoiKy.Clear();

            dtpNgayQuyetDinh.Value = DateTime.Today;
            nudSoTienPhat.Value = 0;

            cboLoaiDoiTuong.SelectedIndex = 0;
            cboNhanVien.SelectedIndex = -1;
            cboPhongBan.SelectedIndex = -1;

            txtMaQDKL.ReadOnly = false;
            CapNhatDoiTuong();
            dgvQuyetDinh.ClearSelection();
        }

        private string LayMa(ComboBox combo)
        {
            if (combo.SelectedValue == null ||
                combo.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(combo.SelectedValue);
        }

        private void CapNhatDoiTuong()
        {
            bool laCaNhan = cboLoaiDoiTuong.Text == "Cá nhân";

            cboNhanVien.Enabled = laCaNhan;
            cboPhongBan.Enabled = !laCaNhan;

            if (laCaNhan)
                cboPhongBan.SelectedIndex = -1;
            else
                cboNhanVien.SelectedIndex = -1;
        }

        private void cboLoaiDoiTuong_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CapNhatDoiTuong();
        }

        private void Luu(bool laThem)
        {
            string loai = cboLoaiDoiTuong.Text;
            string maNV = loai == "Cá nhân"
                ? LayMa(cboNhanVien) : null;
            string maPhongBan = loai == "Tập thể"
                ? LayMa(cboPhongBan) : null;

            int ketQua = laThem
                ? service.Them(
                    txtMaQDKL.Text,
                    txtSoQuyetDinh.Text,
                    dtpNgayQuyetDinh.Value,
                    loai, maNV, maPhongBan,
                    txtLyDoKyLuat.Text,
                    txtHinhThucKyLuat.Text,
                    nudSoTienPhat.Value,
                    txtNguoiKy.Text)
                : service.Sua(
                    txtMaQDKL.Text,
                    txtSoQuyetDinh.Text,
                    dtpNgayQuyetDinh.Value,
                    loai, maNV, maPhongBan,
                    txtLyDoKyLuat.Text,
                    txtHinhThucKyLuat.Text,
                    nudSoTienPhat.Value,
                    txtNguoiKy.Text);

            if (ketQua > 0)
            {
                MessageBox.Show(laThem
                    ? "Thêm quyết định kỷ luật thành công!"
                    : "Cập nhật quyết định kỷ luật thành công!");

                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy quyết định cần sửa.");
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
            if (string.IsNullOrWhiteSpace(txtMaQDKL.Text))
            {
                MessageBox.Show("Vui lòng chọn quyết định cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa quyết định kỷ luật này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (service.Xoa(txtMaQDKL.Text) > 0)
                {
                    MessageBox.Show("Xóa quyết định thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quyết định cần xóa.");
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
                dgvQuyetDinh.DataSource =
                    service.TimKiem(txtTimKiem.Text);
                DinhDangBang();
                dgvQuyetDinh.ClearSelection();
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
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
                BaoLoi(ex);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvQuyetDinh_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvQuyetDinh.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaQDKL.Text =
                Convert.ToString(row.Cells["MaQDKL"].Value);

            txtSoQuyetDinh.Text =
                Convert.ToString(row.Cells["SoQuyetDinh"].Value);

            dtpNgayQuyetDinh.Value =
                Convert.ToDateTime(row.Cells["NgayQuyetDinh"].Value);

            string loai =
                Convert.ToString(row.Cells["LoaiDoiTuong"].Value);

            cboLoaiDoiTuong.SelectedItem = loai;

            if (loai == "Cá nhân")
                cboNhanVien.SelectedValue =
                    Convert.ToString(row.Cells["MaNV"].Value);
            else
                cboPhongBan.SelectedValue =
                    Convert.ToString(row.Cells["MaPhongBan"].Value);

            txtLyDoKyLuat.Text =
                Convert.ToString(row.Cells["LyDoKyLuat"].Value);

            txtHinhThucKyLuat.Text =
                Convert.ToString(row.Cells["HinhThucKyLuat"].Value);

            nudSoTienPhat.Value =
                Convert.ToDecimal(row.Cells["SoTienPhat"].Value);

            txtNguoiKy.Text =
                Convert.ToString(row.Cells["NguoiKy"].Value);

            txtMaQDKL.ReadOnly = true;
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý quyết định kỷ luật",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}