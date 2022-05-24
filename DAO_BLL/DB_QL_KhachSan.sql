Create database QL_KhachSan
Use QL_KhachSan

/*	CreteUser: 162860 - Vo Hoang Bao Son
	CreateDate: 30/04/2022
	Email: soncmlt@gmail.com
	Phone: 070.305.1386
*/

Create Table tbl_LoaiNhanVien
(
	MaLoaiNV int identity (1,1) primary key not null,
	TenLoai nvarchar (50)
);    

Create Table tbl_NhanVien
(
	MaNV char (10) primary key not null /*Khóa chính là SĐT nhân viên và là tên "Đăng nhập"*/,
	TenNV nvarchar (50),
	MatKhau char(10),
	MaLoaiNV int not null,
	GioiTinh nvarchar(10),
	Diachi nvarchar (50),
	NgaySinh date
	Constraint "FK_LoaiNhanVien_NhanVien" foreign key (MaLoaiNV) references  tbl_LoaiNhanVien(MaLoaiNV)
);

Create Table tbl_LoaiPhong
(
	MaLoaiPhong int identity (1,1) primary key not null,
	TenLoai nvarchar (50),
	SoGiuong int,
	GiaGio int,
	GiaNgay int,
	GiaThang int
);

Create Table tbl_Phong
(
	MaPhong int identity (1,1) primary key not null,
	TenPhong nvarchar(20),
	MaLoaiPhong int not null,
	TinhTrang nvarchar(20) /*True(phòng trống) -- False (đang thuê)*/ -- 19/05/2022 -- 162860 - VHBSon: Cập nhật thành kiểu text
	/*Có thể xem thêm thông tin chi tiết của phòng như hình ảnh phòng,.....*/
	Constraint "FK_LoaiPhong_Phong" foreign key (MaLoaiPhong) references  tbl_LoaiPhong(MaLoaiPhong)
);

Create Table tbl_HinhThuc
(
	MaHinhThuc int primary key not null,
	TenHinhThuc nvarchar (50)
);

Create Table tbl_KhachHang
(
	MaKH Char(10) primary key not null,/*Mã khách hàng sẽ là CMND*/
	TenKH nvarchar (50),
	SDT char(10),
	GioiTinh nvarchar(10),
	NgaySinh date,
	DiaChi nvarchar (50)
	/*Các thông tin chi tiết khác về khách hàng sẽ được cập nhật thêm vào table (Nếu phát sinh)*/
);

Create Table tbl_PhieuThue
(
	MaPhieuThue int identity (1,1) primary key not null,
	MaPhong int not null,
	MaHinhThuc int not null,
	NgayDat DateTime,
	TinhTrang bit, /*Có thể xét true fale cho trường hợp chưa thanh toán và đã thanh toán*/
	MaKH Char(10) not null,
	Constraint "FK_Phong_PhieuThue" foreign key (MaPhong) references  tbl_Phong(MaPhong),
	Constraint "FK_HinhThuc_PhieuThue" foreign key (MaHinhThuc) references  tbl_HinhThuc(MaHinhThuc),
	Constraint "FK_KhachHang_PhieuThue" foreign key (MaKH) references  tbl_KhachHang(MaKH)
);

Create Table tbl_HoaDon
(
	MaHD int identity (1,1) primary key not null,
	MaPhieuThue int not null,
	MaKH char(10) not null,
	MaPhong int not null,
	GioVao DateTime not null,
	GioRa DateTime not null,
	ThoiGianThue float not null,
	MaHinhThuc int not null,
	TongTien float not null,
	Constraint "FK_PhieuThue_HoaDon" foreign key (MaPhieuThue) references  tbl_PhieuThue(MaPhieuThue)
);



/*Bộ data này lưu ý nhớ thêm vào trước khi chạy App*/

/*Loại nhân viên*/
Insert into tbl_LoaiNhanVien Values ('Admin');
/*Nhân viên*/
Insert into tbl_NhanVien Values ('0703051386',N'Võ Hoàng Bảo Sơn', '1', 1, N'Nam',N'Tp.Hồ Chí Minh', '2000-06-17');
/*Khách hàng*/
INsert into tbl_KhachHang values ('261610133', N'Võ Hoàng Bảo Sơn', '0703051386', N'Nam', '2000-06-17', N'Tp.Hồ Chí Minh');
/*Hình thức*/
insert into tbl_HinhThuc values (1, N'Thuê theo giờ');
insert into tbl_HinhThuc values (2, N'Thuê theo ngày');
insert into tbl_HinhThuc values (3, N'Thuê theo tháng');


--Không cần thiết
Insert into tbl_LoaiPhong Values (N'Phòng Đơn', 1, 30000, 300000, 1500000);
Insert into tbl_Phong Values (N'Phòng Sơn Tạo', 1, N'Chưa thuê');
