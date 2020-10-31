USE [master]
GO
/****** Object:  Database [QuanLiFastFood]    Script Date: 10/16/2020 1:18:07 PM ******/
CREATE DATABASE [QuanLiFastFood]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiFastFood', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLiFastFood.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiFastFood_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLiFastFood_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiFastFood] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiFastFood].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiFastFood] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiFastFood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiFastFood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLiFastFood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiFastFood] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiFastFood] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiFastFood] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiFastFood] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiFastFood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiFastFood] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLiFastFood] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLiFastFood]
GO
/****** Object:  Table [dbo].[CALAMVIEC]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALAMVIEC](
	[idCaLam] [nvarchar](50) NOT NULL,
	[tenNV] [nvarchar](50) NOT NULL,
	[CaLam] [nvarchar](50) NOT NULL,
	[tgBatDau] [time](7) NOT NULL,
	[tgKetThuc] [time](7) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COMBO]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMBO](
	[idCB] [nvarchar](50) NOT NULL,
	[idSP] [nvarchar](50) NOT NULL,
	[imgCB] [nvarchar](50) NOT NULL,
	[giaCB] [float] NOT NULL,
	[ctCB] [text] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHOADONBAN]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHOADONBAN](
	[idHD] [nvarchar](50) NOT NULL,
	[idSP] [nvarchar](50) NOT NULL,
	[soLuong] [int] NOT NULL,
	[giaTien] [float] NOT NULL,
	[ngayTao] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHOADONNHAP]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHOADONNHAP](
	[idCT] [nvarchar](50) NOT NULL,
	[idNV] [nvarchar](50) NOT NULL,
	[idNCC] [nvarchar](50) NOT NULL,
	[ngayTaoHD] [date] NOT NULL,
	[soLuong] [int] NOT NULL,
	[giaTien] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTNGUYENLIEU]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTNGUYENLIEU](
	[idCT] [nvarchar](50) NOT NULL,
	[idNguyenLieu] [nvarchar](50) NOT NULL,
	[ghiChu] [text] NOT NULL,
	[soLuong] [int] NOT NULL,
	[tinhTrang] [text] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTSANPHAM]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTSANPHAM](
	[idSP] [nvarchar](50) NOT NULL,
	[idNL] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONBAN]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONBAN](
	[idHD] [nvarchar](50) NOT NULL,
	[idNV] [nvarchar](50) NOT NULL,
	[idKH] [nvarchar](50) NOT NULL,
	[tongTien] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[idKH] [nvarchar](50) NOT NULL,
	[hoTenKH] [nvarchar](50) NOT NULL,
	[diaChi] [nvarchar](50) NOT NULL,
	[soDT] [nvarchar](50) NOT NULL,
	[ngaySinh] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHUYENMAI]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUYENMAI](
	[idKM] [nvarchar](50) NOT NULL,
	[idSP] [nvarchar](50) NOT NULL,
	[ngayBatDau] [date] NOT NULL,
	[ngayKetThuc] [date] NOT NULL,
	[giamGia] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LICHLAM]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHLAM](
	[idNV] [nvarchar](50) NOT NULL,
	[idCaLam] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[idNL] [nvarchar](50) NOT NULL,
	[tenNL] [nvarchar](50) NOT NULL,
	[imgNL] [nvarchar](50) NOT NULL,
	[hanSD] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[idNCC] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[soDT] [nvarchar](50) NOT NULL,
	[ghiChu] [text] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[idNV] [nvarchar](50) NOT NULL,
	[hoTenNV] [nvarchar](50) NOT NULL,
	[ngaySinh] [date] NOT NULL,
	[imgNV] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[soDT] [nvarchar](50) NOT NULL,
	[chucVu] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[idSP] [nvarchar](50) NOT NULL,
	[tenSP] [nvarchar](50) NOT NULL,
	[imgSP] [nvarchar](50) NOT NULL,
	[moTaSP] [text] NOT NULL,
	[giaTienSP] [float] NOT NULL,
	[doAn] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 10/16/2020 1:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[idUSER] [nvarchar](50) NOT NULL,
	[taiKhoan] [nvarchar](50) NOT NULL,
	[matKhau] [nvarchar](50) NOT NULL,
	[phanQuyen] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [QuanLiFastFood] SET  READ_WRITE 
GO
