using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmPhieuChiKhenThuong : Form
    {
        private readonly KhenThuongService service =
            new KhenThuongService();

        public FrmPhieuChiKhenThuong()
        {
            InitializeComponent();
        }

        private void FrmPhieuChiKhenThuong_Load(object sender, EventArgs e)
        {
            try
            {
                TaiQuyetDinh();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        private void TaiQuyetDinh()
        {
            cboQuyetDinh.DisplayMember = "TenQuyetDinh";
            cboQuyetDinh.ValueMember = "MaQDKT";
            cboQuyetDinh.DataSource =
                service.LayQuyetDinhKhenThuong();
            cboQuyetDinh.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvPhieuChi.DataSource = service.LayDanhSachPhieuChi();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvPhieuChi.Columns["MaPhieuChi"] != null)
                dgvPhieuChi.Columns["MaPhieuChi"].HeaderText =
                    "Mã phiếu chi";

            if (dgvPhieuChi.Columns["MaQDKT"] != null)
                dgvPhieuChi.Columns["MaQDKT"].HeaderText =
                    "Mã quyết định";

            if (dgvPhieuChi.Columns["SoQuyetDinh"] != null)
                dgvPhieuChi.Columns["SoQuyetDinh"].HeaderText =
                    "Số quyết định";

            if (dgvPhieuChi.Columns["SoTienThuong"] != null)
            {
                dgvPhieuChi.Columns["SoTienThuong"].HeaderText =
                    "Tiền thưởng";
                dgvPhieuChi.Columns["SoTienThuong"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvPhieuChi.Columns["NgayChi"] != null)
            {
                dgvPhieuChi.Columns["NgayChi"].HeaderText =
                    "Ngày chi";

                dgvPhieuChi.Columns["NgayChi"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvPhieuChi.Columns["SoTienChi"] != null)
            {
                dgvPhieuChi.Columns["SoTienChi"].HeaderText =
                    "Số tiền chi";

                dgvPhieuChi.Columns["SoTienChi"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvPhieuChi.Columns["NguoiLap"] != null)
                dgvPhieuChi.Columns["NguoiLap"].HeaderText =
                    "Người lập";

            if (dgvPhieuChi.Columns["HinhThucChi"] != null)
                dgvPhieuChi.Columns["HinhThucChi"].HeaderText =
                    "Hình thức chi";

            if (dgvPhieuChi.Columns["GhiChu"] != null)
                dgvPhieuChi.Columns["GhiChu"].HeaderText =
                    "Ghi chú";
        }

        private void LamMoiNhapLieu()
        {
            txtMaPhieuChi.Clear();
            txtNguoiLap.Clear();
            txtGhiChu.Clear();

            cboQuyetDinh.SelectedIndex = -1;
            cboHinhThucChi.SelectedItem = "Tiền mặt";

            dtpNgayChi.Value = DateTime.Today;
            nudSoTienChi.Value = 0;

            txtMaPhieuChi.ReadOnly = false;
            dgvPhieuChi.ClearSelection();
        }

        private string LayMaQuyetDinh()
        {
            if (cboQuyetDinh.SelectedValue == null ||
                cboQuyetDinh.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(cboQuyetDinh.SelectedValue);
        }

        private void cboQuyetDinh_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            string maQDKT = LayMaQuyetDinh();

           
        }

        private void Luu(bool laThem)
        {
            int ketQua = laThem
                ? service.ThemPhieuChi(
                    txtMaPhieuChi.Text,
                    LayMaQuyetDinh(),
                    dtpNgayChi.Value,
                    nudSoTienChi.Value,
                    txtNguoiLap.Text,
                    cboHinhThucChi.Text,
                    txtGhiChu.Text)
                : service.SuaPhieuChi(
                    txtMaPhieuChi.Text,
                    LayMaQuyetDinh(),
                    dtpNgayChi.Value,
                    nudSoTienChi.Value,
                    txtNguoiLap.Text,
                    cboHinhThucChi.Text,
                    txtGhiChu.Text);

            if (ketQua > 0)
            {
                MessageBox.Show(
                    laThem
                        ? "Thêm phiếu chi khen thưởng thành công!"
                        : "Cập nhật phiếu chi khen thưởng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu chi cần sửa.");
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
            if (string.IsNullOrWhiteSpace(txtMaPhieuChi.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu chi cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phiếu chi này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.XoaPhieuChi(txtMaPhieuChi.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa phiếu chi thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu chi cần xóa.");
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
                dgvPhieuChi.DataSource =
                    service.TimKiemPhieuChi(txtTimKiem.Text);

                DinhDangBang();
                dgvPhieuChi.ClearSelection();
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
                TaiQuyetDinh();
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

        private void dgvPhieuChi_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPhieuChi.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaPhieuChi.Text =
                Convert.ToString(row.Cells["MaPhieuChi"].Value);

            cboQuyetDinh.SelectedValue =
                Convert.ToString(row.Cells["MaQDKT"].Value);

            dtpNgayChi.Value =
                Convert.ToDateTime(row.Cells["NgayChi"].Value);

            nudSoTienChi.Value =
                Convert.ToDecimal(row.Cells["SoTienChi"].Value);

            txtNguoiLap.Text =
                Convert.ToString(row.Cells["NguoiLap"].Value);

            cboHinhThucChi.SelectedItem =
                Convert.ToString(row.Cells["HinhThucChi"].Value);

            txtGhiChu.Text =
                Convert.ToString(row.Cells["GhiChu"].Value);

            txtMaPhieuChi.ReadOnly = true;
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý phiếu chi khen thưởng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}