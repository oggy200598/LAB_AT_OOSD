using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChiTietBangLuong : Form
    {
        private readonly BangLuongService service =
            new BangLuongService();

        public FrmChiTietBangLuong()
        {
            InitializeComponent();
        }

        private void FrmChiTietBangLuong_Load(object sender, EventArgs e)
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
            cboBangLuong.DisplayMember = "TenBang";
            cboBangLuong.ValueMember = "MaBangLuong";
            cboBangLuong.DataSource = service.LayBangLuong();
            cboBangLuong.SelectedIndex = -1;

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
            if (dgvChiTiet.Columns["MaChiTietLuong"] != null)
                dgvChiTiet.Columns["MaChiTietLuong"].HeaderText =
                    "Mã chi tiết";

            if (dgvChiTiet.Columns["MaBangLuong"] != null)
                dgvChiTiet.Columns["MaBangLuong"].HeaderText =
                    "Mã bảng lương";

            if (dgvChiTiet.Columns["MaNV"] != null)
                dgvChiTiet.Columns["MaNV"].HeaderText =
                    "Mã nhân viên";

            if (dgvChiTiet.Columns["HoTen"] != null)
                dgvChiTiet.Columns["HoTen"].HeaderText =
                    "Họ tên";

            if (dgvChiTiet.Columns["LuongCoBan"] != null)
                dgvChiTiet.Columns["LuongCoBan"].HeaderText =
                    "Lương cơ bản";

            if (dgvChiTiet.Columns["SoNgayCong"] != null)
                dgvChiTiet.Columns["SoNgayCong"].HeaderText =
                    "Số ngày công";

            if (dgvChiTiet.Columns["PhuCapLuong"] != null)
                dgvChiTiet.Columns["PhuCapLuong"].HeaderText =
                    "Phụ cấp lương";

            if (dgvChiTiet.Columns["PhuCapChucVu"] != null)
                dgvChiTiet.Columns["PhuCapChucVu"].HeaderText =
                    "Phụ cấp chức vụ";

            if (dgvChiTiet.Columns["PhuCapDocHai"] != null)
                dgvChiTiet.Columns["PhuCapDocHai"].HeaderText =
                    "Phụ cấp độc hại";

            if (dgvChiTiet.Columns["TienPhuTroi"] != null)
                dgvChiTiet.Columns["TienPhuTroi"].HeaderText =
                    "Tiền phụ trội";

            if (dgvChiTiet.Columns["TienThuong"] != null)
                dgvChiTiet.Columns["TienThuong"].HeaderText =
                    "Tiền thưởng";

            if (dgvChiTiet.Columns["TienPhat"] != null)
                dgvChiTiet.Columns["TienPhat"].HeaderText =
                    "Tiền phạt";

            if (dgvChiTiet.Columns["TienBHXH"] != null)
                dgvChiTiet.Columns["TienBHXH"].HeaderText =
                    "Tiền BHXH";

            if (dgvChiTiet.Columns["TienBHYT"] != null)
                dgvChiTiet.Columns["TienBHYT"].HeaderText =
                    "Tiền BHYT";

            if (dgvChiTiet.Columns["ThucLanh"] != null)
                dgvChiTiet.Columns["ThucLanh"].HeaderText =
                    "Thực lãnh";

            string[] cotTien = {
                "LuongCoBan", "PhuCapLuong", "PhuCapChucVu",
                "PhuCapDocHai", "TienPhuTroi", "TienThuong",
                "TienPhat", "TienBHXH", "TienBHYT", "ThucLanh"
            };

            foreach (string cot in cotTien)
            {
                if (dgvChiTiet.Columns[cot] != null)
                    dgvChiTiet.Columns[cot]
                        .DefaultCellStyle.Format = "N2";
            }

            if (dgvChiTiet.Columns["SoNgayCong"] != null)
                dgvChiTiet.Columns["SoNgayCong"]
                    .DefaultCellStyle.Format = "N2";
        }

        private void LamMoiNhapLieu()
        {
            txtMaChiTiet.Clear();

            cboBangLuong.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;

            nudLuongCoBan.Value = 0;
            nudSoNgayCong.Value = 0;
            nudPhuCapLuong.Value = 0;
            nudPhuCapChucVu.Value = 0;
            nudPhuCapDocHai.Value = 0;
            nudTienPhuTroi.Value = 0;
            nudTienThuong.Value = 0;
            nudTienPhat.Value = 0;
            nudTienBHXH.Value = 0;
            nudTienBHYT.Value = 0;
            nudThucLanh.Value = 0;

            txtMaChiTiet.ReadOnly = false;
            dgvChiTiet.ClearSelection();
        }

        private string LayMa(ComboBox combo)
        {
            if (combo.SelectedValue == null ||
                combo.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(combo.SelectedValue);
        }

        private void Luu(bool laThem)
        {
            int ketQua = laThem
                ? service.ThemChiTiet(
                    txtMaChiTiet.Text,
                    LayMa(cboBangLuong),
                    LayMa(cboNhanVien),
                    nudLuongCoBan.Value,
                    nudSoNgayCong.Value,
                    nudPhuCapLuong.Value,
                    nudPhuCapChucVu.Value,
                    nudPhuCapDocHai.Value,
                    nudTienPhuTroi.Value,
                    nudTienThuong.Value,
                    nudTienPhat.Value,
                    nudTienBHXH.Value,
                    nudTienBHYT.Value,
                    nudThucLanh.Value)
                : service.SuaChiTiet(
                    txtMaChiTiet.Text,
                    LayMa(cboBangLuong),
                    LayMa(cboNhanVien),
                    nudLuongCoBan.Value,
                    nudSoNgayCong.Value,
                    nudPhuCapLuong.Value,
                    nudPhuCapChucVu.Value,
                    nudPhuCapDocHai.Value,
                    nudTienPhuTroi.Value,
                    nudTienThuong.Value,
                    nudTienPhat.Value,
                    nudTienBHXH.Value,
                    nudTienBHYT.Value,
                    nudThucLanh.Value);

            if (ketQua > 0)
            {
                MessageBox.Show(
                    laThem
                        ? "Thêm chi tiết lương thành công!"
                        : "Cập nhật chi tiết lương thành công!");

                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết lương cần sửa.");
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
            if (string.IsNullOrWhiteSpace(txtMaChiTiet.Text))
            {
                MessageBox.Show("Vui lòng chọn chi tiết lương cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa chi tiết lương này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.XoaChiTiet(txtMaChiTiet.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa chi tiết lương thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chi tiết lương cần xóa.");
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

            try
            {
                txtMaChiTiet.Text =
                    Convert.ToString(row.Cells["MaChiTietLuong"].Value);

                cboBangLuong.SelectedValue =
                    Convert.ToString(row.Cells["MaBangLuong"].Value);

                cboNhanVien.SelectedValue =
                    Convert.ToString(row.Cells["MaNV"].Value);

                nudLuongCoBan.Value =
                    Convert.ToDecimal(row.Cells["LuongCoBan"].Value);

                nudSoNgayCong.Value =
                    Convert.ToDecimal(row.Cells["SoNgayCong"].Value);

                nudPhuCapLuong.Value =
                    Convert.ToDecimal(row.Cells["PhuCapLuong"].Value);

                nudPhuCapChucVu.Value =
                    Convert.ToDecimal(row.Cells["PhuCapChucVu"].Value);

                nudPhuCapDocHai.Value =
                    Convert.ToDecimal(row.Cells["PhuCapDocHai"].Value);

                nudTienPhuTroi.Value =
                    Convert.ToDecimal(row.Cells["TienPhuTroi"].Value);

                nudTienThuong.Value =
                    Convert.ToDecimal(row.Cells["TienThuong"].Value);

                nudTienPhat.Value =
                    Convert.ToDecimal(row.Cells["TienPhat"].Value);

                nudTienBHXH.Value =
                    Convert.ToDecimal(row.Cells["TienBHXH"].Value);

                nudTienBHYT.Value =
                    Convert.ToDecimal(row.Cells["TienBHYT"].Value);

                nudThucLanh.Value =
                    Convert.ToDecimal(row.Cells["ThucLanh"].Value);

                txtMaChiTiet.ReadOnly = true;
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý chi tiết bảng lương",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}