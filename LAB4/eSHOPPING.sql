IF DB_ID(N'eSHOPPING') IS NULL
    CREATE DATABASE eSHOPPING;
GO
USE eSHOPPING;
GO

IF OBJECT_ID('dbo.ChiTietDonHang','U') IS NOT NULL DROP TABLE dbo.ChiTietDonHang;
IF OBJECT_ID('dbo.ThanhToan','U') IS NOT NULL DROP TABLE dbo.ThanhToan;
IF OBJECT_ID('dbo.DonHang','U') IS NOT NULL DROP TABLE dbo.DonHang;
IF OBJECT_ID('dbo.ChiTietGioHang','U') IS NOT NULL DROP TABLE dbo.ChiTietGioHang;
IF OBJECT_ID('dbo.GioHang','U') IS NOT NULL DROP TABLE dbo.GioHang;
IF OBJECT_ID('dbo.SanPham','U') IS NOT NULL DROP TABLE dbo.SanPham;
IF OBJECT_ID('dbo.NhomSanPham','U') IS NOT NULL DROP TABLE dbo.NhomSanPham;
IF OBJECT_ID('dbo.KhachHang','U') IS NOT NULL DROP TABLE dbo.KhachHang;
GO

CREATE TABLE KhachHang
(
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(150) NOT NULL,
    NgaySinh DATE NULL,
    CMNDPassport NVARCHAR(50) NULL,
    DiaChi NVARCHAR(300) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(200) NOT NULL,
    Email VARCHAR(150) NULL
);

CREATE TABLE NhomSanPham
(
    MaNhom INT IDENTITY(1,1) PRIMARY KEY,
    TenNhom NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE SanPham
(
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    TenSP NVARCHAR(200) NOT NULL,
    NhaSanXuat NVARCHAR(150) NULL,
    HinhAnh NVARCHAR(500) NULL,
    MoTa NVARCHAR(MAX) NULL,
    ThongSoKyThuat NVARCHAR(MAX) NULL,
    GiaBan DECIMAL(18,2) NOT NULL CHECK (GiaBan >= 0),
    TonKho INT NOT NULL CHECK (TonKho >= 0),
    MaNhom INT NOT NULL,
    CONSTRAINT FK_SanPham_Nhom FOREIGN KEY(MaNhom) REFERENCES NhomSanPham(MaNhom)
);

CREATE TABLE GioHang
(
    MaGioHang INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL,
    NgayTao DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_GioHang_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE ChiTietGioHang
(
    MaGioHang INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    PRIMARY KEY(MaGioHang, MaSP),
    CONSTRAINT FK_CTGioHang_GioHang FOREIGN KEY(MaGioHang) REFERENCES GioHang(MaGioHang),
    CONSTRAINT FK_CTGioHang_SanPham FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
);

CREATE TABLE DonHang
(
    MaDonHang INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL,
    HoTenNguoiNhan NVARCHAR(150) NOT NULL,
    DiaChiNguoiNhan NVARCHAR(300) NOT NULL,
    DienThoaiNguoiNhan VARCHAR(20) NOT NULL,
    LoaiGiaoHang NVARCHAR(100) NOT NULL,
    KhuVuc NVARCHAR(100) NOT NULL,
    PhiGiaoHang DECIMAL(18,2) NOT NULL,
    TongTienHang DECIMAL(18,2) NOT NULL,
    TongThanhToan DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    ThoiGianDat DATETIME NOT NULL,
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE ChiTietDonHang
(
    MaCTDH INT IDENTITY(1,1) PRIMARY KEY,
    MaDonHang INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    CONSTRAINT FK_CTDH_DonHang FOREIGN KEY(MaDonHang) REFERENCES DonHang(MaDonHang),
    CONSTRAINT FK_CTDH_SanPham FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
);

CREATE TABLE ThanhToan
(
    MaThanhToan INT IDENTITY(1,1) PRIMARY KEY,
    MaDonHang INT NOT NULL,
    LoaiThe NVARCHAR(50) NOT NULL,
    SoTheMasked VARCHAR(30) NOT NULL,
    MaGiaoDich VARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    ThoiGianThanhToan DATETIME NOT NULL,
    CONSTRAINT FK_ThanhToan_DonHang FOREIGN KEY(MaDonHang) REFERENCES DonHang(MaDonHang)
);
GO

INSERT INTO NhomSanPham(TenNhom) VALUES
(N'Máy chụp hình kỹ thuật số'),
(N'Đồ chơi'),
(N'Thiết bị điện gia dụng'),
(N'Thiết bị máy tính');

INSERT INTO SanPham(TenSP, NhaSanXuat, HinhAnh, MoTa, ThongSoKyThuat, GiaBan, TonKho, MaNhom)
VALUES
(N'Canon EOS R50', N'Canon', N'', N'Máy ảnh mirrorless nhỏ gọn.', N'APS-C; 24.2MP; 4K', 18990000, 12, 1),
(N'Sony Alpha ZV-E10', N'Sony', N'', N'Máy ảnh vlog.', N'APS-C; 24.2MP; 4K', 15990000, 10, 1),
(N'LEGO City Fire Station', N'LEGO', N'', N'Bộ đồ chơi lắp ráp.', N'500 chi tiết', 1490000, 20, 2),
(N'Nồi chiên không dầu 5L', N'Philips', N'', N'Nồi chiên gia dụng.', N'5L; 1500W', 2390000, 15, 3),
(N'Laptop Office 14', N'ABC', N'', N'Laptop phục vụ học tập và văn phòng.', N'Core i5; RAM 16GB; SSD 512GB', 15990000, 8, 4),
(N'Chuột không dây', N'Logitech', N'', N'Chuột văn phòng không dây.', N'2.4GHz; 1600 DPI', 490000, 50, 4);

INSERT INTO KhachHang(HoTen, DiaChi, DienThoai, TenDangNhap, MatKhau, Email)
VALUES(N'Khách hàng mẫu', N'TP.HCM', '0900000000', 'khachhang', '123456', '');
GO
