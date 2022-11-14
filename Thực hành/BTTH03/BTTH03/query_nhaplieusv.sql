﻿CREATE DATABASE NhapLieuSinhVien
USE NhapLieuSinhVien

use master
DROP DATABASE NhapLieuSinhVien
create table SINHVIEN
(
	MSSV char(8), -- MSSV
	HoTen nvarchar(100), -- Ten
	ChuyenNganh nvarchar(100), -- ChuyenNganh
	GioiTinh nvarchar(4), 
	SoMon int,
)

select * from SINHVIEN

insert into SINHVIEN values('20522087','Nguyen Nhat Truong','Khoa học máy tính', 'Nam', 5)