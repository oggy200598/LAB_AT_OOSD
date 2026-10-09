# QUẢN LÝ CÔNG TY DU LỊCH

## 1. Giới thiệu

**Quản lý công ty du lịch** là ứng dụng desktop hỗ trợ quản lý các hoạt động nghiệp vụ của công ty du lịch, bao gồm quản lý danh mục, tour du lịch, chuyến khách lẻ, đăng ký khách lẻ, đăng ký đoàn khách, phân công hướng dẫn viên, khảo sát khách hàng, tính lương và thống kê doanh thu.

Ứng dụng được xây dựng bằng C# Windows Forms, sử dụng SQL Server để lưu trữ dữ liệu và ADO.NET để thực hiện các thao tác truy vấn, thêm, sửa và xóa dữ liệu.

## 2. Công nghệ sử dụng

- **Ngôn ngữ:** C#
- **Giao diện:** Windows Forms
- **Nền tảng:** .NET Framework 4.7.2
- **Cơ sở dữ liệu:** Microsoft SQL Server / LocalDB
- **Kết nối cơ sở dữ liệu:** ADO.NET (`System.Data.SqlClient`)
- **Công cụ phát triển:** Visual Studio hoặc Visual Studio Code
- **Công cụ quản lý cơ sở dữ liệu:** SQL Server Management Studio (SSMS) hoặc extension SQL Server (mssql) trong VS Code.

## 3. Chức năng hệ thống

| Form | Chức năng |
|---|---|
| `FrmMain` | Hiển thị menu chức năng và kiểm tra kết nối SQL Server. |
| `FrmDanhMuc` | Quản lý phương tiện, điểm bán vé, hướng dẫn viên và điểm tham quan. |
| `FrmTour` | Quản lý thông tin tour du lịch. |
| `FrmChuyenLe` | Xem, thêm và xóa chuyến khách lẻ. |
| `FrmDangKyLe` | Đăng ký khách lẻ và thanh toán vé. |
| `FrmDangKyDoan` | Đăng ký đoàn khách và quản lý tiền đặt cọc. |
| `FrmPhanCongHDV` | Phân công hướng dẫn viên và kiểm tra trùng lịch. |
| `FrmKetThucKhaoSat` | Lưu thông tin kết thúc tour và khảo sát khách hàng. |
| `FrmLuongThongKe` | Tính lương hướng dẫn viên, thống kê doanh thu và tour. |

## 4. Cấu trúc dự án

```text
QuanLyCongTyDuLich/
├── Data/
│   └── Db.cs
├── Database/
│   └── QuanLyCongTyDuLich.sql
├── Forms/
│   ├── FrmMain.cs
│   ├── FrmDanhMuc.cs
│   ├── FrmTour.cs
│   ├── FrmChuyenLe.cs
│   ├── FrmDangKyLe.cs
│   ├── FrmDangKyDoan.cs
│   ├── FrmPhanCongHDV.cs
│   ├── FrmKetThucKhaoSat.cs
│   └── FrmLuongThongKe.cs
├── Services/
│   ├── TourService.cs
│   ├── DanhMucService.cs
│   ├── ChuyenLeService.cs
│   ├── DangKyLeService.cs
│   ├── DangKyDoanService.cs
│   ├── PhanCongService.cs
│   └── ThongKeService.cs
├── App.config
├── Program.cs
├── QuanLyCongTyDuLich.csproj
├── QuanLyCongTyDuLich.sln
└── README.md
```

## 5. Yêu cầu môi trường

Trước khi chạy dự án, cần chuẩn bị:

1. Windows có hỗ trợ chạy ứng dụng Windows Forms trên .NET Framework 4.7.2.
2. .NET Framework 4.7.2 Developer Pack hoặc môi trường build tương thích.
3. Visual Studio có workload .NET desktop development hoặc Visual Studio Build Tools có MSBuild và các thành phần cần thiết.
4. SQL Server hoặc SQL Server LocalDB.
5. Visual Studio Code nếu muốn chỉnh sửa mã nguồn bằng VS Code.

## 6. Cài đặt cơ sở dữ liệu

### Bước 1: Mở script SQL

Mở file:

```text
Database/QuanLyCongTyDuLich.sql
```

Sử dụng SQL Server Management Studio hoặc extension SQL Server trong VS Code để kết nối đến SQL Server.

### Bước 2: Tạo cơ sở dữ liệu

Thực thi script SQL để tạo cơ sở dữ liệu, các bảng và dữ liệu mẫu theo nội dung của script.

**Lưu ý:** Script có lệnh `DROP TABLE` để tạo lại cấu trúc. Cần sao lưu dữ liệu trước khi chạy lại để tránh mất dữ liệu hiện có.

## 7. Cấu hình kết nối SQL Server

Mở file `App.config` và kiểm tra chuỗi kết nối.

Ví dụ với SQL Server Express:

```xml
<connectionStrings>
  <add name="QuanLyCongTyDuLichDB"
       connectionString="Server=.\SQLEXPRESS;Database=QuanLyCongTyDuLich;Trusted_Connection=True;TrustServerCertificate=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Nếu sử dụng LocalDB, có thể cấu hình theo ví dụ sau:

```xml
<connectionStrings>
  <add name="QuanLyCongTyDuLichDB"
       connectionString="Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True;Connect Timeout=30;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Chỉ sử dụng chuỗi kết nối phù hợp với instance SQL Server đã cài đặt. Tên connection string trong `App.config` phải khớp với tên mà lớp `Db.cs` sử dụng.

## 8. Chạy dự án bằng Visual Studio Code

### Bước 1: Mở dự án

Giải nén mã nguồn và mở thư mục chứa file `QuanLyCongTyDuLich.sln` bằng VS Code.

### Bước 2: Kiểm tra môi trường build

Mở Terminal trong VS Code và kiểm tra MSBuild:

```powershell
msbuild -version
```

Nếu lệnh không được nhận diện, hãy cài Visual Studio Build Tools hoặc Visual Studio có các thành phần build cần thiết, sau đó mở terminal đã được cấu hình môi trường build.

### Bước 3: Build solution

Chạy tại thư mục chứa file solution:

```powershell
msbuild QuanLyCongTyDuLich.sln /p:Configuration=Debug
```

Nếu build thành công, file thực thi thường nằm tại:

```text
bin/Debug/QuanLyCongTyDuLich.exe
```

### Bước 4: Chạy ứng dụng

Chạy ứng dụng từ Terminal:

```powershell
.\bin\Debug\QuanLyCongTyDuLich.exe
```

Có thể mở trực tiếp file `.exe` bằng File Explorer.

### Bước 5: Kiểm tra kết nối cơ sở dữ liệu

Trong giao diện chính, chọn chức năng kiểm tra kết nối SQL. Nếu kết nối thành công, ứng dụng sẽ hiển thị thông báo và tên cơ sở dữ liệu hiện tại.

## 9. Quy tắc nghiệp vụ cần lưu ý

- Khách lẻ: theo quy tắc đang được áp dụng trong bộ khung, số lượng khách từ 1 đến 11 người.
- Khách đoàn: theo quy tắc đang được áp dụng trong bộ khung, số lượng khách từ 13 người trở lên.
- Phân công hướng dẫn viên cần kiểm tra điều kiện trùng lịch theo nghiệp vụ.
- Khách đoàn phải đặt cọc theo quy định của hệ thống.
- Việc thanh toán và khảo sát cần tuân thủ các điều kiện nghiệp vụ được triển khai trong service.

**Lưu ý:** Trường hợp đúng 12 khách chưa được quy định rõ trong bài toán nguồn. Cần xác nhận quy tắc với yêu cầu môn học trước khi thay đổi cách xử lý.

## 10. Kiểm thử

Dự án có danh sách 24 test case để kiểm tra các nghiệp vụ chính, bao gồm:

- Quản lý danh mục và tour.
- Quản lý chuyến khách lẻ.
- Đăng ký khách lẻ và đăng ký đoàn.
- Kiểm tra số lượng khách, đặt cọc và danh sách bảo hiểm.
- Hủy đoàn.
- Phân công hướng dẫn viên và kiểm tra trùng lịch.
- Thanh toán đoàn.
- Khảo sát và ghi nhận góp ý.
- Tính lương và thống kê.

Sau khi chạy từng test case, ghi lại kết quả thực tế và đánh dấu `Pass` hoặc `Fail`. Chỉ đánh dấu `Pass` khi kết quả thực tế phù hợp với kết quả mong đợi.

## 11. Xử lý sự cố thường gặp

| Sự cố | Hướng xử lý |
|---|---|
| Không kết nối được SQL Server | Kiểm tra instance, trạng thái dịch vụ SQL Server và chuỗi kết nối trong `App.config`. |
| Không tìm thấy cơ sở dữ liệu | Thực thi script SQL và kiểm tra đúng tên `QuanLyCongTyDuLich`. |
| Lệnh `msbuild` không chạy | Kiểm tra cài đặt Build Tools và cấu hình môi trường terminal. |
| Build lỗi không tìm thấy file `.cs` | Kiểm tra cấu trúc thư mục, tên file và đường dẫn `Compile Include` trong file `.csproj`. |
| Không thể ghi đè file `.exe` khi build | Đóng ứng dụng đang chạy, kiểm tra tiến trình còn tồn tại rồi build lại. |
| Chức năng báo lỗi SQL | Kiểm tra bảng, cột, khóa và dữ liệu trong script SQL có khớp với câu truy vấn của service hay không. |

## 12. Lưu ý khi sử dụng

- Sao lưu cơ sở dữ liệu trước khi chạy lại script khởi tạo.
- Kiểm tra kết nối trước khi thực hiện các nghiệp vụ.
- Kiểm thử các trường hợp hợp lệ và không hợp lệ trước khi nghiệm thu.
- Cần chạy thử trong môi trường thực tế để xác nhận các chức năng hoạt động đúng yêu cầu.

## 13. Tác giả

Đề tài: **Quản lý công ty du lịch**

Công nghệ: C# Windows Forms, .NET Framework 4.7.2, SQL Server và ADO.NET.
