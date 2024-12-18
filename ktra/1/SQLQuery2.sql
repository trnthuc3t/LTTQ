CREATE DATABASE QuanLyKhachHang;
--drop DATABASE QuanLyKhachHang
USE QuanLyKhachHang;

CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY,        
    HoTenKhachhang NVARCHAR(100),       -- Họ tên khách hàng, kiểu chuỗi có độ dài tối đa 100 ký tự
    DiaChi NVARCHAR(200),        -- Địa chỉ, kiểu chuỗi có độ dài tối đa 200 ký tự
    NgayChotSo datetime,             -- Ngày chốt số, kiểu ngày tháng
    SoThangTruoc INT,            -- Số tháng trước, kiểu INT
    SoThangNay INT               -- Số tháng này, kiểu INT
);
INSERT INTO KhachHang (MaKhachHang, HoTenKhachhang, DiaChi, NgayChotSo, SoThangTruoc, SoThangNay)
VALUES 
(1, N'Nguyễn Văn A', N'123 Đường Lê Lợi, Quận 1, TP.HCM', '2024-10-01', 50, 55),
(2, N'Trần Thị B', N'456 Đường Trần Hưng Đạo, Quận 5, TP.HCM', '2024-10-02', 60, 65),
(3, N'Lê Minh C', N'789 Đường Nguyễn Trãi, Quận 3, TP.HCM', '2024-10-03', 45, 50),
(4, N'Phạm Văn D', N'12 Đường Võ Thị Sáu, Quận 2, TP.HCM', '2024-10-04', 40, 48),
(5, N'Hoàng Thị E', N'987 Đường Hoàng Diệu, Quận 7, TP.HCM', '2024-10-05', 70, 75);

SELECT * FROM KhachHang