using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object a, EventArgs e) { Tai(); }

        void Tai()
        {
            dgvKhu.DataSource = s.LayKhuVuc();
            dgvNV.DataSource = s.LayNhanVien();
            dgvLoaiTN.DataSource = s.LayLoaiTienNghi();
            dgvDV.DataSource = s.LayDichVu();
            dgvQD.DataSource = s.LayQuyDinhDenBu();

            cboQDLoai.DataSource = s.LayLoaiTienNghi();
            cboQDLoai.DisplayMember = "TenLoaiTN";
            cboQDLoai.ValueMember = "MaLoaiTN";
        }

        void H(bool thanhCong, string msg)
        {
            MessageBox.Show(msg);
            if (thanhCong) Tai();
        }

        private void btnThemKhu_Click(object a, EventArgs e)
        {
            bool ok = s.ThemKhu(txtKhuMa.Text.Trim(), txtKhuTen.Text.Trim(), out string msg);
            H(ok, msg);
        }

        private void btnThemNV_Click(object a, EventArgs e)
        {
            bool ok = s.ThemNhanVien(txtNVMa.Text.Trim(), txtNVTen.Text.Trim(), txtNVVaiTro.Text.Trim(), txtNVSDT.Text.Trim(), out string msg);
            H(ok, msg);
        }

        private void btnThemLoaiTN_Click(object a, EventArgs e)
        {
            bool ok = s.ThemLoaiTN(txtLoaiMa.Text.Trim(), txtLoaiTen.Text.Trim(), out string msg);
            H(ok, msg);
        }

        private void btnThemDV_Click(object a, EventArgs e)
        {
            bool ok = s.ThemDichVu(txtDVMa.Text.Trim(), txtDVTen.Text.Trim(), txtDVDVT.Text.Trim(), numDVGia.Value, out string msg);
            H(ok, msg);
        }

        private void btnThemQD_Click(object a, EventArgs e)
        {
            bool ok = s.ThemQuyDinh(txtQDMa.Text.Trim(), cboQDLoai.SelectedValue == null ? "" : cboQDLoai.SelectedValue.ToString(), txtQDMucDo.Text.Trim(), numQDTien.Value, out string msg);
            H(ok, msg);
        }

        private void btnDong_Click(object a, EventArgs e) { Close(); }

        private void txtQDMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}