

create database QLTuyenSinh
use QLTuyenSinh

create table HoSo (
    MaHoSo int primary key identity,
    HoTen nvarchar(100) not null,
    GioiTinh nvarchar(10),
    NgaySinh date,
    SoDienThoai varchar(15),
    DiaChi nvarchar(255),
    AnhHoSo varbinary(max)
);

create table Users (
    MaHoSo int primary key,
    Account varchar(50) not null,
    Password varchar(50) not null,
    foreign key (MaHoSo) references HoSo(MaHoSo)
);

create table HocBa (
    MaHoSo int,
    DiemKi1Lop10 float,
    DiemKi2Lop10 float,
    DiemKi1Lop11 float,
    DiemKi2Lop11 float,
    DiemKi1Lop12 float,
    DiemKi2Lop12 float,
    HanhKiemCap3 nvarchar(50),
    DiemXetTuyen float,
    foreign key (MaHoSo) references HoSo(MaHoSo)
);

create table Nganh (
    MaNganh int primary key identity,
    MoTa nvarchar(255),
    AnhNganh varbinary(max)
);

create table XetTuyen (
    MaHoSo int,
    MaNganh int,
    DiemXetTuyen float,
    foreign key (MaHoSo) references HoSo(MaHoSo),
    foreign key (MaNganh) references Nganh(MaNganh)
);

create table HoTro (
    MaHoSo int,
    ThongTinYeuCau nvarchar(255),
    ThongTinHoTro nvarchar(255),
    HinhThucHoTro nvarchar(50),
    foreign key (MaHoSo) references HoSo(MaHoSo)
);

create table ThanhToan (
    MaHoSo int,
    SoTienThanhToan decimal(18, 2),
    HinhThucThanhToan nvarchar(50),
    BienLai nvarchar(50),
    foreign key (MaHoSo) references HoSo(MaHoSo)
);
