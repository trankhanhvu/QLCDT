CREATE TABLE KHACHHANG(
	CMND varchar(20) primary key,
	TENKH nvarchar(100),
	NGHENGHIEP nvarchar(50),
	CHUCVU nvarchar(50),
	DIACHI nvarchar(50),
	EMAIL nvarchar(50)
);

CREATE TABLE SIM(
	IDSIM varchar(20) primary key,
	CMND varchar(20),	
	TRANGTHAI nvarchar(20)
);

CREATE TABLE HOADON(
	IDSIM varchar(20),
	THANG int,
	NAM int,
	TONGTIEN float,
	TRANGTHAI nvarchar(20),
	PRIMARY KEY(THANG,NAM,IDSIM)
);

CREATE TABLE CTSD(
	IDSIM varchar(20),
	TGBD DATETIME,
	TGKT DATETIME,
	THANHTIEN float,
	PRIMARY KEY(TGBD,TGKT)
);

CREATE TABLE THAMSO(
	MATS varchar(8) primary key,
	DIENGIAI nvarchar(50),
	GIATRI float
);

CREATE TABLE CUOC(
	GIOBD int,
	GIOKT int,
	PHI float,
	PRIMARY KEY(GIOBD,GIOKT)
);


Alter table SIM
	add constraint fk_sim_kh
	foreign key (CMND)
	references KHACHHANG (CMND)

Alter table HOADON
	add constraint fk_hd_sim
	foreign key (IDSIM)
	references SIM (IDSIM)

Alter table CTSD
	add constraint fk_ctsd_sim
	foreign key (IDSIM)
	references SIM (IDSIM)

--ADD DATA

INSERT INTO THAMSO values('PHIHM','phí hòa mạng',50000);

INSERT INTO CUOC values(7,17,500); --sáng
INSERT INTO CUOC values(17,7,1000); --tối

INSERT INTO KHACHHANG values('206184646',N'Vũ đập chai','Sinh viên',N'Không có',N'Hóc Môn','boykunis90@gmail.com');

INSERT INTO SIM values('0773187889','206184646',N'Đã kích hoạt');

