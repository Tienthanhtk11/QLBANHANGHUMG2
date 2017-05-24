USE [QuanLyBanHangHUMG]
GO
/****** Object:  Table [dbo].[tb_ChiTietHoaDonBan]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_ChiTietHoaDonNhap]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_DangNhap]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_HoaDonBan]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_HoaDonNhap]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_KhachHang]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_MatHang]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_NhaCungCap]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_NhomHang]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_PhongBan]    Script Date: 5/17/2017 10:45:30 AM ******/
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
/****** Object:  Table [dbo].[tb_TonDauKy]    Script Date: 5/17/2017 10:45:30 AM ******/
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
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'11', N'1', N'1', 30000.0000, 30)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'12', N'1', N'2', 35000.0000, 120)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'13', N'1', N'3', 35000.0000, 100)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'21', N'2', N'2', 300000.0000, 100)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'22', N'2', N'1', 300000.0000, 100)
INSERT [dbo].[tb_ChiTietHoaDonBan] ([MaCTHDB], [MaHoaDonBan], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'23', N'2', N'3', 300000.0000, 50)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'11', N'1', N'1', 70000.0000, 30)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'12', N'1', N'2', 70000.0000, 30)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'13', N'1', N'3', 70000.0000, 30)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'21', N'2', N'1', 20000.0000, 120)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'22', N'2', N'3', 20000.0000, 100)
INSERT [dbo].[tb_ChiTietHoaDonNhap] ([MaCTHDN], [MaHoaDonNhap], [MaMatHang], [DonGia], [SoLuong]) VALUES (N'23', N'2', N'2', 20000.0000, 10)
INSERT [dbo].[tb_DangNhap] ([TenDangNhap], [MatKhau], [MaNhanVien], [Role]) VALUES (N'1', N'1', N'1', 1)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'1', N'1', N'1', CAST(N'2016-12-12' AS Date), 0.0000, 0)
INSERT [dbo].[tb_HoaDonBan] ([MaHoaDonBan], [MaKhachHang], [MaNhanVien], [NgayLap], [TongThanhToan], [DaThanhToan]) VALUES (N'2', N'1', N'2', CAST(N'2016-12-22' AS Date), 0.0000, 1)
INSERT [dbo].[tb_HoaDonNhap] ([MaHoaDonNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'1', N'1', N'1', CAST(N'2016-12-12' AS Date))
INSERT [dbo].[tb_HoaDonNhap] ([MaHoaDonNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'2', N'2', N'2', CAST(N'2016-12-22' AS Date))
INSERT [dbo].[tb_KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT]) VALUES (N'1', N'Đỗ Như Hằng', N'Cung Trăng City', N'0989696969')
INSERT [dbo].[tb_KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT]) VALUES (N'2', N'Trương Văn Bằng', N'Tàu Khựa City', N'0968696969')
INSERT [dbo].[tb_MatHang] ([MaMatHang], [TenMatHang], [MaNhaCungCap], [MaNhomHang], [DVT], [GiaBan], [NgayCapNhat], [SoLuong]) VALUES (N'1', N'Ghế gỗ Cẩm Thạch', N'2', N'2', N'Bộ', 12000000.0000, CAST(N'2017-12-01' AS Date), 60)
INSERT [dbo].[tb_MatHang] ([MaMatHang], [TenMatHang], [MaNhaCungCap], [MaNhomHang], [DVT], [GiaBan], [NgayCapNhat], [SoLuong]) VALUES (N'2', N'Bàn trang nhã', N'2', N'2', N'Cái', 6000000.0000, CAST(N'2017-12-01' AS Date), 60)
INSERT [dbo].[tb_MatHang] ([MaMatHang], [TenMatHang], [MaNhaCungCap], [MaNhomHang], [DVT], [GiaBan], [NgayCapNhat], [SoLuong]) VALUES (N'3', N'Bộ sô-fa VIP', N'1', N'1', N'Bộ', 3000000.0000, CAST(N'2017-01-03' AS Date), 60)
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SDT]) VALUES (N'1', N'Hello Kitty', N'Hà Nội', N'0433222000')
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SDT]) VALUES (N'2', N'Adele Cat', N'US', N'0933223223')
INSERT [dbo].[tb_NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [MaPhongBan]) VALUES (N'1', N'Nguyễn Văn An', CAST(N'1996-12-01' AS Date), N'Nam', N'Thạch Thất, Sài Gòn', N'0987676766', N'2')
INSERT [dbo].[tb_NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [MaPhongBan]) VALUES (N'2', N'Đặng Thị Tuấn', CAST(N'1996-04-30' AS Date), N'Nữ', N'Cà Mau', N'0969696969', N'1')
INSERT [dbo].[tb_NhomHang] ([MaNhomHang], [TenNhomHang]) VALUES (N'1', N'Đồ gia dụng')
INSERT [dbo].[tb_NhomHang] ([MaNhomHang], [TenNhomHang]) VALUES (N'2', N'Đồ nội thất')
INSERT [dbo].[tb_PhongBan] ([MaPhongBan], [TenPhongBan]) VALUES (N'1', N'Nhân sự')
INSERT [dbo].[tb_PhongBan] ([MaPhongBan], [TenPhongBan]) VALUES (N'2', N'Kế toán')
INSERT [dbo].[tb_TonDauKy] ([MaMatHang], [NgayCapNhat], [SoLuong], [GiaTriTon]) VALUES (N'1', CAST(N'2017-05-16' AS Date), 300, 300000.0000)
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
