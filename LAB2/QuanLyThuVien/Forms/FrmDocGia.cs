using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmDocGia : Form
    {
        private readonly DocGiaService service = new DocGiaService();

        public FrmDocGia()
        {
            InitializeComponent();

            Load += FrmDocGia_Load;
        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            try
            {
                cboPhai.Items.Clear();
                cboPhai.Items.Add("Nam");
                cboPhai.Items.Add("Nữ");

                if (cboPhai.Items.Count > 0)
                    cboPhai.SelectedIndex = 0;

                dtNgaySinh.Value =
                    new DateTime(2000, 1, 1);

                dtNgayCap.Value =
                    DateTime.Today;

                dtHan.Value =
                    DateTime.Today.AddYears(1);

                chkLePhi.Checked = true;

                CauHinhBangDocGia();

                TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể khởi tạo dữ liệu.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CauHinhBangDocGia()
        {
            dgvDocGia.AutoGenerateColumns = false;
            dgvDocGia.ReadOnly = true;
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dgvDocGia.MultiSelect = false;
            dgvDocGia.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDocGia.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvDocGia.Columns.Count >= 7)
            {
                dgvDocGia.Columns[0].DataPropertyName =
                    "MaThe";

                dgvDocGia.Columns[0].HeaderText =
                    "Mã";

                dgvDocGia.Columns[1].DataPropertyName =
                    "Ho";

                dgvDocGia.Columns[1].HeaderText =
                    "Họ";

                dgvDocGia.Columns[2].DataPropertyName =
                    "Ten";

                dgvDocGia.Columns[2].HeaderText =
                    "Tên";

                dgvDocGia.Columns[3].DataPropertyName =
                    "Phai";

                dgvDocGia.Columns[3].HeaderText =
                    "Phái";

                dgvDocGia.Columns[4].DataPropertyName =
                    "SoDienThoai";

                dgvDocGia.Columns[4].HeaderText =
                    "Điện thoại";

                dgvDocGia.Columns[5].DataPropertyName =
                    "Email";

                dgvDocGia.Columns[5].HeaderText =
                    "Email";

                dgvDocGia.Columns[6].DataPropertyName =
                    "HanSuDung";

                dgvDocGia.Columns[6].HeaderText =
                    "Hạn thẻ";

                dgvDocGia.Columns[6]
                    .DefaultCellStyle
                    .Format = "dd/MM/yyyy";
            }

            dgvDocGia.ClearSelection();
            dgvDocGia.CurrentCell = null;
        }

        private void TaiDanhSach()
        {
            try
            {
                DataTable data =
                    service.LayDanhSach();

                dgvDocGia.DataSource = null;

                dgvDocGia.AutoGenerateColumns = false;

                if (dgvDocGia.Columns.Count >= 7)
                {
                    dgvDocGia.Columns[0].DataPropertyName =
                        "MaThe";

                    dgvDocGia.Columns[0].HeaderText =
                        "Mã";

                    dgvDocGia.Columns[1].DataPropertyName =
                        "Ho";

                    dgvDocGia.Columns[1].HeaderText =
                        "Họ";

                    dgvDocGia.Columns[2].DataPropertyName =
                        "Ten";

                    dgvDocGia.Columns[2].HeaderText =
                        "Tên";

                    dgvDocGia.Columns[3].DataPropertyName =
                        "Phai";

                    dgvDocGia.Columns[3].HeaderText =
                        "Phái";

                    dgvDocGia.Columns[4].DataPropertyName =
                        "SoDienThoai";

                    dgvDocGia.Columns[4].HeaderText =
                        "Điện thoại";

                    dgvDocGia.Columns[5].DataPropertyName =
                        "Email";

                    dgvDocGia.Columns[5].HeaderText =
                        "Email";

                    dgvDocGia.Columns[6].DataPropertyName =
                        "HanSuDung";

                    dgvDocGia.Columns[6].HeaderText =
                        "Hạn thẻ";

                    dgvDocGia.Columns[6]
                        .DefaultCellStyle
                        .Format = "dd/MM/yyyy";
                }

                dgvDocGia.DataSource = data;

                dgvDocGia.ClearSelection();
                dgvDocGia.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể đọc dữ liệu độc giả từ SQL Server.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã độc giả.");

                txtMa.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHo.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ.");

                txtHo.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên.");

                txtTen.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(cboPhai.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn phái.");

                cboPhai.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại.");

                txtSDT.Focus();

                return false;
            }

            return true;
        }

        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!KiemTraDuLieu())
                    return;

                service.ThemDocGia(
                    txtMa.Text.Trim(),
                    txtHo.Text.Trim(),
                    txtTen.Text.Trim(),
                    dtNgaySinh.Value.Date,
                    cboPhai.Text.Trim(),
                    txtSDT.Text.Trim(),
                    txtDiaChi.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtAnh.Text.Trim());

                MessageBox.Show(
                    "Thêm độc giả thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDanhSach();

                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm độc giả.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!KiemTraDuLieu())
                    return;

                int result =
                    service.CapNhatDocGia(
                        txtMa.Text.Trim(),
                        txtHo.Text.Trim(),
                        txtTen.Text.Trim(),
                        dtNgaySinh.Value.Date,
                        cboPhai.Text.Trim(),
                        txtSDT.Text.Trim(),
                        txtDiaChi.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtAnh.Text.Trim());

                if (result == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy độc giả cần cập nhật.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "Cập nhật độc giả thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật độc giả.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCapThe_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    MessageBox.Show(
                        "Vui lòng chọn độc giả.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string maDocGia =
                    txtMa.Text.Trim();

                string maThe =
                    "THE" + maDocGia;

                service.CapThe(
                    maThe,
                    maDocGia,
                    dtNgayCap.Value.Date,
                    dtHan.Value.Date,
                    chkLePhi.Checked,
                    "Đang hoạt động");

                MessageBox.Show(
                    "Cấp thẻ độc giả thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cấp thẻ.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGiaHan_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    MessageBox.Show(
                        "Vui lòng chọn độc giả.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                service.GiaHanThe(
                    txtMa.Text.Trim(),
                    dtHan.Value.Date,
                    chkLePhi.Checked,
                    "Đang hoạt động");

                MessageBox.Show(
                    "Gia hạn thẻ thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể gia hạn thẻ.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            LamMoi();

            TaiDanhSach();
        }

        private void LamMoi()
        {
            txtMa.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtAnh.Clear();

            if (cboPhai.Items.Count > 0)
                cboPhai.SelectedIndex = 0;

            dtNgaySinh.Value =
                new DateTime(2000, 1, 1);

            dtNgayCap.Value =
                DateTime.Today;

            dtHan.Value =
                DateTime.Today.AddYears(1);

            chkLePhi.Checked = true;

            dgvDocGia.ClearSelection();
            dgvDocGia.CurrentCell = null;
        }

        private void btnDong_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void dgvDocGia_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            HienThiDocGia(e.RowIndex);
        }

        private void dgvDocGia_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvDocGia.SelectedRows.Count == 0)
                return;

            int rowIndex =
                dgvDocGia.SelectedRows[0].Index;

            HienThiDocGia(rowIndex);
        }

        private void HienThiDocGia(int rowIndex)
        {
            if (rowIndex < 0)
                return;

            if (rowIndex >= dgvDocGia.Rows.Count)
                return;

            DataGridViewRow row =
                dgvDocGia.Rows[rowIndex];

            if (row.DataBoundItem == null)
                return;

            DataRowView data =
                row.DataBoundItem as DataRowView;

            if (data == null)
                return;

            DataRow r = data.Row;

            txtMa.Text =
                LayGiaTri(r, "MaDocGia");

            txtHo.Text =
                LayGiaTri(r, "Ho");

            txtTen.Text =
                LayGiaTri(r, "Ten");

            txtSDT.Text =
                LayGiaTri(r, "SoDienThoai");

            txtDiaChi.Text =
                LayGiaTri(r, "DiaChi");

            txtEmail.Text =
                LayGiaTri(r, "Email");

            txtAnh.Text =
                LayGiaTri(r, "Anh3x4");

            string phai =
                LayGiaTri(r, "Phai");

            if (cboPhai.Items.Contains(phai))
                cboPhai.SelectedItem = phai;

            DateTime ngaySinh;

            if (DateTime.TryParse(
                LayGiaTri(r, "NgaySinh"),
                out ngaySinh))
            {
                if (ngaySinh >= dtNgaySinh.MinDate &&
                    ngaySinh <= dtNgaySinh.MaxDate)
                {
                    dtNgaySinh.Value =
                        ngaySinh;
                }
            }

            try
            {
                DataTable the =
                    service.LayTheTheoDocGia(
                        txtMa.Text.Trim());

                if (the.Rows.Count == 0)
                    return;

                DataRow t =
                    the.Rows[0];

                DateTime ngayCap;

                if (DateTime.TryParse(
                    LayGiaTri(t, "NgayCap"),
                    out ngayCap))
                {
                    if (ngayCap >= dtNgayCap.MinDate &&
                        ngayCap <= dtNgayCap.MaxDate)
                    {
                        dtNgayCap.Value =
                            ngayCap;
                    }
                }

                DateTime han;

                if (DateTime.TryParse(
                    LayGiaTri(t, "HanSuDung"),
                    out han))
                {
                    if (han >= dtHan.MinDate &&
                        han <= dtHan.MaxDate)
                    {
                        dtHan.Value =
                            han;
                    }
                }

                bool daDong;

                if (bool.TryParse(
                    LayGiaTri(t, "DaDongLePhi"),
                    out daDong))
                {
                    chkLePhi.Checked =
                        daDong;
                }
            }
            catch
            {
            }
        }

        private string LayGiaTri(
            DataRow row,
            string columnName)
        {
            if (row == null)
                return "";

            if (!row.Table.Columns.Contains(
                columnName))
                return "";

            if (row[columnName] ==
                DBNull.Value)
                return "";

            return Convert.ToString(
                row[columnName]);
        }
    }
}