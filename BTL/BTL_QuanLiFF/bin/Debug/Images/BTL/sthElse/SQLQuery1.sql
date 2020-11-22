SELECT CTHOADONBAN.idHD , hoTenNV, SANPHAM.tenSP , CTHOADONBAN.soLuong, CTHOADONBAN.giaTien , CTHOADONBAN.KM , tongTien  FROM CTHOADONBAN INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD INNER JOIN NHANVIEN ON NHANVIEN.idNV = HOADONBAN.idNV INNER JOIN SANPHAM ON SANPHAM.idSP = CTHOADONBAN.idSP


SELECT * FROM CTHOADONNHAP

SELECT CTHOADONNHAP.idCT , CTHOADONNHAP.idNCC , hoTenNV , tenNL ,CTHOADONNHAP.soLuong , CTNGUYENLIEU.DONGIA, CTHOADONNHAP.TONGTIEN , ngayTaoHD , CTNGUYENLIEU.ghiChu  FROM CTHOADONNHAP INNER JOIN CTNGUYENLIEU ON CTHOADONNHAP.idCT = CTNGUYENLIEU.idCT INNER JOIN NHANVIEN ON NHANVIEN.idNV = CTHOADONNHAP.idNV INNER JOIN NHACUNGCAP ON NHACUNGCAP.idNCC = CTHOADONNHAP.idNCC INNER JOIN NGUYENLIEU ON NGUYENLIEU.idNL = CTNGUYENLIEU.idNL

alter table cthoadonnhap 
alter column tongTien float null 

alter table cthoadonnhap 
drop column giaTien 

select * from nhanvien

update nhanvien set sex = N'Nữ' where idNV = 'NV08'   

alter table nhanvien
drop column status

select * from  CTNGUYENLIEU

alter table ctnguyenlieu
drop column ghiChu

alter table ctnguyenlieu 
add ghiChu text null 

alter table ctnguyenlieu 
ADD CONSTRAINT ghiChuDF
DEFAULT 'Không có ghi chú' FOR ghiChu;
 

 "SELECT CTHOADONBAN.idHD, idSP ,idNV, idKH, soLuong, SANPHAM.giaTienSP, ngayTao, yeuCau FROM CTHOADONBAN INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD INNER JOIN SANPHAM ON CTHOADONBAN.idSP = SANPHAM.idSP WHERE CTHOADONBAN.idHD = 'HDB11/18/202026'"



 alter TRIGGER CNTT ON CTHOADONBAN FOR INSERT , UPDATE , delete
 AS 
 BEGIN
	DECLARE @idhd nvarchar(50), @gt1 float , @idsp nvarchar(50), @gt2  float , @sl1 float , @sl2 float
	
	set @gt2 =0 
	set @gt1 = 0

	if exists (select * from deleted)
		SELECT @idHD = idHD, @idsp = idSP , @sl1 = isnull(soLuong,0), @gt1 = giaTien FROM DELETED

	if exists (select * from inserted)
		select @idHD = idHD ,  @idsp = idSP  , @sl2 = isnull(soLuong,0),  @gt2 = giaTien   FROM INSERTED

	UPDATE HOADONBAN SET tongTien = isnull((select tongTien from HOADONBAN where idHD = @idHD) , 0 ) - isnull(@gt1,0) + isnull(@gt2,0)
	where idHD = @idhd
 END

 select * from hoadonban 

 select * from hoadonban
 select * from cthoadonban
 delete cthoadonban
 delete hoadonban
 
 insert into hoadonban values ('HDB11/19/23333', 'NV01', 'KH01' , '0')
 insert into CTHOADONBAN values ('HDB11/19/23333', 'SP01' , 1, 10000, '11/19/2020', '0', 0)

  insert into CTHOADONBAN values ('HDB11/19/23333', 'SP02' , 5, 10000, '11/19/2020', '0', 0)

select cthoadonnhap.idCT ,  cthoadonnhap.idNCC , nhanvien.hoTenNV, nguyenlieu.tenNL,  cthoadonnhap.tongTien from cthoadonnhap  inner join ctnguyenlieu on ctnguyenlieu.idct = cthoadonnhap.idct inner join nguyenlieu on ctnguyenlieu.idnl = nguyenlieu.idnl inner join nhanvien on nhanvien.idnv = cthoadonnhap.idnv

select * from cthoadonnhap

select * from khuyenmai 

update khuyenmai set idSP = 'CB02' , ngayBatDau = '2020-11-19' , ngayKetThuc = '2020-11-19', 

select cthoadonban.idHD, nhanvien.idNV, nhanvien.hoTenNV,khachhang.idKH, khachhang.hoTenKH, sanpham.idsp, sanpham.tenSP, sanpham.giaTienSP,  cthoadonban.soLuong, cthoadonban.giaTien ,cthoadonban.ngayTao,  cthoadonban.yeuCau from cthoadonban inner join hoadonban on cthoadonban.idhd= hoadonban.idhd inner join sanpham on cthoadonban.idsp = sanpham.idsp inner join khachhang on khachhang.idKH = hoadonban.idKH inner join nhanvien on nhanvien.idNV = hoadonban.idNV where cthoadonban.idHD = 'HDB11/19/20200'

SELECT CTHOADONNHAP.idCT , NHACUNGCAP.IDNCC , NGUYENLIEU.tenNL, CTNGUYENLIEU.soLuong , CTNGUYENLIEU.DONGIA , CTNGUYENLIEU.donVi , CTHOADONNHAP.ngayTaoHD ,CTHOADONNHAP.TONGTIEN FROM CTHOADONNHAP INNER JOIN CTNGUYENLIEU ON CTNGUYENLIEU.idCT = CTHOADONNHAP.idCT INNER JOIN NHACUNGCAP ON NHACUNGCAP.idNCC = CTHOADONNHAP.idNCC INNER JOIN NGUYENLIEU ON NGUYENLIEU.idNL = CTNGUYENLIEU.idNL INNER JOIN NHANVIEN ON NHANVIEN.idNV = CTHOADONNHAP.idNV

SELECT * FROM CTHOADONNHAP
SELECT * FROM CTNGUYENLIEU

SELECT * FROM NHACUNGCAP

insert into ctnguyenlieu values('CT10', 'NL02' , 50 ,  N'Sử dụng' , 'Túi' , 20000 , N'Không có ghi chú')

select * from taikhoan
insert into taikhoan values('US04', 'NV03' , 'us04', '111' , 'dayla@gmail.com')
update taikhoan where idUSER = '






----------------------------------------------------------------------------------------------------------------
/*------------------------------------------------------------------------------------------------------------*/

/*

3. Các thủ tục (Stored Procedure) >=4 thủ tục
	DEM SO CAC KHANH HANG CO DIA CHI TAI THANH PHO NOI (NHAP) 
	XOA CAC KHACH HANG CO MA KHACH HANG NHAP VAO
	TINH TONG SO MAT HANG TRONG HOA DON BAN
	KIEM TRA TAI KHOAN KHACH HANG CON HD HAY KHONG

5. Các câu lệnh ngôn ngữ điều khiển dữ liệu: >=2 lệnh

Kiem tra login 
KIEM TRA XEM SO DONG TRA VE . 
NEU > 0 THI LA CO TAI KHOAN .	
	DANG NHAP THANH CONG THI HIEN THONG BAO DANG NHAP THANH CONG 
	GIAO DIEN ADMIN SE BAO GOM TAT CA CAC THONG TIN, KHI DANG NHAP SE KIEM TRA XEM CO QUYEN NHU THE NAO THI SE CHO PHEP THAO TAC
NEU = 0 THI LA KHONG CO TAI KHOAN.
	THONG BAO TAI KHOAN KHONG TON TAI

Khi them hoa don co san pham nao thi nguyen lieu tao nen san pham do -1
*/
--So luong trong cthoadonnhap laf so luong nhap
-- so luong trong ctnguyen lieu la so luong con lai 
--3.1
CREATE PROCEDURE NKH @TENTP NVARCHAR(50) , @DEM INT OUTPUT
AS 
BEGIN
	SELECT @DEM = COUNT(diaChi)
	FROM KHACHHANG 
	WHERE KHACHHANG.diaChi = @TENTP


END

declare @DEM int
exec NKH N'Hà Nội' , @DEM output
print @DEM

--3.2
CREATE PROCEDURE XKH @MAKH NVARCHAR(50)
AS
BEGIN
	DELETE KHACHHANG WHERE IDKH = @MAKH
END

exec XKH 'KH05' 
SELECT * FROM KHACHHANG

--3.3
alter PROCEDURE THDB @MAHD NVARCHAR(50), @DEM INT output
AS 
BEGIN
	SELECT  @DEM = count(idSP) 
	FROM CTHOADONBAN
	WHERE idHD = @MAHD

END

declare @DEM int
exec THDB 'HDB11/19/20200' , @DEM output
print @DEM

--3.4
ALTER PROCEDURE KTTT @MAKH NVARCHAR(50) , @TT NVARCHAR(50) OUTPUT
AS 
BEGIN
	
	BEGIN TRY 
		SELECT @TT = KHACHHANG.STATUS FROM KHACHHANG WHERE idKH = @MAKH

	END TRY
	BEGIN CATCH
		EXECUTE KTTT; 
	END CATCH
END

declare @TT NVARCHAR(50)
exec KTTT 'KH01' , @TT OUTPUT
print @TT

/*
4. Các hàm (UDFs): >= 4 hàm
	HAM SINH RA KHOA CUA BANG KHUYEN MAI
	HAM DUA RA THONG TIN CUA KHACH HANG VA CAC HOA DON CUA KHACH HANG
	HAM TINH DOANH THU TRONG THANG TU HOA DON BAN VA HOA DON NHAP
	HAM KIEM TRA TAI KHOAN LOGIN
*/

--4.2
CREATE FUNCTION TT (@TT NVARCHAR(50)) 
RETURNS  TABLE
AS
RETURN ( 
	SELECT KHACHHANG.IDKH, KHACHHANG.hoTenKH, KHACHHANG.diaChi , KHACHHANG.soDT , KHACHHANG.ngaySinh , 
			CTHOADONBAN.idHD , CTHOADONBAN.ngayTao ,HOADONBAN.tongTien
	FROM KHACHHANG 
	INNER JOIN HOADONBAN ON HOADONBAN.idKH = KHACHHANG.idKH
	INNER JOIN CTHOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD
)

SELECT * FROM TT('KH01')
-- THU SU DUNG ROLLUP XEM 

--4.3
ALTER FUNCTION DT(@m int)
RETURNS TABLE
AS 
RETURN (
SELECT  (month(cthoadonban.ngayTao)) as Thang ,
		sum(hoadonban.tongtien) as "Tong hoa don ban" ,
		sum(cthoadonnhap.tongTien) as "Tong hoa don nhap", 
		( sum(hoadonban.tongtien) - sum(cthoadonnhap.tongTien) ) AS "DOANH THU"
		from hoadonban
		inner join cthoadonban on hoadonban.idhd = cthoadonban.idhd
		INNER JOIN CTHOADONNHAP ON month(CTHOADONNHAP.ngayTaoHD) = month(cthoadonban.ngayTao)
		where month(cthoadonban.ngayTao) = @m 
		GROUP BY MONTH(CTHOADONBAN.NGAYTAO) 
)

SELECT * FROM DBO.DT(11)
--4.4
alter function kt (@US NVARCHAR(50) , @MK NVARCHAR(50) )
RETURNS NVARCHAR(200) 
AS
BEGIN 
	DECLARE @TB NVARCHAR(200)
	IF exists (SELECT * FROM TAIKHOAN WHERE EMAIL = @US AND MATKHAU = @MK ) 
	BEGIN 
		SET @TB = N'ĐĂNG NHẬP THÀNH CÔNG '
		RETURN @TB
		
	END

	SET @TB = N'TÀI KHOÀN HOẶC MẬT KHẨU KHÔNG ĐÚNG'
	RETURN @TB
END

SELECT  dbo.kt('tranvm@gmail.com','111')


