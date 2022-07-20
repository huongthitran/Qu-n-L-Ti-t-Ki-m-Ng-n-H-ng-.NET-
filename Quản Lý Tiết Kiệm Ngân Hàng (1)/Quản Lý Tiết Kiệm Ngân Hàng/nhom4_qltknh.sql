create database Nhom4_QLTK
use Nhom4_QLTK

create table DANGNHAP
(
	TENDN nvarchar(50),
	MATKHAU nvarchar(50)
);

create table KHACHHANG
(
	MAKH nvarchar(50) primary key not null,
	TENKH nvarchar(50),
	CMND nvarchar(50),
	NGAYSINH date,
	DIACHI nvarchar(50),
	DIENTHOAIKH char(50),
	MAIL nvarchar(50),
	TENDN nvarchar(50) 
);

create table THONGTINNGUOIQUANLY (
	MAQL NVARCHAR(50) primary key not null,
	TENQL nvarchar(50),
	SDT char(50),
	EMAIL nvarchar(50),
	DIACHIQL nvarchar(50),
	TENDN nvarchar(50),
	MAPHONG nvarchar(50) references PHONG(MAPHONG)
)


create table PHONG
(
	MAPHONG nvarchar(50) primary key not null,
	TENPHONG nvarchar(50)
);

create table TAIKHOANTIETKIEM
(
	MATK nvarchar(50) primary key not null,
	MAKH nvarchar(50) references KHACHHANG(MAKH),
	NGAYMOSO date,
	SOTIENGOC float,
	LOAITIEN nvarchar(50)
);

create table LAISUAT
(
	MALS nvarchar(50),
	MUCLS float
);

create table KYHAN
(
	MAKYHAN nvarchar(50) primary key not null,
	MAQL nvarchar(50) references THONGTINNGUOIQUANLY(MAQL),
	MATK nvarchar(50) references TAIKHOANTIETKIEM(MATK),
	KYHAN nvarchar(10),
	LOAITIEN nvarchar(50),
	MALS nvarchar(50)	
);

create table GIAODICH
(
	MAGD nvarchar(50) primary key not null,
	MATK nvarchar(50) references TAIKHOANTIETKIEM(MATK),
	NGAYGD date,
	LOAIGD nvarchar(50),
	SOTIEN float,
	LOAITIETKIEM nvarchar(50),
	MAKYHAN nvarchar(50) references KYHAN(MAKYHAN)
);

create table CHITIETGIAODICH
(
	MACHITIET nvarchar(50),
	MAKH nvarchar(50) references KHACHHANG(MAKH),
	MAGD nvarchar(50) references GIAODICH(MAGD),
	SOTIEN int,
	NOIDUNG nvarchar(50)
);

insert into DANGNHAP values ('QL1', 'MKQL'),
('QL2', 'MKQL'),
('QL3', 'MKQL'),
('QL4', 'MKQL'),
('QL5', 'MKQL'),
('KH2', 'MKKH2'),
('KH3', 'MKKH3'),
('KH4', 'MKKH4'),
('KH5', 'MKKH5'),
							('KH1', 'MKKH1');
							

insert into KHACHHANG values ('MKH_01', 'Mai Vinh Minh', '001202012036', '02/20/2002', '01 Hang Bai', '093455077', 'minhmoc12@gmail.com','KH1'),
							 ('MKH_02', 'Ngo Van Teo', '001202012678', '03/02/2002', '02 Ba Dinh', '093454577', 'starlord@gmail.com','KH2'),
							 ('MKH_03', 'Long Thi Pieng', '001202012436', '04/12/2002', '155 Kim Ma', '093453799', 'capcap12@gmail.com','KH3'),
							 ('MKH_04', 'Lau A Thai', '001245856231', '06/03/2002', '05 Hoang Hoa Tham', '0934213455', '0123m12@gmail.com','KH4'),
							 ('MKH_05', 'Nguyen Tien Nhat', '001202501036', '10/20/2002', '07 Hang Bai', '093134077', 'bminmin@gmail.com','KH5');

insert into TAIKHOANTIETKIEM values ('TKTK_01', 'MKH_01', '05/20/2022', 10000000, 'VND'),
('TKTK_06', 'MKH_01', '07/20/2022', 10000000, 'VND'),
('TKTK_07', 'MKH_01', '08/18/2022', 10000000, 'VND'),
('TKTK_08', 'MKH_02', '09/03/2022', 10000000, 'VND'),
('TKTK_09', 'MKH_03', '10/04/2022', 10000000, 'VND'),
('TKTK_10', 'MKH_03', '11/30/2022', 10000000, 'VND'),
									('TKTK_02', 'MKH_02', '05/20/2022', 15000000, 'VND'),
									('TKTK_03', 'MKH_03', '04/21/2022', 23000000, 'VND'),
									('TKTK_04', 'MKH_04', '02/23/2022', 25000000, 'VND'),
									('TKTK_11', 'MKH_04', '07/26/2022', 25000000, 'VND'),
									('TKTK_12', 'MKH_04', '03/13/2022', 25000000, 'VND'),
									('TKTK_05', 'MKH_05', '01/12/2022', 30000000, 'VND');

insert into THONGTINNGUOIQUANLY values ('QL_01', 'Nguyen Thu Hanh', '0934645077', 'quanlybaca@gmail.com', '12 Hoan Kiem','QL1','P_01'),	
									   ('QL_02', 'Nguyen Thu Huong', '0934645435', 'quanlyviettin@gmail.com', '24 Ly Thai To','QL2','P_02'),
									   ('QL_03', 'Nguyen Quynh Trang', '0934645897', 'quanlytechcom@gmail.com', '36 Hoang Hoa Tham','QL3','P_03'),
									   ('QL_04', 'Nguyen Van Thai', '0154454039', 'thai@gmail.com', '48 Au co','QL4','P_01'),
									   ('QL_05', 'Phan Manh Cuong', '0234645132', 'cuong@gmail.com', '60 Hai Ba Trung','QL5','P_02');

insert into PHONG values ('P_01', 'Phong Xu Ly Phat Sinh'),
						 ('P_02', 'Phong Cong Tac'),
						 ('P_03', 'Phong Ke Toan');

insert into LAISUAT values ('LS_01', 0.05),
						   ('LS_02', 0.03),
						   ('LS_04', 0.009),
						   ('LS_05', 0.04),
						   ('LS_03', 0.01);

insert into KYHAN values ('KYH_01', 'QL_01', 'TKTK_01', 'Ky han 01', 'VND', 'LS_01'),
						 ('KYH_02', 'QL_02', 'TKTK_02', 'Ky han 02', 'VND', 'LS_02'),
						 ('KYH_03', 'QL_03', 'TKTK_03', 'Ky han 03', 'VND', 'LS_03');
insert into KYHAN values ('KYH_06', 'QL_01', 'TKTK_01', 'Ky han 01', 'VND', 'LS_01'),
						 ('KYH_05', 'QL_04', 'TKTK_04', 'Ky han 02', 'VND', 'LS_02'),
						 ('KYH_04', 'QL_05', 'TKTK_05', 'Ky han 03', 'VND', 'LS_03');

insert into GIAODICH values ('GD_01', 'TKTK_01', '05/22/2022', 'L_01', 500000, 'LTK_01', 'KYH_01'),
							('GD_02', 'TKTK_02', '05/21/2022', 'L_02', 400000, 'LTK_02', 'KYH_02'),
							('GD_03', 'TKTK_03', '05/12/2022', 'L_03', 200000, 'LTK_03', 'KYH_03'),
							('GD_04', 'TKTK_04', '05/02/2022', 'L_04', 1000000, 'LTK_04', 'KYH_02'),
							('GD_05', 'TKTK_05', '05/10/2022', 'L_05', 800000, 'LTK_05', 'KYH_03');

insert into CHITIETGIAODICH values ('CT_01', 'MKH_01', 'GD_01', 500000, 'Chuyen tien dong hoc'),
								   ('CT_02', 'MKH_02', 'GD_02', 400000, 'Chuyen tien cho me'),
								   ('CT_03', 'MKH_03', 'GD_03', 200000, 'Gui tien vao so tiet kiem'),
								   ('CT_04', 'MKH_04', 'GD_04', 1000000, 'Chuyen tien dong hoc'),
								   ('CT_05', 'MKH_05', 'GD_05', 800000, 'Chuyen tien cho ba');






select TenQl 
from THONGTINNGUOIQUANLY,DANGNHAP
where DANGNHAP.TENDN = THONGTINNGUOIQUANLY.TENDN and DANGNHAP.TENDN = 'ql1'

select TenKH
from KHACHHANG,DANGNHAP
where DANGNHAP.TENDN = KHACHHANG.TENDN and DANGNHAP.TENDN = 'kh1'

select MAKH, TENKH, CMND, NGAYSINH,DIACHI, DIENTHOAIKH,MAIL
from KHACHHANG, DANGNHAP
where  DANGNHAP.TENDN = KHACHHANG.TENDN and DANGNHAP.TENDN = 'kh1'

select THONGTINNGUOIQUANLY.MAQL,THONGTINNGUOIQUANLY.TENQL, THONGTINNGUOIQUANLY.MAPHONG,THONGTINNGUOIQUANLY.DIACHIQL ,THONGTINNGUOIQUANLY.DIACHIQL , THONGTINNGUOIQUANLY.SDT, THONGTINNGUOIQUANLY.EMAIL
from THONGTINNGUOIQUANLY, DANGNHAP,KYHAN,TAIKHOANTIETKIEM, KHACHHANG
where  DANGNHAP.TENDN = KHACHHANG.TENDN  and THONGTINNGUOIQUANLY.MAQL = KYHAN.MAQL and KYHAN.MATK = TAIKHOANTIETKIEM.MATK and TAIKHOANTIETKIEM.MAKH =KHACHHANG.MAKH and DANGNHAP.TENDN = 'kh1'

select TAIKHOANTIETKIEM.MAKH,TAIKHOANTIETKIEM.MATK,TAIKHOANTIETKIEM.LOAITIEN,TAIKHOANTIETKIEM.NGAYMOSO,TAIKHOANTIETKIEM.SOTIENGOC
from DANGNHAP,KHACHHANG,TAIKHOANTIETKIEM
where DANGNHAP.TENDN = KHACHHANG.TENDN and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH  and DANGNHAP.TENDN = 'kh1'

select GIAODICH.MAGD,GIAODICH.MATK,GIAODICH.NGAYGD,GIAODICH.LOAIGD, GIAODICH.SOTIEN, GIAODICH.LOAITIETKIEM, GIAODICH.MAKYHAN
from GIAODICH, DANGNHAP, khachhang, taikhoantietkiem
where DANGNHAP.TENDN = KHACHHANG.TENDN and giaodich.Matk = taikhoantietkiem.matk and taikhoantietkiem.maKH = Khachhang.makh and DANGNHAP.TENDN = 'kh1'


select CHITIETGIAODICH.MACHITIET, CHITIETGIAODICH.MAGD, CHITIETGIAODICH.MAKH, CHITIETGIAODICH.NOIDUNG, CHITIETGIAODICH.SOTIEN
from DANGNHAP, KHACHHANG, CHITIETGIAODICH
where DANGNHAP.TENDN = KHACHHANG.TENDN and KHACHHANG.MAKH = CHITIETGIAODICH.MAKH and DANGNHAP.TENDN = 'kh1'

select KYHAN.KYHAN, KYHAN.LOAITIEN, KYHAN.MAKYHAN, KYHAN.MALS, KYHAN.MALS, KYHAN.MAQL, KYHAN.MATK
from KHACHHANG, KYHAN, TAIKHOANTIETKIEM
where KHACHHANG.TENDN = 'kh1' and KYHAN.MATK = TAIKHOANTIETKIEM.MATK and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH

select LAISUAT.MALS, LAISUAT.MUCLS 
from KHACHHANG,LAISUAT, KYHAN,TAIKHOANTIETKIEM
where KHACHHANG.TENDN = '  kh1' and KYHAN.MALS = LAISUAT.MALS and KYHAN.MATK = TAIKHOANTIETKIEM.MATK and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH

select * from CHItietgiaodich where MAKH like 'm'

--------------
CREATE view v_tonghop AS (
SELECT KHACHHANG.TENKH ,KHACHHANG.MAKH , KHACHHANG.DIENTHOAIKH, KHACHHANG.DIACHI ,KHACHHANG.CMND , KHACHHANG.MAIL ,KHACHHANG.NGAYSINH,
DANGNHAP.TENDN ,
TAIKHOANTIETKIEM.MAKH ,
THONGTINNGUOIQUANLY.MAQL,THONGTINNGUOIQUANLY.TENQL, THONGTINNGUOIQUANLY.MAPHONG,THONGTINNGUOIQUANLY.DIACHIQL ,THONGTINNGUOIQUANLY.DIACHIQL , THONGTINNGUOIQUANLY.SDT,
LAISUAT.MALS,LAISUAT.MUCLS,


FROM CHUCVU, NHANVIEN, LUONG
Where CHUCVU.ma_CV = NHANVIEN.ma_CV and
NHANVIEN.ma_NV = LUONG.ma_NV);

Select * from v_tonghop
update v_tonghop
set thuc_linh = luong_co_ban * (he_so_luong + phu_cap)
+ khoan_cong_them - khoan_tru


