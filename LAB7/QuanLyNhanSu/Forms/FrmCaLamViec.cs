
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmCaLamViec : Form
    {
        private readonly CaLamViecService service =
            new CaLamViecService();

        public FrmCaLamViec()
        {
            InitializeComponent();
        }

        private void FrmCaLamViec_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                dgvCaLamViec.DataSource = service.LayDanhSach();
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
            if (dgvCaLamViec.Columns["MaCa"] != null)
                dgvCaLamViec.Columns["MaCa"].HeaderText = "Mã ca";

            if (dgvCaLamViec.Columns["TenCa"] != null)
                dgvCaLamViec.Columns["TenCa"].HeaderText = "Tên ca";

            if (dgvCaLamViec.Columns["GioBatDau"] != null)
            {
                dgvCaLamViec.Columns["GioBatDau"].HeaderText =
                    "Giờ bắt đầu";

                dgvCaLamViec.Columns["GioBatDau"]
                    .DefaultCellStyle.Format = @"hh\:mm";
            }

            if (dgvCaLamViec.Columns["GioKetThuc"] != null)
            {
                dgvCaLamViec.Columns["GioKetThuc"].HeaderText =
                    "Giờ kết thúc";

                dgvCaLamViec.Columns["GioKetThuc"]
                    .DefaultCellStyle.Format = @"hh\:mm";
            }

            if (dgvCaLamViec.Columns["MoTa"] != null)
                dgvCaLamViec.Columns["MoTa"].HeaderText = "Mô tả";
        }

        private void LamMoiNhapLieu()
        {
            txtMaCa.Clear();
            txtTenCa.Clear();
            txtMoTa.Clear();

            dtpGioBatDau.Value = DateTime.Today.AddHours(8);
            dtpGioKetThuc.Value = DateTime.Today.AddHours(17);

            txtMaCa.ReadOnly = false;
            dgvCaLamViec.ClearSelection();
            txtMaCa.Focus();
        }

        private TimeSpan LayGio(DateTimePicker picker)
        {
            DateTime ngayGio = picker.Value;

            return new TimeSpan(
                ngayGio.Hour,
                ngayGio.Minute,
                0);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaCa.Text,
                    txtTenCa.Text,
                    LayGio(dtpGioBatDau),
                    LayGio(dtpGioKetThuc),
                    txtMoTa.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show(
                        "Thêm ca làm việc thành công!",
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
                    txtMaCa.Text,
                    txtTenCa.Text,
                    LayGio(dtpGioBatDau),
                    LayGio(dtpGioKetThuc),
                    txtMoTa.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật ca làm việc thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ca làm việc cần sửa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCa.Text))
            {
                MessageBox.Show("Vui lòng chọn ca làm việc cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa ca làm việc này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaCa.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa ca làm việc thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ca làm việc cần xóa.");
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
                dgvCaLamViec.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvCaLamViec.ClearSelection();
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

        private void dgvCaLamViec_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvCaLamViec.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaCa.Text =
                Convert.ToString(row.Cells["MaCa"].Value);

            txtTenCa.Text =
                Convert.ToString(row.Cells["TenCa"].Value);

            txtMoTa.Text =
                Convert.ToString(row.Cells["MoTa"].Value);

            TimeSpan gioBatDau =
                (TimeSpan)row.Cells["GioBatDau"].Value;

            TimeSpan gioKetThuc =
                (TimeSpan)row.Cells["GioKetThuc"].Value;

            dtpGioBatDau.Value = DateTime.Today.Add(gioBatDau);
            dtpGioKetThuc.Value = DateTime.Today.Add(gioKetThuc);

            txtMaCa.ReadOnly = true;
        }

        private void ThongBaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý ca làm việc",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
