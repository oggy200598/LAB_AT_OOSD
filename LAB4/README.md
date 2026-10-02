# e-SHOPPING WinForms

Prototype C# WinForms theo .NET Framework 4.7.2, kiến trúc UI → Service/Adapter → Data, sử dụng SQL Server.

## Chức năng

- Đăng ký, đăng nhập khách hàng
- Xem nhóm sản phẩm
- Tìm kiếm sản phẩm
- Xem chi tiết sản phẩm
- Thêm/cập nhật/xóa giỏ hàng
- Đặt hàng
- Tính phí giao hàng theo khu vực và loại giao hàng
- Miễn phí chuyển phát nhanh từ 1.000.000đ
- Miễn phí chuyển phát nhanh trong ngày từ 5.000.000đ
- Thanh toán mô phỏng qua PaymentAdapter
- Ghi nhận đơn hàng, chi tiết đơn hàng và giao dịch thanh toán
- Không có tác nhân/dịch vụ Email theo yêu cầu đã chỉnh sửa

## Chạy project

1. Mở Visual Studio trên Windows.
2. Chọn Open a project or solution và mở `eSHOPPING.csproj`.
3. Mở SQL Server Management Studio.
4. Chạy toàn bộ file `SQL/eSHOPPING.sql`.
5. Mở `App.config` và sửa connection string nếu SQL Server không dùng instance mặc định.
6. Build `eSHOPPING` với .NET Framework 4.7.2.
7. Chạy chương trình.

Tài khoản mẫu:
- Tên đăng nhập: `khachhang`
- Mật khẩu: `123456`

## Giao diện

1. FrmSanPham
2. FrmDangNhap
3. FrmDangKy
4. FrmChiTietSanPham
5. FrmGioHang
6. FrmDatHang
7. FrmThanhToan
8. FrmXacNhanDon
