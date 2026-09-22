using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmMuonTra : Form
    {
        private readonly MuonTraService service =
            new MuonTraService();

        private ComboBox cboDocGiaTra;
        private TextBox txtNhanVienTra;
        private DateTimePicker dtNgayTra;
        private ComboBox cboTinhTrangTra;
        private NumericUpDown numPhiPhat;
        private Button btnTraSach;
        private DataGridView dgvSachDangMuon;

        public FrmMuonTra()
        {
            InitializeComponent();

            dgvSachKho.ClearSelection();
            dgvSachKho.CurrentCell = null;

            dgvSachChon.ClearSelection();
            dgvSachChon.CurrentCell = null;

            KhoiTaoGiaoDienTraSach();

            Load += FrmMuonTra_Load;
        }

        private void FrmMuonTra_Load(
            object sender,
            EventArgs e)
        {
            dtNgayMuon.Value =
                DateTime.Today;

            dtHenTra.Value =
                DateTime.Today.AddDays(7);

            TaiDuLieu();
            TaiDocGiaTra();
        }

        private void KhoiTaoGiaoDienTraSach()
        {
            tabTraSach.Controls.Clear();

            Label lblDocGiaTra =
                new Label();

            lblDocGiaTra.Text =
                "Độc giả:";

            lblDocGiaTra.Location =
                new Point(25, 20);

            lblDocGiaTra.AutoSize = true;

            cboDocGiaTra =
                new ComboBox();

            cboDocGiaTra.Name =
                "cboDocGiaTra";

            cboDocGiaTra.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboDocGiaTra.Location =
                new Point(90, 16);

            cboDocGiaTra.Size =
                new Size(210, 30);

            cboDocGiaTra.DisplayMember =
                "HienThi";

            cboDocGiaTra.ValueMember =
                "MaDocGia";

            cboDocGiaTra.SelectedIndexChanged +=
                cboDocGiaTra_SelectedIndexChanged;

            Label lblNhanVienTra =
                new Label();

            lblNhanVienTra.Text =
                "Nhân viên:";

            lblNhanVienTra.Location =
                new Point(315, 20);

            lblNhanVienTra.AutoSize = true;

            txtNhanVienTra =
                new TextBox();

            txtNhanVienTra.Name =
                "txtNhanVienTra";

            txtNhanVienTra.Text =
                "NV001";

            txtNhanVienTra.Location =
                new Point(390, 16);

            txtNhanVienTra.Size =
                new Size(100, 30);

            Label lblNgayTra =
                new Label();

            lblNgayTra.Text =
                "Ngày trả:";

            lblNgayTra.Location =
                new Point(505, 20);

            lblNgayTra.AutoSize = true;

            dtNgayTra =
                new DateTimePicker();

            dtNgayTra.Name =
                "dtNgayTra";

            dtNgayTra.Format =
                DateTimePickerFormat.Short;

            dtNgayTra.Value =
                DateTime.Today;

            dtNgayTra.Location =
                new Point(575, 16);

            dtNgayTra.Size =
                new Size(125, 30);

            Label lblTinhTrang =
                new Label();

            lblTinhTrang.Text =
                "Tình trạng:";

            lblTinhTrang.Location =
                new Point(715, 20);

            lblTinhTrang.AutoSize = true;

            cboTinhTrangTra =
                new ComboBox();

            cboTinhTrangTra.Name =
                "cboTinhTrangTra";

            cboTinhTrangTra.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboTinhTrangTra.Items.Add(
                "Bình thường");

            cboTinhTrangTra.Items.Add(
                "Rách/Hư hỏng");

            cboTinhTrangTra.Items.Add(
                "Mất");

            cboTinhTrangTra.SelectedIndex = 0;

            cboTinhTrangTra.Location =
                new Point(790, 16);

            cboTinhTrangTra.Size =
                new Size(150, 30);

            cboTinhTrangTra.SelectedIndexChanged +=
                cboTinhTrangTra_SelectedIndexChanged;

            Label lblPhiPhat =
                new Label();

            lblPhiPhat.Text =
                "Phí phạt:";

            lblPhiPhat.Location =
                new Point(955, 20);

            lblPhiPhat.AutoSize = true;

            numPhiPhat =
                new NumericUpDown();

            numPhiPhat.Name =
                "numPhiPhat";

            numPhiPhat.Minimum =
                0;

            numPhiPhat.Maximum =
                1000000000;

            numPhiPhat.Increment =
                10000;

            numPhiPhat.DecimalPlaces =
                0;

            numPhiPhat.ThousandsSeparator =
                true;

            numPhiPhat.Location =
                new Point(1020, 16);

            numPhiPhat.Size =
                new Size(130, 30);

            btnTraSach =
                new Button();

            btnTraSach.Name =
                "btnTraSach";

            btnTraSach.Text =
                "Trả sách";

            btnTraSach.Location =
                new Point(1030, 55);

            btnTraSach.Size =
                new Size(120, 35);

            btnTraSach.Click +=
                btnTraSach_Click;

            dgvSachDangMuon =
                new DataGridView();

            dgvSachDangMuon.Name =
                "dgvSachDangMuon";

            dgvSachDangMuon.Location =
                new Point(25, 105);

            dgvSachDangMuon.Size =
                new Size(1125, 390);

            dgvSachDangMuon.ReadOnly = true;

            dgvSachDangMuon.AllowUserToAddRows =
                false;

            dgvSachDangMuon.AllowUserToDeleteRows =
                false;

            dgvSachDangMuon.AllowUserToResizeRows =
                false;

            dgvSachDangMuon.AutoGenerateColumns =
                false;

            dgvSachDangMuon.MultiSelect =
                false;

            dgvSachDangMuon.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSachDangMuon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvSachDangMuon.BackgroundColor =
                Color.White;

            dgvSachDangMuon.GridColor =
                Color.LightGray;

            dgvSachDangMuon.DefaultCellStyle.BackColor =
                Color.White;

            dgvSachDangMuon.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvSachDangMuon.DefaultCellStyle.SelectionBackColor =
                Color.White;

            dgvSachDangMuon.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.BackColor =
                Color.White;

            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.Black;

            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.White;

            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvSachDangMuon.EnableHeadersVisualStyles =
                false;

            dgvSachDangMuon.RowHeadersVisible =
                false;

            ThemCotTra(
                "MaChiTiet",
                "Mã chi tiết");

            ThemCotTra(
                "MaPhieuMuon",
                "Mã phiếu");

            ThemCotTra(
                "MaDocGia",
                "Mã độc giả");

            ThemCotTra(
                "TenDocGia",
                "Độc giả");

            ThemCotTra(
                "MaDauSach",
                "Mã sách");

            ThemCotTra(
                "TenSach",
                "Tên sách");

            ThemCotTra(
                "NgayMuon",
                "Ngày mượn");

            ThemCotTra(
                "NgayHenTra",
                "Hẹn trả");

            tabTraSach.Controls.Add(
                lblDocGiaTra);

            tabTraSach.Controls.Add(
                cboDocGiaTra);

            tabTraSach.Controls.Add(
                lblNhanVienTra);

            tabTraSach.Controls.Add(
                txtNhanVienTra);

            tabTraSach.Controls.Add(
                lblNgayTra);

            tabTraSach.Controls.Add(
                dtNgayTra);

            tabTraSach.Controls.Add(
                lblTinhTrang);

            tabTraSach.Controls.Add(
                cboTinhTrangTra);

            tabTraSach.Controls.Add(
                lblPhiPhat);

            tabTraSach.Controls.Add(
                numPhiPhat);

            tabTraSach.Controls.Add(
                btnTraSach);

            tabTraSach.Controls.Add(
                dgvSachDangMuon);
        }

        private void ThemCotTra(
            string dataPropertyName,
            string headerText)
        {
            DataGridViewTextBoxColumn col =
                new DataGridViewTextBoxColumn();

            col.DataPropertyName =
                dataPropertyName;

            col.HeaderText =
                headerText;

            col.ReadOnly = true;

            dgvSachDangMuon.Columns.Add(col);
        }

        private void TaiDuLieu()
        {
            try
            {
                TaiSachKho();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể đọc dữ liệu.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TaiDocGiaTra()
        {
            try
            {
                DataTable data =
                    service.LayDocGiaDangMuon();

                DataTable source =
                    new DataTable();

                source.Columns.Add(
                    "MaDocGia");

                source.Columns.Add(
                    "HienThi");

                foreach (DataRow row
                    in data.Rows)
                {
                    DataRow newRow =
                        source.NewRow();

                    newRow["MaDocGia"] =
                        row["MaDocGia"];

                    newRow["HienThi"] =
                        row["MaDocGia"] +
                        " - " +
                        row["TenDocGia"];

                    source.Rows.Add(newRow);
                }

                cboDocGiaTra.DataSource =
                    source;

                cboDocGiaTra.DisplayMember =
                    "HienThi";

                cboDocGiaTra.ValueMember =
                    "MaDocGia";

                if (source.Rows.Count > 0)
                    cboDocGiaTra.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải độc giả đang mượn.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string LayMaDocGiaTra()
        {
            if (cboDocGiaTra.SelectedValue == null)
                return "";

            return Convert.ToString(
                cboDocGiaTra.SelectedValue);
        }

        private void TaiSachKho()
        {
            DataTable data =
                service.LaySachKho();

            dgvSachKho.AutoGenerateColumns =
                false;

            if (dgvSachKho.Columns.Count >= 4)
            {
                dgvSachKho.Columns[0]
                    .DataPropertyName =
                    "MaDauSach";

                dgvSachKho.Columns[1]
                    .DataPropertyName =
                    "TenSach";

                dgvSachKho.Columns[2]
                    .DataPropertyName =
                    "NamXuatBan";

                dgvSachKho.Columns[3]
                    .DataPropertyName =
                    "SoLuongHienCo";
            }

            dgvSachKho.DataSource =
                data;

            dgvSachKho.ClearSelection();
            dgvSachKho.CurrentCell = null;
        }

        private void TaiSachDangMuon()
        {
            try
            {
                string maDocGia =
                    LayMaDocGiaTra();

                if (string.IsNullOrWhiteSpace(maDocGia))
                {
                    dgvSachDangMuon.DataSource =
                        null;

                    return;
                }

                DataTable data =
                    service.LaySachDangMuon(
                        maDocGia);

                dgvSachDangMuon.DataSource =
                    null;

                dgvSachDangMuon.DataSource =
                    data;

                dgvSachDangMuon.ClearSelection();
                dgvSachDangMuon.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải sách đang mượn.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cboDocGiaTra_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (dgvSachDangMuon == null)
                return;

            TaiSachDangMuon();
        }

        private void cboTinhTrangTra_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (numPhiPhat == null)
                return;

            if (cboTinhTrangTra.Text ==
                "Bình thường")
            {
                numPhiPhat.Value = 0;
            }
        }

        private void btnKiemTra_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string maDocGia =
                    txtDocGia.Text
                        .Trim()
                        .Split('-')[0]
                        .Trim();

                string maNhanVien =
                    txtNhanVien.Text.Trim();

                if (string.IsNullOrWhiteSpace(
                    maDocGia))
                {
                    MessageBox.Show(
                        "Vui lòng nhập mã độc giả.");

                    txtDocGia.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    maNhanVien))
                {
                    MessageBox.Show(
                        "Vui lòng nhập mã nhân viên.");

                    txtNhanVien.Focus();
                    return;
                }

                DataTable docGia =
                    service.KiemTraDocGia(
                        maDocGia);

                if (docGia.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Độc giả không tồn tại.",
                        "Kiểm tra",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!service.KiemTraNhanVien(
                    maNhanVien))
                {
                    MessageBox.Show(
                        "Nhân viên không tồn tại.",
                        "Kiểm tra",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool hopLe = false;

                foreach (DataRow row
                    in docGia.Rows)
                {
                    if (row["MaThe"] ==
                        DBNull.Value)
                        continue;

                    DateTime hanSuDung =
                        Convert.ToDateTime(
                            row["HanSuDung"]);

                    bool daDongLePhi =
                        Convert.ToBoolean(
                            row["DaDongLePhi"]);

                    string trangThai =
                        Convert.ToString(
                            row["TrangThai"]);

                    if (hanSuDung.Date >=
                            dtNgayMuon.Value.Date &&
                        daDongLePhi &&
                        trangThai ==
                            "Đang hoạt động")
                    {
                        hopLe = true;
                        break;
                    }
                }

                if (!hopLe)
                {
                    MessageBox.Show(
                        "Thẻ độc giả không hợp lệ.\n\n" +
                        "Kiểm tra hạn sử dụng, lệ phí và trạng thái thẻ.",
                        "Không thể mượn",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "Độc giả và nhân viên hợp lệ. Có thể chọn sách.",
                    "Kiểm tra",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể kiểm tra.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            if (dgvSachKho.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sách trong kho.");

                return;
            }

            if (dgvSachChon.Rows.Count >= 3)
            {
                MessageBox.Show(
                    "Một độc giả chỉ được mượn tối đa 3 sách.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvSachKho.CurrentRow;

            string maSach =
                Convert.ToString(
                    row.Cells[0].Value);

            string tenSach =
                Convert.ToString(
                    row.Cells[1].Value);

            if (string.IsNullOrWhiteSpace(
                maSach))
                return;

            foreach (DataGridViewRow selectedRow
                in dgvSachChon.Rows)
            {
                if (Convert.ToString(
                    selectedRow.Cells[0].Value)
                    == maSach)
                {
                    MessageBox.Show(
                        "Sách này đã được chọn.");

                    return;
                }
            }

            int index =
                dgvSachChon.Rows.Add();

            dgvSachChon.Rows[index]
                .Cells[0]
                .Value = maSach;

            dgvSachChon.Rows[index]
                .Cells[1]
                .Value = tenSach;

            dgvSachChon.ClearSelection();
            dgvSachChon.CurrentCell = null;
        }

        private void btnBo_Click(
            object sender,
            EventArgs e)
        {
            if (dgvSachChon.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sách cần bỏ.");

                return;
            }

            if (dgvSachChon.CurrentRow.IsNewRow)
                return;

            dgvSachChon.Rows.RemoveAt(
                dgvSachChon.CurrentRow.Index);

            dgvSachChon.ClearSelection();
            dgvSachChon.CurrentCell = null;
        }

        private void btnLapPhieu_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string maDocGia =
                    txtDocGia.Text
                        .Trim()
                        .Split('-')[0]
                        .Trim();

                string maNhanVien =
                    txtNhanVien.Text.Trim();

                if (dgvSachChon.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Chưa chọn sách để mượn.");

                    return;
                }

                List<string> danhSachSach =
                    new List<string>();

                foreach (DataGridViewRow row
                    in dgvSachChon.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string maSach =
                        Convert.ToString(
                            row.Cells[0].Value);

                    if (!string.IsNullOrWhiteSpace(
                        maSach))
                    {
                        danhSachSach.Add(maSach);
                    }
                }

                string maPhieu =
                    service.LapPhieuMuon(
                        maDocGia,
                        maNhanVien,
                        dtNgayMuon.Value.Date,
                        dtHenTra.Value.Date,
                        danhSachSach);

                MessageBox.Show(
                    "Lập phiếu mượn thành công.\n\n" +
                    "Mã phiếu: " +
                    maPhieu,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvSachChon.Rows.Clear();

                TaiSachKho();
                TaiDocGiaTra();
                TaiSachDangMuon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lập phiếu mượn.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTraSach_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvSachDangMuon.CurrentRow ==
                    null)
                {
                    MessageBox.Show(
                        "Vui lòng chọn sách cần trả.");

                    return;
                }

                string maChiTiet =
                    Convert.ToString(
                        dgvSachDangMuon
                            .CurrentRow
                            .Cells[0]
                            .Value);

                string tenSach =
                    Convert.ToString(
                        dgvSachDangMuon
                            .CurrentRow
                            .Cells[5]
                            .Value);

                string maNhanVien =
                    txtNhanVienTra.Text.Trim();

                decimal phiPhat =
                    numPhiPhat.Value;

                string tinhTrang =
                    cboTinhTrangTra.Text;

                if (string.IsNullOrWhiteSpace(
                    maNhanVien))
                {
                    MessageBox.Show(
                        "Vui lòng nhập nhân viên nhận trả.");

                    txtNhanVienTra.Focus();
                    return;
                }

                if (!service.KiemTraNhanVien(
                    maNhanVien))
                {
                    MessageBox.Show(
                        "Nhân viên nhận trả không tồn tại.");

                    return;
                }

                DialogResult confirm =
                    MessageBox.Show(
                        "Xác nhận trả sách:\n\n" +
                        "Sách: " +
                        tenSach +
                        "\nTình trạng: " +
                        tinhTrang +
                        "\nPhí phạt: " +
                        phiPhat.ToString("N0") +
                        " đ",
                        "Xác nhận trả sách",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirm !=
                    DialogResult.Yes)
                    return;

                KetQuaXuLy ketQua =
                    service.TraSach(
                        maChiTiet,
                        maNhanVien,
                        dtNgayTra.Value.Date,
                        tinhTrang,
                        phiPhat);

                if (!ketQua.ThanhCong)
                {
                    MessageBox.Show(
                        ketQua.ThongBao,
                        "Không thể trả sách",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    ketQua.ThongBao,
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiSachDangMuon();
                TaiSachKho();
                TaiDocGiaTra();

                numPhiPhat.Value = 0;
                cboTinhTrangTra.SelectedIndex = 0;
                dtNgayTra.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể trả sách.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvSachKho_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dgvSachKho.ClearSelection();

            dgvSachKho.Rows[e.RowIndex]
                .Selected = true;

            dgvSachKho.CurrentCell =
                dgvSachKho.Rows[e.RowIndex]
                    .Cells[0];
        }

        private void dgvSachChon_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dgvSachChon.ClearSelection();

            dgvSachChon.Rows[e.RowIndex]
                .Selected = true;

            dgvSachChon.CurrentCell =
                dgvSachChon.Rows[e.RowIndex]
                    .Cells[0];
        }

        private void tabMuonTra_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (tabMuonTra.SelectedTab ==
                tabTraSach)
            {
                TaiDocGiaTra();
                TaiSachDangMuon();
            }
            else if (
                tabMuonTra.SelectedTab ==
                tabMuonSach)
            {
                TaiSachKho();
            }
        }
    }
}