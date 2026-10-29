-- SQL SERVER | Nguyễn Gia Huy - Lab 6
-- Chạy một lần trong SQL Server Management Studio
IF DB_ID(N'QuanLyBenhAn_GiaHuy') IS NULL CREATE DATABASE QuanLyBenhAn_GiaHuy;
GO
USE QuanLyBenhAn_GiaHuy;
GO
IF OBJECT_ID(N'dbo.BenhNhan', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[BenhNhan] (
    [maBenhNhan] NVARCHAR(30) NOT NULL,
    [hoTen] NVARCHAR(255) NULL,
    [ngaySinh] DATE NULL,
    [diaChi] NVARCHAR(255) NULL,
    [soDienThoai] NVARCHAR(255) NULL,
    [anh3x4] NVARCHAR(255) NULL,
    CONSTRAINT [PK_BenhNhan] PRIMARY KEY ([maBenhNhan])
 );
END
GO
IF OBJECT_ID(N'dbo.PhieuDangKy', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[PhieuDangKy] (
    [maPhieuDK] NVARCHAR(30) NOT NULL,
    [maBenhNhan] NVARCHAR(30) NULL,
    [ngayDangKy] DATE NULL,
    [lePhiNam] DECIMAL(18,2) NULL,
    [trangThaiThanhToan] BIT NOT NULL DEFAULT (0),
    CONSTRAINT [PK_PhieuDangKy] PRIMARY KEY ([maPhieuDK])
 );
END
GO
IF OBJECT_ID(N'dbo.HoSoBenhAn', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[HoSoBenhAn] (
    [maHoSo] NVARCHAR(30) NOT NULL,
    [maBenhNhan] NVARCHAR(30) NULL,
    [ngayLap] DATE NULL,
    [trangThai] NVARCHAR(255) NULL,
    CONSTRAINT [PK_HoSoBenhAn] PRIMARY KEY ([maHoSo])
 );
END
GO
IF OBJECT_ID(N'dbo.KhoaDieuTri', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[KhoaDieuTri] (
    [maKhoa] NVARCHAR(30) NOT NULL,
    [tenKhoa] NVARCHAR(255) NULL,
    [viTri] NVARCHAR(255) NULL,
    CONSTRAINT [PK_KhoaDieuTri] PRIMARY KEY ([maKhoa])
 );
END
GO
IF OBJECT_ID(N'dbo.BacSi', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[BacSi] (
    [maBacSi] NVARCHAR(30) NOT NULL,
    [hoTen] NVARCHAR(255) NULL,
    [chuyenMon] NVARCHAR(255) NULL,
    [soDienThoai] NVARCHAR(255) NULL,
    CONSTRAINT [PK_BacSi] PRIMARY KEY ([maBacSi])
 );
END
GO
IF OBJECT_ID(N'dbo.PhieuKham', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[PhieuKham] (
    [maPhieuKham] NVARCHAR(30) NOT NULL,
    [maHoSo] NVARCHAR(30) NULL,
    [maBacSi] NVARCHAR(30) NULL,
    [maKhoa] NVARCHAR(30) NULL,
    [ngayGioKham] DATETIME2(0) NULL,
    [trieuChung] NVARCHAR(255) NULL,
    [thanNhiet] DECIMAL(18,2) NULL,
    [huyetAp] NVARCHAR(255) NULL,
    [chanDoan] NVARCHAR(255) NULL,
    CONSTRAINT [PK_PhieuKham] PRIMARY KEY ([maPhieuKham])
 );
END
GO
IF OBJECT_ID(N'dbo.XetNghiem', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[XetNghiem] (
    [maXetNghiem] NVARCHAR(30) NOT NULL,
    [maPhieuKham] NVARCHAR(30) NULL,
    [tenXetNghiem] NVARCHAR(255) NULL,
    [ngayThucHien] DATETIME2(0) NULL,
    [ketQua] NVARCHAR(255) NULL,
    CONSTRAINT [PK_XetNghiem] PRIMARY KEY ([maXetNghiem])
 );
END
GO
IF OBJECT_ID(N'dbo.Thuoc', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[Thuoc] (
    [maThuoc] NVARCHAR(30) NOT NULL,
    [tenThuoc] NVARCHAR(255) NULL,
    [donViTinh] NVARCHAR(255) NULL,
    [giaThuoc] DECIMAL(18,2) NULL,
    CONSTRAINT [PK_Thuoc] PRIMARY KEY ([maThuoc])
 );
END
GO
IF OBJECT_ID(N'dbo.ToaThuoc', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[ToaThuoc] (
    [maToaThuoc] NVARCHAR(30) NOT NULL,
    [maPhieuKham] NVARCHAR(30) NULL,
    [ngayLap] DATE NULL,
    [loiDan] NVARCHAR(255) NULL,
    CONSTRAINT [PK_ToaThuoc] PRIMARY KEY ([maToaThuoc])
 );
END
GO
IF OBJECT_ID(N'dbo.ChiTietToaThuoc', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[ChiTietToaThuoc] (
    [maChiTietToa] NVARCHAR(30) NOT NULL,
    [maToaThuoc] NVARCHAR(30) NULL,
    [maThuoc] NVARCHAR(30) NULL,
    [lieuDung] NVARCHAR(255) NULL,
    [soLuong] INT NULL,
    [tanSuat] NVARCHAR(255) NULL,
    [thoiGianDung] NVARCHAR(255) NULL,
    CONSTRAINT [PK_ChiTietToaThuoc] PRIMARY KEY ([maChiTietToa])
 );
END
GO
IF OBJECT_ID(N'dbo.NhanVienCSKH', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[NhanVienCSKH] (
    [maNhanVien] NVARCHAR(30) NOT NULL,
    [hoTen] NVARCHAR(255) NULL,
    [soDienThoai] NVARCHAR(255) NULL,
    CONSTRAINT [PK_NhanVienCSKH] PRIMARY KEY ([maNhanVien])
 );
END
GO
IF OBJECT_ID(N'dbo.LichHen', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[LichHen] (
    [maLichHen] NVARCHAR(30) NOT NULL,
    [maBenhNhan] NVARCHAR(30) NULL,
    [maNhanVien] NVARCHAR(30) NULL,
    [ngayHen] DATE NULL,
    [gioHen] TIME(0) NULL,
    [loaiKham] NVARCHAR(255) NULL,
    [trangThai] NVARCHAR(255) NULL,
    CONSTRAINT [PK_LichHen] PRIMARY KEY ([maLichHen])
 );
END
GO
IF OBJECT_ID(N'dbo.VienPhi', N'U') IS NULL
BEGIN
 CREATE TABLE dbo.[VienPhi] (
    [maVienPhi] NVARCHAR(30) NOT NULL,
    [maPhieuKham] NVARCHAR(30) NULL,
    [ngayThanhToan] DATETIME2(0) NULL,
    [tongTien] DECIMAL(18,2) NULL,
    [trangThaiThanhToan] BIT NOT NULL DEFAULT (0),
    CONSTRAINT [PK_VienPhi] PRIMARY KEY ([maVienPhi])
 );
END
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_PhieuDangKy_BenhNhan_maBenhNhan') ALTER TABLE dbo.[PhieuDangKy] ADD CONSTRAINT [FK_PhieuDangKy_BenhNhan_maBenhNhan] FOREIGN KEY ([maBenhNhan]) REFERENCES dbo.[BenhNhan]([maBenhNhan]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_HoSoBenhAn_BenhNhan_maBenhNhan') ALTER TABLE dbo.[HoSoBenhAn] ADD CONSTRAINT [FK_HoSoBenhAn_BenhNhan_maBenhNhan] FOREIGN KEY ([maBenhNhan]) REFERENCES dbo.[BenhNhan]([maBenhNhan]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_PhieuKham_HoSoBenhAn_maHoSo') ALTER TABLE dbo.[PhieuKham] ADD CONSTRAINT [FK_PhieuKham_HoSoBenhAn_maHoSo] FOREIGN KEY ([maHoSo]) REFERENCES dbo.[HoSoBenhAn]([maHoSo]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_PhieuKham_BacSi_maBacSi') ALTER TABLE dbo.[PhieuKham] ADD CONSTRAINT [FK_PhieuKham_BacSi_maBacSi] FOREIGN KEY ([maBacSi]) REFERENCES dbo.[BacSi]([maBacSi]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_PhieuKham_KhoaDieuTri_maKhoa') ALTER TABLE dbo.[PhieuKham] ADD CONSTRAINT [FK_PhieuKham_KhoaDieuTri_maKhoa] FOREIGN KEY ([maKhoa]) REFERENCES dbo.[KhoaDieuTri]([maKhoa]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_XetNghiem_PhieuKham_maPhieuKham') ALTER TABLE dbo.[XetNghiem] ADD CONSTRAINT [FK_XetNghiem_PhieuKham_maPhieuKham] FOREIGN KEY ([maPhieuKham]) REFERENCES dbo.[PhieuKham]([maPhieuKham]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_ToaThuoc_PhieuKham_maPhieuKham') ALTER TABLE dbo.[ToaThuoc] ADD CONSTRAINT [FK_ToaThuoc_PhieuKham_maPhieuKham] FOREIGN KEY ([maPhieuKham]) REFERENCES dbo.[PhieuKham]([maPhieuKham]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_ChiTietToaThuoc_ToaThuoc_maToaThuoc') ALTER TABLE dbo.[ChiTietToaThuoc] ADD CONSTRAINT [FK_ChiTietToaThuoc_ToaThuoc_maToaThuoc] FOREIGN KEY ([maToaThuoc]) REFERENCES dbo.[ToaThuoc]([maToaThuoc]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_ChiTietToaThuoc_Thuoc_maThuoc') ALTER TABLE dbo.[ChiTietToaThuoc] ADD CONSTRAINT [FK_ChiTietToaThuoc_Thuoc_maThuoc] FOREIGN KEY ([maThuoc]) REFERENCES dbo.[Thuoc]([maThuoc]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_LichHen_BenhNhan_maBenhNhan') ALTER TABLE dbo.[LichHen] ADD CONSTRAINT [FK_LichHen_BenhNhan_maBenhNhan] FOREIGN KEY ([maBenhNhan]) REFERENCES dbo.[BenhNhan]([maBenhNhan]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_LichHen_NhanVienCSKH_maNhanVien') ALTER TABLE dbo.[LichHen] ADD CONSTRAINT [FK_LichHen_NhanVienCSKH_maNhanVien] FOREIGN KEY ([maNhanVien]) REFERENCES dbo.[NhanVienCSKH]([maNhanVien]);
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name=N'FK_VienPhi_PhieuKham_maPhieuKham') ALTER TABLE dbo.[VienPhi] ADD CONSTRAINT [FK_VienPhi_PhieuKham_maPhieuKham] FOREIGN KEY ([maPhieuKham]) REFERENCES dbo.[PhieuKham]([maPhieuKham]);
GO
IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE name='UX_HoSoBenhAn_maBenhNhan' AND object_id=OBJECT_ID('dbo.HoSoBenhAn')) CREATE UNIQUE INDEX [UX_HoSoBenhAn_maBenhNhan] ON dbo.[HoSoBenhAn]([maBenhNhan]) WHERE [maBenhNhan] IS NOT NULL;
GO
IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE name='UX_ToaThuoc_maPhieuKham' AND object_id=OBJECT_ID('dbo.ToaThuoc')) CREATE UNIQUE INDEX [UX_ToaThuoc_maPhieuKham] ON dbo.[ToaThuoc]([maPhieuKham]) WHERE [maPhieuKham] IS NOT NULL;
GO
IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE name='UX_VienPhi_maPhieuKham' AND object_id=OBJECT_ID('dbo.VienPhi')) CREATE UNIQUE INDEX [UX_VienPhi_maPhieuKham] ON dbo.[VienPhi]([maPhieuKham]) WHERE [maPhieuKham] IS NOT NULL;
GO
-- Dữ liệu mẫu cơ bản (chạy lại không tạo bản ghi trùng)
IF NOT EXISTS(SELECT 1 FROM BenhNhan WHERE maBenhNhan=N'BN001') INSERT INTO BenhNhan(maBenhNhan,hoTen,ngaySinh,diaChi,soDienThoai) VALUES(N'BN001',N'Nguyễn Văn An','2000-05-12',N'Tây Ninh',N'0900000001');
IF NOT EXISTS(SELECT 1 FROM KhoaDieuTri WHERE maKhoa=N'K001') INSERT INTO KhoaDieuTri(maKhoa,tenKhoa,viTri) VALUES(N'K001',N'Khoa nội tổng quát',N'Tầng 1');
IF NOT EXISTS(SELECT 1 FROM BacSi WHERE maBacSi=N'BS001') INSERT INTO BacSi(maBacSi,hoTen,chuyenMon,soDienThoai) VALUES(N'BS001',N'Trần Minh Đức',N'Nội tổng quát',N'0900000002');
IF NOT EXISTS(SELECT 1 FROM NhanVienCSKH WHERE maNhanVien=N'NV001') INSERT INTO NhanVienCSKH(maNhanVien,hoTen,soDienThoai) VALUES(N'NV001',N'Lê Thị Lan',N'0900000003');
IF NOT EXISTS(SELECT 1 FROM HoSoBenhAn WHERE maHoSo=N'HS001') INSERT INTO HoSoBenhAn(maHoSo,maBenhNhan,ngayLap,trangThai) VALUES(N'HS001',N'BN001',GETDATE(),N'Đang theo dõi');
IF NOT EXISTS(SELECT 1 FROM Thuoc WHERE maThuoc=N'T001') INSERT INTO Thuoc(maThuoc,tenThuoc,donViTinh,giaThuoc) VALUES(N'T001',N'Paracetamol 500mg',N'Viên',1500);
IF NOT EXISTS(SELECT 1 FROM PhieuKham WHERE maPhieuKham=N'PK001') INSERT INTO PhieuKham(maPhieuKham,maHoSo,maBacSi,maKhoa,ngayGioKham,trieuChung,thanNhiet,huyetAp,chanDoan) VALUES(N'PK001',N'HS001',N'BS001',N'K001',GETDATE(),N'Đau đầu',37.0,N'120/80',N'Cảm nhẹ');
GO
