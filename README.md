# 🐾 Quản Lý Thú Cưng - WinForms C#

## 📌 Giới thiệu dự án

Đây là dự án quản lý cửa hàng/chăm sóc thú cưng được xây dựng bằng:

- C#
- WinForms
- SQL Server

Dự án hỗ trợ:

- Quản lý khách hàng
- Quản lý thú cưng
- Quản lý dịch vụ
- Lập hóa đơn
- Tìm kiếm dữ liệu
- Thống kê cơ bản

---

# 🛠 Công nghệ sử dụng

- C# WinForms (.NET Framework)
- SQL Server
- ADO.NET
- GitHub

---

# 📂 Cấu trúc project

```txt
QuanLyThuCung
│
├── GUI
│   ├── Main
│   ├── KhachHang
│   ├── ThuCung
│   ├── DichVu
│   └── HoaDon
│
├── DTO
│
├── DAL
│
├── BLL
│
├── Database
│
├── Resources
│
├── Utils
│
├── App.config
│
└── Program.cs
```

---

# 📖 Chức năng từng thư mục

## GUI

Chứa toàn bộ giao diện WinForms.

### Main
- frmMain
- frmDashboard

### KhachHang
Quản lý khách hàng:
- thêm
- sửa
- xóa
- tìm kiếm

### ThuCung
Quản lý thú cưng.

### DichVu
Quản lý dịch vụ chăm sóc thú cưng.

### HoaDon
Quản lý:
- lập hóa đơn
- lịch sử hóa đơn
- chi tiết hóa đơn

---

## DTO

Chứa các class đối tượng dữ liệu.

Ví dụ:
- KhachHangDTO
- ThuCungDTO

---

## DAL

Data Access Layer.

Chứa:
- kết nối database
- query SQL
- CRUD dữ liệu

---

## BLL

Business Logic Layer.

Xử lý:
- logic nghiệp vụ
- validation
- tính toán dữ liệu

---

## Database

Chứa file SQL:
- create database
- create table
- sample data

---

## Resources

Chứa:
- icon
- hình ảnh
- tài nguyên giao diện

---

## Utils

Chứa:
- hàm dùng chung
- validate
- format dữ liệu

---

# 🗄 Database

Database sử dụng:

- SQL Server

File script:

```txt
Database/script.sql
```

---

# 🚀 Cách chạy project

## 1. Clone project

```bash
git clone https://github.com/ngovan960/quan_ly_thu_cung.git
```

---

## 2. Tạo database

Mở:

```txt
Database/script.sql
```

bằng SQL Server Management Studio và Execute.

---

## 3. Mở project bằng Visual Studio

Mở file:

```txt
QuanLyThuCung.sln
```

---

## 4. Chạy project

Nhấn:

```txt
F5
```

---

# 👨‍💻 Thành viên nhóm

- Thành viên 1: Vuong Khanh Ly
- Thành viên 2: Ngo Van Hieu

---

# 📌 Ghi chú

Dự án được xây dựng phục vụ mục đích học tập và thực hành WinForms + SQL Server.
