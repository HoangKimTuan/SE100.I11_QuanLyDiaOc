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

create table DiaOc
(	
	ID int identity(1,1) not null primary key clustered,
	MaDO as 'DO' + RIGHT('000' + CAST(ID as varchar(5)), 5) persisted,
	MaKH varchar(10) not null,
	MaLoaiDO varchar(10) not null,
	DiaChi nvarchar(200),
	DienTichKhuonVien numeric(18,2),
	DienTichSuDung numeric(18,2),
	HuongNha nvarchar(100),
	ViTri nvarchar(100),
	MoTaChiTiet nvarchar(100),
	GiaBan money,
	HinhAnh bit,
	TrangThai nvarchar(50),
)

create table LoaiDiaOc
(
	ID int identity(1,1) not null primary key clustered,
	MaLoaiDO as 'LDO' + RIGHT('00' + CAST(ID as varchar(5)), 5) persisted,
	TenLoaiDO nvarchar(50),
)

create table PhieuDangKy
(
	SoPDK nchar(10) primary key not null,
	MaQCTrenBao nchar(10),
	MaQCTrenBang nchar(10),
	MaQCToBuom nchar(10),
	MaDO nchar(10) not null,
	MaKH nchar(10) not null,
	NgayDangKy date,
	NgayKetThuc date,
	SoLanGiaHan int,
)

create table GiayTo 
(
	MaGiayTo nchar(10) primary key not null,
	MaDO nchar(10) not null,
	TenGiayTO nvarchar(100),
	NgayNhan date,
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

create table QC_ToBuom
(
	MaQCToBuom nchar(10) primary key not null,
	NoiDung nvarchar(500),
	SoLuongPhatHanh Int,
	GiaTien Money,
)


Create table QC_TrenBang
(
	MaQCBang nchar(10) primary key not null,
	MaLoaiBang nchar(10) not null,
	NoiDung nvarchar(100),
	DonGia Money,
	TinhTrang Bit,
	MaHinhAnh varchar(10),
)


create table HinhAnh
(
	MaHinhAnh varchar(10) not null primary key,
	Mota nvarchar(100),
	DuongDanAnh varchar(100),
)

create table LoaiBang
(
	MaLoaiBang nchar(10) primary key not null,
	TenLoaiBang nvarchar(50) not null,
	MoTaLoaiBang nvarchar(100),
	KichCo varchar(50),
)


create table QC_TrenBao
(
	MaQCTrenBao nchar(10) primary key not null,
	CoHinhAnh bit,
	MauSac bit,
	NoiDung nvarchar(1000),
	DonGia money,
	SoKy int,
	KyBatDau int,
	ThanhTien money,
	TinhTrang bit,
	ViTri nvarchar(50),
)

create table Bao
(
	MaBao nchar(10) primary key not null,
	MaQCTrenBao nchar(10) not null,
	TenBao nvarchar(50),
	ThuPhatHanh nvarchar(20),
)

create table ThamSo
(
	TenThamSo nvarchar(100) not null primary key,
	GiaTri nvarchar(100) not null,
)

create table NguoiDung
(
	ID int identity(1,1) not null primary key clustered,
	MaNguoiDung as 'ND' + RIGHT('000' + CAST(ID as varchar(5)), 5) persisted,
	TenNguoiDung nvarchar(30) not null,
	MatKhau nvarchar(25) not null,
	MaLoaiNguoiDung varchar(10) not null,
)

create table LoaiNguoiDung
(
	ID int identity(1,1) not null primary key clustered,
	MaLoaiNguoiDung as 'LND' + RIGHT('00' + CAST(ID as varchar(5)), 5) persisted,
	LoaiNguoiDung nvarchar(30) not null,
	MoTa nvarchar(100),
)

CREATE PROC sp_NguoiDung_LayDanhSach
@user nvarchar(30),
@pass nvarchar(25)

AS
	SELECT MaNguoiDung FROM NguoiDung WHERE TenNguoiDung=@user AND MatKhau=@pass
GO

CREATE PROC sp_NguoiDung_LoaiNguoiDung_LayDanhSach

AS
	SELECT MaNguoiDung, TenNguoiDung, LoaiNguoiDung FROM NguoiDung, LoaiNguoiDung WHERE NguoiDung.MaLoaiNguoiDung = LoaiNguoiDung.MaLoaiNguoiDung
GO

CREATE PROC sp_NguoiDung_KiemTra
@ten nvarchar(30)

AS
	SELECT * FROM NguoiDung WHERE TenNguoiDung=@ten
GO

CREATE PROC sp_NguoiDung_Them
@ten nvarchar(30),
@mk nvarchar(25),
@malnd varchar(10)

AS
	INSERT INTO NguoiDung VALUES(@ten, @mk, @malnd)
GO

CREATE PROC sp_NguoiDung_Sua
@ten nvarchar(30),
@mk nvarchar(25)

AS
	UPDATE NguoiDung SET MatKhau=@mk WHERE TenNguoiDung=@ten
GO

CREATE PROC sp_NguoiDung_Xoa
@ma varchar(10)

AS
	DELETE FROM NguoiDung WHERE MaNguoiDung=@ma
GO

CREATE PROC sp_NguoiDung_LoaiNguoiDung_LayLoaiNguoiDung
@user nvarchar(30)

AS
	SELECT LoaiNguoiDung FROM NguoiDung, LoaiNguoiDung WHERE TenNguoiDung=@user AND NguoiDung.MaLoaiNguoiDung=LoaiNguoiDung.MaLoaiNguoiDung
GO

CREATE PROC sp_LoaiNguoiDung_LayDanhSach

AS
	SELECT * FROM LoaiNguoiDung
GO

CREATE PROC sp_KhachHang_LayDanhSach

AS
	SELECT MaKH, TenKH, GioiTinh, NamSinh, DiaChi, SDT, Email FROM KhachHang
GO

CREATE PROC sp_KhachHang_LayDanhSachTen

AS
	SELECT MaKH, TenKH FROM KhachHang
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

CREATE PROC sp_KhachHang_Xoa
@ma varchar(10)

AS
	DELETE FROM KhachHang WHERE MaKH=@ma
GO

create proc sp_QCToBuom_LayThongTin
@maqctobuom nchar(10)
AS
	select * from QC_ToBuom where MaQCToBuom = @maqctobuom
GO

CREATE PROC sp_KhachHang_Sua
@ma varchar(10),
@ten nvarchar(100),
@gioitinh nvarchar(3),
@namsinh smallint,
@diachi nvarchar(200),
@sdt nvarchar(20),
@email nvarchar(20)

AS
	UPDATE KhachHang SET TenKH=@ten, GioiTinh=@gioitinh, NamSinh=@namsinh, DiaChi=@diachi, SDT=@sdt, Email=@email WHERE MaKH=@ma
GO

CREATE PROC sp_KhachHang_TimKiem
@tukhoa nvarchar(100)

AS
	SELECT MaKH, TenKH, GioiTinh, NamSinh, DiaChi, SDT, Email FROM KhachHang WHERE TenKH LIKE '%'+ @tukhoa +'%'
GO

CREATE PROC sp_KhachHang_TimKiem_2
@makh varchar(10),
@tenkh nvarchar(100),
@diachi nvarchar(1000),
@sdt nvarchar(20)

AS
	SELECT MaKH, TenKH, GioiTinh, NamSinh, DiaChi, SDT, Email FROM KhachHang WHERE TenKH LIKE '%'+ @tenkh +'%' AND MaKH LIKE '%'+ @makh +'%' AND DiaChi LIKE '%'+ @diachi +'%'AND SDT LIKE '%'+ @sdt +'%'
GO


CREATE PROC sp_DiaOc_LayDanhSach
@makh varchar(10)

AS
	SELECT MaDO, TenLoaiDO, DiaChi, DienTichSuDung, DienTichKhuonVien, HuongNha, ViTri, MoTaChiTiet, GiaBan, HinhAnh, TrangThai FROM DiaOc, LoaiDiaOc WHERE MaKH=@makh AND DiaOc.MaLoaiDO=LoaiDiaOc.MaLoaiDO
GO

CREATE PROC sp_DiaOc_Them
@makh varchar(10),
@maldo varchar(10),
@diachi nvarchar(200),
@dtkv numeric(18,2),
@dtsd numeric(18,2),
@hn nvarchar(100),
@vt nvarchar(100),
@mota nvarchar(100),
@giaban money,
@ha bit,
@tt nvarchar(50)

AS
	INSERT INTO DiaOc VALUES(@makh, @maldo, @diachi, @dtkv, @dtsd, @hn, @vt, @mota, @giaban, @ha, @tt)
GO

CREATE PROC sp_DiaOc_Sua
@mado varchar(10),
@makh varchar(10),
@maldo varchar(10),
@diachi nvarchar(200),
@dtkv numeric(18,2),
@dtsd numeric(18,2),
@hn nvarchar(100),
@vt nvarchar(100),
@mota nvarchar(100),
@giaban money,
@ha bit,
@tt nvarchar(50)

AS
	INSERT INTO DiaOc VALUES(@makh, @maldo, @diachi, @dtkv, @dtsd, @hn, @vt, @mota, @giaban, @ha, @tt)
GO

CREATE PROC sp_DiaOc_Xoa
@mado varchar(10)

AS
	DELETE FROM DiaOc WHERE MaDO=@mado
GO


CREATE PROC sp_LoaiDiaOc_LayDanhSach

AS
	SELECT * FROM LoaiDiaOc 
GO

CREATE PROC sp_ThamSo_LayDanhSach

AS
	SELECT * FROM ThamSo
GO

CREATE PROC sp_ThamSo_Sua
@laisuat nvarchar(100),
@mota nvarchar(100),
@tuoi nvarchar(100)

AS
	BEGIN
		UPDATE ThamSo SET GiaTri=@laisuat  WHERE TenThamSo=N'Lãi suất gia hạn'
		UPDATE ThamSo SET GiaTri=@mota  WHERE TenThamSo=N'Mô tả quảng cáo'
		UPDATE ThamSo SET GiaTri=@tuoi  WHERE TenThamSo=N'Tuổi tối thiểu'
	END
GO

CREATE PROC sp_ThamSo_LayTuoiToiThieu

AS
	SELECT GiaTri FROM ThamSo WHERE TenThamSo=N'Tuổi tối thiểu'
GO

CREATE PROC sp_ThamSo_LayTuoiToiDa

AS
	SELECT GiaTri FROM ThamSo WHERE TenThamSo=N'Tuổi tối đa'
GO

CREATE PROC sp_ThamSo_LayLaiSuatGiaHan
AS
	SELECT GiaTri FROM ThamSo WHERE TenThamSo=N'Lãi suất gia hạn'
GO

CREATE PROC sp_ThamSo_LaySoTuQuangCao
AS
	SELECT GiaTri FROM ThamSo WHERE TenThamSo=N'Mô tả quảng cáo'
GO

CREATE PROC sp_GiayTo_LayDanhSach
@mado varchar(10)

AS
	SELECT *  FROM GiayTo WHERE MaDO=@mado
GO

CREATE PROC sp_DangKy_LayDanhSachHetHan
AS
Select * FROM PhieuDangKy d 
WHERE d.NGAYKETTHUC < getdate()
GO

CREATE PROC sp_DiaOc_TimKiem
@mado varchar(10),
@diachi nvarchar(200),
@dientichtu numeric(18,2),
@dientichden numeric(18,2),
@giabantu money,
@giabanden money
AS
	SELECT * FROM DiaOc 
	WHERE
	( (MaDO like CONCAT('%',@mado,'%') ))
	and ( DiaChi like '%'+@diachi+'%')
	and (((@giabanden = 0) and (GIABAN > @giabantu))or ((GIABAN > @giabantu) and (GIABAN < @giabanden)))
	and (((@dientichden =0) and (DIENTICHKHUONVIEN > @dientichtu) )or ( (DIENTICHKHUONVIEN > @dientichtu) and (DIENTICHKHUONVIEN< @dientichden)))
GO

CREATE PROC sp_DangKy_LayThongTin
@mado varchar(10),
@makh varchar(10)

AS
	SELECT * FROM DANG_KY WHERE MAKH=@makh AND MADIAOC=@mado
GO

CREATE PROC sp_QCBang_LayThongTin
@maqcbang varchar(10)
AS
	Select NoiDung,TenLoaiBang,KichCo, MaHinhAnh, DonGia from QC_TrenBang,LoaiBang where MaQCBang = @maqcbang and QC_TrenBang.MaLoaiBang = LoaiBang.MaLoaiBang
GO

CREATE PROC sp_QCBao_LayThongTin
@maqcbao varchar(10)
AS
	select * from QC_TrenBao
GO

CREATE PROC sp_Bao_LayDanhSachBao
@maqcbao varchar(10)
AS
	select MaBao,TenBao,ThuPhatHanh from Bao where MaQCTrenBao = @maqcbao
GO

INSERT INTO NguoiDung VALUES('HoangKimTuan', '123456', 'LND001')
INSERT INTO NguoiDung VALUES('HoangKimTuan', '12345678', 'LND002')
INSERT INTO LoaiNguoiDung VALUES('admin', 'All role')
INSERT INTO LoaiNguoiDung VALUES('staff', 'Unknown')
INSERT INTO KhachHang VALUES(N'Nguyễn Văn A', N'Nam', 1990, N'Thủ Đức', '0123654987', 'nguyenvana@gmail.com')
INSERT INTO KhachHang VALUES(N'Nguyễn Văn B', N'Nam', 1990, N'Thủ Đức', '0123654987', 'nguyenvana@gmail.com')
INSERT INTO KhachHang VALUES(N'Nguyễn Văn C', N'Nam', 1990, N'Thủ Đức', '0123654987', 'nguyenvana@gmail.com')
INSERT INTO KhachHang VALUES(N'Nguyễn Văn D', N'Nam', 1990, N'Thủ Đức', '0123654987', 'nguyenvana@gmail.com')
INSERT INTO KhachHang VALUES(N'Nguyễn Văn E', N'Nam', 1990, N'Thủ Đức', '0123654987', 'nguyenvana@gmail.com')
INSERT INTO KhachHang VALUES(N'Nguyễn Văn F', N'Nam', 1990, N'Thủ Đức', '0123654987', 'nguyenvana@gmail.com')
INSERT INTO LoaiDiaOc VALUES('A')
INSERT INTO LoaiDiaOc VALUES('B')
INSERT INTO LoaiDiaOc VALUES('C')
INSERT INTO DiaOc VALUES('KH0006', 'LDO001', N'Số 30 đường Vành Đai ĐHQG KP. Tân Lập TX. Dĩ An tỉnh Bình Dương', 30.02, 10.36, N'Đông', N'XXX', N'Đẹp rẻ bền không set rỉ bảo hành 2 năm', 30000000, 1, N'Chưa bán')
INSERT INTO DiaOc VALUES('KH0007', 'LDO001', N'Số 30 đường Vành Đai ĐHQG KP. Tân Lập TX. Dĩ An tỉnh Bình Dương', 30.02, 10.36, N'Đông', N'XXX', N'Đẹp rẻ bền không set rỉ bảo hành 2 năm', 30000000, 1, N'Chưa bán')
INSERT INTO DiaOc VALUES('KH0008', 'LDO002', N'Số 30 đường Vành Đai ĐHQG KP. Tân Lập TX. Dĩ An tỉnh Bình Dương', 30.02, 10.36, N'Đông', N'XXX', N'Đẹp rẻ bền không set rỉ bảo hành 2 năm', 30000000, 1, N'Chưa bán')
INSERT INTO DiaOc VALUES('KH0006', 'LDO001', N'Số 30 đường Vành Đai ĐHQG KP. Tân Lập TX. Dĩ An tỉnh Bình Dương', 30.02, 10.36, N'Đông', N'XXX', N'Đẹp rẻ bền không set rỉ bảo hành 2 năm', 30000000, 1, N'Chưa bán')
INSERT INTO DiaOc VALUES('KH0006', 'LDO002', N'Số 30 đường Vành Đai ĐHQG KP. Tân Lập TX. Dĩ An tỉnh Bình Dương', 30.02, 10.36, N'Đông', N'XXX', N'Đẹp rẻ bền không set rỉ bảo hành 2 năm', 30000000, 1, N'Chưa bán')
INSERT INTO DiaOc VALUES('KH0007', 'LDO001', N'Số 30 đường Vành Đai ĐHQG KP. Tân Lập TX. Dĩ An tỉnh Bình Dương', 30.02, 10.36, N'Đông', N'XXX', N'Đẹp rẻ bền không set rỉ bảo hành 2 năm', 30000000, 0, N'Chưa bán')
INSERT INTO DiaOc VALUES('KH0008', 'LDO001', N'Số 30 đường Vành Đai ĐHQG KP. Tân Lập TX. Dĩ An tỉnh Bình Dương', 30.02, 10.36, N'Đông', N'XXX', N'Đẹp rẻ bền không set rỉ bảo hành 2 năm', 30000000, 1, N'Chưa bán')
INSERT INTO DiaOc VALUES('KH0008', 'LDO003', N'Số 30 đường Vành Đai ĐHQG KP. Tân Lập TX. Dĩ An tỉnh Bình Dương', 30.02, 10.36, N'Đông', N'XXX', N'Đẹp rẻ bền không set rỉ bảo hành 2 năm', 30000000, 1, N'Chưa bán')
INSERT INTO ThamSo VALUES(N'Lãi suất gia hạn', '2.5')
INSERT INTO ThamSo VALUES(N'Mô tả quảng cáo', '200')
INSERT INTO ThamSo VALUES(N'Tuổi tối thiểu', '18')
INSERT INTO ThamSo VALUES(N'Tuổi tối đa', '150')
INSERT INTO GiayTo VALUES('GT0001','DO0001',N'Sổ đỏ','2017-04-04')
INSERT INTO GiayTo VALUES('GT0002','DO0001',N'Giấy chứng nhận đất hoang','2017-04-04')
INSERT INTO GiayTo VALUES('GT0003','DO0006',N'Sổ đỏ','2017-04-04')
INSERT INTO GiayTo VALUES('GT0004','DO0006',N'Sổ đỏ','2017-04-04')

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
add constraint FK_GiayTo_DiaOc
foreign key (MaDO)
references DiaOc(MaDO)

alter table GiayTo drop constraint FK_GiayTo_DiaOc

ALTER TABLE KhachHang 
ADD CONSTRAINT CK_KH_SDT 
CHECK (SDT in ('0','1','2','3','4','5','6','7','8','9'))

ALTER TABLE PhieuDangKy 
ADD CONSTRAINT CK_PDK_NgayDK 
CHECK (Year(NgayDangKy) > 0 and (month(NgayDangKy) between 0 and 12) and (day(NgayDangKy) between 0 and 31))
