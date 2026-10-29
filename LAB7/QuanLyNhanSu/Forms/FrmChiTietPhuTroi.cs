using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChiTietPhuTroi : Form
    {
        private readonly PhuTroiService service =
            new PhuTroiService();

        public FrmChiTietPhuTroi()
        {
            InitializeComponent();
        }

        private void FrmChiTietPhuTroi_Load(object sender, EventArgs e)
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
            cboPhieuPhuTroi.DisplayMember = "TenPhieu";
            cboPhieuPhuTroi.ValueMember = "MaPhieuPhuTroi";
            cboPhieuPhuTroi.DataSource = service.LayPhieuPhuTroi();
            cboPhieuPhuTroi.SelectedIndex = -1;

            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.DataSource = service.LayNhanVien();
            cboNhanVien.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvChiTiet.DataSource = service.LayDanhSachChiTiet();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvChiTiet.Columns["MaChiTietPhuTroi"] != null)
                dgvChiTiet.Columns["MaChiTietPhuTroi"].HeaderText =
                    "Mã chi tiết";

            if (dgvChiTiet.Columns["MaPhieuPhuTroi"] != null)
                dgvChiTiet.Columns["MaPhieuPhuTroi"].HeaderText =
                    "Mã phiếu";

            if (dgvChiTiet.Columns["SoPhieu"] != null)
                dgvChiTiet.Columns["SoPhieu"].HeaderText =
                    "Số phiếu";

            if (dgvChiTiet.Columns["MaNV"] != null)
                dgvChiTiet.Columns["MaNV"].HeaderText =
                    "Mã nhân viên";

            if (dgvChiTiet.Columns["HoTen"] != null)
                dgvChiTiet.Columns["HoTen"].HeaderText =
                    "Họ tên nhân viên";

            if (dgvChiTiet.Columns["SoGioThamGia"] != null)
            {
                dgvChiTiet.Columns["SoGioThamGia"].HeaderText =
                    "Số giờ tham gia";
                dgvChiTiet.Columns["SoGioThamGia"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvChiTiet.Columns["HeSoPhuTroi"] != null)
            {
                dgvChiTiet.Columns["HeSoPhuTroi"].HeaderText =
                    "Hệ số phụ trội";
                dgvChiTiet.Columns["HeSoPhuTroi"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvChiTiet.Columns["ThanhTien"] != null)
            {
                dgvChiTiet.Columns["ThanhTien"].HeaderText =
                    "Thành tiền";
                dgvChiTiet.Columns["ThanhTien"]
                    .DefaultCellStyle.Format = "N2";
            }
        }

        private void LamMoiNhapLieu()
        {
            txtMaChiTiet.Clear();

            cboPhieuPhuTroi.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;

            nudSoGioThamGia.Value = 1;
            nudThanhTien.Value = 0;

            txtHeSoPhuTroi.Text = "1,50";
            txtMaChiTiet.ReadOnly = false;


            dgvChiTiet.ClearSelection();
            txtMaChiTiet.Focus();
        }

        private string LayGiaTri(ComboBox combo)
        {
            if (combo.SelectedValue == null ||
                combo.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(combo.SelectedValue);
        }

        private void cboPhieuPhuTroi_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            string maPhieu = LayGiaTri(cboPhieuPhuTroi);



        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.ThemChiTiet(
                    txtMaChiTiet.Text,
                    LayGiaTri(cboPhieuPhuTroi),
                    LayGiaTri(cboNhanVien),
                    nudSoGioThamGia.Value,
                    nudThanhTien.Value);

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Thêm chi tiết phụ trội thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    TaiDuLieu();
                }
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
                int ketQua = service.SuaChiTiet(
                    txtMaChiTiet.Text,
                    LayGiaTri(cboPhieuPhuTroi),
                    LayGiaTri(cboNhanVien),
                    nudSoGioThamGia.Value,
                    nudThanhTien.Value);

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Cập nhật chi tiết phụ trội thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy chi tiết cần sửa.");
                }
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChiTiet.Text))
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa chi tiết phụ trội?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.XoaChiTiet(txtMaChiTiet.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa chi tiết thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy chi tiết cần xóa.");
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
                dgvChiTiet.DataSource =
                    service.TimKiemChiTiet(txtTimKiem.Text);
                DinhDangBang();
                dgvChiTiet.ClearSelection();
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

        private void dgvChiTiet_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaChiTiet.Text =
                Convert.ToString(
                    row.Cells["MaChiTietPhuTroi"].Value);

            cboPhieuPhuTroi.SelectedValue =
                Convert.ToString(
                    row.Cells["MaPhieuPhuTroi"].Value);

            cboNhanVien.SelectedValue =
                Convert.ToString(row.Cells["MaNV"].Value);

            nudSoGioThamGia.Value =
                Convert.ToDecimal(
                    row.Cells["SoGioThamGia"].Value);

            txtHeSoPhuTroi.Text =
                Convert.ToDecimal(
                    row.Cells["HeSoPhuTroi"].Value).ToString("N2");

            nudThanhTien.Value =
                Convert.ToDecimal(row.Cells["ThanhTien"].Value);

            txtMaChiTiet.ReadOnly = true;
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý chi tiết phụ trội",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}