CREATE DATABASE QLCUAHANG
GO

USE QLCUAHANG
GO

CREATE TABLE QUANLY(
	username VARCHAR(20),
	password VARCHAR(20)
)

CREATE TABLE NHANVIEN(
	msnv INT PRIMARY KEY NOT NULL,
	hoten NVARCHAR(50),
	gioitinh NVARCHAR(6),
	namsinh DATE,
	diachi NVARCHAR(50),
	hinh image,
	username VARCHAR(20),
	password VARCHAR(20)
)
CREATE TABLE KHACHHANG
(
	mskh INT PRIMARY KEY NOT NULL,
	hoten NVARCHAR(50),
	gioitinh NVARCHAR(6),
	namsinh DATE,
	diachi NVARCHAR(50),
	sdt CHAR(12),
	username VARCHAR(20),
	password VARCHAR(20)
)
CREATE TABLE CHAMCONG(
	STT INT PRIMARY KEY IDENTITY(1,1), 
	msnv INT NOT NULL,
	hoten NVARCHAR(50),
	giovao DATETIME,
	giora DATETIME,
	sogio int
)
CREATE TABLE HANGHOA
(
	mahang INT PRIMARY KEY NOT NULL,
	loaihang NVARCHAR(20),
	tenhang NVARCHAR(50),
	hinh image,
	gia FLOAT,
	soluong INT CHECK (soluong>=0),
	magiamgia VARCHAR(15) DEFAULT ('khong')
)

CREATE TABLE HOADON
(
	mahoadon INT PRIMARY KEY IDENTITY(1,1),
	mskh INT,
	magiohang INT,
	tongtien FLOAT,
	ngaymua DATE,
	trangthai INT NOT NULL DEFAULT ('0')
)
CREATE TABLE THANHTOAN
(
	mahoadon INT,
	msnv INT,
	ngaythanhtoan DATE,
	tongtien FLOAT
)
CREATE TABLE GIOHANG(
	stt INT IDENTITY(1,1),
	magiohang int NOT NULL,
	mahang INT ,
	tenhang NVARCHAR(50),
	soluong INT CHECK (soluong>0),
	gia FLOAT,
	mskh INT,
	thanhtoan INT DEFAULT(0)
)
CREATE TABLE DOANHTHU(
	STT INT PRIMARY KEY IDENTITY(1,1),
	tien FLOAT,
	ngay DATE
)

CREATE TABLE LICHSU_GIOHANG
(
    magiohang int NOT NULL,
	mahang INT ,
	tenhang NVARCHAR(50),
	soluong INT CHECK (soluong>0),
	gia FLOAT,
	mskh INT,
	ngay DATE
);
CREATE TABLE MAGIAMGIA(
	magiamgia varchar(15) PRIMARY KEY NOT NULL,
)

go
CREATE VIEW XUATHOADON AS SELECT mskh,tenhang,soluong,gia,thanhtoan FROM dbo.GIOHANG
go

ALTER TABLE dbo.THANHTOAN ADD FOREIGN KEY(mahoadon) REFERENCES dbo.HOADON(mahoadon)
ALTER TABLE dbo.HOADON ADD FOREIGN KEY(mskh) REFERENCES dbo.KHACHHANG(mskh)
ALTER TABLE dbo.CHAMCONG ADD FOREIGN KEY(msnv) REFERENCES dbo.NHANVIEN(msnv)
ALTER TABLE GIOHANG ADD FOREIGN KEY(mskh) REFERENCES KHACHHANG(mskh)
ALTER TABLE GIOHANG ADD FOREIGN KEY(mahang) REFERENCES HANGHOA(mahang)
ALTER TABLE thanhtoan ADD FOREIGN KEY (msnv) REFERENCES nhanvien(msnv)
GO

INSERT dbo.QUANLY
(
    username,
    password
)
VALUES
(   'admin', -- username - varchar(20)
    'admin'  -- password - varchar(20)
)
go
INSERT dbo.KHACHHANG
(
    mskh,
    hoten,
    gioitinh,
    namsinh,
    diachi,
    sdt,
    username,
    password
)
VALUES
(   1,         -- mskh - int
    N'Nguyễn Văn A',       -- hoten - nvarchar(50)
    N'Nữ',       -- gioitinh - nvarchar(6)
    GETDATE(), -- namsinh - date
    N'HCM',       -- diachi - nvarchar(50)
    '12345678',        -- sdt - char(12)
    'a',        -- username - varchar(20)
    'a'         -- password - varchar(20)
    )
go
----trigger thực hiện
CREATE TRIGGER muahang 
ON GIOHANG
AFTER INSERT
AS
BEGIN
	UPDATE dbo.HANGHOA
	SET Soluong = dbo.HANGHOA.soluong - (SELECT soluong FROM INSERTED WHERE dbo.HANGHOA.mahang=INSERTED.mahang )
	FROM dbo.HANGHOA JOIN INSERTED  ON dbo.HANGHOA.mahang=INSERTED.mahang
	
	
END
go



CREATE TRIGGER truhang
ON dbo.GIOHANG
AFTER DELETE
AS
DECLARE @thanhtoan INT
SELECT @thanhtoan=thanhtoan FROM dbo.GIOHANG
BEGIN
	IF @thanhtoan=0 -- chưa thanh toán thì trả hàng về
	BEGIN
	UPDATE dbo.HANGHOA
	SET Soluong = dbo.HANGHOA.soluong + (SELECT soluong FROM Deleted WHERE Deleted.mahang=HANGHOA.mahang )
	FROM dbo.HANGHOA JOIN Deleted ON dbo.HANGHOA.mahang=Deleted.mahang
	END
	ELSE
	BEGIN
	UPDATE dbo.HANGHOA
	SET Soluong = dbo.HANGHOA.soluong - (SELECT soluong FROM INSERTED WHERE dbo.HANGHOA.mahang=INSERTED.mahang )
	FROM dbo.HANGHOA JOIN INSERTED  ON dbo.HANGHOA.mahang=INSERTED.mahang
    END
    
END
go
