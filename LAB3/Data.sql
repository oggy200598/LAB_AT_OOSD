/* =========================================================
   QUẢN LÝ KHÁCH SẠN
   SQL SERVER
   XÓA CSDL CŨ -> TẠO LẠI CSDL -> TẠO BẢNG -> DỮ LIỆU MẪU
   ========================================================= */

------------------------------------------------------------
-- 1. TẠO DATABASE NẾU CHƯA CÓ
------------------------------------------------------------
IF DB_ID(N'QuanLyKhachSan') IS NULL
BEGIN
    CREATE DATABASE QuanLyKhachSan;
END
GO

USE QuanLyKhachSan;
GO

------------------------------------------------------------
-- 2. XÓA BẢNG CŨ THEO THỨ TỰ KHÓA NGOẠI
------------------------------------------------------------

IF OBJECT_ID(N'dbo.ThanhToan', N'U') IS NOT NULL
    DROP TABLE dbo.ThanhToan;

IF OBJECT_ID(N'dbo.HoaDon', N'U') IS NOT NULL
    DROP TABLE dbo.HoaDon;

IF OBJECT_ID(N'dbo.ChiTietPhieuDenBu', N'U') IS NOT NULL
    DROP TABLE dbo.ChiTietPhieuDenBu;

IF OBJECT_ID(N'dbo.PhieuDenBu', N'U') IS NOT NULL
    DROP TABLE dbo.PhieuDenBu;

IF OBJECT_ID(N'dbo.ChiTietPhieuSuDungDV', N'U') IS NOT NULL
    DROP TABLE dbo.ChiTietPhieuSuDungDV;

IF OBJECT_ID(N'dbo.PhieuSuDungDV', N'U') IS NOT NULL
    DROP TABLE dbo.PhieuSuDungDV;

IF OBJECT_ID(N'dbo.NguoiLuuTru', N'U') IS NOT NULL
    DROP TABLE dbo.NguoiLuuTru;

IF OBJECT_ID(N'dbo.ChiTietDatPhong', N'U') IS NOT NULL
    DROP TABLE dbo.ChiTietDatPhong;

IF OBJECT_ID(N'dbo.PhieuDatPhong', N'U') IS NOT NULL
    DROP TABLE dbo.PhieuDatPhong;

IF OBJECT_ID(N'dbo.PhieuLapDat', N'U') IS NOT NULL
    DROP TABLE dbo.PhieuLapDat;

IF OBJECT_ID(N'dbo.QuyDinhDenBu', N'U') IS NOT NULL
    DROP TABLE dbo.QuyDinhDenBu;

IF OBJECT_ID(N'dbo.TienNghi', N'U') IS NOT NULL
    DROP TABLE dbo.TienNghi;

IF OBJECT_ID(N'dbo.DichVu', N'U') IS NOT NULL
    DROP TABLE dbo.DichVu;

IF OBJECT_ID(N'dbo.Phong', N'U') IS NOT NULL
    DROP TABLE dbo.Phong;

IF OBJECT_ID(N'dbo.LoaiTienNghi', N'U') IS NOT NULL
    DROP TABLE dbo.LoaiTienNghi;

IF OBJECT_ID(N'dbo.KhuVuc', N'U') IS NOT NULL
    DROP TABLE dbo.KhuVuc;

IF OBJECT_ID(N'dbo.KhachHang', N'U') IS NOT NULL
    DROP TABLE dbo.KhachHang;

IF OBJECT_ID(N'dbo.NhanVien', N'U') IS NOT NULL
    DROP TABLE dbo.NhanVien;

GO

------------------------------------------------------------
-- 3. BẢNG NHÂN VIÊN
------------------------------------------------------------
CREATE TABLE NhanVien
(
    MaNV VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(120) NOT NULL,
    VaiTro NVARCHAR(50) NOT NULL,
    SoDienThoai VARCHAR(20) NULL,

    CONSTRAINT PK_NhanVien
        PRIMARY KEY (MaNV)
);
GO

------------------------------------------------------------
-- 4. BẢNG KHU VỰC
------------------------------------------------------------
CREATE TABLE KhuVuc
(
    MaKhuVuc VARCHAR(20) NOT NULL,
    TenKhuVuc NVARCHAR(100) NOT NULL,

    CONSTRAINT PK_KhuVuc
        PRIMARY KEY (MaKhuVuc),

    CONSTRAINT UQ_KhuVuc_Ten
        UNIQUE (TenKhuVuc)
);
GO

------------------------------------------------------------
-- 5. BẢNG PHÒNG
------------------------------------------------------------
CREATE TABLE Phong
(
    SoPhong VARCHAR(20) NOT NULL,
    MaKhuVuc VARCHAR(20) NOT NULL,
    SoNguoiToiDa INT NOT NULL,
    DonGiaNgay DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Trống',

    CONSTRAINT PK_Phong
        PRIMARY KEY (SoPhong),

    CONSTRAINT CK_Phong_SoNguoi
        CHECK (SoNguoiToiDa > 0),

    CONSTRAINT CK_Phong_DonGia
        CHECK (DonGiaNgay >= 0),

    CONSTRAINT CK_Phong_TrangThai
        CHECK
        (
            TrangThai IN
            (
                N'Trống',
                N'Đã đặt',
                N'Đang ở',
                N'Bảo trì'
            )
        ),

    CONSTRAINT FK_Phong_KhuVuc
        FOREIGN KEY (MaKhuVuc)
        REFERENCES KhuVuc(MaKhuVuc)
);
GO

------------------------------------------------------------
-- 6. BẢNG LOẠI TIỆN NGHI
------------------------------------------------------------
CREATE TABLE LoaiTienNghi
(
    MaLoaiTN VARCHAR(20) NOT NULL,
    TenLoaiTN NVARCHAR(100) NOT NULL,

    CONSTRAINT PK_LoaiTienNghi
        PRIMARY KEY (MaLoaiTN),

    CONSTRAINT UQ_LoaiTienNghi_Ten
        UNIQUE (TenLoaiTN)
);
GO

------------------------------------------------------------
-- 7. BẢNG TIỆN NGHI
------------------------------------------------------------
CREATE TABLE TienNghi
(
    MaTienNghi VARCHAR(30) NOT NULL,
    MaLoaiTN VARCHAR(20) NOT NULL,
    SoThuTu INT NOT NULL,
    TinhTrangHienTai NVARCHAR(100) NULL,

    CONSTRAINT PK_TienNghi
        PRIMARY KEY (MaTienNghi),

    CONSTRAINT UQ_TienNghi_Loai_STT
        UNIQUE (MaLoaiTN, SoThuTu),

    CONSTRAINT FK_TienNghi_Loai
        FOREIGN KEY (MaLoaiTN)
        REFERENCES LoaiTienNghi(MaLoaiTN)
);
GO

------------------------------------------------------------
-- 8. BẢNG PHIẾU LẮP ĐẶT
------------------------------------------------------------
CREATE TABLE PhieuLapDat
(
    SoPhieuLapDat VARCHAR(30) NOT NULL,
    MaTienNghi VARCHAR(30) NOT NULL,
    SoPhong VARCHAR(20) NOT NULL,
    NgayLap DATE NOT NULL,
    TinhTrang NVARCHAR(100) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    GhiChu NVARCHAR(250) NULL,

    CONSTRAINT PK_PhieuLapDat
        PRIMARY KEY (SoPhieuLapDat),

    CONSTRAINT UQ_PhieuLapDat_TN_Ngay
        UNIQUE (MaTienNghi, NgayLap),

    CONSTRAINT FK_PhieuLapDat_TienNghi
        FOREIGN KEY (MaTienNghi)
        REFERENCES TienNghi(MaTienNghi),

    CONSTRAINT FK_PhieuLapDat_Phong
        FOREIGN KEY (SoPhong)
        REFERENCES Phong(SoPhong),

    CONSTRAINT FK_PhieuLapDat_NV
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV)
);
GO

------------------------------------------------------------
-- 9. BẢNG KHÁCH HÀNG
------------------------------------------------------------
CREATE TABLE KhachHang
(
    MaKhach VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(120) NOT NULL,
    SoCMND VARCHAR(30) NOT NULL,
    QuocTich NVARCHAR(80) NOT NULL,
    SoDienThoai VARCHAR(20) NULL,

    CONSTRAINT PK_KhachHang
        PRIMARY KEY (MaKhach),

    CONSTRAINT UQ_KhachHang_CMND
        UNIQUE (SoCMND)
);
GO

------------------------------------------------------------
-- 10. BẢNG PHIẾU ĐẶT PHÒNG
------------------------------------------------------------
CREATE TABLE PhieuDatPhong
(
    SoPhieuDat VARCHAR(30) NOT NULL,
    MaKhach VARCHAR(20) NOT NULL,
    MaNVLeTan VARCHAR(20) NOT NULL,
    NgayLap DATETIME NOT NULL,
    NgayNhan DATE NOT NULL,
    NgayTraDuKien DATE NOT NULL,
    TienCoc DECIMAL(18,2) NOT NULL DEFAULT 0,
    KenhDat NVARCHAR(20) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đã đặt',
    NgayNhanThucTe DATETIME NULL,
    NgayTraThucTe DATETIME NULL,

    CONSTRAINT PK_PhieuDatPhong
        PRIMARY KEY (SoPhieuDat),

    CONSTRAINT CK_PhieuDat_Ngay
        CHECK (NgayTraDuKien >= NgayNhan),

    CONSTRAINT CK_PhieuDat_TienCoc
        CHECK (TienCoc >= 0),

    CONSTRAINT CK_PhieuDat_Kenh
        CHECK
        (
            KenhDat IN
            (
                N'Điện thoại',
                N'Website',
                N'Trực tiếp'
            )
        ),

    CONSTRAINT CK_PhieuDat_TrangThai
        CHECK
        (
            TrangThai IN
            (
                N'Đã đặt',
                N'Đang ở',
                N'Đã trả',
                N'No-show',
                N'Hủy'
            )
        ),

    CONSTRAINT FK_PhieuDat_Khach
        FOREIGN KEY (MaKhach)
        REFERENCES KhachHang(MaKhach),

    CONSTRAINT FK_PhieuDat_NV
        FOREIGN KEY (MaNVLeTan)
        REFERENCES NhanVien(MaNV)
);
GO

------------------------------------------------------------
-- 11. BẢNG CHI TIẾT ĐẶT PHÒNG
------------------------------------------------------------
CREATE TABLE ChiTietDatPhong
(
    SoPhieuDat VARCHAR(30) NOT NULL,
    SoPhong VARCHAR(20) NOT NULL,
    SoNguoi INT NOT NULL,

    CONSTRAINT PK_ChiTietDatPhong
        PRIMARY KEY (SoPhieuDat, SoPhong),

    CONSTRAINT CK_CTDat_SoNguoi
        CHECK (SoNguoi > 0),

    CONSTRAINT FK_CTDat_Phieu
        FOREIGN KEY (SoPhieuDat)
        REFERENCES PhieuDatPhong(SoPhieuDat),

    CONSTRAINT FK_CTDat_Phong
        FOREIGN KEY (SoPhong)
        REFERENCES Phong(SoPhong)
);
GO

------------------------------------------------------------
-- 12. BẢNG NGƯỜI LƯU TRÚ
------------------------------------------------------------
CREATE TABLE NguoiLuuTru
(
    MaNguoiLT INT IDENTITY(1,1) NOT NULL,
    SoPhieuDat VARCHAR(30) NOT NULL,
    SoPhong VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(120) NOT NULL,
    SoCMND VARCHAR(30) NOT NULL,
    QuocTich NVARCHAR(80) NOT NULL,

    CONSTRAINT PK_NguoiLuuTru
        PRIMARY KEY (MaNguoiLT),

    CONSTRAINT FK_NguoiLT_CTDat
        FOREIGN KEY (SoPhieuDat, SoPhong)
        REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong)
);
GO

------------------------------------------------------------
-- 13. BẢNG DỊCH VỤ
------------------------------------------------------------
CREATE TABLE DichVu
(
    MaDV VARCHAR(20) NOT NULL,
    TenDV NVARCHAR(120) NOT NULL,
    DonViTinh NVARCHAR(40) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,

    CONSTRAINT PK_DichVu
        PRIMARY KEY (MaDV),

    CONSTRAINT CK_DichVu_DonGia
        CHECK (DonGia >= 0)
);
GO

------------------------------------------------------------
-- 14. BẢNG PHIẾU SỬ DỤNG DỊCH VỤ
------------------------------------------------------------
CREATE TABLE PhieuSuDungDV
(
    SoPhieuSDDV VARCHAR(30) NOT NULL,
    SoPhieuDat VARCHAR(30) NOT NULL,
    SoPhong VARCHAR(20) NOT NULL,
    NgaySuDung DATE NOT NULL,
    MaNV VARCHAR(20) NOT NULL,

    CONSTRAINT PK_PhieuSuDungDV
        PRIMARY KEY (SoPhieuSDDV),

    CONSTRAINT UQ_PhieuSDDV_PhongNgay
        UNIQUE (SoPhieuDat, SoPhong, NgaySuDung),

    CONSTRAINT FK_PhieuSDDV_CTDat
        FOREIGN KEY (SoPhieuDat, SoPhong)
        REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong),

    CONSTRAINT FK_PhieuSDDV_NV
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV)
);
GO

------------------------------------------------------------
-- 15. BẢNG CHI TIẾT PHIẾU SỬ DỤNG DỊCH VỤ
------------------------------------------------------------
CREATE TABLE ChiTietPhieuSuDungDV
(
    SoPhieuSDDV VARCHAR(30) NOT NULL,
    MaDV VARCHAR(20) NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,

    ThanhTien AS
    (
        CONVERT(DECIMAL(18,2), SoLuong * DonGia)
    ) PERSISTED,

    CONSTRAINT PK_ChiTietPhieuSuDungDV
        PRIMARY KEY (SoPhieuSDDV, MaDV),

    CONSTRAINT CK_CTSDDV_SoLuong
        CHECK (SoLuong > 0),

    CONSTRAINT CK_CTSDDV_DonGia
        CHECK (DonGia >= 0),

    CONSTRAINT FK_CTSDDV_Phieu
        FOREIGN KEY (SoPhieuSDDV)
        REFERENCES PhieuSuDungDV(SoPhieuSDDV),

    CONSTRAINT FK_CTSDDV_DV
        FOREIGN KEY (MaDV)
        REFERENCES DichVu(MaDV)
);
GO

------------------------------------------------------------
-- 16. BẢNG QUY ĐỊNH ĐỀN BÙ
------------------------------------------------------------
CREATE TABLE QuyDinhDenBu
(
    MaQuyDinh VARCHAR(30) NOT NULL,
    MaLoaiTN VARCHAR(20) NOT NULL,
    MucDoThietHai NVARCHAR(80) NOT NULL,
    MucDenBu DECIMAL(18,2) NOT NULL,

    CONSTRAINT PK_QuyDinhDenBu
        PRIMARY KEY (MaQuyDinh),

    CONSTRAINT UQ_QDDB_Loai_MucDo
        UNIQUE (MaLoaiTN, MucDoThietHai),

    CONSTRAINT CK_QDDB_MucDenBu
        CHECK (MucDenBu >= 0),

    CONSTRAINT FK_QDDB_Loai
        FOREIGN KEY (MaLoaiTN)
        REFERENCES LoaiTienNghi(MaLoaiTN)
);
GO

------------------------------------------------------------
-- 17. BẢNG PHIẾU ĐỀN BÙ
------------------------------------------------------------
CREATE TABLE PhieuDenBu
(
    SoPhieuDenBu VARCHAR(30) NOT NULL,
    SoPhieuDat VARCHAR(30) NOT NULL,
    SoPhong VARCHAR(20) NOT NULL,
    NgayLap DATETIME NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0,

    CONSTRAINT PK_PhieuDenBu
        PRIMARY KEY (SoPhieuDenBu),

    CONSTRAINT CK_PhieuDB_TongTien
        CHECK (TongTien >= 0),

    CONSTRAINT FK_PhieuDB_CTDat
        FOREIGN KEY (SoPhieuDat, SoPhong)
        REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong),

    CONSTRAINT FK_PhieuDB_NV
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV)
);
GO

------------------------------------------------------------
-- 18. BẢNG CHI TIẾT PHIẾU ĐỀN BÙ
------------------------------------------------------------
CREATE TABLE ChiTietPhieuDenBu
(
    SoPhieuDenBu VARCHAR(30) NOT NULL,
    MaTienNghi VARCHAR(30) NOT NULL,
    MucDoThietHai NVARCHAR(80) NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL,

    CONSTRAINT PK_ChiTietPhieuDenBu
        PRIMARY KEY (SoPhieuDenBu, MaTienNghi),

    CONSTRAINT CK_CTDB_SoTien
        CHECK (SoTien >= 0),

    CONSTRAINT FK_CTDB_Phieu
        FOREIGN KEY (SoPhieuDenBu)
        REFERENCES PhieuDenBu(SoPhieuDenBu),

    CONSTRAINT FK_CTDB_TienNghi
        FOREIGN KEY (MaTienNghi)
        REFERENCES TienNghi(MaTienNghi)
);
GO

------------------------------------------------------------
-- 19. BẢNG HÓA ĐƠN
------------------------------------------------------------
CREATE TABLE HoaDon
(
    SoHoaDon VARCHAR(30) NOT NULL,
    SoPhieuDat VARCHAR(30) NOT NULL,
    NgayLap DATETIME NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    SoNgayTinhTien INT NOT NULL,
    TienPhong DECIMAL(18,2) NOT NULL,
    TienDichVu DECIMAL(18,2) NOT NULL,

    TongTien AS
    (
        CONVERT(DECIMAL(18,2), TienPhong + TienDichVu)
    ) PERSISTED,

    TrangThai NVARCHAR(30) NOT NULL
        DEFAULT N'Chưa thanh toán',

    CONSTRAINT PK_HoaDon
        PRIMARY KEY (SoHoaDon),

    CONSTRAINT UQ_HoaDon_PhieuDat
        UNIQUE (SoPhieuDat),

    CONSTRAINT CK_HoaDon_SoNgay
        CHECK (SoNgayTinhTien > 0),

    CONSTRAINT CK_HoaDon_TienPhong
        CHECK (TienPhong >= 0),

    CONSTRAINT CK_HoaDon_TienDV
        CHECK (TienDichVu >= 0),

    CONSTRAINT CK_HoaDon_TrangThai
        CHECK
        (
            TrangThai IN
            (
                N'Chưa thanh toán',
                N'Đã thanh toán'
            )
        ),

    CONSTRAINT FK_HoaDon_PhieuDat
        FOREIGN KEY (SoPhieuDat)
        REFERENCES PhieuDatPhong(SoPhieuDat),

    CONSTRAINT FK_HoaDon_NV
        FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV)
);
GO

------------------------------------------------------------
-- 20. BẢNG THANH TOÁN
------------------------------------------------------------
CREATE TABLE ThanhToan
(
    MaThanhToan VARCHAR(30) NOT NULL,
    SoHoaDon VARCHAR(30) NOT NULL,
    NgayThanhToan DATETIME NOT NULL,
    HinhThuc NVARCHAR(30) NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL,

    CONSTRAINT PK_ThanhToan
        PRIMARY KEY (MaThanhToan),

    CONSTRAINT CK_ThanhToan_SoTien
        CHECK (SoTien > 0),

    CONSTRAINT CK_ThanhToan_HinhThuc
        CHECK
        (
            HinhThuc IN
            (
                N'Tiền mặt',
                N'Chuyển khoản',
                N'Thẻ',
                N'Ví điện tử'
            )
        ),

    CONSTRAINT FK_ThanhToan_HoaDon
        FOREIGN KEY (SoHoaDon)
        REFERENCES HoaDon(SoHoaDon)
);
GO

------------------------------------------------------------
-- 21. INDEX
------------------------------------------------------------
CREATE INDEX IX_PhieuDatPhong_Ngay
ON PhieuDatPhong
(
    NgayNhan,
    NgayTraDuKien,
    TrangThai
);

CREATE INDEX IX_CTDat_Phong
ON ChiTietDatPhong
(
    SoPhong,
    SoPhieuDat
);

CREATE INDEX IX_PhieuSDDV_DatPhong
ON PhieuSuDungDV
(
    SoPhieuDat,
    SoPhong,
    NgaySuDung
);
GO

------------------------------------------------------------
-- 22. DỮ LIỆU NHÂN VIÊN
------------------------------------------------------------
INSERT INTO NhanVien
(
    MaNV,
    HoTen,
    VaiTro,
    SoDienThoai
)
VALUES
('NV01', N'Nguyễn Thu Hà', N'Lễ tân', '0901000001'),
('NV02', N'Trần Minh An', N'Phục vụ phòng', '0901000002'),
('NV03', N'Lê Hoàng Nam', N'Thanh toán', '0901000003');
GO

------------------------------------------------------------
-- 23. DỮ LIỆU KHU VỰC
------------------------------------------------------------
INSERT INTO KhuVuc
(
    MaKhuVuc,
    TenKhuVuc
)
VALUES
('A', N'Khu A'),
('B', N'Khu B');
GO

------------------------------------------------------------
-- 24. DỮ LIỆU PHÒNG
------------------------------------------------------------
INSERT INTO Phong
(
    SoPhong,
    MaKhuVuc,
    SoNguoiToiDa,
    DonGiaNgay,
    TrangThai
)
VALUES
('A101', 'A', 2, 600000, N'Trống'),
('A102', 'A', 3, 800000, N'Trống'),
('A103', 'A', 2, 700000, N'Trống'),
('B201', 'B', 4, 1200000, N'Trống'),
('B202', 'B', 3, 1000000, N'Trống');
GO

------------------------------------------------------------
-- 25. DỮ LIỆU LOẠI TIỆN NGHI
------------------------------------------------------------
INSERT INTO LoaiTienNghi
(
    MaLoaiTN,
    TenLoaiTN
)
VALUES
('TV', N'Tivi'),
('TL', N'Tủ lạnh'),
('DT', N'Điện thoại');
GO

------------------------------------------------------------
-- 26. DỮ LIỆU TIỆN NGHI
------------------------------------------------------------
INSERT INTO TienNghi
(
    MaTienNghi,
    MaLoaiTN,
    SoThuTu,
    TinhTrangHienTai
)
VALUES
('TV01', 'TV', 1, N'Tốt'),
('TV02', 'TV', 2, N'Tốt'),
('TL01', 'TL', 1, N'Tốt'),
('TL02', 'TL', 2, N'Tốt'),
('DT01', 'DT', 1, N'Tốt');
GO

------------------------------------------------------------
-- 27. DỮ LIỆU KHÁCH HÀNG
------------------------------------------------------------
INSERT INTO KhachHang
(
    MaKhach,
    HoTen,
    SoCMND,
    QuocTich,
    SoDienThoai
)
VALUES
('KH01', N'Nguyễn Văn Minh', '079202001234',
 N'Việt Nam', '0905123456'),

('KH02', N'Trần Thị Lan', '079202005678',
 N'Việt Nam', '0916234567'),

('KH03', N'Lê Hoàng Nam', '079202009876',
 N'Việt Nam', '0987345123'),

('KH04', N'Phạm Ngọc Hân', '079202004321',
 N'Việt Nam', '0938456123'),

('KH05', N'Võ Minh Thư', '079202007654',
 N'Việt Nam', '0979567123');
GO

------------------------------------------------------------
-- 28. DỮ LIỆU DỊCH VỤ
------------------------------------------------------------
INSERT INTO DichVu
(
    MaDV,
    TenDV,
    DonViTinh,
    DonGia
)
VALUES
('DV01', N'Ăn sáng', N'Suất', 120000),
('DV02', N'Tắm hơi', N'Lượt', 250000),
('DV03', N'Karaoke', N'Giờ', 300000),
('DV04', N'Giặt ủi', N'Kg', 50000),
('DV05', N'Nước suối', N'Chai', 20000);
GO

------------------------------------------------------------
-- 29. DỮ LIỆU QUY ĐỊNH ĐỀN BÙ
------------------------------------------------------------
INSERT INTO QuyDinhDenBu
(
    MaQuyDinh,
    MaLoaiTN,
    MucDoThietHai,
    MucDenBu
)
VALUES
('QD01', 'TV', N'Hư hỏng nhẹ', 500000),
('QD02', 'TV', N'Mất', 5000000),
('QD03', 'TL', N'Hư hỏng nhẹ', 400000),
('QD04', 'TL', N'Mất', 4000000),
('QD05', 'DT', N'Hư hỏng nhẹ', 200000),
('QD06', 'DT', N'Mất', 1000000);
GO

------------------------------------------------------------
-- 30. KIỂM TRA CÁC BẢNG
------------------------------------------------------------

SELECT * FROM NhanVien;
SELECT * FROM KhuVuc;
SELECT * FROM Phong;
SELECT * FROM LoaiTienNghi;
SELECT * FROM TienNghi;
SELECT * FROM KhachHang;
SELECT * FROM DichVu;
SELECT * FROM QuyDinhDenBu;

------------------------------------------------------------
-- 31. KIỂM TRA DANH SÁCH BẢNG
------------------------------------------------------------
SELECT
    TABLE_NAME AS TenBang
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;
GO