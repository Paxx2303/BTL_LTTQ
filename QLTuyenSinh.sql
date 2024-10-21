CREATE DATABASE QLTuyenSinh
USE QLTuyenSinh

CREATE TABLE HoSo (
    MaHoSo VARCHAR(10),
    HoTen NVARCHAR(100),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SoDienThoai VARCHAR(15),
    DiaChi NVARCHAR(200),
    AnhHoSo NVARCHAR(255)
);

CREATE TABLE HocBa (
    MaHoSo VARCHAR(10),
    DiemKi1Lop10 FLOAT,
    DiemKi2Lop10 FLOAT,
    DiemKi1Lop11 FLOAT,
    DiemKi2Lop11 FLOAT,
    DiemKi1Lop12 FLOAT,
    DiemKi2Lop12 FLOAT,
    HanhKiemCap3 NVARCHAR(50),
    DiemXetTuyen FLOAT
);

CREATE TABLE HoTro (
    MaHoSo VARCHAR(10),
    ThongTinYeuCau NVARCHAR(255),
    ThongTinHoTro NVARCHAR(255),
    HinhThucHoTro NVARCHAR(100)
);

CREATE TABLE ThanhToan (
    MaHoSo VARCHAR(10),
    SoTienThanhToan DECIMAL(10, 2),
    HinhThucThanhToan NVARCHAR(100),
    BienLai NVARCHAR(255)
);

CREATE TABLE XetTuyen (
    MaHoSo VARCHAR(10),
    MaNganh VARCHAR(10),
    DiemXetTuyen FLOAT
);

CREATE TABLE Users (
    MaHoSo VARCHAR(10),
    Account NVARCHAR(50),
    Password NVARCHAR(255)
);

CREATE TABLE Nganh (
    MaNganh VARCHAR(10),
    MoTa NVARCHAR(255),
    AnhNganh NVARCHAR(255)
);

