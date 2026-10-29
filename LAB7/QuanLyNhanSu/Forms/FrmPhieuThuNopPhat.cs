using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmPhieuThuNopPhat : Form
    {
        private readonly PhieuThuNopPhatService service =
            new PhieuThuNopPhatService();

        public FrmPhieuThuNopPhat()
        {
            InitializeComponent();
        }

        private void FrmPhieuThuNopPhat_Load(object sender, EventArgs e)
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
            cboQuyetDinh.ValueMember = "MaQDKL";
            cboQuyetDinh.DataSource = service.LayQuyetDinh();
            cboQuyetDinh.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvPhieuThu.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvPhieuThu.Columns["MaPhieuThu"] != null)
                dgvPhieuThu.Columns["MaPhieuThu"].HeaderText =
                    "Mã phiếu thu";

            if (dgvPhieuThu.Columns["MaQDKL"] != null)
                dgvPhieuThu.Columns["MaQDKL"].HeaderText =
                    "Mã quyết định";

            if (dgvPhieuThu.Columns["SoQuyetDinh"] != null)
                dgvPhieuThu.Columns["SoQuyetDinh"].HeaderText =
                    "Số quyết định";

            if (dgvPhieuThu.Columns["SoTienPhat"] != null)
            {
                dgvPhieuThu.Columns["SoTienPhat"].HeaderText =
                    "Số tiền phạt";
                dgvPhieuThu.Columns["SoTienPhat"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvPhieuThu.Columns["NgayThu"] != null)
            {
                dgvPhieuThu.Columns["NgayThu"].HeaderText =
                    "Ngày thu";
                dgvPhieuThu.Columns["NgayThu"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvPhieuThu.Columns["SoTienThu"] != null)
            {
                dgvPhieuThu.Columns["SoTienThu"].HeaderText =
                    "Số tiền thu";
                dgvPhieuThu.Columns["SoTienThu"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvPhieuThu.Columns["NguoiLap"] != null)
                dgvPhieuThu.Columns["NguoiLap"].HeaderText =
                    "Người lập";

            if (dgvPhieuThu.Columns["HinhThucThu"] != null)
                dgvPhieuThu.Columns["HinhThucThu"].HeaderText =
                    "Hình thức thu";

            if (dgvPhieuThu.Columns["GhiChu"] != null)
                dgvPhieuThu.Columns["GhiChu"].HeaderText =
                    "Ghi chú";
        }

        private void LamMoiNhapLieu()
        {
            txtMaPhieuThu.Clear();
            txtNguoiLap.Clear();
            txtGhiChu.Clear();

            cboQuyetDinh.SelectedIndex = -1;
            cboHinhThucThu.SelectedItem = "Tiền mặt";

            dtpNgayThu.Value = DateTime.Today;
            nudSoTienThu.Value = 0;


            txtMaPhieuThu.ReadOnly = false;
            dgvPhieuThu.ClearSelection();
            txtMaPhieuThu.Focus();
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
            string maQDKL = LayMaQuyetDinh();

            if (string.IsNullOrWhiteSpace(maQDKL))
            {

            }


        }

        private void Luu(bool laThem)
        {
            int ketQua = laThem
                ? service.Them(
                    txtMaPhieuThu.Text,
                    LayMaQuyetDinh(),
                    dtpNgayThu.Value,
                    nudSoTienThu.Value,
                    txtNguoiLap.Text,
                    cboHinhThucThu.Text,
                    txtGhiChu.Text)
                : service.Sua(
                    txtMaPhieuThu.Text,
                    LayMaQuyetDinh(),
                    dtpNgayThu.Value,
                    nudSoTienThu.Value,
                    txtNguoiLap.Text,
                    cboHinhThucThu.Text,
                    txtGhiChu.Text);

            if (ketQua > 0)
            {
                MessageBox.Show(
                    laThem
                        ? "Thêm phiếu thu nộp phạt thành công!"
                        : "Cập nhật phiếu thu nộp phạt thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu thu cần sửa.");
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
            if (string.IsNullOrWhiteSpace(txtMaPhieuThu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu thu cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phiếu thu này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaPhieuThu.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa phiếu thu thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu thu cần xóa.");
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
                dgvPhieuThu.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvPhieuThu.ClearSelection();
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

        private void dgvPhieuThu_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPhieuThu.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaPhieuThu.Text =
                Convert.ToString(row.Cells["MaPhieuThu"].Value);

            cboQuyetDinh.SelectedValue =
                Convert.ToString(row.Cells["MaQDKL"].Value);

            dtpNgayThu.Value =
                Convert.ToDateTime(row.Cells["NgayThu"].Value);

            nudSoTienThu.Value =
                Convert.ToDecimal(row.Cells["SoTienThu"].Value);

            txtNguoiLap.Text =
                Convert.ToString(row.Cells["NguoiLap"].Value);

            cboHinhThucThu.SelectedItem =
                Convert.ToString(row.Cells["HinhThucThu"].Value);

            txtGhiChu.Text =
                Convert.ToString(row.Cells["GhiChu"].Value);

            txtMaPhieuThu.ReadOnly = true;
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý phiếu thu nộp phạt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}