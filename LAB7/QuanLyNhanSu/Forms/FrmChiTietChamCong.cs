
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChiTietChamCong : Form
    {
        private readonly ChamCongService service = new ChamCongService();

        public FrmChiTietChamCong()
        {
            InitializeComponent();
        }

        private void FrmChiTietChamCong_Load(object sender, EventArgs e)
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
            cboBangChamCong.DisplayMember = "TenBang";
            cboBangChamCong.ValueMember = "MaBangChamCong";
            cboBangChamCong.DataSource = service.LayBangChamCong();
            cboBangChamCong.SelectedIndex = -1;

            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.DataSource = service.LayNhanVien();
            cboNhanVien.SelectedIndex = -1;

            cboCaLamViec.DisplayMember = "TenCa";
            cboCaLamViec.ValueMember = "MaCa";
            cboCaLamViec.DataSource = service.LayCaLamViec();
            cboCaLamViec.SelectedIndex = -1;
        }

        private void TaiDuLieu()
        {
            dgvChiTiet.DataSource = service.LayChiTietChamCong();
            DinhDangBang();
            LamMoi();
        }

        private void DinhDangBang()
        {
            if (dgvChiTiet.Columns["MaChiTietChamCong"] != null)
                dgvChiTiet.Columns["MaChiTietChamCong"].HeaderText =
                    "Mã chi tiết";

            if (dgvChiTiet.Columns["MaBangChamCong"] != null)
                dgvChiTiet.Columns["MaBangChamCong"].HeaderText =
                    "Bảng chấm công";

            if (dgvChiTiet.Columns["MaNV"] != null)
                dgvChiTiet.Columns["MaNV"].Visible = false;

            if (dgvChiTiet.Columns["HoTen"] != null)
                dgvChiTiet.Columns["HoTen"].HeaderText = "Nhân viên";

            if (dgvChiTiet.Columns["MaCa"] != null)
                dgvChiTiet.Columns["MaCa"].Visible = false;

            if (dgvChiTiet.Columns["TenCa"] != null)
                dgvChiTiet.Columns["TenCa"].HeaderText = "Ca làm việc";

            if (dgvChiTiet.Columns["NgayChamCong"] != null)
            {
                dgvChiTiet.Columns["NgayChamCong"].HeaderText =
                    "Ngày chấm công";
                dgvChiTiet.Columns["NgayChamCong"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvChiTiet.Columns["GioVao"] != null)
            {
                dgvChiTiet.Columns["GioVao"].HeaderText = "Giờ vào";
                dgvChiTiet.Columns["GioVao"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            if (dgvChiTiet.Columns["GioRa"] != null)
            {
                dgvChiTiet.Columns["GioRa"].HeaderText = "Giờ ra";
                dgvChiTiet.Columns["GioRa"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            if (dgvChiTiet.Columns["SoGioLam"] != null)
            {
                dgvChiTiet.Columns["SoGioLam"].HeaderText = "Số giờ làm";
                dgvChiTiet.Columns["SoGioLam"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvChiTiet.Columns["TrangThai"] != null)
                dgvChiTiet.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void LamMoi()
        {
            txtMaChiTiet.Clear();

            cboBangChamCong.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            cboCaLamViec.SelectedIndex = -1;
            cboTrangThai.SelectedItem = "Có mặt";

            dtpNgayChamCong.Value = DateTime.Today;
            dtpGioVao.Value = DateTime.Today.AddHours(8);
            dtpGioRa.Value = DateTime.Today.AddHours(17);
            dtpGioVao.Checked = false;
            dtpGioRa.Checked = false;

            txtSoGioLam.Text = "0";
            txtMaChiTiet.ReadOnly = false;
            dgvChiTiet.ClearSelection();
        }

        private string LayGiaTri(ComboBox combo)
        {
            if (combo.SelectedValue == null ||
                combo.SelectedValue is DataRowView)
                return null;

            return Convert.ToString(combo.SelectedValue);
        }

        private DateTime? LayGio(DateTimePicker picker)
        {
            return picker.Checked ? (DateTime?)picker.Value : null;
        }

        private decimal TinhSoGio()
        {
            if (cboTrangThai.Text != "Có mặt" ||
                !dtpGioVao.Checked || !dtpGioRa.Checked)
                return 0;

            TimeSpan khoangThoiGian =
                dtpGioRa.Value - dtpGioVao.Value;

            if (khoangThoiGian.TotalMinutes < 0)
                throw new Exception("Giờ ra phải sau giờ vào.");

            decimal soGio = Math.Round(
                (decimal)khoangThoiGian.TotalHours, 2);

            if (soGio > 24)
                throw new Exception("Số giờ làm không được vượt quá 24.");

            return soGio;
        }

        private void CapNhatGio(object sender, EventArgs e)
        {
            if (dtpGioVao == null || dtpGioRa == null ||
                cboTrangThai == null || txtSoGioLam == null)
                return;

            if (cboTrangThai.Text != "Có mặt")
            {
                dtpGioVao.Checked = false;
                dtpGioRa.Checked = false;
                txtSoGioLam.Text = "0";
                return;
            }

            if (!dtpGioVao.Checked || !dtpGioRa.Checked)
            {
                txtSoGioLam.Text = "0";
                return;
            }

            TimeSpan thoiGian = dtpGioRa.Value - dtpGioVao.Value;

            if (thoiGian.TotalMinutes < 0 || thoiGian.TotalHours > 24)
            {
                txtSoGioLam.Text = "Không hợp lệ";
                return;
            }

            txtSoGioLam.Text =
                Math.Round((decimal)thoiGian.TotalHours, 2).ToString("N2");
        }

        private void dtpNgayChamCong_ValueChanged(
            object sender, EventArgs e)
        {
            if (dtpGioVao == null || dtpGioRa == null)
                return;

            DateTime ngay = dtpNgayChamCong.Value.Date;

            dtpGioVao.Value = ngay.AddHours(8);
            dtpGioRa.Value = ngay.AddHours(17);
            dtpGioVao.Checked = false;
            dtpGioRa.Checked = false;
        }

        private void Luu(bool laThem)
        {
            string trangThai = cboTrangThai.Text;
            DateTime? gioVao = trangThai == "Có mặt"
                ? LayGio(dtpGioVao) : null;
            DateTime? gioRa = trangThai == "Có mặt"
                ? LayGio(dtpGioRa) : null;

            decimal soGio = TinhSoGio();

            int ketQua = laThem
                ? service.ThemChiTiet(
                    txtMaChiTiet.Text,
                    LayGiaTri(cboBangChamCong),
                    LayGiaTri(cboNhanVien),
                    dtpNgayChamCong.Value,
                    LayGiaTri(cboCaLamViec),
                    gioVao, gioRa, soGio, trangThai)
                : service.SuaChiTiet(
                    txtMaChiTiet.Text,
                    LayGiaTri(cboBangChamCong),
                    LayGiaTri(cboNhanVien),
                    dtpNgayChamCong.Value,
                    LayGiaTri(cboCaLamViec),
                    gioVao, gioRa, soGio, trangThai);

            if (ketQua > 0)
            {
                MessageBox.Show(
                    laThem ? "Thêm chi tiết chấm công thành công!"
                           : "Cập nhật chi tiết chấm công thành công!");
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi cần sửa.");
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
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa chi tiết chấm công?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (service.XoaChiTiet(txtMaChiTiet.Text) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi.");
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
                Convert.ToString(row.Cells["MaChiTietChamCong"].Value);

            cboBangChamCong.SelectedValue =
                Convert.ToString(row.Cells["MaBangChamCong"].Value);

            cboNhanVien.SelectedValue =
                Convert.ToString(row.Cells["MaNV"].Value);

            cboCaLamViec.SelectedValue =
                Convert.ToString(row.Cells["MaCa"].Value);

            dtpNgayChamCong.Value =
                Convert.ToDateTime(row.Cells["NgayChamCong"].Value);

            cboTrangThai.SelectedItem =
                Convert.ToString(row.Cells["TrangThai"].Value);

            object gioVao = row.Cells["GioVao"].Value;
            object gioRa = row.Cells["GioRa"].Value;

            if (gioVao != null && gioVao != DBNull.Value)
            {
                dtpGioVao.Value = Convert.ToDateTime(gioVao);
                dtpGioVao.Checked = true;
            }
            else
            {
                dtpGioVao.Checked = false;
            }

            if (gioRa != null && gioRa != DBNull.Value)
            {
                dtpGioRa.Value = Convert.ToDateTime(gioRa);
                dtpGioRa.Checked = true;
            }
            else
            {
                dtpGioRa.Checked = false;
            }

            txtSoGioLam.Text =
                Convert.ToDecimal(row.Cells["SoGioLam"].Value)
                    .ToString("N2");

            txtMaChiTiet.ReadOnly = true;
        }

        private void BaoLoi(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Lỗi chi tiết chấm công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
