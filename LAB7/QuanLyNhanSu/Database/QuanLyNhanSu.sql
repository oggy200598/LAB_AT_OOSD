
-- ============================================================
-- LAB 7: HE THONG QUAN LY NHAN SU
-- DATABASE: QUANLYNHANSU
-- SQL SERVER - 21 BANG
-- ============================================================

-- 1. TAO DATABASE

IF DB_ID(N'QuanLyNhanSu') IS NULL
BEGIN
    CREATE DATABASE QuanLyNhanSu;
END;
GO

USE QuanLyNhanSu;
GO

-- ============================================================
-- 2. TAO CAC BANG
-- ============================================================

-- ------------------------------------------------------------
-- BANG 1: PHONGBAN
-- ------------------------------------------------------------

CREATE TABLE PhongBan (
    MaPhongBan VARCHAR(20) NOT NULL,
    TenPhongBan NVARCHAR(100) NOT NULL,
    DiaDiem NVARCHAR(200) NULL,
    SoDienThoai VARCHAR(15) NULL,
    MoTa NVARCHAR(500) NULL,

    CONSTRAINT PK_PhongBan
        PRIMARY KEY (MaPhongBan),

    CONSTRAINT UQ_PhongBan_Ten
        UNIQUE (TenPhongBan)
);
GO

-- ------------------------------------------------------------
-- BANG 2: NHANVIEN
-- ------------------------------------------------------------

CREATE TABLE NhanVien (
    MaNV VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NULL,
    DiaChi NVARCHAR(255) NULL,
    SoDienThoai VARCHAR(15) NULL,
    Email VARCHAR(100) NULL,
    NgayVaoLam DATE NULL,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Thử việc',
    MaPhongBan VARCHAR(20) NOT NULL,

    CONSTRAINT PK_NhanVien
        PRIMARY KEY (MaNV),

    CONSTRAINT FK_NhanVien_PhongBan
        FOREIGN KEY (MaPhongBan)
        REFERENCES PhongBan(MaPhongBan),

    CONSTRAINT CK_NhanVien_GioiTinh
        CHECK (
            GioiTinh IS NULL
            OR GioiTinh IN (
                N'Nam', N'Nữ', N'Khác'
            )
        ),

    CONSTRAINT CK_NhanVien_TrangThai
        CHECK (
            TrangThai IN (
                N'Thử việc',
                N'Chính thức',
                N'Nghỉ việc'
            )
        )
);
GO

CREATE UNIQUE INDEX UQ_NhanVien_Email
ON NhanVien(Email)
WHERE Email IS NOT NULL;
GO

-- ------------------------------------------------------------
-- BANG 3: CHUCVU
-- ------------------------------------------------------------

CREATE TABLE ChucVu (
    MaChucVu VARCHAR(20) NOT NULL,
    TenChucVu NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(500) NULL,
    PhuCapChucVu DECIMAL(18,2) NOT NULL
        DEFAULT 0,

    CONSTRAINT PK_ChucVu
        PRIMARY KEY (MaChucVu),

    CONSTRAINT UQ_ChucVu_Ten
        UNIQUE (TenChucVu),

    CONSTRAINT CK_ChucVu_PhuCap
        CHECK (PhuCapChucVu >= 0)
);
GO

-- ------------------------------------------------------------
-- BANG 4: QUYETDINHTUYENDUNG
-- ------------------------------------------------------------

CREATE TABLE QuyetDinhTuyenDung (
    MaQDTD VARCHAR(20) NOT NULL,
    SoQuyetDinh VARCHAR(30) NOT NULL,
    NgayQuyetDinh DATE NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    MaPhongBan VARCHAR(20) NOT NULL,
    NgayBatDauThuViec DATE NOT NULL,
    NgayKetThucThuViec DATE NOT NULL,
    LuongThuViec DECIMAL(18,2) NOT NULL,
    NoiDung NVARCHAR(MAX) NULL,
    DieuKhoan NVARCHAR(MAX) NULL,

    CONSTRAINT PK_QuyetDinhTuyenDung
        PRIMARY KEY (MaQDTD),

    CONSTRAINT UQ_QDTD_SoQuyetDinh
        UNIQUE (SoQuyetDinh),

    CONSTRAINT FK_QDTD_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT FK_QDTD_PhongBan
        FOREIGN KEY (MaPhongBan)
        REFERENCES PhongBan(MaPhongBan),

    CONSTRAINT CK_QDTD_ThoiGian
        CHECK (
            NgayKetThucThuViec >= NgayBatDauThuViec
        ),

    CONSTRAINT CK_QDTD_Luong
        CHECK (LuongThuViec >= 0)
);
GO

-- ------------------------------------------------------------
-- BANG 5: HOPDONGLAODONG
-- ------------------------------------------------------------

CREATE TABLE HopDongLaoDong (
    MaHopDong VARCHAR(20) NOT NULL,
    SoHopDong VARCHAR(30) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    LoaiHopDong NVARCHAR(20) NOT NULL,
    NgayKy DATE NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NULL,
    NoiDungHopDong NVARCHAR(MAX) NULL,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Có hiệu lực',

    CONSTRAINT PK_HopDongLaoDong
        PRIMARY KEY (MaHopDong),

    CONSTRAINT UQ_HopDong_SoHopDong
        UNIQUE (SoHopDong),

    CONSTRAINT FK_HopDong_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT CK_HopDong_Loai
        CHECK (
            LoaiHopDong IN (
                N'Dài hạn',
                N'Ngắn hạn'
            )
        ),

    CONSTRAINT CK_HopDong_ThoiHan
        CHECK (
            NgayKetThuc IS NULL
            OR NgayKetThuc >= NgayBatDau
        ),

    CONSTRAINT CK_HopDong_TrangThai
        CHECK (
            TrangThai IN (
                N'Có hiệu lực',
                N'Hết hiệu lực',
                N'Chấm dứt'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 6: HOSOBAOHIEM
-- ------------------------------------------------------------

CREATE TABLE HoSoBaoHiem (
    MaBaoHiem VARCHAR(20) NOT NULL,
    MaHopDong VARCHAR(20) NOT NULL,
    SoBHXH VARCHAR(30) NOT NULL,
    SoBHYT VARCHAR(30) NOT NULL,
    NgayThamGia DATE NOT NULL,
    MucDongBHXH DECIMAL(18,2) NOT NULL,
    MucDongBHYT DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Đang tham gia',

    CONSTRAINT PK_HoSoBaoHiem
        PRIMARY KEY (MaBaoHiem),

    CONSTRAINT UQ_BaoHiem_HopDong
        UNIQUE (MaHopDong),

    CONSTRAINT FK_BaoHiem_HopDong
        FOREIGN KEY (MaHopDong)
        REFERENCES HopDongLaoDong(MaHopDong),

    CONSTRAINT CK_BaoHiem_MucDong
        CHECK (
            MucDongBHXH >= 0
            AND MucDongBHYT >= 0
        ),

    CONSTRAINT CK_BaoHiem_TrangThai
        CHECK (
            TrangThai IN (
                N'Đang tham gia',
                N'Ngừng tham gia'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 7: QUYETDINHLUONG
-- ------------------------------------------------------------

CREATE TABLE QuyetDinhLuong (
    MaQDL VARCHAR(20) NOT NULL,
    SoQuyetDinh VARCHAR(30) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    NgayQuyetDinh DATE NOT NULL,
    NgayHieuLuc DATE NOT NULL,
    LuongCoBan DECIMAL(18,2) NOT NULL,
    PhuCapLuong DECIMAL(18,2) NOT NULL DEFAULT 0,
    PhuCapDocHai DECIMAL(18,2) NOT NULL DEFAULT 0,
    NoiDung NVARCHAR(MAX) NULL,

    CONSTRAINT PK_QuyetDinhLuong
        PRIMARY KEY (MaQDL),

    CONSTRAINT UQ_QDL_SoQuyetDinh
        UNIQUE (SoQuyetDinh),

    CONSTRAINT FK_QDL_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT CK_QDL_Tien
        CHECK (
            LuongCoBan > 0
            AND PhuCapLuong >= 0
            AND PhuCapDocHai >= 0
        )
);
GO

-- ------------------------------------------------------------
-- BANG 8: QUYETDINHCHUCVU
-- ------------------------------------------------------------

CREATE TABLE QuyetDinhChucVu (
    MaQDCV VARCHAR(20) NOT NULL,
    SoQuyetDinh VARCHAR(30) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    MaChucVu VARCHAR(20) NOT NULL,
    NgayQuyetDinh DATE NOT NULL,
    NgayHieuLuc DATE NOT NULL,
    PhuCapChucVu DECIMAL(18,2) NOT NULL DEFAULT 0,
    NoiDung NVARCHAR(MAX) NULL,

    CONSTRAINT PK_QuyetDinhChucVu
        PRIMARY KEY (MaQDCV),

    CONSTRAINT UQ_QDCV_SoQuyetDinh
        UNIQUE (SoQuyetDinh),

    CONSTRAINT FK_QDCV_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT FK_QDCV_ChucVu
        FOREIGN KEY (MaChucVu)
        REFERENCES ChucVu(MaChucVu),

    CONSTRAINT CK_QDCV_PhuCap
        CHECK (PhuCapChucVu >= 0)
);
GO

-- ------------------------------------------------------------
-- BANG 9: KEHOACHTUAN
-- ------------------------------------------------------------

CREATE TABLE KeHoachTuan (
    MaKeHoach VARCHAR(20) NOT NULL,
    MaPhongBan VARCHAR(20) NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    NguoiLap NVARCHAR(100) NOT NULL,
    NgayLap DATE NOT NULL,
    NoiDung NVARCHAR(MAX) NULL,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Đã lập',

    CONSTRAINT PK_KeHoachTuan
        PRIMARY KEY (MaKeHoach),

    CONSTRAINT FK_KeHoach_PhongBan
        FOREIGN KEY (MaPhongBan)
        REFERENCES PhongBan(MaPhongBan),

    CONSTRAINT UQ_KeHoach_PhongBan_Tuan
        UNIQUE (MaPhongBan, NgayBatDau),

    CONSTRAINT CK_KeHoach_ThoiGian
        CHECK (
            NgayKetThuc = DATEADD(
                DAY, 6, NgayBatDau
            )
        ),

    CONSTRAINT CK_KeHoach_TrangThai
        CHECK (
            TrangThai IN (
                N'Đã lập',
                N'Đang thực hiện',
                N'Hoàn thành',
                N'Hủy'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 10: CALAMVIEC
-- ------------------------------------------------------------

CREATE TABLE CaLamViec (
    MaCa VARCHAR(20) NOT NULL,
    TenCa NVARCHAR(100) NOT NULL,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    MoTa NVARCHAR(500) NULL,

    CONSTRAINT PK_CaLamViec
        PRIMARY KEY (MaCa),

    CONSTRAINT UQ_CaLamViec_Ten
        UNIQUE (TenCa),

    CONSTRAINT CK_CaLamViec_ThoiGian
        CHECK (GioBatDau <> GioKetThuc)
);
GO

-- ------------------------------------------------------------
-- BANG 11: CHITIETPHANCONG
-- ------------------------------------------------------------

CREATE TABLE ChiTietPhanCong (
    MaPhanCong VARCHAR(20) NOT NULL,
    MaKeHoach VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    MaCa VARCHAR(20) NOT NULL,
    NgayLamViec DATE NOT NULL,
    NoiDungCongViec NVARCHAR(500) NULL,
    GhiChu NVARCHAR(500) NULL,

    CONSTRAINT PK_ChiTietPhanCong
        PRIMARY KEY (MaPhanCong),

    CONSTRAINT FK_PhanCong_KeHoach
        FOREIGN KEY (MaKeHoach)
        REFERENCES KeHoachTuan(MaKeHoach),

    CONSTRAINT FK_PhanCong_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT FK_PhanCong_CaLamViec
        FOREIGN KEY (MaCa)
        REFERENCES CaLamViec(MaCa),

    CONSTRAINT UQ_PhanCong_NhanVien_Ngay_Ca
        UNIQUE (
            MaNV,
            NgayLamViec,
            MaCa
        )
);
GO

-- ------------------------------------------------------------
-- BANG 12: BANGCHAMCONG
-- ------------------------------------------------------------

CREATE TABLE BangChamCong (
    MaBangChamCong VARCHAR(20) NOT NULL,
    MaPhongBan VARCHAR(20) NOT NULL,
    Thang INT NOT NULL,
    Nam INT NOT NULL,
    NgayLap DATE NOT NULL,
    NguoiLap NVARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Đã lập',

    CONSTRAINT PK_BangChamCong
        PRIMARY KEY (MaBangChamCong),

    CONSTRAINT FK_BangChamCong_PhongBan
        FOREIGN KEY (MaPhongBan)
        REFERENCES PhongBan(MaPhongBan),

    CONSTRAINT UQ_BCC_PhongBan_Thang_Nam
        UNIQUE (
            MaPhongBan,
            Thang,
            Nam
        ),

    CONSTRAINT CK_BCC_Thang
        CHECK (Thang BETWEEN 1 AND 12),

    CONSTRAINT CK_BCC_Nam
        CHECK (Nam BETWEEN 2000 AND 2100),

    CONSTRAINT CK_BCC_TrangThai
        CHECK (
            TrangThai IN (
                N'Đã lập',
                N'Đang chấm công',
                N'Đã tổng hợp'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 13: CHITIETCHAMCONG
-- ------------------------------------------------------------

CREATE TABLE ChiTietChamCong (
    MaChiTietChamCong VARCHAR(20) NOT NULL,
    MaBangChamCong VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    NgayChamCong DATE NOT NULL,
    MaCa VARCHAR(20) NOT NULL,
    GioVao DATETIME2(0) NULL,
    GioRa DATETIME2(0) NULL,
    SoGioLam DECIMAL(8,2) NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Có mặt',

    CONSTRAINT PK_ChiTietChamCong
        PRIMARY KEY (MaChiTietChamCong),

    CONSTRAINT FK_CTCC_BangChamCong
        FOREIGN KEY (MaBangChamCong)
        REFERENCES BangChamCong(MaBangChamCong),

    CONSTRAINT FK_CTCC_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT FK_CTCC_CaLamViec
        FOREIGN KEY (MaCa)
        REFERENCES CaLamViec(MaCa),

    CONSTRAINT UQ_CTCC_NhanVien_Ngay_Ca
        UNIQUE (
            MaNV,
            NgayChamCong,
            MaCa
        ),

    CONSTRAINT CK_CTCC_SoGioLam
        CHECK (
            SoGioLam >= 0
            AND SoGioLam <= 24
        ),

    CONSTRAINT CK_CTCC_Gio
        CHECK (
            GioVao IS NULL
            OR GioRa IS NULL
            OR GioRa >= GioVao
        ),

    CONSTRAINT CK_CTCC_TrangThai
        CHECK (
            TrangThai IN (
                N'Có mặt',
                N'Vắng mặt',
                N'Nghỉ phép',
                N'Nghỉ lễ'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 14: PHIEUPHUTROI
-- ------------------------------------------------------------

CREATE TABLE PhieuPhuTroi (
    MaPhieuPhuTroi VARCHAR(20) NOT NULL,
    SoPhieu VARCHAR(30) NOT NULL,
    NgayPhuTroi DATE NOT NULL,
    SoGioPhuTroi DECIMAL(8,2) NOT NULL,
    HinhThucPhuTroi NVARCHAR(20) NOT NULL,
    NguoiLap NVARCHAR(100) NOT NULL,
    GhiChu NVARCHAR(500) NULL,

    CONSTRAINT PK_PhieuPhuTroi
        PRIMARY KEY (MaPhieuPhuTroi),

    CONSTRAINT UQ_PhieuPhuTroi_SoPhieu
        UNIQUE (SoPhieu),

    CONSTRAINT CK_PhieuPhuTroi_SoGio
        CHECK (
            SoGioPhuTroi > 0
            AND SoGioPhuTroi <= 24
        ),

    CONSTRAINT CK_PhieuPhuTroi_HinhThuc
        CHECK (
            HinhThucPhuTroi IN (
                N'Tăng ca',
                N'Ngày lễ',
                N'Ngày nghỉ'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 15: CHITIETPHUTROI
-- ------------------------------------------------------------

CREATE TABLE ChiTietPhuTroi (
    MaChiTietPhuTroi VARCHAR(20) NOT NULL,
    MaPhieuPhuTroi VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    SoGioThamGia DECIMAL(8,2) NOT NULL,
    HeSoPhuTroi DECIMAL(4,2) NOT NULL DEFAULT 1.50,
    ThanhTien DECIMAL(18,2) NOT NULL DEFAULT 0,

    CONSTRAINT PK_ChiTietPhuTroi
        PRIMARY KEY (MaChiTietPhuTroi),

    CONSTRAINT FK_CTPT_PhieuPhuTroi
        FOREIGN KEY (MaPhieuPhuTroi)
        REFERENCES PhieuPhuTroi(MaPhieuPhuTroi),

    CONSTRAINT FK_CTPT_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT UQ_CTPT_Phieu_NhanVien
        UNIQUE (
            MaPhieuPhuTroi,
            MaNV
        ),

    CONSTRAINT CK_CTPT_SoGio
        CHECK (
            SoGioThamGia > 0
            AND SoGioThamGia <= 24
        ),

    CONSTRAINT CK_CTPT_HeSo
        CHECK (HeSoPhuTroi = 1.50),

    CONSTRAINT CK_CTPT_ThanhTien
        CHECK (ThanhTien >= 0)
);
GO

-- ------------------------------------------------------------
-- BANG 16: QUYETDINHKHENTHUONG
-- ------------------------------------------------------------

CREATE TABLE QuyetDinhKhenThuong (
    MaQDKT VARCHAR(20) NOT NULL,
    SoQuyetDinh VARCHAR(30) NOT NULL,
    NgayQuyetDinh DATE NOT NULL,
    LoaiDoiTuong NVARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NULL,
    MaPhongBan VARCHAR(20) NULL,
    LyDoKhenThuong NVARCHAR(500) NOT NULL,
    SoTienThuong DECIMAL(18,2) NOT NULL,
    NguoiKy NVARCHAR(100) NOT NULL,

    CONSTRAINT PK_QuyetDinhKhenThuong
        PRIMARY KEY (MaQDKT),

    CONSTRAINT UQ_QDKT_SoQuyetDinh
        UNIQUE (SoQuyetDinh),

    CONSTRAINT FK_QDKT_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT FK_QDKT_PhongBan
        FOREIGN KEY (MaPhongBan)
        REFERENCES PhongBan(MaPhongBan),

    CONSTRAINT CK_QDKT_DoiTuong
        CHECK (
            (
                LoaiDoiTuong = N'Cá nhân'
                AND MaNV IS NOT NULL
                AND MaPhongBan IS NULL
            )
            OR
            (
                LoaiDoiTuong = N'Tập thể'
                AND MaNV IS NULL
                AND MaPhongBan IS NOT NULL
            )
        ),

    CONSTRAINT CK_QDKT_SoTien
        CHECK (SoTienThuong >= 0)
);
GO

-- ------------------------------------------------------------
-- BANG 17: PHIEUCHIKHENTHUONG
-- ------------------------------------------------------------

CREATE TABLE PhieuChiKhenThuong (
    MaPhieuChi VARCHAR(20) NOT NULL,
    MaQDKT VARCHAR(20) NOT NULL,
    NgayChi DATE NOT NULL,
    SoTienChi DECIMAL(18,2) NOT NULL,
    NguoiLap NVARCHAR(100) NOT NULL,
    HinhThucChi NVARCHAR(30) NOT NULL,
    GhiChu NVARCHAR(500) NULL,

    CONSTRAINT PK_PhieuChiKhenThuong
        PRIMARY KEY (MaPhieuChi),

    CONSTRAINT UQ_PhieuChi_MaQDKT
        UNIQUE (MaQDKT),

    CONSTRAINT FK_PhieuChi_QDKT
        FOREIGN KEY (MaQDKT)
        REFERENCES QuyetDinhKhenThuong(MaQDKT),

    CONSTRAINT CK_PhieuChi_SoTien
        CHECK (SoTienChi >= 0),

    CONSTRAINT CK_PhieuChi_HinhThuc
        CHECK (
            HinhThucChi IN (
                N'Tiền mặt',
                N'Chuyển khoản',
                N'Qua lương'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 18: QUYETDINHKYLUAT
-- ------------------------------------------------------------

CREATE TABLE QuyetDinhKyLuat (
    MaQDKL VARCHAR(20) NOT NULL,
    SoQuyetDinh VARCHAR(30) NOT NULL,
    NgayQuyetDinh DATE NOT NULL,
    LoaiDoiTuong NVARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NULL,
    MaPhongBan VARCHAR(20) NULL,
    LyDoKyLuat NVARCHAR(500) NOT NULL,
    HinhThucKyLuat NVARCHAR(100) NOT NULL,
    SoTienPhat DECIMAL(18,2) NOT NULL DEFAULT 0,
    NguoiKy NVARCHAR(100) NOT NULL,

    CONSTRAINT PK_QuyetDinhKyLuat
        PRIMARY KEY (MaQDKL),

    CONSTRAINT UQ_QDKL_SoQuyetDinh
        UNIQUE (SoQuyetDinh),

    CONSTRAINT FK_QDKL_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT FK_QDKL_PhongBan
        FOREIGN KEY (MaPhongBan)
        REFERENCES PhongBan(MaPhongBan),

    CONSTRAINT CK_QDKL_DoiTuong
        CHECK (
            (
                LoaiDoiTuong = N'Cá nhân'
                AND MaNV IS NOT NULL
                AND MaPhongBan IS NULL
            )
            OR
            (
                LoaiDoiTuong = N'Tập thể'
                AND MaNV IS NULL
                AND MaPhongBan IS NOT NULL
            )
        ),

    CONSTRAINT CK_QDKL_SoTien
        CHECK (SoTienPhat >= 0)
);
GO

-- ------------------------------------------------------------
-- BANG 19: PHIEUTHUNOPPHAT
-- ------------------------------------------------------------

CREATE TABLE PhieuThuNopPhat (
    MaPhieuThu VARCHAR(20) NOT NULL,
    MaQDKL VARCHAR(20) NOT NULL,
    NgayThu DATE NOT NULL,
    SoTienThu DECIMAL(18,2) NOT NULL,
    NguoiLap NVARCHAR(100) NOT NULL,
    HinhThucThu NVARCHAR(30) NOT NULL,
    GhiChu NVARCHAR(500) NULL,

    CONSTRAINT PK_PhieuThuNopPhat
        PRIMARY KEY (MaPhieuThu),

    CONSTRAINT UQ_PhieuThu_MaQDKL
        UNIQUE (MaQDKL),

    CONSTRAINT FK_PhieuThu_QDKL
        FOREIGN KEY (MaQDKL)
        REFERENCES QuyetDinhKyLuat(MaQDKL),

    CONSTRAINT CK_PhieuThu_SoTien
        CHECK (SoTienThu >= 0),

    CONSTRAINT CK_PhieuThu_HinhThuc
        CHECK (
            HinhThucThu IN (
                N'Tiền mặt',
                N'Chuyển khoản',
                N'Trừ lương'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 20: BANGLUONG
-- ------------------------------------------------------------

CREATE TABLE BangLuong (
    MaBangLuong VARCHAR(20) NOT NULL,
    Thang INT NOT NULL,
    Nam INT NOT NULL,
    NgayLap DATE NOT NULL,
    NguoiLap NVARCHAR(100) NOT NULL,
    TongTienLuong DECIMAL(18,2) NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Đã lập',

    CONSTRAINT PK_BangLuong
        PRIMARY KEY (MaBangLuong),

    CONSTRAINT UQ_BangLuong_Thang_Nam
        UNIQUE (Thang, Nam),

    CONSTRAINT CK_BangLuong_Thang
        CHECK (Thang BETWEEN 1 AND 12),

    CONSTRAINT CK_BangLuong_Nam
        CHECK (Nam BETWEEN 2000 AND 2100),

    CONSTRAINT CK_BangLuong_TongTien
        CHECK (TongTienLuong >= 0),

    CONSTRAINT CK_BangLuong_TrangThai
        CHECK (
            TrangThai IN (
                N'Đã lập',
                N'Đã tính',
                N'Đã thanh toán'
            )
        )
);
GO

-- ------------------------------------------------------------
-- BANG 21: CHITIETBANGLUONG
-- ------------------------------------------------------------

CREATE TABLE ChiTietBangLuong (
    MaChiTietLuong VARCHAR(20) NOT NULL,
    MaBangLuong VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    LuongCoBan DECIMAL(18,2) NOT NULL,
    SoNgayCong DECIMAL(8,2) NOT NULL,
    PhuCapLuong DECIMAL(18,2) NOT NULL DEFAULT 0,
    PhuCapChucVu DECIMAL(18,2) NOT NULL DEFAULT 0,
    PhuCapDocHai DECIMAL(18,2) NOT NULL DEFAULT 0,
    TienPhuTroi DECIMAL(18,2) NOT NULL DEFAULT 0,
    TienThuong DECIMAL(18,2) NOT NULL DEFAULT 0,
    TienPhat DECIMAL(18,2) NOT NULL DEFAULT 0,
    TienBHXH DECIMAL(18,2) NOT NULL DEFAULT 0,
    TienBHYT DECIMAL(18,2) NOT NULL DEFAULT 0,
    ThucLanh DECIMAL(18,2) NOT NULL DEFAULT 0,

    CONSTRAINT PK_ChiTietBangLuong
        PRIMARY KEY (MaChiTietLuong),

    CONSTRAINT FK_CTL_BangLuong
        FOREIGN KEY (MaBangLuong)
        REFERENCES BangLuong(MaBangLuong),

    CONSTRAINT FK_CTL_NhanVien
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV),

    CONSTRAINT UQ_CTL_BangLuong_NhanVien
        UNIQUE (
            MaBangLuong,
            MaNV
        ),

    CONSTRAINT CK_CTL_Luong
        CHECK (
            LuongCoBan >= 0
            AND SoNgayCong >= 0
            AND SoNgayCong <= 31
            AND PhuCapLuong >= 0
            AND PhuCapChucVu >= 0
            AND PhuCapDocHai >= 0
            AND TienPhuTroi >= 0
            AND TienThuong >= 0
            AND TienPhat >= 0
            AND TienBHXH >= 0
            AND TienBHYT >= 0
            AND ThucLanh >= 0
        )
);
GO

-- ============================================================
-- 3. TRIGGER KIEM TRA RANG BUOC NGHIEP VU
-- ============================================================

-- TRIGGER 1: BAO HIEM CHI AP DUNG CHO HOP DONG DAI HAN

CREATE OR ALTER TRIGGER TR_BaoHiem_HopDongDaiHan
ON HoSoBaoHiem
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN HopDongLaoDong h
            ON i.MaHopDong = h.MaHopDong
        WHERE h.LoaiHopDong <> N'Dài hạn'
    )
    BEGIN
        THROW 50001,
            N'Chi duoc lap bao hiem cho hop dong dai han.',
            1;
    END
END;
GO

-- TRIGGER 2: KHONG DOI SANG NGAN HAN NEU DA CO BAO HIEM

CREATE OR ALTER TRIGGER TR_HopDong_KiemTraBaoHiem
ON HopDongLaoDong
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN HoSoBaoHiem b
            ON i.MaHopDong = b.MaHopDong
        WHERE i.LoaiHopDong <> N'Dài hạn'
    )
    BEGIN
        THROW 50002,
            N'Hop dong co bao hiem phai la hop dong dai han.',
            1;
    END
END;
GO

-- TRIGGER 3: GIO PHU TROI KHONG DUOC VUOT GIO TREN PHIEU

CREATE OR ALTER TRIGGER TR_CTPT_KiemTraSoGio
ON ChiTietPhuTroi
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN PhieuPhuTroi p
            ON i.MaPhieuPhuTroi = p.MaPhieuPhuTroi
        WHERE i.SoGioThamGia > p.SoGioPhuTroi
    )
    BEGIN
        THROW 50003,
            N'So gio tham gia vuot so gio tren phieu.',
            1;
    END
END;
GO

-- TRIGGER 4: KHONG GIAM GIO PHIEU THAP HON GIO DA GHI

CREATE OR ALTER TRIGGER TR_PhieuPhuTroi_KiemTraSoGio
ON PhieuPhuTroi
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN ChiTietPhuTroi ct
            ON i.MaPhieuPhuTroi = ct.MaPhieuPhuTroi
        WHERE ct.SoGioThamGia > i.SoGioPhuTroi
    )
    BEGIN
        THROW 50004,
            N'So gio phieu nho hon gio da ghi nhan.',
            1;
    END
END;
GO

-- TRIGGER 5: NGAY PHAN CONG PHAI NAM TRONG TUAN KE HOACH

CREATE OR ALTER TRIGGER TR_PhanCong_NgayTrongTuan
ON ChiTietPhanCong
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN KeHoachTuan k
            ON i.MaKeHoach = k.MaKeHoach
        WHERE i.NgayLamViec < k.NgayBatDau
           OR i.NgayLamViec > k.NgayKetThuc
    )
    BEGIN
        THROW 50005,
            N'Ngay phan cong khong thuoc tuan ke hoach.',
            1;
    END
END;
GO

-- TRIGGER 6: KIEM TRA KHI SUA KE HOACH TUAN

CREATE OR ALTER TRIGGER TR_KeHoach_KiemTraNgayPhanCong
ON KeHoachTuan
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN ChiTietPhanCong ct
            ON i.MaKeHoach = ct.MaKeHoach
        WHERE ct.NgayLamViec < i.NgayBatDau
           OR ct.NgayLamViec > i.NgayKetThuc
    )
    BEGIN
        THROW 50006,
            N'Ke hoach moi khong chua ngay da phan cong.',
            1;
    END
END;
GO

-- TRIGGER 7: NGAY CHAM CONG PHAI THUOC THANG NAM

CREATE OR ALTER TRIGGER TR_CTCC_KiemTraThangNam
ON ChiTietChamCong
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN BangChamCong b
            ON i.MaBangChamCong = b.MaBangChamCong
        WHERE MONTH(i.NgayChamCong) <> b.Thang
           OR YEAR(i.NgayChamCong) <> b.Nam
    )
    BEGIN
        THROW 50007,
            N'Ngay cham cong khong thuoc thang nam bang cham cong.',
            1;
    END
END;
GO

-- TRIGGER 8: KIEM TRA CHI TIET KHI SUA BANG CHAM CONG

CREATE OR ALTER TRIGGER TR_BCC_KiemTraChiTiet
ON BangChamCong
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN ChiTietChamCong ct
            ON i.MaBangChamCong = ct.MaBangChamCong
        WHERE MONTH(ct.NgayChamCong) <> i.Thang
           OR YEAR(ct.NgayChamCong) <> i.Nam
    )
    BEGIN
        THROW 50008,
            N'Thang nam bang cham cong khong khop chi tiet.',
            1;
    END
END;
GO

-- TRIGGER 9: KIEM TRA PHIEU CHI KHEN THUONG

CREATE OR ALTER TRIGGER TR_PhieuChi_KiemTraQuyetDinh
ON PhieuChiKhenThuong
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN QuyetDinhKhenThuong q
            ON i.MaQDKT = q.MaQDKT
        WHERE i.SoTienChi <> q.SoTienThuong
           OR i.NgayChi < q.NgayQuyetDinh
    )
    BEGIN
        THROW 50009,
            N'Phieu chi khong khop tien hoac ngay quyet dinh.',
            1;
    END
END;
GO

-- TRIGGER 10: KIEM TRA PHIEU THU NOP PHAT

CREATE OR ALTER TRIGGER TR_PhieuThu_KiemTraQuyetDinh
ON PhieuThuNopPhat
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN QuyetDinhKyLuat q
            ON i.MaQDKL = q.MaQDKL
        WHERE i.SoTienThu <> q.SoTienPhat
           OR i.NgayThu < q.NgayQuyetDinh
    )
    BEGIN
        THROW 50010,
            N'Phieu thu khong khop tien hoac ngay quyet dinh.',
            1;
    END
END;
GO

-- TRIGGER 11: KIEM TRA QUYET DINH KHEN THUONG KHI SUA

CREATE OR ALTER TRIGGER TR_QDKT_KiemTraPhieuChi
ON QuyetDinhKhenThuong
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN PhieuChiKhenThuong p
            ON i.MaQDKT = p.MaQDKT
        WHERE i.SoTienThuong <> p.SoTienChi
           OR i.NgayQuyetDinh > p.NgayChi
    )
    BEGIN
        THROW 50011,
            N'Quyet dinh khen thuong khong khop phieu chi.',
            1;
    END
END;
GO

-- TRIGGER 12: KIEM TRA QUYET DINH KY LUAT KHI SUA

CREATE OR ALTER TRIGGER TR_QDKL_KiemTraPhieuThu
ON QuyetDinhKyLuat
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN PhieuThuNopPhat p
            ON i.MaQDKL = p.MaQDKL
        WHERE i.SoTienPhat <> p.SoTienThu
           OR i.NgayQuyetDinh > p.NgayThu
    )
    BEGIN
        THROW 50012,
            N'Quyet dinh ky luat khong khop phieu thu.',
            1;
    END
END;
GO

-- ============================================================
-- 4. KIEM TRA KET QUA
-- ============================================================

-- DANH SACH BANG
SELECT TABLE_NAME AS TenBang
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
  AND TABLE_SCHEMA = 'dbo'
ORDER BY TABLE_NAME;
GO

-- DEM SO BANG
SELECT COUNT(*) AS TongSoBang
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
  AND TABLE_SCHEMA = 'dbo';
GO

-- KIEM TRA PRIMARY KEY
SELECT
    t.name AS TenBang,
    kc.name AS TenKhoaChinh
FROM sys.key_constraints kc
INNER JOIN sys.tables t
    ON kc.parent_object_id = t.object_id
WHERE kc.type = 'PK'
ORDER BY t.name;
GO

-- KIEM TRA FOREIGN KEY
SELECT
    fk.name AS TenKhoaNgoai,
    OBJECT_NAME(fk.parent_object_id) AS BangCon,
    OBJECT_NAME(fk.referenced_object_id) AS BangCha
FROM sys.foreign_keys fk
ORDER BY BangCon;
GO

-- KIEM TRA UNIQUE
SELECT
    t.name AS TenBang,
    kc.name AS TenRangBuocUnique
FROM sys.key_constraints kc
INNER JOIN sys.tables t
    ON kc.parent_object_id = t.object_id
WHERE kc.type = 'UQ'
ORDER BY t.name;
GO

-- KIEM TRA CHECK
SELECT
    OBJECT_NAME(parent_object_id) AS TenBang,
    name AS TenRangBuocCheck
FROM sys.check_constraints
ORDER BY TenBang;
GO

-- KIEM TRA TRIGGER
SELECT
    OBJECT_NAME(parent_id) AS TenBang,
    name AS TenTrigger
FROM sys.triggers
WHERE parent_class = 1
ORDER BY TenBang;
GO

PRINT N'HOAN THANH TAO DATABASE QuanLyNhanSu';
GO



USE QuanLyNhanSu;
GO

SET XACT_ABORT ON;
GO

BEGIN TRY
    BEGIN TRANSACTION;

    -- =====================================================
    -- 1. PHONGBAN - 5 DU LIEU
    -- =====================================================

    INSERT INTO PhongBan
    (MaPhongBan, TenPhongBan, DiaDiem, SoDienThoai, MoTa)
    VALUES
    ('PB01', N'Phòng Nhân sự',
     N'Tầng 1', '02838110001',
     N'Quản lý nhân sự và tuyển dụng'),

    ('PB02', N'Phòng Kế toán',
     N'Tầng 2', '02838110002',
     N'Quản lý tài chính và tiền lương'),

    ('PB03', N'Phòng Kỹ thuật',
     N'Tầng 3', '02838110003',
     N'Kiểm tra kỹ thuật và chất lượng sơn'),

    ('PB04', N'Phòng Kinh doanh',
     N'Tầng 4', '02838110004',
     N'Kinh doanh và phân phối sản phẩm'),

    ('PB05', N'Phân xưởng Sản xuất',
     N'Khu nhà xưởng', '02838110005',
     N'Sản xuất và đóng gói sơn');


    -- =====================================================
    -- 2. NHANVIEN - 5 DU LIEU
    -- =====================================================

    INSERT INTO NhanVien
    (MaNV, HoTen, NgaySinh, GioiTinh, DiaChi,
     SoDienThoai, Email, NgayVaoLam, TrangThai,
     MaPhongBan)
    VALUES
    ('NV01', N'Nguyễn Văn An', '1998-05-12',
     N'Nam', N'TP. Hồ Chí Minh',
     '0901000001', 'an@dongson.vn',
     '2026-01-01', N'Chính thức', 'PB01'),

    ('NV02', N'Trần Thị Bình', '1999-08-20',
     N'Nữ', N'TP. Hồ Chí Minh',
     '0901000002', 'binh@dongson.vn',
     '2026-01-01', N'Chính thức', 'PB02'),

    ('NV03', N'Lê Văn Cường', '1997-03-15',
     N'Nam', N'Đồng Nai',
     '0901000003', 'cuong@dongson.vn',
     '2026-01-01', N'Chính thức', 'PB03'),

    ('NV04', N'Phạm Thị Dung', '2000-11-10',
     N'Nữ', N'Bình Dương',
     '0901000004', 'dung@dongson.vn',
     '2026-01-01', N'Chính thức', 'PB04'),

    ('NV05', N'Hoàng Văn Em', '1996-07-25',
     N'Nam', N'Long An',
     '0901000005', 'em@dongson.vn',
     '2026-01-01', N'Chính thức', 'PB05');


    -- =====================================================
    -- 3. CHUCVU - 5 DU LIEU
    -- =====================================================

    INSERT INTO ChucVu
    (MaChucVu, TenChucVu, MoTa, PhuCapChucVu)
    VALUES
    ('CV01', N'Nhân viên nhân sự',
     N'Phụ trách công tác nhân sự', 500000),

    ('CV02', N'Kế toán viên',
     N'Phụ trách kế toán và tiền lương', 600000),

    ('CV03', N'Kỹ thuật viên',
     N'Kiểm tra kỹ thuật sản xuất', 700000),

    ('CV04', N'Nhân viên kinh doanh',
     N'Tư vấn và bán hàng', 800000),

    ('CV05', N'Công nhân sản xuất',
     N'Trực tiếp sản xuất sơn', 400000);


    -- =====================================================
    -- 4. QUYETDINHTUYENDUNG - 5 DU LIEU
    -- =====================================================

    INSERT INTO QuyetDinhTuyenDung
    (MaQDTD, SoQuyetDinh, NgayQuyetDinh,
     MaNV, MaPhongBan, NgayBatDauThuViec,
     NgayKetThucThuViec, LuongThuViec,
     NoiDung, DieuKhoan)
    VALUES
    ('TD01', 'QDTD001', '2025-11-25',
     'NV01', 'PB01',
     '2025-12-01', '2025-12-31', 5000000,
     N'Tuyển dụng nhân viên nhân sự',
     N'Thử việc một tháng'),

    ('TD02', 'QDTD002', '2025-11-25',
     'NV02', 'PB02',
     '2025-12-01', '2025-12-31', 5500000,
     N'Tuyển dụng kế toán viên',
     N'Thử việc một tháng'),

    ('TD03', 'QDTD003', '2025-11-25',
     'NV03', 'PB03',
     '2025-12-01', '2025-12-31', 6000000,
     N'Tuyển dụng kỹ thuật viên',
     N'Thử việc một tháng'),

    ('TD04', 'QDTD004', '2025-11-25',
     'NV04', 'PB04',
     '2025-12-01', '2025-12-31', 5000000,
     N'Tuyển dụng nhân viên kinh doanh',
     N'Thử việc một tháng'),

    ('TD05', 'QDTD005', '2025-11-25',
     'NV05', 'PB05',
     '2025-12-01', '2025-12-31', 4800000,
     N'Tuyển dụng công nhân sản xuất',
     N'Thử việc một tháng');


    -- =====================================================
    -- 5. HOPDONGLAODONG - 5 DU LIEU
    -- =====================================================

    INSERT INTO HopDongLaoDong
    (MaHopDong, SoHopDong, MaNV, LoaiHopDong,
     NgayKy, NgayBatDau, NgayKetThuc,
     NoiDungHopDong, TrangThai)
    VALUES
    ('HD01', 'HDLD001', 'NV01', N'Dài hạn',
     '2026-01-01', '2026-01-01', '2028-12-31',
     N'Hợp đồng nhân viên nhân sự',
     N'Có hiệu lực'),

    ('HD02', 'HDLD002', 'NV02', N'Dài hạn',
     '2026-01-01', '2026-01-01', '2028-12-31',
     N'Hợp đồng kế toán viên',
     N'Có hiệu lực'),

    ('HD03', 'HDLD003', 'NV03', N'Dài hạn',
     '2026-01-01', '2026-01-01', '2028-12-31',
     N'Hợp đồng kỹ thuật viên',
     N'Có hiệu lực'),

    ('HD04', 'HDLD004', 'NV04', N'Dài hạn',
     '2026-01-01', '2026-01-01', '2028-12-31',
     N'Hợp đồng nhân viên kinh doanh',
     N'Có hiệu lực'),

    ('HD05', 'HDLD005', 'NV05', N'Dài hạn',
     '2026-01-01', '2026-01-01', '2028-12-31',
     N'Hợp đồng công nhân sản xuất',
     N'Có hiệu lực');


    -- =====================================================
    -- 6. HOSOBAOHIEM - 5 DU LIEU
    -- =====================================================

    INSERT INTO HoSoBaoHiem
    (MaBaoHiem, MaHopDong, SoBHXH, SoBHYT,
     NgayThamGia, MucDongBHXH,
     MucDongBHYT, TrangThai)
    VALUES
    ('BH01', 'HD01', 'BHXH001', 'BHYT001',
     '2026-01-01', 480000, 90000,
     N'Đang tham gia'),

    ('BH02', 'HD02', 'BHXH002', 'BHYT002',
     '2026-01-01', 560000, 105000,
     N'Đang tham gia'),

    ('BH03', 'HD03', 'BHXH003', 'BHYT003',
     '2026-01-01', 640000, 120000,
     N'Đang tham gia'),

    ('BH04', 'HD04', 'BHXH004', 'BHYT004',
     '2026-01-01', 520000, 97500,
     N'Đang tham gia'),

    ('BH05', 'HD05', 'BHXH005', 'BHYT005',
     '2026-01-01', 480000, 90000,
     N'Đang tham gia');


    -- =====================================================
    -- 7. QUYETDINHLUONG - 5 DU LIEU
    -- =====================================================

    INSERT INTO QuyetDinhLuong
    (MaQDL, SoQuyetDinh, MaNV,
     NgayQuyetDinh, NgayHieuLuc,
     LuongCoBan, PhuCapLuong,
     PhuCapDocHai, NoiDung)
    VALUES
    ('L01', 'QDL001', 'NV01',
     '2026-01-01', '2026-01-01',
     6000000, 500000, 0,
     N'Lương nhân viên nhân sự'),

    ('L02', 'QDL002', 'NV02',
     '2026-01-01', '2026-01-01',
     7000000, 600000, 0,
     N'Lương kế toán viên'),

    ('L03', 'QDL003', 'NV03',
     '2026-01-01', '2026-01-01',
     8000000, 700000, 500000,
     N'Lương kỹ thuật viên'),

    ('L04', 'QDL004', 'NV04',
     '2026-01-01', '2026-01-01',
     6500000, 800000, 0,
     N'Lương nhân viên kinh doanh'),

    ('L05', 'QDL005', 'NV05',
     '2026-01-01', '2026-01-01',
     6000000, 400000, 700000,
     N'Lương công nhân sản xuất');


    -- =====================================================
    -- 8. QUYETDINHCHUCVU - 5 DU LIEU
    -- =====================================================

    INSERT INTO QuyetDinhChucVu
    (MaQDCV, SoQuyetDinh, MaNV,
     MaChucVu, NgayQuyetDinh,
     NgayHieuLuc, PhuCapChucVu, NoiDung)
    VALUES
    ('DCV01', 'QDCV001', 'NV01', 'CV01',
     '2026-01-01', '2026-01-01',
     500000, N'Bổ nhiệm nhân viên nhân sự'),

    ('DCV02', 'QDCV002', 'NV02', 'CV02',
     '2026-01-01', '2026-01-01',
     600000, N'Bổ nhiệm kế toán viên'),

    ('DCV03', 'QDCV003', 'NV03', 'CV03',
     '2026-01-01', '2026-01-01',
     700000, N'Bổ nhiệm kỹ thuật viên'),

    ('DCV04', 'QDCV004', 'NV04', 'CV04',
     '2026-01-01', '2026-01-01',
     800000, N'Bổ nhiệm nhân viên kinh doanh'),

    ('DCV05', 'QDCV005', 'NV05', 'CV05',
     '2026-01-01', '2026-01-01',
     400000, N'Bổ nhiệm công nhân sản xuất');


    -- =====================================================
    -- 9. KEHOACHTUAN - 5 DU LIEU
    -- =====================================================

    INSERT INTO KeHoachTuan
    (MaKeHoach, MaPhongBan, NgayBatDau,
     NgayKetThuc, NguoiLap, NgayLap,
     NoiDung, TrangThai)
    VALUES
    ('KH01', 'PB01',
     '2026-10-05', '2026-10-11',
     N'Trưởng phòng Nhân sự', '2026-10-01',
     N'Kế hoạch tuần phòng Nhân sự',
     N'Hoàn thành'),

    ('KH02', 'PB02',
     '2026-10-05', '2026-10-11',
     N'Trưởng phòng Kế toán', '2026-10-01',
     N'Kế hoạch tuần phòng Kế toán',
     N'Hoàn thành'),

    ('KH03', 'PB03',
     '2026-10-05', '2026-10-11',
     N'Trưởng phòng Kỹ thuật', '2026-10-01',
     N'Kế hoạch tuần phòng Kỹ thuật',
     N'Hoàn thành'),

    ('KH04', 'PB04',
     '2026-10-05', '2026-10-11',
     N'Trưởng phòng Kinh doanh', '2026-10-01',
     N'Kế hoạch tuần phòng Kinh doanh',
     N'Hoàn thành'),

    ('KH05', 'PB05',
     '2026-10-05', '2026-10-11',
     N'Quản đốc phân xưởng', '2026-10-01',
     N'Kế hoạch tuần phân xưởng',
     N'Hoàn thành');


    -- =====================================================
    -- 10. CALAMVIEC - 5 DU LIEU
    -- =====================================================

    INSERT INTO CaLamViec
    (MaCa, TenCa, GioBatDau, GioKetThuc, MoTa)
    VALUES
    ('CA01', N'Ca hành chính',
     '08:00', '17:00',
     N'Làm việc giờ hành chính'),

    ('CA02', N'Ca sáng',
     '06:00', '14:00',
     N'Làm việc buổi sáng'),

    ('CA03', N'Ca chiều',
     '14:00', '22:00',
     N'Làm việc buổi chiều'),

    ('CA04', N'Ca đêm',
     '22:00', '06:00',
     N'Làm việc qua đêm'),

    ('CA05', N'Ca nửa ngày',
     '08:00', '12:00',
     N'Làm việc nửa ngày');


    -- =====================================================
    -- 11. CHITIETPHANCONG - 5 DU LIEU
    -- =====================================================

    INSERT INTO ChiTietPhanCong
    (MaPhanCong, MaKeHoach, MaNV, MaCa,
     NgayLamViec, NoiDungCongViec, GhiChu)
    VALUES
    ('PC01', 'KH01', 'NV01', 'CA01',
     '2026-10-05',
     N'Quản lý hồ sơ nhân sự', N'Đúng kế hoạch'),

    ('PC02', 'KH02', 'NV02', 'CA01',
     '2026-10-05',
     N'Kiểm tra chứng từ kế toán', N'Đúng kế hoạch'),

    ('PC03', 'KH03', 'NV03', 'CA02',
     '2026-10-06',
     N'Kiểm tra chất lượng sơn', N'Đúng kế hoạch'),

    ('PC04', 'KH04', 'NV04', 'CA01',
     '2026-10-06',
     N'Tư vấn khách hàng', N'Đúng kế hoạch'),

    ('PC05', 'KH05', 'NV05', 'CA03',
     '2026-10-07',
     N'Sản xuất và đóng gói sơn', N'Đúng kế hoạch');


    -- =====================================================
    -- 12. BANGCHAMCONG - 5 DU LIEU
    -- =====================================================

    INSERT INTO BangChamCong
    (MaBangChamCong, MaPhongBan, Thang,
     Nam, NgayLap, NguoiLap, TrangThai)
    VALUES
    ('BCC01', 'PB01', 10, 2026,
     '2026-10-28', N'Ban chấm công',
     N'Đang chấm công'),

    ('BCC02', 'PB02', 10, 2026,
     '2026-10-28', N'Ban chấm công',
     N'Đang chấm công'),

    ('BCC03', 'PB03', 10, 2026,
     '2026-10-28', N'Ban chấm công',
     N'Đang chấm công'),

    ('BCC04', 'PB04', 10, 2026,
     '2026-10-28', N'Ban chấm công',
     N'Đang chấm công'),

    ('BCC05', 'PB05', 10, 2026,
     '2026-10-28', N'Ban chấm công',
     N'Đang chấm công');


    -- =====================================================
    -- 13. CHITIETCHAMCONG - 5 DU LIEU
    -- =====================================================

    INSERT INTO ChiTietChamCong
    (MaChiTietChamCong, MaBangChamCong,
     MaNV, NgayChamCong, MaCa,
     GioVao, GioRa, SoGioLam, TrangThai)
    VALUES
    ('CC01', 'BCC01', 'NV01',
     '2026-10-05', 'CA01',
     '2026-10-05T08:00:00',
     '2026-10-05T17:00:00',
     8, N'Có mặt'),

    ('CC02', 'BCC02', 'NV02',
     '2026-10-05', 'CA01',
     '2026-10-05T08:00:00',
     '2026-10-05T17:00:00',
     8, N'Có mặt'),

    ('CC03', 'BCC03', 'NV03',
     '2026-10-06', 'CA02',
     '2026-10-06T06:00:00',
     '2026-10-06T14:00:00',
     8, N'Có mặt'),

    ('CC04', 'BCC04', 'NV04',
     '2026-10-06', 'CA01',
     '2026-10-06T08:00:00',
     '2026-10-06T17:00:00',
     8, N'Có mặt'),

    ('CC05', 'BCC05', 'NV05',
     '2026-10-07', 'CA03',
     '2026-10-07T14:00:00',
     '2026-10-07T22:00:00',
     8, N'Có mặt');


    -- =====================================================
    -- 14. PHIEUPHUTROI - 5 DU LIEU
    -- =====================================================

    INSERT INTO PhieuPhuTroi
    (MaPhieuPhuTroi, SoPhieu, NgayPhuTroi,
     SoGioPhuTroi, HinhThucPhuTroi,
     NguoiLap, GhiChu)
    VALUES
    ('PT01', 'PT001', '2026-10-08',
     2, N'Tăng ca',
     N'Ban chấm công', N'Tăng ca xử lý hồ sơ'),

    ('PT02', 'PT002', '2026-10-09',
     3, N'Tăng ca',
     N'Ban chấm công', N'Tăng ca kế toán'),

    ('PT03', 'PT003', '2026-10-10',
     4, N'Ngày nghỉ',
     N'Ban chấm công', N'Kiểm tra thiết bị'),

    ('PT04', 'PT004', '2026-10-11',
     2, N'Ngày nghỉ',
     N'Ban chấm công', N'Hỗ trợ kinh doanh'),

    ('PT05', 'PT005', '2026-10-12',
     3, N'Tăng ca',
     N'Ban chấm công', N'Tăng ca sản xuất');


    -- =====================================================
    -- 15. CHITIETPHUTROI - 5 DU LIEU
    -- HESO PHU TROI = 1.5
    -- =====================================================

    INSERT INTO ChiTietPhuTroi
    (MaChiTietPhuTroi, MaPhieuPhuTroi,
     MaNV, SoGioThamGia, HeSoPhuTroi,
     ThanhTien)
    VALUES
    ('CTPT01', 'PT01', 'NV01',
     2, 1.50, 86538.46),

    ('CTPT02', 'PT02', 'NV02',
     3, 1.50, 151442.31),

    ('CTPT03', 'PT03', 'NV03',
     4, 1.50, 230769.23),

    ('CTPT04', 'PT04', 'NV04',
     2, 1.50, 93750.00),

    ('CTPT05', 'PT05', 'NV05',
     3, 1.50, 129807.69);


    -- =====================================================
    -- 16. QUYETDINHKHENTHUONG - 5 DU LIEU
    -- CA NHAN HOAC TAP THE
    -- =====================================================

    INSERT INTO QuyetDinhKhenThuong
    (MaQDKT, SoQuyetDinh, NgayQuyetDinh,
     LoaiDoiTuong, MaNV, MaPhongBan,
     LyDoKhenThuong, SoTienThuong, NguoiKy)
    VALUES
    ('KT01', 'QDKT001', '2026-10-10',
     N'Cá nhân', 'NV01', NULL,
     N'Hoàn thành tốt công việc',
     500000, N'Giám đốc'),

    ('KT02', 'QDKT002', '2026-10-10',
     N'Cá nhân', 'NV02', NULL,
     N'Hoàn thành báo cáo đúng hạn',
     700000, N'Giám đốc'),

    ('KT03', 'QDKT003', '2026-10-11',
     N'Cá nhân', 'NV03', NULL,
     N'Có sáng kiến cải tiến kỹ thuật',
     1000000, N'Giám đốc'),

    ('KT04', 'QDKT004', '2026-10-12',
     N'Tập thể', NULL, 'PB04',
     N'Phòng kinh doanh đạt chỉ tiêu',
     2000000, N'Giám đốc'),

    ('KT05', 'QDKT005', '2026-10-12',
     N'Tập thể', NULL, 'PB05',
     N'Phân xưởng hoàn thành kế hoạch',
     3000000, N'Giám đốc');


    -- =====================================================
    -- 17. PHIEUCHIKHENTHUONG - 5 DU LIEU
    -- TIEN CHI = TIEN TREN QUYET DINH
    -- =====================================================

    INSERT INTO PhieuChiKhenThuong
    (MaPhieuChi, MaQDKT, NgayChi,
     SoTienChi, NguoiLap, HinhThucChi, GhiChu)
    VALUES
    ('PCKT01', 'KT01', '2026-10-13',
     500000, N'Kế toán',
     N'Tiền mặt', N'Đã chi thưởng'),

    ('PCKT02', 'KT02', '2026-10-13',
     700000, N'Kế toán',
     N'Chuyển khoản', N'Đã chi thưởng'),

    ('PCKT03', 'KT03', '2026-10-14',
     1000000, N'Kế toán',
     N'Tiền mặt', N'Đã chi thưởng'),

    ('PCKT04', 'KT04', '2026-10-15',
     2000000, N'Kế toán',
     N'Chuyển khoản', N'Đã chi thưởng tập thể'),

    ('PCKT05', 'KT05', '2026-10-15',
     3000000, N'Kế toán',
     N'Chuyển khoản', N'Đã chi thưởng tập thể');


    -- =====================================================
    -- 18. QUYETDINHKYLUAT - 5 DU LIEU
    -- =====================================================

    INSERT INTO QuyetDinhKyLuat
    (MaQDKL, SoQuyetDinh, NgayQuyetDinh,
     LoaiDoiTuong, MaNV, MaPhongBan,
     LyDoKyLuat, HinhThucKyLuat,
     SoTienPhat, NguoiKy)
    VALUES
    ('KL01', 'QDKL001', '2026-10-15',
     N'Cá nhân', 'NV01', NULL,
     N'Đi làm muộn',
     N'Phạt tiền', 100000, N'Giám đốc'),

    ('KL02', 'QDKL002', '2026-10-15',
     N'Cá nhân', 'NV02', NULL,
     N'Nộp báo cáo trễ',
     N'Phạt tiền', 150000, N'Giám đốc'),

    ('KL03', 'QDKL003', '2026-10-16',
     N'Cá nhân', 'NV03', NULL,
     N'Không tuân thủ nội quy',
     N'Phạt tiền', 200000, N'Giám đốc'),

    ('KL04', 'QDKL004', '2026-10-17',
     N'Tập thể', NULL, 'PB04',
     N'Không hoàn thành báo cáo tuần',
     N'Phạt tiền', 300000, N'Giám đốc'),

    ('KL05', 'QDKL005', '2026-10-17',
     N'Tập thể', NULL, 'PB05',
     N'Vi phạm quy trình sản xuất',
     N'Phạt tiền', 500000, N'Giám đốc');


    -- =====================================================
    -- 19. PHIEUTHUNOPPHAT - 5 DU LIEU
    -- TIEN THU = TIEN PHAT TREN QUYET DINH
    -- =====================================================

    INSERT INTO PhieuThuNopPhat
    (MaPhieuThu, MaQDKL, NgayThu,
     SoTienThu, NguoiLap, HinhThucThu, GhiChu)
    VALUES
    ('PTNP01', 'KL01', '2026-10-18',
     100000, N'Kế toán',
     N'Tiền mặt', N'Đã thu tiền phạt'),

    ('PTNP02', 'KL02', '2026-10-18',
     150000, N'Kế toán',
     N'Chuyển khoản', N'Đã thu tiền phạt'),

    ('PTNP03', 'KL03', '2026-10-19',
     200000, N'Kế toán',
     N'Tiền mặt', N'Đã thu tiền phạt'),

    ('PTNP04', 'KL04', '2026-10-20',
     300000, N'Kế toán',
     N'Chuyển khoản', N'Đã thu tiền phạt tập thể'),

    ('PTNP05', 'KL05', '2026-10-20',
     500000, N'Kế toán',
     N'Chuyển khoản', N'Đã thu tiền phạt tập thể');


    -- =====================================================
    -- 20. BANGLUONG - 5 DU LIEU
    -- 5 THANG KHAC NHAU DE KHONG TRUNG UNIQUE
    -- =====================================================

    INSERT INTO BangLuong
    (MaBangLuong, Thang, Nam, NgayLap,
     NguoiLap, TongTienLuong, TrangThai)
    VALUES
    ('BL01', 6, 2026, '2026-06-30',
     N'Kế toán', 0, N'Đã lập'),

    ('BL02', 7, 2026, '2026-07-31',
     N'Kế toán', 0, N'Đã lập'),

    ('BL03', 8, 2026, '2026-08-31',
     N'Kế toán', 0, N'Đã lập'),

    ('BL04', 9, 2026, '2026-09-30',
     N'Kế toán', 0, N'Đã lập'),

    ('BL05', 10, 2026, '2026-10-28',
     N'Kế toán', 0, N'Đã lập');


    -- =====================================================
    -- 21. CHITIETBANGLUONG - 5 DU LIEU
    -- DU LIEU MINH HOA CHO 5 NHAN VIEN
    -- =====================================================

    INSERT INTO ChiTietBangLuong
    (MaChiTietLuong, MaBangLuong, MaNV,
     LuongCoBan, SoNgayCong, PhuCapLuong,
     PhuCapChucVu, PhuCapDocHai, TienPhuTroi,
     TienThuong, TienPhat, TienBHXH,
     TienBHYT, ThucLanh)
    VALUES
    ('CTL01', 'BL01', 'NV01',
     6000000, 26, 500000,
     500000, 0, 0,
     0, 0, 480000,
     90000, 6430000),

    ('CTL02', 'BL02', 'NV02',
     7000000, 26, 600000,
     600000, 0, 0,
     0, 0, 560000,
     105000, 7535000),

    ('CTL03', 'BL03', 'NV03',
     8000000, 26, 700000,
     700000, 500000, 0,
     0, 0, 640000,
     120000, 9140000),

    ('CTL04', 'BL04', 'NV04',
     6500000, 26, 800000,
     800000, 0, 0,
     0, 0, 520000,
     97500, 7482500),

    ('CTL05', 'BL05', 'NV05',
     6000000, 26, 400000,
     400000, 700000, 129807.69,
     0, 0, 480000,
     90000, 7059807.69);


    -- =====================================================
    -- CAP NHAT TONG TIEN LUONG CUA MOI BANG
    -- =====================================================

    UPDATE bl
    SET TongTienLuong = ISNULL((
        SELECT SUM(ct.ThucLanh)
        FROM ChiTietBangLuong ct
        WHERE ct.MaBangLuong = bl.MaBangLuong
    ), 0)
    FROM BangLuong bl
    WHERE bl.MaBangLuong IN
        ('BL01', 'BL02', 'BL03', 'BL04', 'BL05');


    COMMIT TRANSACTION;

    PRINT N'THÊM THÀNH CÔNG 105 DÒNG DỮ LIỆU MẪU';

END TRY
BEGIN CATCH

    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;

    SELECT
        ERROR_NUMBER() AS MaLoi,
        ERROR_MESSAGE() AS NoiDungLoi;

END CATCH;
GO


-- =====================================================
-- KIEM TRA SO LUONG DU LIEU TUNG BANG
-- =====================================================

SELECT N'PhongBan' AS TenBang, COUNT(*) AS SoDong
FROM PhongBan
UNION ALL
SELECT N'NhanVien', COUNT(*) FROM NhanVien
UNION ALL
SELECT N'ChucVu', COUNT(*) FROM ChucVu
UNION ALL
SELECT N'QuyetDinhTuyenDung', COUNT(*)
FROM QuyetDinhTuyenDung
UNION ALL
SELECT N'HopDongLaoDong', COUNT(*)
FROM HopDongLaoDong
UNION ALL
SELECT N'HoSoBaoHiem', COUNT(*)
FROM HoSoBaoHiem
UNION ALL
SELECT N'QuyetDinhLuong', COUNT(*)
FROM QuyetDinhLuong
UNION ALL
SELECT N'QuyetDinhChucVu', COUNT(*)
FROM QuyetDinhChucVu
UNION ALL
SELECT N'KeHoachTuan', COUNT(*)
FROM KeHoachTuan
UNION ALL
SELECT N'CaLamViec', COUNT(*)
FROM CaLamViec
UNION ALL
SELECT N'ChiTietPhanCong', COUNT(*)
FROM ChiTietPhanCong
UNION ALL
SELECT N'BangChamCong', COUNT(*)
FROM BangChamCong
UNION ALL
SELECT N'ChiTietChamCong', COUNT(*)
FROM ChiTietChamCong
UNION ALL
SELECT N'PhieuPhuTroi', COUNT(*)
FROM PhieuPhuTroi
UNION ALL
SELECT N'ChiTietPhuTroi', COUNT(*)
FROM ChiTietPhuTroi
UNION ALL
SELECT N'QuyetDinhKhenThuong', COUNT(*)
FROM QuyetDinhKhenThuong
UNION ALL
SELECT N'PhieuChiKhenThuong', COUNT(*)
FROM PhieuChiKhenThuong
UNION ALL
SELECT N'QuyetDinhKyLuat', COUNT(*)
FROM QuyetDinhKyLuat
UNION ALL
SELECT N'PhieuThuNopPhat', COUNT(*)
FROM PhieuThuNopPhat
UNION ALL
SELECT N'BangLuong', COUNT(*)
FROM BangLuong
UNION ALL
SELECT N'ChiTietBangLuong', COUNT(*)
FROM ChiTietBangLuong;
GO

-- TONG SO DU LIEU TOAN BO 21 BANG

SELECT SUM(SoDong) AS TongSoDong
FROM (
    SELECT COUNT(*) AS SoDong FROM PhongBan
    UNION ALL SELECT COUNT(*) FROM NhanVien
    UNION ALL SELECT COUNT(*) FROM ChucVu
    UNION ALL SELECT COUNT(*) FROM QuyetDinhTuyenDung
    UNION ALL SELECT COUNT(*) FROM HopDongLaoDong
    UNION ALL SELECT COUNT(*) FROM HoSoBaoHiem
    UNION ALL SELECT COUNT(*) FROM QuyetDinhLuong
    UNION ALL SELECT COUNT(*) FROM QuyetDinhChucVu
    UNION ALL SELECT COUNT(*) FROM KeHoachTuan
    UNION ALL SELECT COUNT(*) FROM CaLamViec
    UNION ALL SELECT COUNT(*) FROM ChiTietPhanCong
    UNION ALL SELECT COUNT(*) FROM BangChamCong
    UNION ALL SELECT COUNT(*) FROM ChiTietChamCong
    UNION ALL SELECT COUNT(*) FROM PhieuPhuTroi
    UNION ALL SELECT COUNT(*) FROM ChiTietPhuTroi
    UNION ALL SELECT COUNT(*) FROM QuyetDinhKhenThuong
    UNION ALL SELECT COUNT(*) FROM PhieuChiKhenThuong
    UNION ALL SELECT COUNT(*) FROM QuyetDinhKyLuat
    UNION ALL SELECT COUNT(*) FROM PhieuThuNopPhat
    UNION ALL SELECT COUNT(*) FROM BangLuong
    UNION ALL SELECT COUNT(*) FROM ChiTietBangLuong
) AS TongHop;
GO
