# COMP1019 - Lập trình trên Windows | Bài Lab 01

## Ứng dụng Thông tin cá nhân (Windows Forms App - C#)

Dự án bài tập thực hành Lab 01 xây dựng ứng dụng Windows Forms cho phép nhập, kiểm tra và hiển thị thông tin cá nhân của sinh viên theo chuẩn yêu cầu môn học.

---

### 1. Mục tiêu và Yêu cầu
- Khởi tạo project Windows Forms App với C# (.NET 8.0 Windows).
- Thiết kế giao diện đầy đủ các controls cơ bản: `Label`, `TextBox`, `Button`, `RadioButton`, `ComboBox`, `GroupBox`.
- Đặt tên controls chuẩn theo quy ước (`lblTitle`, `txtHoTen`, `txtNamSinh`, `txtEmail`, `radNam`, `radNu`, `cboKhoa`, `btnHienThi`, `btnXoa`, `btnThoat`, `txtKetQua`).
- Kiểm tra tính hợp lệ dữ liệu nhập (Validation):
  - Họ tên: Không được để trống.
  - Năm sinh: Không để trống, phải là số nguyên, từ 1900 đến năm hiện tại.
  - Email: Không để trống, đúng định dạng email chuẩn.
  - Giới tính: Bắt buộc chọn Nam hoặc Nữ.
  - Khoa/Lớp: Bắt buộc chọn từ danh sách.
- Xử lý các chức năng:
  - **Hiển thị**: Kiểm tra hợp lệ, tính tuổi (`Năm hiện tại - Năm sinh`), hiển thị kết quả lên giao diện và hiển thị hộp thoại `MessageBox`.
  - **Xóa**: Đưa tất cả các ô nhập liệu về rỗng, bỏ chọn giới tính, reset ComboBox, xóa kết quả và đặt lại focus vào ô Họ tên.
  - **Thoát**: Hỏi xác nhận người dùng qua hộp thoại `MessageBox` trước khi đóng chương trình (áp dụng cho cả nút Thoát và nút Đóng trên thanh tiêu đề).

---

### 2. Danh sách Control trên Giao diện

| STT | Control | Tên Control | Chức năng |
|:---:|:---|:---|:---|
| 1 | Label | `lblTitle` | Tiêu đề chương trình ("ỨNG DỤNG THÔNG TIN CÁ NHÂN") |
| 2 | TextBox | `txtHoTen` | Nhập họ và tên sinh viên |
| 3 | TextBox | `txtNamSinh` | Nhập năm sinh |
| 4 | TextBox | `txtEmail` | Nhập địa chỉ email |
| 5 | RadioButton | `radNam`, `radNu` | Lựa chọn giới tính Nam / Nữ (nhóm trong GroupBox `grpGioiTinh`) |
| 6 | ComboBox | `cboKhoa` | Chọn khoa/lớp học (có sẵn nhiều lựa chọn mặc định) |
| 7 | Button | `btnHienThi` | Xử lý kiểm tra dữ liệu và hiển thị thông tin |
| 8 | Button | `btnXoa` | Xóa trắng dữ liệu đã nhập và đưa về mặc định |
| 9 | Button | `btnThoat` | Thoát chương trình có hộp thoại xác nhận |
| 10 | TextBox / Label | `txtKetQua` | Hiển thị kết quả thông tin tổng hợp |

---

### 3. Hướng dẫn mở và chạy ứng dụng

#### Cách 1: Sử dụng Visual Studio
1. Mở file `Lab_01.sln` bằng Visual Studio 2022 (hoặc phiên bản mới hơn).
2. Nhấn `F5` hoặc nút **Start** để biên dịch và chạy ứng dụng.

#### Cách 2: Sử dụng dòng lệnh (.NET CLI)
```bash
# Di chuyển vào thư mục project
cd Lab_01

# Chạy ứng dụng
dotnet run
```
