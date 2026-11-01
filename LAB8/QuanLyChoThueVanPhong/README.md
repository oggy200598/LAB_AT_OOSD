# Bài 4 – Quản lý cho thuê văn phòng ở cao ốc

**Nền tảng:** C# Windows Forms, .NET Framework 4.7.2, SQL Server, ADO.NET. Giao diện chuẩn WinForms, không thư viện UI bên ngoài. Dự án được tạo dựa trên đề Bài 4 và cấu trúc minh họa của dự án QuanLyKhachSan (ảnh), không có mã nguồn gốc của mẫu.

## Chạy trong Visual Studio 2022

1. Giải nén `QuanLyChoThueVanPhong.zip`.
2. Mở `QuanLyChoThueVanPhong.sln` bằng Visual Studio 2022 trên Windows.
3. Kiểm tra đã cài workload **.NET desktop development** và .NET Framework **4.7.2 Targeting Pack**.
4. Cài **SQL Server Express LocalDB** (Visual Studio Installer > Individual components), hoặc SQL Server Express / SQL Server đầy đủ. Mặc định ứng dụng dùng `(localdb)\MSSQLLocalDB` với Windows Authentication.
5. Chọn **Build → Build Solution**, sau đó nhấn **F5**.
6. Nếu kết nối mặc định hoạt động, ứng dụng **tự tạo CSDL và dữ liệu mẫu**. Nếu không, cửa sổ **Kết nối và khởi tạo SQL Server** sẽ xuất hiện; nhập tên máy chủ, chọn kiểu đăng nhập và bấm nút kết nối. Tài khoản SQL Server cần có quyền tạo CSDL cho lần đầu.
7. Khi cửa sổ chính mở, vào các menu Danh mục / Thuê văn phòng / Thanh toán - dịch vụ / Nhân sự - kiểm tra / Báo cáo.

Trường hợp muốn chạy script thủ công: mở `Database/QuanLyChoThueVanPhong.sql` trong SQL Server Management Studio, chọn đúng server rồi **Execute**. Script dùng các lệnh `IF NOT EXISTS` để không tạo trùng bảng và dữ liệu mẫu.

## Thử luồng nghiệp vụ

1. Mở **Danh mục → Phòng**, có sẵn P101, P102, P201; khách hàng KH001, quản lý QL001.
2. Mở **Thuê văn phòng → Ký hợp đồng**. Chọn KH001, QL001, ngày bắt đầu, thời hạn tối thiểu 6 tháng; bấm **Tìm phòng trống**, đánh dấu từ 1 phòng trở lên. Hệ thống tính giá thuê và tiền trả trước 6 tháng.
3. Xác nhận **đã nhận đủ tiền thuê 6 tháng đầu**, chọn tiền mặt/chuyển khoản và bấm **Ký và thu đủ 6 tháng**. Hệ thống ghi hợp đồng, chi tiết nhiều phòng, hóa đơn và thanh toán trong một transaction.
4. Khi đến đầu tháng thứ 7, mở **Thanh toán - dịch vụ → Hóa đơn tiền thuê**, chọn **Lập hóa đơn đến hôm nay**. Mỗi phòng có hóa đơn riêng; vào **Thu tiền** để ghi nhận thanh toán. Để thử nhanh với thời điểm hiện tại, có thể tạo hợp đồng có ngày bắt đầu cách đây từ 6 tháng và phòng vẫn trống trong khoảng chọn.
5. Vào **Ghi nhận sử dụng dịch vụ** để nhập điện, nước, internet cho phòng và tháng sử dụng. Chỉ được lập **Hóa đơn dịch vụ** từ ngày cuối tháng sử dụng trở đi. Vào **Thu tiền** để thanh toán dịch vụ.
6. Vào **Thuê văn phòng → Gia hạn hợp đồng**, chọn phòng, số tháng gia hạn và quản lý. Chỉ được gia hạn tối đa một nửa thời hạn thuê ban đầu; hệ thống từ chối khi còn hóa đơn thuê, dịch vụ chưa thanh toán hoặc lượng dịch vụ chưa lập hóa đơn.
7. Các form còn lại cho phép thêm/sửa/xóa và tra cứu tầng, phòng, khách hàng, dịch vụ, nhân viên, thẻ xe, phiếu kiểm tra, phiếu vi phạm. Kiểm tra quy tắc CSDL khi xóa dữ liệu đã được tham chiếu.

## Mã nguồn

- `Forms/`: Form chính, các màn hình CRUD, hợp đồng, hóa đơn, thanh toán, gia hạn, công nợ, thống kê. Giao diện được dựng bằng WinForms Control từ mã C# nên không yêu cầu `.Designer.cs`.
- `Services/`: kiểm tra nghiệp vụ và giao dịch SQL.
- `Data/`: kết nối, khởi tạo CSDL, sinh mã định danh.
- `Database/`: script SQL Server đầy đủ, có FK, PK, UNIQUE, CHECK và dữ liệu ban đầu.
- `App.config`: chuỗi kết nối mặc định.

## Lưu ý

- Phần mềm chạy **chỉ trên Windows** có .NET Framework 4.7.2+ và một SQL Server tương thích.
- Chưa tích hợp phân quyền tài khoản, xác thực người dùng, xuất hóa đơn PDF hoặc sao lưu tự động. Đây là bản thực hành có nghiệp vụ lõi và CRUD, không phải sản phẩm triển khai thương mại.
- Giao diện được tạo bằng mã C# (không có Designer riêng) để dễ phân phối một Solution chạy trực tiếp; các thuộc tính vẫn chỉnh được trong mã nguồn.
- Hóa đơn tiền thuê từ tháng 7 được lập bằng nút **Lập hóa đơn đến hôm nay**, không có tác vụ chạy nền. Ngày phải thanh toán đặt bằng ngày đầu kỳ thuê.
- Hóa đơn dịch vụ có thể lập vào ngày cuối tháng sử dụng hoặc sau đó; hạn thanh toán ghi ngày cuối tháng sử dụng theo đề. Đây là lịch hạn thanh toán, không tự động thu tiền.
- Một phiếu vi phạm ghi nhận tiền phạt và tình trạng xử lý; tiền phạt hiện chưa được ghi vào sổ thanh toán tiền thuê/dịch vụ.
- Không thể biên dịch/chạy trực tiếp ứng dụng WinForms trong môi trường Linux tạo gói. Cần xác nhận bằng **Build Solution** và chạy trên Visual Studio 2022/Windows.
