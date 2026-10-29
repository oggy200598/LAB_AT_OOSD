using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmQuyetDinhKhenThuong : Form
    {
        private readonly KhenThuongService service =
            new KhenThuongService();

        public FrmQuyetDinhKhenThuong()
        {
            InitializeComponent();
        }

        private void FrmQuyetDinhKhenThuong_Load(
            object sender, EventArgs e)
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
            if (dgvQuyetDinh.Columns["MaQDKT"] != null)
                dgvQuyetDinh.Columns["MaQDKT"].HeaderText =
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
                dgvQuyetDinh.Columns["HoTen"].HeaderText =
                    "Nhân viên";

            if (dgvQuyetDinh.Columns["MaPhongBan"] != null)
                dgvQuyetDinh.Columns["MaPhongBan"].Visible = false;

            if (dgvQuyetDinh.Columns["TenPhongBan"] != null)
                dgvQuyetDinh.Columns["TenPhongBan"].HeaderText =
                    "Phòng ban";

            if (dgvQuyetDinh.Columns["LyDoKhenThuong"] != null)
                dgvQuyetDinh.Columns["LyDoKhenThuong"].HeaderText =
                    "Lý do khen thưởng";

            if (dgvQuyetDinh.Columns["SoTienThuong"] != null)
            {
                dgvQuyetDinh.Columns["SoTienThuong"].HeaderText =
                    "Số tiền thưởng";
                dgvQuyetDinh.Columns["SoTienThuong"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvQuyetDinh.Columns["NguoiKy"] != null)
                dgvQuyetDinh.Columns["NguoiKy"].HeaderText =
                    "Người ký";
        }

        private void LamMoiNhapLieu()
        {
            txtMaQDKT.Clear();
            txtSoQuyetDinh.Clear();
            txtLyDo.Clear();
            txtNguoiKy.Clear();

            dtpNgayQuyetDinh.Value = DateTime.Today;
            nudSoTienThuong.Value = 0;

            cboLoaiDoiTuong.SelectedIndex = 0;
            cboNhanVien.SelectedIndex = -1;
            cboPhongBan.SelectedIndex = -1;

            txtMaQDKT.ReadOnly = false;
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
                    txtMaQDKT.Text,
                    txtSoQuyetDinh.Text,
                    dtpNgayQuyetDinh.Value,
                    loai,
                    maNV,
                    maPhongBan,
                    txtLyDo.Text,
                    nudSoTienThuong.Value,
                    txtNguoiKy.Text)
                : service.Sua(
                    txtMaQDKT.Text,
                    txtSoQuyetDinh.Text,
                    dtpNgayQuyetDinh.Value,
                    loai,
                    maNV,
                    maPhongBan,
                    txtLyDo.Text,
                    nudSoTienThuong.Value,
                    txtNguoiKy.Text);

            if (ketQua > 0)
            {
                MessageBox.Show(laThem
                    ? "Thêm quyết định khen thưởng thành công!"
                    : "Cập nhật quyết định khen thưởng thành công!");

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
            if (string.IsNullOrWhiteSpace(txtMaQDKT.Text))
            {
                MessageBox.Show("Vui lòng chọn quyết định cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa quyết định này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (service.Xoa(txtMaQDKT.Text) > 0)
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

            txtMaQDKT.Text =
                Convert.ToString(row.Cells["MaQDKT"].Value);

            txtSoQuyetDinh.Text =
                Convert.ToString(row.Cells["SoQuyetDinh"].Value);

            dtpNgayQuyetDinh.Value =
                Convert.ToDateTime(row.Cells["NgayQuyetDinh"].Value);

            string loai =
                Convert.ToString(row.Cells["LoaiDoiTuong"].Value);

            cboLoaiDoiTuong.SelectedItem = loai;

            if (loai == "Cá nhân")
            {
                cboNhanVien.SelectedValue =
                    Convert.ToString(row.Cells["MaNV"].Value);
            }
            else
            {
                cboPhongBan.SelectedValue =
                    Convert.ToString(row.Cells["MaPhongBan"].Value);
            }

            txtLyDo.Text =
                Convert.ToString(row.Cells["LyDoKhenThuong"].Value);

            nudSoTienThuong.Value =
                Convert.ToDecimal(row.Cells["SoTienThuong"].Value);

            txtNguoiKy.Text =
                Convert.ToString(row.Cells["NguoiKy"].Value);

            txtMaQDKT.ReadOnly = true;
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý quyết định khen thưởng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}