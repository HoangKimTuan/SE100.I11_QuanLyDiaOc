create database QuanLyDiaOc
go
use QuanLyDiaOc
go

create table KhachHang
(
	ID int identity(1,1) not null primary key clustered,
	MaKH as 'KH' + RIGHT('000' + CAST(ID as varchar(5)), 5) persisted,
	TenKH nvarchar(100) not null,
	GioiTinh nvarchar(3) not null,
	NamSinh smallint,
	DiaChi nvarchar(200) not null,
	SDT nvarchar(20) not null,
	Email nvarchar(20)
)

create table DIAOC
(	
	MaDO nchar(10) primary key not null,
	MaKH nchar(10) not null,
	MaLoaiDiaOC nchar(10) not null,
	SoNha int,
	Duong nvarchar(50),
	Phuong nvarchar(50),
	Quan nvarchar(50),
	DienTichDat numeric(18,2),
	DienTichXayDung numeric(18,2),
	Huong nvarchar(100),
	ViTri nvarchar(100),
	MoTaChiTiet nvarchar(100),
	MoTaTomTat nvarchar(50),
	HinhAnh bit,
	TrangThai nvarchar(50),
)

create table LoaiDiaOc
(
	MaLoaiDiaOc nchar(10) primary key not null,
	TenLoaiDiaOc nvarchar(50),
)

create table PhieuDangKy
(
	SoPDK nchar(10) primary key not null,
	NgayDangKy date not null,
	NgayGioHenChup datetime,
	NgayGioChupAnh datetime,
	MaDO nchar(10) not null,
)

create table GiayTo 
(
	MaGiayTo nchar(10) primary key not null,
	GiayPhepXayDung bit,
	GiayPhepHoanCong bit,
	GiayChungNhanSoHuuNha bit,
	SoDo bit,
	HopDongMuaBan bit,
)

create table PhieuThu
(
	SoPT nchar(10) primary key not null,
	SoPDK nchar(10) not null,
	NgayThu date not null,
	SoPTDauTien nchar(10),
	TuNgay date,
	DenNgay date,
	SoTienThu money,
)

create table ToBuom
(
	MaToBuom nchar(10) primary key not null,
	SoPDK nchar(10) not null,
	DonGia money,
	SoLuongPhatHanh Int,
	ThanhTien Money,
)

Create table QC_TrenBang
(
	MaQCBang nchar(10) primary key not null,
	SoPDK nchar(10) not null,
	MaBang nchar(10) not null,
	NoiDung nvarchar(100),
	DonGia Money,
	TinhTrang Bit,
)

create table LoaiBang
(
	MaLoaiBang nchar(10) primary key not null,
	TenLoaiBang nvarchar(50) not null,
	DonGia Money,
)

create table Bang
(
	MaBang nchar(10) primary key not null,
	MaLoaiBang nchar(10) not null,
	ViTriVi nvarchar(50),
)

create table QC_TrenBao
(
	MaQCTrenBao nchar(10) primary key not null,
	SoPDK nchar(10),
	MaBao nchar(10),
	CoHinhAnh bit,
	NoiDung nvarchar(100),
	DonGia money,
	SoKy int,
	KyBatDau int,
	ThanhTien money,
	TinhTrang bit,
)

create table Bao
(
	MaBao nchar(10) primary key not null,
	TenBao nvarchar(50),
	ThuPhatHanh nvarchar(20),
)

create table ThamSo
(
	TenThamSo nvarchar(100) not null,
	GiaTri nvarchar(100) not null,
)

create table NguoiDung
(
	MaNguoiDung nchar(5) not null,
	TenNguoiDung nvarchar(30) not null,
	MatKhau nvarchar(25) not null,
	MaLoaiNguoiDung nchar(5) not null,
)

create table LoaiNguoiDung
(
	MaLoaiNguoiDung nchar(5) not null,
	LoaiNguoiDung nvarchar(30) not null,
	MoTa nvarchar(100),
)

CREATE PROC sp_NguoiDung_LayDanhSach
@user nvarchar(30),
@pass nvarchar(25)

AS
	SELECT MaNguoiDung FROM NguoiDung WHERE TenNguoiDung=@user AND MatKhau=@pass
GO

CREATE PROC sp_NguoiDung_LoaiNguoiDung_LayLoaiNguoiDung
@user nvarchar(30)

AS
	SELECT LoaiNguoiDung FROM NguoiDung, LoaiNguoiDung WHERE TenNguoiDung=@user AND NguoiDung.MaLoaiNguoiDung=LoaiNguoiDung.MaLoaiNguoiDung
GO

CREATE PROC sp_KhachHang_LayDanhSach

AS
	SELECT MaKH, TenKH, GioiTinh, NamSinh, DiaChi, SDT, Email FROM KhachHang
GO

CREATE PROC sp_KhachHang_Them
 @ten nvarchar(100),
 @gioitinh nvarchar(3),
 @namsinh smallint,
 @diachi nvarchar(200),
 @sdt nvarchar(20),
 @email nvarchar(20)

AS
	INSERT INTO KhachHang VALUES(@ten, @gioitinh, @namsinh, @diachi, @sdt, @email)
GO






INSERT INTO NguoiDung VALUES('ND001', 'HoangKimTuan', '123456', 'LND01')
INSERT INTO LoaiNguoiDung VALUES('LND01', 'admin', 'All role')
INSERT INTO KhachHang VALUES(N'Nguyễn Văn A', N'Nam', 1990, N'Thủ Đức', '0123654987', 'nguyenvana@gmail.com')










alter table Bang
add constraint FK_Bang_LoaiBang
foreign key (MaLoaiBang)
references LoaiBang(MaLoaiBang)

alter table QC_TrenBang
add constraint FK_QCBang_Bang
foreign key (MaBang)
references Bang(MaBang)

alter table QC_TrenBao
add constraint FK_QCBao_Bao
foreign key (MaBao)
references Bao(MaBao)

alter table ToBuom
add constraint FK_ToBuom_PhieuDangKy
foreign key (SoPDK)
references PhieuDangKy(SoPDK)

alter table QC_TrenBao
add constraint FK_QCBao_PhieuDangKy
foreign key (SoPDK)
references PhieuDangKy(SoPDK)

alter table QC_TrenBang
add constraint FK_QCBang_PhieuDangKy
foreign key (SoPDK)
references PhieuDangKy(SoPDK)

alter table PhieuDangKy
add constraint FK_PhieuDangKy_DiaOc
foreign key (MaDO)
references DiaOc(MaDO)

alter table PhieuThu
add constraint FK_PhieuThu_PhieuDangKy
foreign key (SoPDK)
references PhieuDangKy(SoPDK)

alter table DiaOc
add constraint FK_DiaOc_KhachHang
foreign key (MaKH)
references KhachHang(MaKH)

alter table DiaOc
add constraint FK_DiaOc_LoaiDiaOc
foreign key (MaLoaiDiaOc)
references LoaiDiaOc(MaLoaiDiaOc)

alter table GiayTo
add constraint FK_DiaOc_GiayTo
foreign key (MaGiayTo)
references DiaOc(MaDO)

ALTER TABLE KhachHang 
ADD CONSTRAINT CK_KH_SDT 
CHECK (SDT in ('0','1','2','3','4','5','6','7','8','9'))

ALTER TABLE PhieuDangKy 
ADD CONSTRAINT CK_PDK_NgayDK 
CHECK (Year(NgayDangKy) > 0 and (month(NgayDangKy) between 0 and 12) and (day(NgayDangKy) between 0 and 31))
