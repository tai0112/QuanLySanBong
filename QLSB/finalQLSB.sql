create database qlsbmn




use qlsbmn
Go

create table ACCOUNT(
	Username nvarchar(100),
	Password nvarchar(100),
	type int default 0
)

insert into ACCOUNT(Username, Password)
values('nhanvien',123456)
insert into ACCOUNT(Username, Password, type)
values('admin',123456,1)
select * from ACCOUNT


create table LOAISAN(
	MaLoaiSan int IDENTITY(1,1) PRIMARY KEY,
	TenLoaiSan nvarchar(100),
	GiaTien int,
)

Go
create table SAN(
	MaSan int IDENTITY(1,1) PRIMARY KEY,
	MaLoaiSan int,
	TenSan nvarchar(100)
	constraint FK_LOAISAN foreign key(MaLoaiSan) references LOAISAN(MaLoaiSan)
)


Go
create table KHACHHANG(
	MaKH int IDENTITY(1,1) PRIMARY KEY,
	TenKH nvarchar(100),
	DiaChi nvarchar(100),
	DienThoaiKH nvarchar(11)
)





Create table BANGLUONG(
	MaNV int PRIMARY KEY,
	LuongCoBan int,
	Thuong int
)

Create table NHANVIEN(
	MaNV int PRIMARY KEY,
	HoTenNV nvarchar(30),
	DiaChiNV nvarchar(30),
	SDT nvarchar(11),
	constraint FK_BANGLUONG foreign key(MaNV) references BANGLUONG(MaNV)
)



Go
create table DICHVU(
	MaDichVu int IDENTITY(1,1) PRIMARY KEY,
	TenDichVu nvarchar(100),
	GiaTien int
)


Go

create table THUESAN(
	MaThueSan int IDENTITY(1,1) PRIMARY KEY,
	MaKH int,
	MaLoaiSan int,
	MaSan int,
	TenSan nvarchar(100),
	ThoiDiemThue datetime,
	ThoiDiemTra datetime,
	ThanhTien int
	constraint FK_KHACHHANG foreign key(MaKH) references KHACHHANG(MaKH),
	constraint FK_MASAN foreign key(MaSan) references San(MaSan),
)



create table HOADON(
	MaHD int primary key,
	MaKH int,
	MaNV int,
	ThanhTien int,
	constraint FK_KHACHHANG_HD foreign key(MaKH) references KHACHHANG(MaKH),
	constraint FK_MANV_HD foreign key(MaNV) references NHANVIEN(MaNV)
)
--alter table CHITIETHOADON add TenDichVu nvarchar(100)
create table CHITIETHOADON(
	MaHD int,
	MaThueSan int,
	MaLoaiSan int,	
	MaSan int,
	MaDichVu int,
	ThanhTien int,
	NgayTao date,
	SoLuong int,
	TenDichVu nvarchar(100),
	primary key clustered (MaHD ASC, MaDichVu ASC),
	constraint FK_THUESAN_HD foreign key(MaThueSan) references THUESAN(MaThueSan),
	constraint FK_DICHVU foreign key(MaDichVu) references DICHVU(MaDichVu),
	constraint FK_HOADON foreign key(MaHD) references HOADON(MaHD)
)



SELECT * FROM THUESAN

insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH)
values(N'Lê Hữu Tài', N'Hà Nội','0328097858')
insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH)
values(N'Nguyễn Hông Sơn', N'Hà Nội','0328017858')
insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH)
values(N'Nguyễn Hải Nam', N'Hà Nội','0318097858')
insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH)
values(N'Mai Đức Tùng', N'Hà Đông','0328197858')
insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH)
values(N'Mai Anh Toàn', N'Hà Giang','0928197858')
insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH)
values(N'Mai Anh Thư', N'Hà Tây','0928142128')
insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH)
values(N'Nguyễn Minh Khánh', N'Phú Yên','0921462128')
insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH)
values(N'Nguyễn Hải Linh', N'Yên Xá','0328087878')
select * from KHACHHANG

insert into DICHVU(TenDichVu, GiaTien)
values(N'Nước uống',100000)
insert into DICHVU(TenDichVu, GiaTien)
values(N'Thuê bóng',50000)
select * from DICHVU

insert into LOAISAN(TenLoaiSan, GiaTien)
values(N'Sân 5', 50000)
insert into LOAISAN(TenLoaiSan, GiaTien)
values(N'Sân 7', 100000)
insert into LOAISAN(TenLoaiSan, GiaTien)
values(N'Sân 11',150000)
select * from LOAISAN


insert into SAN(MaLoaiSan, TenSan)
VALUES('1',N'Sân 5 - 1')
insert into SAN(MaLoaiSan, TenSan)
VALUES('1',N'Sân 5 - 2');
insert into SAN(MaLoaiSan, TenSan)
VALUES('1',N'Sân 5 - 3');
insert into SAN(MaLoaiSan, TenSan)
VALUES('2',N'Sân 7 - 1');
insert into SAN(MaLoaiSan, TenSan)
VALUES('2',N'Sân 7 - 2');
insert into SAN(MaLoaiSan, TenSan)
VALUES('2',N'Sân 7 - 3');
insert into SAN(MaLoaiSan, TenSan)
VALUES('3',N'Sân 11 - 1');
insert into SAN(MaLoaiSan, TenSan)
VALUES('3',N'Sân 11 - 2');
insert into SAN(MaLoaiSan, TenSan)
VALUES('3',N'Sân 11 - 3');

select * from SAN

insert into BANGLUONG(MaNV,LuongCoBan, Thuong)
values(1, 100000, 0);
insert into BANGLUONG(MaNV, LuongCoBan, Thuong)
values(2, 150000, 0);

select * from BANGLUONG

insert into NHANVIEN(MaNV, HoTenNV, DiaChiNV, SDT)
values(1, N'Mai Đức Anh', N'Hà Nội', '0328097858')
insert into NHANVIEN(MaNV, HoTenNV, DiaChiNV, SDT)
values(2, N'Nguyễn Văn Xuân', N'Hà Giang', '0328093322')
SELECT * FROM NHANVIEN


select * from BANGLUONG

