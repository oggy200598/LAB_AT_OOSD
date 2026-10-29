
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmHoSoBaoHiem : Form
    {
        private readonly BaoHiemService service = new BaoHiemService();

        public FrmHoSoBaoHiem()
        {
            InitializeComponent();
        }

        private void FrmHoSoBaoHiem_Load(object sender, EventArgs e)
        {
            try
            {
                TaiHopDong();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void TaiHopDong()
        {
            cboHopDong.DataSource = service.LayHopDong();
            cboHopDong.DisplayMember = "TenHopDong";
            cboHopDong.ValueMember = "MaHopDong";
            cboHopDong.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvBaoHiem.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvBaoHiem.Columns["MaBaoHiem"] != null)
                dgvBaoHiem.Columns["MaBaoHiem"].HeaderText = "Mã bảo hiểm";

            if (dgvBaoHiem.Columns["MaHopDong"] != null)
                dgvBaoHiem.Columns["MaHopDong"].HeaderText = "Mã hợp đồng";

            if (dgvBaoHiem.Columns["SoHopDong"] != null)
                dgvBaoHiem.Columns["SoHopDong"].HeaderText = "Số hợp đồng";

            if (dgvBaoHiem.Columns["HoTen"] != null)
                dgvBaoHiem.Columns["HoTen"].HeaderText = "Nhân viên";

            if (dgvBaoHiem.Columns["SoBHXH"] != null)
                dgvBaoHiem.Columns["SoBHXH"].HeaderText = "Số BHXH";

            if (dgvBaoHiem.Columns["SoBHYT"] != null)
                dgvBaoHiem.Columns["SoBHYT"].HeaderText = "Số BHYT";

            if (dgvBaoHiem.Columns["NgayThamGia"] != null)
            {
                dgvBaoHiem.Columns["NgayThamGia"].HeaderText =
                    "Ngày tham gia";
                dgvBaoHiem.Columns["NgayThamGia"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvBaoHiem.Columns["MucDongBHXH"] != null)
            {
                dgvBaoHiem.Columns["MucDongBHXH"].HeaderText =
                    "Mức đóng BHXH";
                dgvBaoHiem.Columns["MucDongBHXH"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvBaoHiem.Columns["MucDongBHYT"] != null)
            {
                dgvBaoHiem.Columns["MucDongBHYT"].HeaderText =
                    "Mức đóng BHYT";
                dgvBaoHiem.Columns["MucDongBHYT"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvBaoHiem.Columns["TrangThai"] != null)
                dgvBaoHiem.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void LamMoiNhapLieu()
        {
            txtMaBaoHiem.Clear();
            txtSoBHXH.Clear();
            txtSoBHYT.Clear();

            txtMucDongBHXH.Text = "0";
            txtMucDongBHYT.Text = "0";

            cboHopDong.SelectedIndex = -1;
            cboTrangThai.SelectedItem = "Đang tham gia";

            dtpNgayThamGia.Value = DateTime.Today;

            txtMaBaoHiem.ReadOnly = false;
            dgvBaoHiem.ClearSelection();
            txtMaBaoHiem.Focus();
        }

        private string LayMaHopDong()
        {
            if (cboHopDong.SelectedValue == null ||
                cboHopDong.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(cboHopDong.SelectedValue);
        }

        private string LayTrangThai()
        {
            if (cboTrangThai.SelectedIndex < 0)
                return null;

            return cboTrangThai.SelectedItem.ToString();
        }

        private decimal LaySoTien(TextBox textBox)
        {
            decimal giaTri;

            if (!decimal.TryParse(
                textBox.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out giaTri))
            {
                throw new Exception("Mức đóng bảo hiểm phải là số hợp lệ.");
            }

            if (giaTri < 0)
                throw new Exception("Mức đóng bảo hiểm không được âm.");

            return giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaBaoHiem.Text,
                    LayMaHopDong(),
                    txtSoBHXH.Text,
                    txtSoBHYT.Text,
                    dtpNgayThamGia.Value,
                    LaySoTien(txtMucDongBHXH),
                    LaySoTien(txtMucDongBHYT),
                    LayTrangThai());

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm hồ sơ bảo hiểm thành công!");
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
                    txtMaBaoHiem.Text,
                    LayMaHopDong(),
                    txtSoBHXH.Text,
                    txtSoBHYT.Text,
                    dtpNgayThamGia.Value,
                    LaySoTien(txtMucDongBHXH),
                    LaySoTien(txtMucDongBHYT),
                    LayTrangThai());

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật hồ sơ bảo hiểm thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ cần sửa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBaoHiem.Text))
            {
                MessageBox.Show("Vui lòng chọn hồ sơ cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hồ sơ bảo hiểm này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaBaoHiem.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa hồ sơ bảo hiểm thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ cần xóa.");
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
                dgvBaoHiem.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvBaoHiem.ClearSelection();
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
                TaiHopDong();
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

        private void dgvBaoHiem_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvBaoHiem.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaBaoHiem.Text =
                Convert.ToString(row.Cells["MaBaoHiem"].Value);

            cboHopDong.SelectedValue =
                Convert.ToString(row.Cells["MaHopDong"].Value);

            txtSoBHXH.Text =
                Convert.ToString(row.Cells["SoBHXH"].Value);

            txtSoBHYT.Text =
                Convert.ToString(row.Cells["SoBHYT"].Value);

            dtpNgayThamGia.Value =
                Convert.ToDateTime(row.Cells["NgayThamGia"].Value);

            txtMucDongBHXH.Text =
                Convert.ToDecimal(row.Cells["MucDongBHXH"].Value)
                    .ToString("N0");

            txtMucDongBHYT.Text =
                Convert.ToDecimal(row.Cells["MucDongBHYT"].Value)
                    .ToString("N0");

            cboTrangThai.SelectedItem =
                Convert.ToString(row.Cells["TrangThai"].Value);

            txtMaBaoHiem.ReadOnly = true;
        }

        private void ThongBaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý bảo hiểm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
