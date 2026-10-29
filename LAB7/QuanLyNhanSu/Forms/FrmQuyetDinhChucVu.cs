
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmQuyetDinhChucVu : Form
    {
        private readonly QuyetDinhChucVuService service =
            new QuyetDinhChucVuService();

        private bool dangTaiDuLieu;

        public FrmQuyetDinhChucVu()
        {
            InitializeComponent();
        }

        private void FrmQuyetDinhChucVu_Load(object sender, EventArgs e)
        {
            try
            {
                TaiDanhMuc();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void TaiDanhMuc()
        {
            dangTaiDuLieu = true;

            try
            {
                cboNhanVien.DataSource = service.LayNhanVien();
                cboNhanVien.DisplayMember = "TenNhanVien";
                cboNhanVien.ValueMember = "MaNV";
                cboNhanVien.SelectedIndex = -1;

                cboChucVu.DataSource = service.LayChucVu();
                cboChucVu.DisplayMember = "TenChucVu";
                cboChucVu.ValueMember = "MaChucVu";
                cboChucVu.SelectedIndex = -1;
            }
            finally
            {
                dangTaiDuLieu = false;
            }
        }

        private void TaiDuLieu()
        {
            dgvQuyetDinhChucVu.DataSource = service.LayDanhSach();
            DinhDangBang();
            LamMoiNhapLieu();
        }

        private void DinhDangBang()
        {
            if (dgvQuyetDinhChucVu.Columns["MaQDCV"] != null)
                dgvQuyetDinhChucVu.Columns["MaQDCV"].HeaderText =
                    "Mã quyết định";

            if (dgvQuyetDinhChucVu.Columns["SoQuyetDinh"] != null)
                dgvQuyetDinhChucVu.Columns["SoQuyetDinh"].HeaderText =
                    "Số quyết định";

            if (dgvQuyetDinhChucVu.Columns["MaNV"] != null)
                dgvQuyetDinhChucVu.Columns["MaNV"].HeaderText =
                    "Mã nhân viên";

            if (dgvQuyetDinhChucVu.Columns["HoTen"] != null)
                dgvQuyetDinhChucVu.Columns["HoTen"].HeaderText =
                    "Họ tên";

            if (dgvQuyetDinhChucVu.Columns["MaChucVu"] != null)
                dgvQuyetDinhChucVu.Columns["MaChucVu"].Visible = false;

            if (dgvQuyetDinhChucVu.Columns["TenChucVu"] != null)
                dgvQuyetDinhChucVu.Columns["TenChucVu"].HeaderText =
                    "Chức vụ";

            if (dgvQuyetDinhChucVu.Columns["NgayQuyetDinh"] != null)
            {
                dgvQuyetDinhChucVu.Columns["NgayQuyetDinh"].HeaderText =
                    "Ngày quyết định";
                dgvQuyetDinhChucVu.Columns["NgayQuyetDinh"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvQuyetDinhChucVu.Columns["NgayHieuLuc"] != null)
            {
                dgvQuyetDinhChucVu.Columns["NgayHieuLuc"].HeaderText =
                    "Ngày hiệu lực";
                dgvQuyetDinhChucVu.Columns["NgayHieuLuc"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvQuyetDinhChucVu.Columns["PhuCapChucVu"] != null)
            {
                dgvQuyetDinhChucVu.Columns["PhuCapChucVu"].HeaderText =
                    "Phụ cấp chức vụ";
                dgvQuyetDinhChucVu.Columns["PhuCapChucVu"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvQuyetDinhChucVu.Columns["NoiDung"] != null)
                dgvQuyetDinhChucVu.Columns["NoiDung"].HeaderText =
                    "Nội dung";
        }

        private void LamMoiNhapLieu()
        {
            dangTaiDuLieu = true;

            try
            {
                txtMaQDCV.Clear();
                txtSoQuyetDinh.Clear();
                txtPhuCapChucVu.Text = "0";
                txtNoiDung.Clear();

                cboNhanVien.SelectedIndex = -1;
                cboChucVu.SelectedIndex = -1;

                dtpNgayQuyetDinh.Value = DateTime.Today;
                dtpNgayHieuLuc.Value = DateTime.Today;

                txtMaQDCV.ReadOnly = false;
                dgvQuyetDinhChucVu.ClearSelection();
            }
            finally
            {
                dangTaiDuLieu = false;
            }
        }

        private string LayGiaTri(ComboBox combo)
        {
            if (combo.SelectedValue == null ||
                combo.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(combo.SelectedValue);
        }

        private decimal LayPhuCap()
        {
            decimal giaTri;

            if (!decimal.TryParse(
                txtPhuCapChucVu.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out giaTri))
                throw new Exception("Phụ cấp chức vụ phải là số hợp lệ.");

            if (giaTri < 0)
                throw new Exception("Phụ cấp chức vụ không được âm.");

            return giaTri;
        }

        private void cboChucVu_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (dangTaiDuLieu)
                return;

            DataRowView dong = cboChucVu.SelectedItem as DataRowView;

            if (dong != null)
            {
                decimal phuCap =
                    Convert.ToDecimal(dong["PhuCapChucVu"]);

                txtPhuCapChucVu.Text = phuCap.ToString("N0");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ketQua = service.Them(
                    txtMaQDCV.Text,
                    txtSoQuyetDinh.Text,
                    LayGiaTri(cboNhanVien),
                    LayGiaTri(cboChucVu),
                    dtpNgayQuyetDinh.Value,
                    dtpNgayHieuLuc.Value,
                    LayPhuCap(),
                    txtNoiDung.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm quyết định chức vụ thành công!");
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
                    txtMaQDCV.Text,
                    txtSoQuyetDinh.Text,
                    LayGiaTri(cboNhanVien),
                    LayGiaTri(cboChucVu),
                    dtpNgayQuyetDinh.Value,
                    dtpNgayHieuLuc.Value,
                    LayPhuCap(),
                    txtNoiDung.Text);

                if (ketQua > 0)
                {
                    MessageBox.Show("Cập nhật quyết định thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quyết định cần sửa.");
                }
            }
            catch (Exception ex)
            {
                ThongBaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaQDCV.Text))
            {
                MessageBox.Show("Vui lòng chọn quyết định cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa quyết định chức vụ này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int ketQua = service.Xoa(txtMaQDCV.Text);

                if (ketQua > 0)
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
                ThongBaoLoi(ex);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvQuyetDinhChucVu.DataSource =
                    service.TimKiem(txtTimKiem.Text);

                DinhDangBang();
                dgvQuyetDinhChucVu.ClearSelection();
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
                TaiDanhMuc();
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

        private void dgvQuyetDinhChucVu_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvQuyetDinhChucVu.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            dangTaiDuLieu = true;

            try
            {
                txtMaQDCV.Text =
                    Convert.ToString(row.Cells["MaQDCV"].Value);

                txtSoQuyetDinh.Text =
                    Convert.ToString(row.Cells["SoQuyetDinh"].Value);

                cboNhanVien.SelectedValue =
                    Convert.ToString(row.Cells["MaNV"].Value);

                cboChucVu.SelectedValue =
                    Convert.ToString(row.Cells["MaChucVu"].Value);

                dtpNgayQuyetDinh.Value =
                    Convert.ToDateTime(row.Cells["NgayQuyetDinh"].Value);

                dtpNgayHieuLuc.Value =
                    Convert.ToDateTime(row.Cells["NgayHieuLuc"].Value);

                txtPhuCapChucVu.Text =
                    Convert.ToDecimal(row.Cells["PhuCapChucVu"].Value)
                        .ToString("N0");

                txtNoiDung.Text =
                    Convert.ToString(row.Cells["NoiDung"].Value);

                txtMaQDCV.ReadOnly = true;
            }
            finally
            {
                dangTaiDuLieu = false;
            }
        }

        private void ThongBaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi quản lý quyết định chức vụ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void dtpNgayQuyetDinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
