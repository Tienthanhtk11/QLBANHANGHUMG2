USE [QuanLyBanHangHUMG]
GO
/****** Object:  Table [dbo].[tb_ChiTietHoaDonBan]    Script Date: 5/27/2017 5:21:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_ChiTietHoaDonBan](
	[MaCTHDB] [varchar](20) NOT NULL,
	[MaHoaDonBan] [varchar](20) NOT NULL,
	[MaMatHang] [varchar](20) NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [tinyint] NOT NULL,
 CONSTRAINT [PK_tb_ChiTietHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[MaCTHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_ChiTietHoaDonNhap]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_ChiTietHoaDonNhap](
	[MaCTHDN] [varchar](20) NOT NULL,
	[MaHoaDonNhap] [varchar](20) NOT NULL,
	[MaMatHang] [varchar](20) NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_tb_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaCTHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_DangNhap]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_DangNhap](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](32) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[Role] [tinyint] NOT NULL,
 CONSTRAINT [PK_tb_DangNhap] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_HoaDonBan]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_HoaDonBan](
	[MaHoaDonBan] [varchar](20) NOT NULL,
	[MaKhachHang] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TongThanhToan] [money] NOT NULL,
	[DaThanhToan] [bit] NOT NULL,
 CONSTRAINT [PK_tb_HoaDonBan] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_HoaDonNhap]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_HoaDonNhap](
	[MaHoaDonNhap] [varchar](20) NOT NULL,
	[MaNhaCungCap] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[NgayLap] [date] NOT NULL,
 CONSTRAINT [PK_tb_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_KhachHang]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_KhachHang](
	[MaKhachHang] [varchar](20) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
 CONSTRAINT [PK_tb_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_MatHang]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_MatHang](
	[MaMatHang] [varchar](20) NOT NULL,
	[TenMatHang] [nvarchar](100) NOT NULL,
	[MaNhaCungCap] [varchar](20) NOT NULL,
	[MaNhomHang] [varchar](20) NOT NULL,
	[DVT] [nvarchar](20) NOT NULL,
	[GiaBan] [money] NOT NULL,
	[NgayCapNhat] [date] NOT NULL,
	[SoLuong] [float] NULL,
 CONSTRAINT [PK_tb_MatHang] PRIMARY KEY CLUSTERED 
(
	[MaMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_NhaCungCap]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_NhaCungCap](
	[MaNhaCungCap] [varchar](20) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
 CONSTRAINT [PK_tb_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_NhanVien](
	[MaNhanVien] [varchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[MaPhongBan] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tb_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_NhomHang]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_NhomHang](
	[MaNhomHang] [varchar](20) NOT NULL,
	[TenNhomHang] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tb_NhomHang] PRIMARY KEY CLUSTERED 
(
	[MaNhomHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PhongBan]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_PhongBan](
	[MaPhongBan] [varchar](20) NOT NULL,
	[TenPhongBan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tb_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_TonDauKy]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_TonDauKy](
	[MaMatHang] [varchar](20) NOT NULL,
	[NgayCapNhat] [date] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaTriTon] [money] NOT NULL,
 CONSTRAINT [PK_tb_TonDauKy] PRIMARY KEY CLUSTERED 
(
	[MaMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_1]    Script Date: 5/27/2017 5:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT        dbo.tb_HoaDonBan.MaKhachHang, dbo.tb_HoaDonBan.MaNhanVien, dbo.tb_HoaDonBan.NgayLap, dbo.tb_HoaDonBan.TongThanhToan, dbo.tb_HoaDonBan.DaThanhToan, dbo.tb_ChiTietHoaDonBan.MaCTHDB, 
                         dbo.tb_ChiTietHoaDonBan.MaMatHang, dbo.tb_HoaDonBan.MaHoaDonBan AS Expr1, dbo.tb_ChiTietHoaDonBan.DonGia, dbo.tb_ChiTietHoaDonBan.SoLuong, dbo.tb_NhanVien.TenNhanVien, 
                         dbo.tb_KhachHang.TenKhachHang, dbo.tb_MatHang.TenMatHang
FROM            dbo.tb_ChiTietHoaDonBan INNER JOIN
                         dbo.tb_HoaDonBan ON dbo.tb_ChiTietHoaDonBan.MaHoaDonBan = dbo.tb_HoaDonBan.MaHoaDonBan INNER JOIN
                         dbo.tb_NhanVien ON dbo.tb_HoaDonBan.MaNhanVien = dbo.tb_NhanVien.MaNhanVien INNER JOIN
                         dbo.tb_KhachHang ON dbo.tb_HoaDonBan.MaKhachHang = dbo.tb_KhachHang.MaKhachHang INNER JOIN
                         dbo.tb_MatHang ON dbo.tb_ChiTietHoaDonBan.MaMatHang = dbo.tb_MatHang.MaMatHang

GO
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'10-1', N'10', N'1', 12000000.0000, 0)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'10-2', N'10', N'2', 6000000.0000, 0)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'10-3', N'10', N'3', 3000000.0000, 0)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'11', N'1', N'1', 30000.0000, 30)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'11-2', N'11', N'2', 6000000.0000, 6)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'12', N'1', N'2', 35000.0000, 120)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'12-1', N'12', N'1', 12000000.0000, 8)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'12-2', N'12', N'2', 6000000.0000, 8)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'12-3', N'12', N'3', 3000000.0000, 8)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'13', N'1', N'3', 35000.0000, 100)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'13-1', N'13', N'1', 12000000.0000, 10)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'13-2', N'13', N'2', 6000000.0000, 9)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'14-1', N'14', N'1', 12000000.0000, 99)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'15-1', N'15', N'1', 12000000.0000, 7)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'15-2', N'15', N'2', 6000000.0000, 7)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'15-3', N'15', N'3', 3000000.0000, 7)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'16-2', N'16', N'2', 6000000.0000, 4)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'16-3', N'16', N'3', 3000000.0000, 2)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'17-1', N'17', N'1', 12000000.0000, 2)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'17-2', N'17', N'2', 6000000.0000, 3)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'17-3', N'17', N'3', 3000000.0000, 4)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'18-1', N'18', N'1', 12000000.0000, 9)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'18-2', N'18', N'2', 6000000.0000, 9)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'18-3', N'18', N'3', 3000000.0000, 9)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'21', N'2', N'2', 300000.0000, 100)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'22', N'2', N'1', 300000.0000, 100)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'23', N'2', N'3', 300000.0000, 50)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'7-0', N'7', N'1', 12000000.0000, 6)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'7-1', N'7', N'2', 6000000.0000, 5)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'7-2', N'7', N'3', 3000000.0000, 7)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'8-1', N'8', N'1', 12000000.0000, 6)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'8-2', N'8', N'2', 6000000.0000, 6)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'8-3', N'8', N'3', 3000000.0000, 6)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'9-2', N'9', N'2', 6000000.0000, 0)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'9-3', N'9', N'3', 3000000.0000, 0)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'11', N'1', N'1', 70000.0000, 30)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'12', N'1', N'2', 70000.0000, 30)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'13', N'1', N'3', 70000.0000, 30)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'21', N'2', N'1', 20000.0000, 120)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'23', N'2', N'2', 20000.0000, 10)
INSERT [dbo].[tb_DangNhap] ([TenDangNhap], [MatKhau], [MaNhanVien], [Role]) VALUES (N'1', N'1', N'1', 1)
INSERT [dbo].[tb_DangNhap] ([TenDangNhap], [MatKhau], [MaNhanVien], [Role]) VALUES (N'2', N'2', N'2', 2)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'1', N'1', N'1', CAST(N'2016-12-12' AS Date), 0.0000, 0)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'10', N'1', N'1', CAST(N'2017-05-27' AS Date), 0.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'11', N'1', N'1', CAST(N'2017-05-27' AS Date), 36000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'12', N'2', N'2', CAST(N'2017-05-27' AS Date), 168000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'13', N'1', N'1', CAST(N'2017-05-27' AS Date), 174000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'14', N'1', N'1', CAST(N'2017-05-27' AS Date), 1188000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'15', N'1', N'1', CAST(N'2017-05-27' AS Date), 147000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'16', N'1', N'1', CAST(N'2017-05-27' AS Date), 30000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'17', N'1', N'1', CAST(N'2017-05-27' AS Date), 54000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'18', N'1', N'1', CAST(N'2017-05-27' AS Date), 189000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'2', N'1', N'2', CAST(N'2016-12-22' AS Date), 0.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'3', N'1', N'1', CAST(N'2017-05-25' AS Date), 48000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'4', N'1', N'1', CAST(N'2017-05-25' AS Date), 21000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'5', N'1', N'1', CAST(N'2017-05-25' AS Date), 33000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'6', N'1', N'1', CAST(N'2017-05-25' AS Date), 21000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'7', N'1', N'1', CAST(N'2017-05-25' AS Date), 123000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'8', N'1', N'1', CAST(N'2017-05-25' AS Date), 126000000.0000, 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'9', N'2', N'2', CAST(N'2017-05-25' AS Date), 45000000.0000, 1)
INSERT [dbo].[tb_HoaDonNhap] ([MaHoaDonNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'1', N'1', N'1', CAST(N'2016-12-12' AS Date))
INSERT [dbo].[tb_HoaDonNhap] ([MaHoaDonNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'2', N'2', N'2', CAST(N'2016-12-22' AS Date))
INSERT [dbo].[tb_KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT]) VALUES (N'1', N'Đỗ Như Hằng', N'Cung Trăng City', N'0989696969')
INSERT [dbo].[tb_KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT]) VALUES (N'2', N'Trương Văn Bằng', N'Tàu Khựa City', N'0968696969')
INSERT [dbo].[tb_MatHang] ([MaMatHang], [TenMatHang], [MaNhaCungCap], [MaNhomHang], [DVT], [GiaBan], [NgayCapNhat], [SoLuong]) VALUES (N'1', N'Xăng Diazel 1008', N'2', N'2', N'Lít', 12000000.0000, CAST(N'2017-12-01' AS Date), 991)
INSERT [dbo].[tb_MatHang] ([MaMatHang], [TenMatHang], [MaNhaCungCap], [MaNhomHang], [DVT], [GiaBan], [NgayCapNhat], [SoLuong]) VALUES (N'2', N'Xăng Xinas 9001', N'2', N'2', N'Lít', 6000000.0000, CAST(N'2017-12-01' AS Date), 991)
INSERT [dbo].[tb_MatHang] ([MaMatHang], [TenMatHang], [MaNhaCungCap], [MaNhomHang], [DVT], [GiaBan], [NgayCapNhat], [SoLuong]) VALUES (N'3', N'Dầu nhớt Neptune', N'1', N'1', N'Thùng', 3000000.0000, CAST(N'2017-01-03' AS Date), 1)
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SDT]) VALUES (N'1', N'Hello Kitty', N'Hà Nội', N'0433222000')
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SDT]) VALUES (N'2', N'Adele Cat', N'US', N'0933223223')
INSERT [dbo].[tb_NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [MaPhongBan]) VALUES (N'1', N'Nguyễn Văn An', CAST(N'1996-12-01' AS Date), N'Nam', N'Thạch Thất, Sài Gòn', N'0987676766', N'2')
INSERT [dbo].[tb_NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [MaPhongBan]) VALUES (N'2', N'Đặng Thị Tuấn', CAST(N'1996-04-30' AS Date), N'Nữ', N'Cà Mau', N'0969696969', N'1')
INSERT [dbo].[tb_NhomHang] ([MaNhomHang], [TenNhomHang]) VALUES (N'1', N'Đồ gia dụng')
INSERT [dbo].[tb_NhomHang] ([MaNhomHang], [TenNhomHang]) VALUES (N'2', N'Đồ nội thất')
INSERT [dbo].[tb_PhongBan] ([MaPhongBan], [TenPhongBan]) VALUES (N'1', N'Nhân sự')
INSERT [dbo].[tb_PhongBan] ([MaPhongBan], [TenPhongBan]) VALUES (N'2', N'Kế toán')
INSERT [dbo].[tb_TonDauKy] ([MaMatHang], [NgayCapNhat], [SoLuong], [GiaTriTon]) VALUES (N'1', CAST(N'2017-05-16' AS Date), 30, 300000.0000)
INSERT [dbo].[tb_TonDauKy] ([MaMatHang], [NgayCapNhat], [SoLuong], [GiaTriTon]) VALUES (N'2', CAST(N'2018-02-02' AS Date), 39, 900000.0000)
ALTER TABLE [dbo].[tb_ChiTietHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tb_ChiTietHoaDonBan_tb_HoaDonBan] FOREIGN KEY([MaHoaDonBan])
REFERENCES [dbo].[tb_HoaDonBan] ([MaHoaDonBan])
GO
ALTER TABLE [dbo].[tb_ChiTietHoaDonBan] CHECK CONSTRAINT [FK_tb_ChiTietHoaDonBan_tb_HoaDonBan]
GO
ALTER TABLE [dbo].[tb_ChiTietHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tb_ChiTietHoaDonBan_tb_MatHang] FOREIGN KEY([MaMatHang])
REFERENCES [dbo].[tb_MatHang] ([MaMatHang])
GO
ALTER TABLE [dbo].[tb_ChiTietHoaDonBan] CHECK CONSTRAINT [FK_tb_ChiTietHoaDonBan_tb_MatHang]
GO
ALTER TABLE [dbo].[tb_ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_ChiTietHoaDonNhap_tb_HoaDonNhap] FOREIGN KEY([MaHoaDonNhap])
REFERENCES [dbo].[tb_HoaDonNhap] ([MaHoaDonNhap])
GO
ALTER TABLE [dbo].[tb_ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_tb_ChiTietHoaDonNhap_tb_HoaDonNhap]
GO
ALTER TABLE [dbo].[tb_ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_ChiTietHoaDonNhap_tb_MatHang] FOREIGN KEY([MaMatHang])
REFERENCES [dbo].[tb_MatHang] ([MaMatHang])
GO
ALTER TABLE [dbo].[tb_ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_tb_ChiTietHoaDonNhap_tb_MatHang]
GO
ALTER TABLE [dbo].[tb_DangNhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_DangNhap_tb_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[tb_NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[tb_DangNhap] CHECK CONSTRAINT [FK_tb_DangNhap_tb_NhanVien]
GO
ALTER TABLE [dbo].[tb_HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDonBan_tb_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[tb_KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[tb_HoaDonBan] CHECK CONSTRAINT [FK_tb_HoaDonBan_tb_KhachHang]
GO
ALTER TABLE [dbo].[tb_HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDonBan_tb_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[tb_NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[tb_HoaDonBan] CHECK CONSTRAINT [FK_tb_HoaDonBan_tb_NhanVien]
GO
ALTER TABLE [dbo].[tb_HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDonNhap_tb_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[tb_NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[tb_HoaDonNhap] CHECK CONSTRAINT [FK_tb_HoaDonNhap_tb_NhaCungCap]
GO
ALTER TABLE [dbo].[tb_HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDonNhap_tb_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[tb_NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[tb_HoaDonNhap] CHECK CONSTRAINT [FK_tb_HoaDonNhap_tb_NhanVien]
GO
ALTER TABLE [dbo].[tb_MatHang]  WITH CHECK ADD  CONSTRAINT [FK_tb_MatHang_tb_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[tb_NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[tb_MatHang] CHECK CONSTRAINT [FK_tb_MatHang_tb_NhaCungCap]
GO
ALTER TABLE [dbo].[tb_MatHang]  WITH CHECK ADD  CONSTRAINT [FK_tb_MatHang_tb_NhomHang] FOREIGN KEY([MaNhomHang])
REFERENCES [dbo].[tb_NhomHang] ([MaNhomHang])
GO
ALTER TABLE [dbo].[tb_MatHang] CHECK CONSTRAINT [FK_tb_MatHang_tb_NhomHang]
GO
ALTER TABLE [dbo].[tb_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tb_NhanVien_tb_PhongBan] FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[tb_PhongBan] ([MaPhongBan])
GO
ALTER TABLE [dbo].[tb_NhanVien] CHECK CONSTRAINT [FK_tb_NhanVien_tb_PhongBan]
GO
ALTER TABLE [dbo].[tb_TonDauKy]  WITH CHECK ADD  CONSTRAINT [FK_tb_TonDauKy_tb_MatHang] FOREIGN KEY([MaMatHang])
REFERENCES [dbo].[tb_MatHang] ([MaMatHang])
GO
ALTER TABLE [dbo].[tb_TonDauKy] CHECK CONSTRAINT [FK_tb_TonDauKy_tb_MatHang]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tb_ChiTietHoaDonBan"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tb_HoaDonBan"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_NhanVien"
            Begin Extent = 
               Top = 6
               Left = 462
               Bottom = 136
               Right = 632
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tb_KhachHang"
            Begin Extent = 
               Top = 6
               Left = 670
               Bottom = 136
               Right = 841
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_MatHang"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 216
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
