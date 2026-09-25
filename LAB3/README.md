# LAB 3 - HỆ THỐNG QUẢN LÝ KHÁCH SẠN

## 1. Thông tin bài

| Nội dung | Thông tin |
|---|---|
| Họ và tên | Nguyễn Gia Huy |
| MSSV | 1250080071 |
| Tên bài Lab | LAB 3 |
| Đề tài | Hệ thống quản lý khách sạn |
| Ngôn ngữ | C# |
| Nền tảng | Windows Forms |
| Cơ sở dữ liệu | SQL Server |
| IDE | Visual Studio 2022 |
| .NET | .NET Framework 4.7.2 |

## 2. Môi trường và phiên bản

- Visual Studio 2022
- C#
- Windows Forms
- .NET Framework 4.7.2
- SQL Server / SQL Server LocalDB
- ADO.NET
- Windows

## 3. Nội dung đã thực hiện

Hệ thống được xây dựng theo mô hình WinForms, kết nối SQL Server và triển khai các nghiệp vụ chính:

- Quản lý khu vực
- Quản lý nhân viên
- Quản lý loại tiện nghi
- Quản lý tiện nghi
- Quản lý phòng
- Quản lý dịch vụ
- Quản lý quy định đền bù
- Quản lý khách hàng
- Đặt phòng
- Nhận phòng
- Quản lý người lưu trú
- Lắp đặt/luân chuyển tiện nghi
- Ghi nhận dịch vụ
- Lập phiếu đền bù
- Lập hóa đơn
- Thanh toán
- Trả phòng
- Thống kê

## 4. Cấu trúc project

```text
QuanLyKhachSan/
├── Data/
├── Forms/
├── Properties/
├── Services/
├── App.config
├── Program.cs
├── QuanLyKhachSan.csproj
└── QuanLyKhachSan.sln
```

## 5. Các Form chính

| Form | Chức năng |
|---|---|
| `FrmMain` | Màn hình chính, điều hướng |
| `FrmDanhMuc` | Quản lý danh mục |
| `FrmDatPhong` | Khách hàng, đặt phòng, nhận phòng |
| `FrmPhongTienNghi` | Phòng, tiện nghi, lắp đặt |
| `FrmDichVu` | Ghi nhận dịch vụ |
| `FrmTraPhong` | Đền bù, hóa đơn, thanh toán, trả phòng |
| `FrmThongKe` | Thống kê |

## 6. Cơ sở dữ liệu

File:

```text
Data.sql
```

File SQL dùng để tạo database, bảng, khóa chính, khóa ngoại, ràng buộc và dữ liệu mẫu phục vụ chương trình.

Các nhóm dữ liệu chính:

- Khu vực
- Phòng
- Nhân viên
- Khách hàng
- Loại tiện nghi
- Tiện nghi
- Phiếu lắp đặt
- Phiếu đặt phòng
- Chi tiết đặt phòng
- Người lưu trú
- Dịch vụ
- Phiếu sử dụng dịch vụ
- Chi tiết sử dụng dịch vụ
- Quy định đền bù
- Phiếu đền bù
- Chi tiết đền bù
- Hóa đơn
- Thanh toán

## 7. Kết quả thực hiện

- Hoàn thành solution WinForms quản lý khách sạn.
- Hoàn thành các Form nghiệp vụ chính.
- Kết nối chương trình với SQL Server.
- Hoàn thành các chức năng đặt phòng, nhận phòng, dịch vụ, đền bù, hóa đơn, thanh toán, trả phòng và thống kê.
- Hoàn thành bộ Test Case.
- Hoàn thành tài liệu thiết kế UML và báo cáo Word.

## 8. Kiểm thử

File kiểm thử:

```text
TestCase_QuanLyKhachSan.xlsx
```

Bộ Test Case gồm các nội dung kiểm tra chính:

- Kiểm tra sức chứa phòng
- Kiểm tra trùng lịch đặt phòng
- Kiểm tra trùng thiết bị trong cùng ngày
- Kiểm tra nhận phòng
- Kiểm tra số lượng người lưu trú
- Kiểm tra cộng dồn dịch vụ trong ngày
- Kiểm tra phiếu đang ở khi ghi dịch vụ
- Kiểm tra đền bù
- Kiểm tra lập hóa đơn
- Kiểm tra thanh toán một phần
- Kiểm tra thanh toán đủ
- Kiểm tra điều kiện trả phòng
- Kiểm tra thống kê

## 9. Một số lỗi gặp và cách khắc phục

### Lỗi trùng class `KetQuaXuLy`

Nguyên nhân: tồn tại nhiều định nghĩa `KetQuaXuLy` trong namespace `QuanLyKhachSan.Models`.

Cách khắc phục:

- Xóa định nghĩa bị trùng.
- Chỉ giữ một class `KetQuaXuLy`.
- Rebuild Solution sau khi chỉnh sửa.

### Lỗi kết nối SQL Server

Nguyên nhân: chuỗi kết nối trong `App.config` không phù hợp với máy chạy chương trình.

Cách khắc phục:

- Kiểm tra `Data Source`.
- Kiểm tra database đã được tạo.
- Kiểm tra SQL Server/LocalDB đang hoạt động.
- Chạy lại `Data.sql` nếu database chưa tồn tại.

### Lỗi build sau khi chỉnh sửa Form

Cách khắc phục:

```text
Build
→ Clean Solution
→ Rebuild Solution
```

Kiểm tra lại tên control và event trong các file `.Designer.cs` và `.cs`.

## 10. Hướng dẫn giảng viên kiểm tra và chạy lại

### Bước 1: Tạo database

Mở SQL Server Management Studio hoặc SQL Server Object Explorer.

Chạy file:

```text
Data.sql
```

### Bước 2: Kiểm tra cấu hình kết nối

Mở:

```text
QuanLyKhachSan/App.config
```

Kiểm tra chuỗi kết nối database.

Ví dụ:

```xml
<connectionStrings>
  <add
    name="QuanLyKhachSanDB"
    connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True"
    providerName="System.Data.SqlClient" />
</connectionStrings>
```

### Bước 3: Mở Solution

Mở:

```text
QuanLyKhachSan/QuanLyKhachSan.sln
```

bằng Visual Studio 2022.

### Bước 4: Build

Chọn:

```text
Build → Rebuild Solution
```

Kiểm tra cửa sổ Error List không còn lỗi biên dịch.

### Bước 5: Chạy chương trình

Nhấn:

```text
Ctrl + F5
```

hoặc:

```text
Debug → Start Without Debugging
```

### Bước 6: Kiểm tra các chức năng

Từ `FrmMain`, kiểm tra lần lượt:

```text
Danh mục
→ Phòng - Tiện nghi
→ Đặt / Nhận phòng
→ Sử dụng dịch vụ
→ Trả phòng - Thanh toán
→ Thống kê
```

## 11. Tài liệu và sản phẩm nộp

```text
LAB3/
├── QuanLyKhachSan/
├── 1250080071_NguyenGiaHuy_Lab3.docx
├── Data.sql
├── TestCase_QuanLyKhachSan.xlsx
└── README.md
```

Trong báo cáo Word có các nội dung thiết kế:

- Use Case
- Sequence Diagram
- Detailed Class Diagram
- Class Diagram theo chức năng
- Activity Diagram
- Kiến trúc hệ thống
- Sơ đồ điều hướng Form

## 12. Tác giả

**Nguyễn Gia Huy - 1250080071**

**LAB 3 - Hệ thống quản lý khách sạn**
