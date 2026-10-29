# Lab 6 – Quản lý hồ sơ bệnh án – Nguyễn Gia Huy

## Yêu cầu
- Windows 10/11, Visual Studio 2022 với **.NET desktop development** và **.NET Framework 4.8 targeting pack**.
- Microsoft SQL Server (Express hoặc Developer) và SSMS.

## Chạy
1. Mở `Database/QuanLyBenhAn_GiaHuy.sql` trong SSMS và **Execute** để tạo DB `QuanLyBenhAn_GiaHuy` (13 bảng + khóa ngoại + dữ liệu mẫu).
2. Mở `QuanLyBenhAn_GiaHuy.sln` trong Visual Studio 2022.
3. Mở `App.config`, đổi `Data Source=.\SQLEXPRESS` thành instance thực tế (ví dụ `.` hoặc `TENMAY\SQLEXPRESS`). SQL Authentication cần tự đổi chuỗi kết nối.
4. Build Solution, chạy F5. Chọn các chức năng sidebar để xem và CRUD từng bảng.

## Cấu trúc
- `Forms`: `FrmMain`, `FrmDanhSach`, `FrmNhapLieu`, từng Form có `.Designer.cs` để mở **View Designer**.
- `Data/Db.cs`: kết nối SQL Server bằng System.Data.SqlClient.
- `Services/Catalog.cs`: khai báo tên bảng và metadata của 13 bảng (không nhận tên bảng từ người dùng).
- `Services/CrudService.cs`: CRUD tham số hóa.
- `Database`: script T-SQL.
- `App.config`: connection string.

## Khác so với bài Nguyễn Thị Kim Liên
Theo tài liệu Nguyễn Gia Huy: PhieuDangKy (thay DangKyKhamBenh), KhoaDieuTri (thay Khoa), LichHen (thay LichKhamDinhKy), VienPhi (thay ThanhToanVienPhi); thêm NhanVienCSKH và các thông số thanNhiet/huyetAp/tanSuat/thoiGianDung. Thiết kế: sidebar màu xanh ngọc đậm, dashboard dạng thẻ, form nhập liệu riêng.

## Giới hạn / lưu ý
- Đây là **ứng dụng học tập**, chưa có đăng nhập, phân quyền, lưu ảnh nhị phân, in toa thuốc hay quy trình thanh toán thực tế.
- Form danh sách và nhập liệu được tạo linh hoạt từ metadata; bố cục Form nền có thể sửa trong Visual Studio Designer, các trường nhập được tạo động trong `FrmNhapLieu.cs`.
- Quan hệ 'ToaThuoc – ChiTietToaThuoc 1..*' và 'BenhNhan – HoSoBenhAn 1–1' thể hiện về nghiệp vụ; SQL không thể tự ép tối thiểu 1 chi tiết toa ở thời điểm vừa tạo mà không có transaction nghiệp vụ riêng.
- Chưa biên dịch trực tiếp trên máy Windows/Visual Studio trong môi trường tạo file; nếu cấu hình SQL không khớp, hãy sửa `App.config`.
