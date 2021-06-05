create database QL_BanHang
go
use QL_BanHang


create table tb_NhanVien(
 MaNV	varchar(10) primary key	,
 TenNhanVien	nvarchar(50)	,
 Gioitinh	nvarchar(5)	,
 NamSinh	date	,
 DiaChi	nvarchar(50)	,
 SDT	varchar(11)	,
 MatKhau	varchar(20)	
		
 )

 create table tb_KhachHang(
 MaKH	varchar(10)	primary key,
 TenKH	nvarchar(50),
 SDT	varchar(10)	,
 GioiTinh	nvarchar(5)	,
 DiaChi	nvarchar(50),	
 SoDiem	varchar(10)
 )



 create table tb_HoaDon(
 
 MaHoaDon	varchar(10) primary key	,
 KhachHang	nvarchar(50),	
 NhanVienLap	nvarchar(50),	
 NgayLap	date,	
 MaKH	varchar(10)	,
 MaNV	varchar(10)	,
		
 )

 create table tb_CTHD(
 MaHD	varchar(10)	,
 MaHH	varchar(10)	,
 DonGia	varchar(20)	,
 SoLuong	varchar(10)	,
 primary key (MaHD,MaHH)
		
 )

 create table tb_HangHoa(
 MaHang	varchar(10) primary key	,
 TenHang	nvarchar(50),
 DonGia	varchar(20)	,
 SoLuong	varchar(10)	,
		
 )

 go
 alter table tb_HoaDon add foreign key (MaKH) references  tb_KhachHang(MaKH)
 alter table tb_HoaDon add foreign key (MaNV) references  tb_NhanVien(MaNV)


 alter table tb_CTHD add foreign key (MaHD) references  tb_HoaDon(MaHoaDon)
  alter table tb_CTHD add foreign key (MaHH) references  tb_HangHoa( MaHang)
  go

  select * from tb_KhachHang
   insert into tb_HangHoa values ('4',N'Tivi' , '150000','1500')

   insert into tb_NhanVien values ('3',N'hung','nam','2/12/2000','nghe an','0866254355','567')

    insert into tb_KhachHang values ('4',N'huy' , '150000','nam','binh phuoc','458')

   insert into tb_HoaDon values ('2',N'huy','nam','2/10/2000','1','1')

   insert into tb_CTHD values ('1','4','1256','6')



    insert into tb_HangHoa values ('5',N'Tu Lanh' , '180000','2000')

   insert into tb_NhanVien values ('4',N'Hien','Nu','2/12/1993','Ha Noi','0888884447','999')

    insert into tb_KhachHang values ('5',N'Nhien' , '200000','nam','Binh Thuan','888')

   insert into tb_HoaDon values ('3',N'Nhien','nam','2/10/2000','1','1')

   insert into tb_CTHD values ('1','3','1256','6')
