using System;
using System.Globalization;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmPhieuPhuTroi : Form
    {
        private readonly PhuTroiService service = new PhuTroiService();

        public FrmPhieuPhuTroi()
        {
            InitializeComponent();
        }

        private void FrmPhieuPhuTroi_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                dgvPhieuPhuTroi.DataSource = service.LayDanhSach();
                DinhDangBang();
                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void DinhDangBang()
        {
            if (dgvPhieuPhuTroi.Columns["MaPhieuPhuTroi"] != null)
                dgvPhieuPhuTroi.Columns["MaPhieuPhuTroi"].HeaderText =
                    "Mã phiếu phụ trội";

            if (dgvPhieuPhuTroi.Columns["SoPhieu"] != null)
                dgvPhieuPhuTroi.Columns["SoPhieu"].HeaderText =
                    "Số phiếu";

            if (dgvPhieuPhuTroi.Columns["NgayPhuTroi"] != null)
            {
                dgvPhieuPhuTroi.Columns["NgayPhuTroi"].HeaderText =
                    "Ngày phụ trội";
                dgvPhieuPhuTroi.Columns["NgayPhuTroi"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvPhieuPhuTroi.Columns["SoGioPhuTroi"] != null)
            {
                dgvPhieuPhuTroi.Columns["SoGioPhuTroi"].HeaderText =
                    "Số giờ phụ trội";
                dgvPhieuPhuTroi.Columns["SoGioPhuTroi"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvPhieuPhuTroi.Columns["HinhThucPhuTroi"] != null)
                dgvPhieuPhuTroi.Columns["HinhThucPhuTroi"].HeaderText =
                    "Hình thức";

            if (dgvPhieuPhuTroi.Columns["NguoiLap"] != null)
                dgvPhieuPhuTroi.Columns["NguoiLap"].HeaderText =
                    "Người lập";

            if (dgvPhieuPhuTroi.Columns["GhiChu"] != null)
                dgvPhieuPhuTroi.Columns["GhiChu"].HeaderText =
                    "Ghi chú";
        }

        private void LamMoiNhapLieu()
        {
            txtMaPhieuPhuTroi.Clear();
            txtSoPhieu.Clear();
            txtNguoiLap.Clear();
            txtGhiChu.Clear();

            dtpNgayPhuTroi.Value = DateTime.Today;
            nudSoGioPhuTroi.Value = 1;
            cboHinhThuc.SelectedIndex = 0;

            txtMaPhieuPhuTroi.ReadOnly = false;
            dgvPhieuPhuTroi.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaPhieuPhuTroi.Text,
                    txtSoPhieu.Text,
                    dtpNgayPhuTroi.Value,
                    nudSoGioPhuTroi.Value,
                    cboHinhThuc.Text,
                    txtNguoiLap.Text,
                    txtGhiChu.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm phiếu phụ trội thành công!");
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
                    txtMaPhieuPhuTroi.Text,
                    txtSoPhieu.Text,
                    dtpNgayPhuTroi.Value,
                    nudSoGioPhuTroi.Value,
                    cboHinhThuc.Text,
                    txtNguoiLap.Text,
                    txtGhiChu.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật phiếu phụ trội thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu cần sửa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieuPhuTroi.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phiếu phụ trội này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaPhieuPhuTroi.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa phiếu phụ trội thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu cần xóa.");
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
                dgvPhieuPhuTroi.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvPhieuPhuTroi.ClearSelection();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
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

        private void dgvPhieuPhuTroi_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvPhieuPhuTroi.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaPhieuPhuTroi.Text =
                Convert.ToString(row.Cells["MaPhieuPhuTroi"].Value);

            txtSoPhieu.Text =
                Convert.ToString(row.Cells["SoPhieu"].Value);

            dtpNgayPhuTroi.Value =
                Convert.ToDateTime(row.Cells["NgayPhuTroi"].Value);

            nudSoGioPhuTroi.Value =
                Convert.ToDecimal(row.Cells["SoGioPhuTroi"].Value);

            cboHinhThuc.SelectedItem =
                Convert.ToString(row.Cells["HinhThucPhuTroi"].Value);

            txtNguoiLap.Text =
                Convert.ToString(row.Cells["NguoiLap"].Value);

            txtGhiChu.Text =
                Convert.ToString(row.Cells["GhiChu"].Value);

            txtMaPhieuPhuTroi.ReadOnly = true;
        }

        private void ThongBaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý phiếu phụ trội",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}