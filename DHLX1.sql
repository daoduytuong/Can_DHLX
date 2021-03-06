USE [DHLX1]
GO
/****** Object:  Table [dbo].[Tem]    Script Date: 06/16/2021 10:51:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tem](
	[Tem] [nvarchar](50) NOT NULL,
	[Trangthai] [nvarchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0001', N'1')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'Tem2', N'1')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'Tem3', N'0')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0002', N'0')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0003', N'1')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0004', N'0')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0005', N'0')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0006', N'0')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0007', N'0')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0008', N'0')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0009', N'0')
INSERT [dbo].[Tem] ([Tem], [Trangthai]) VALUES (N'21T0010', N'0')
/****** Object:  Table [dbo].[KiemDinhVien]    Script Date: 06/16/2021 10:51:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KiemDinhVien](
	[KiemDinhVien] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[KiemDinhVien] ([KiemDinhVien]) VALUES (N'Dao Duy Tuong')
INSERT [dbo].[KiemDinhVien] ([KiemDinhVien]) VALUES (N'Ho Xuan Hung')
INSERT [dbo].[KiemDinhVien] ([KiemDinhVien]) VALUES (N'Tran Toan Thang')
/****** Object:  Table [dbo].[canloxo]    Script Date: 06/16/2021 10:51:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[canloxo](
	[SoBienBan] [nvarchar](50) NOT NULL,
	[SoCan] [int] NOT NULL,
	[TenCan] [nvarchar](50) NULL,
	[Kieu] [nchar](10) NULL,
	[CapChinhXac] [nchar](10) NULL,
	[NuocSX] [nvarchar](50) NULL,
	[NamSX] [int] NULL,
	[CheDoKD] [nvarchar](50) NULL,
	[NgayKD] [nvarchar](50) NULL,
	[Max] [nvarchar](50) NULL,
	[Min] [nvarchar](50) NULL,
	[DoChia] [int] NULL,
	[DoChiaKiem] [int] NULL,
	[PPTH] [nvarchar](50) NULL,
	[DonViSD] [nvarchar](50) NULL,
	[KiemDinhVien] [nvarchar](50) NULL,
	[SoTem] [nvarchar](50) NULL,
	[NhanMac] [nvarchar](10) NULL,
	[Tem] [nvarchar](10) NULL,
	[DayDu] [nvarchar](10) NULL,
	[DongHoThangDo] [nvarchar](10) NULL,
	[BoPhan] [nvarchar](10) NULL,
	[KiemtraNgoai] [nvarchar](10) NULL,
	[DDCT1min] [nvarchar](50) NULL,
	[DDCT105max] [nvarchar](50) NULL,
	[DDCT1max] [nvarchar](50) NULL,
	[DDGTmin] [nvarchar](50) NULL,
	[DDGT05max] [nvarchar](50) NULL,
	[DDGTmax] [nvarchar](50) NULL,
	[DDCT2min] [nvarchar](50) NULL,
	[DDCT205max] [nvarchar](50) NULL,
	[DDCT2max] [nvarchar](50) NULL,
	[DDmin] [nvarchar](50) NULL,
	[DD05max] [nvarchar](50) NULL,
	[DDmax] [nvarchar](50) NULL,
	[KiemtraDoDong] [nvarchar](10) NULL,
	[LLCT1min] [nvarchar](50) NULL,
	[LLCT105max] [nvarchar](50) NULL,
	[LLCT1max] [nvarchar](50) NULL,
	[LLCT2min] [nvarchar](50) NULL,
	[LLCT205max] [nvarchar](50) NULL,
	[LLCT2max] [nvarchar](50) NULL,
	[LLCT3min] [nvarchar](50) NULL,
	[LLCT305max] [nvarchar](50) NULL,
	[LLCT3max] [nvarchar](50) NULL,
	[LLCLLonmin] [nvarchar](50) NULL,
	[LLCLLon05max] [nvarchar](50) NULL,
	[LLCLLonmax] [nvarchar](50) NULL,
	[LLCLCPmin] [nvarchar](50) NULL,
	[LLCLCP05max] [nvarchar](50) NULL,
	[LLCLCPmax] [nvarchar](50) NULL,
	[KiemtraLapLai] [nvarchar](10) NULL,
	[LTMucTai] [nvarchar](10) NULL,
	[LTChiThiG] [nvarchar](10) NULL,
	[LTChiThiI1] [nvarchar](10) NULL,
	[LTChiThiI2] [nvarchar](10) NULL,
	[LTChiThiI3] [nvarchar](10) NULL,
	[LTChiThiI4] [nvarchar](10) NULL,
	[LTCLLN] [nvarchar](10) NULL,
	[LTCLCP] [nvarchar](10) NULL,
	[KiemtraLechTam] [nvarchar](10) NULL,
	[MTL1] [nvarchar](10) NULL,
	[MTL2] [nvarchar](10) NULL,
	[MTL3] [nvarchar](10) NULL,
	[MTL4] [nvarchar](10) NULL,
	[MTL5] [nvarchar](10) NULL,
	[CTCT1] [nvarchar](10) NULL,
	[CTCT2] [nvarchar](10) NULL,
	[CTCT3] [nvarchar](10) NULL,
	[CTCT4] [nvarchar](10) NULL,
	[CTCT5] [nvarchar](10) NULL,
	[CTCG1] [nvarchar](10) NULL,
	[CTCG2] [nvarchar](10) NULL,
	[CTCG3] [nvarchar](10) NULL,
	[CTCG4] [nvarchar](10) NULL,
	[SST1] [nvarchar](10) NULL,
	[SST2] [nvarchar](10) NULL,
	[SST3] [nvarchar](10) NULL,
	[SST4] [nvarchar](10) NULL,
	[SST5] [nvarchar](10) NULL,
	[SSG1] [nvarchar](10) NULL,
	[SSG2] [nvarchar](10) NULL,
	[SSG3] [nvarchar](10) NULL,
	[SSG4] [nvarchar](10) NULL,
	[DHS1] [nvarchar](10) NULL,
	[DHS2] [nvarchar](10) NULL,
	[DHS3] [nvarchar](10) NULL,
	[DHS4] [nvarchar](10) NULL,
	[SSCP1] [nvarchar](10) NULL,
	[SSCP2] [nvarchar](10) NULL,
	[SSCP3] [nvarchar](10) NULL,
	[SSCP4] [nvarchar](10) NULL,
	[SSCP5] [nvarchar](10) NULL,
	[KiemtraSaiSo] [nvarchar](10) NULL,
	[KetLuan] [nvarchar](100) NULL,
	[DiaChiSD] [nvarchar](100) NULL,
	[GCN] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoBienBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[canloxo] ([SoBienBan], [SoCan], [TenCan], [Kieu], [CapChinhXac], [NuocSX], [NamSX], [CheDoKD], [NgayKD], [Max], [Min], [DoChia], [DoChiaKiem], [PPTH], [DonViSD], [KiemDinhVien], [SoTem], [NhanMac], [Tem], [DayDu], [DongHoThangDo], [BoPhan], [KiemtraNgoai], [DDCT1min], [DDCT105max], [DDCT1max], [DDGTmin], [DDGT05max], [DDGTmax], [DDCT2min], [DDCT205max], [DDCT2max], [DDmin], [DD05max], [DDmax], [KiemtraDoDong], [LLCT1min], [LLCT105max], [LLCT1max], [LLCT2min], [LLCT205max], [LLCT2max], [LLCT3min], [LLCT305max], [LLCT3max], [LLCLLonmin], [LLCLLon05max], [LLCLLonmax], [LLCLCPmin], [LLCLCP05max], [LLCLCPmax], [KiemtraLapLai], [LTMucTai], [LTChiThiG], [LTChiThiI1], [LTChiThiI2], [LTChiThiI3], [LTChiThiI4], [LTCLLN], [LTCLCP], [KiemtraLechTam], [MTL1], [MTL2], [MTL3], [MTL4], [MTL5], [CTCT1], [CTCT2], [CTCT3], [CTCT4], [CTCT5], [CTCG1], [CTCG2], [CTCG3], [CTCG4], [SST1], [SST2], [SST3], [SST4], [SST5], [SSG1], [SSG2], [SSG3], [SSG4], [DHS1], [DHS2], [DHS3], [DHS4], [SSCP1], [SSCP2], [SSCP3], [SSCP4], [SSCP5], [KiemtraSaiSo], [KetLuan], [DiaChiSD], [GCN]) VALUES (N'211/LX', 1, N'Phương tiện 1', N'5kg       ', N'3         ', N'VN', 2020, N'Thường', N'12/12/2020', N'100', N'10', 0, 5, N'Iso', N'DHQN', N'Dao Duy Tuong', N'21T0003', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'1', N'023', N'3', N'4', N'5', N'6', N'7', N'8', N'9', N'10', N'11', N'12', N'Đạt', N'1', N'02', N'3', N'4', N'5', N'6', N'7', N'7', N'8', N'10', N'11', N'12', N'13', N'14', N'15', N'Đạt', N'1', N'2', N'03', N'04', N'05', N'06', N'7', N'8', N'Đạt', N'01', N'02', N'3', N'04', N'05', N'06', N'07', N'08', N'09', N'010', N'05', N'02', N'04', N'05', N'4', N'54', N'6', N'6', N'6', N'6', N'7', N'5', N'3', N'6', N'72', N'2', N'5', N'3', N'5', N'3', N'6', N'3', N'Đạt', N'Đạt yêu cầu kỹ thuật đo lường', N'QN', N'')
INSERT [dbo].[canloxo] ([SoBienBan], [SoCan], [TenCan], [Kieu], [CapChinhXac], [NuocSX], [NamSX], [CheDoKD], [NgayKD], [Max], [Min], [DoChia], [DoChiaKiem], [PPTH], [DonViSD], [KiemDinhVien], [SoTem], [NhanMac], [Tem], [DayDu], [DongHoThangDo], [BoPhan], [KiemtraNgoai], [DDCT1min], [DDCT105max], [DDCT1max], [DDGTmin], [DDGT05max], [DDGTmax], [DDCT2min], [DDCT205max], [DDCT2max], [DDmin], [DD05max], [DDmax], [KiemtraDoDong], [LLCT1min], [LLCT105max], [LLCT1max], [LLCT2min], [LLCT205max], [LLCT2max], [LLCT3min], [LLCT305max], [LLCT3max], [LLCLLonmin], [LLCLLon05max], [LLCLLonmax], [LLCLCPmin], [LLCLCP05max], [LLCLCPmax], [KiemtraLapLai], [LTMucTai], [LTChiThiG], [LTChiThiI1], [LTChiThiI2], [LTChiThiI3], [LTChiThiI4], [LTCLLN], [LTCLCP], [KiemtraLechTam], [MTL1], [MTL2], [MTL3], [MTL4], [MTL5], [CTCT1], [CTCT2], [CTCT3], [CTCT4], [CTCT5], [CTCG1], [CTCG2], [CTCG3], [CTCG4], [SST1], [SST2], [SST3], [SST4], [SST5], [SSG1], [SSG2], [SSG3], [SSG4], [DHS1], [DHS2], [DHS3], [DHS4], [SSCP1], [SSCP2], [SSCP3], [SSCP4], [SSCP5], [KiemtraSaiSo], [KetLuan], [DiaChiSD], [GCN]) VALUES (N'212/LX', 2, N'Cân đồng hồ lò xo', N'CĐH15     ', N'III       ', N'Nhơn Hòa-Việt Nam', 2019, N'Định kỳ', N'11/06/2021', N'15', N'0.5', 50, 50, N'ĐLVN 30 : 2021', N'Chợ Vườn Chuối', N'Dao Duy Tuong', N'Tem2', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'0,5', N'7,475', N'14,95', N'25,00', N'50,00', N'75,00', N'0,525', N'7,525', N'15,025', N'25/25', N'50/50', N'75/75', N'Đạt', N'0,5', N'7,475', N'14,95', N'0,5', N'7,475', N'14,95', N'0,5', N'7,5', N'14,975', N',00', N'25,00', N'25,00', N'25,00', N'50,00', N'75,00', N'Đạt', N'5', N'5', N'5', N'5', N'5', N'5', N'0', N'50,00', N'Đạt', N'0,5', N'2,5', N'7,5', N'10', N'15', N'0,5', N'2,5', N'7,475', N'9,975', N'14,95', N'0,5', N'2,5', N'7,5', N'9,975', N',00', N',00', N'-25,00', N'-25,00', N'-50,00', N',00', N',00', N',00', N'-25,00', N',00', N',00', N'25,00', N',00', N'+/- ,025', N'+/- ,025', N'+/- ,05', N'+/- ,05', N'+/- ,075', N'Đạt', N'Đạt yêu cầu kỹ thuật đo lường', N'Nguyễn Đình Chiểu, Quận 3, Tp. Hồ Chí Minh', N'212/GCNCLX')
INSERT [dbo].[canloxo] ([SoBienBan], [SoCan], [TenCan], [Kieu], [CapChinhXac], [NuocSX], [NamSX], [CheDoKD], [NgayKD], [Max], [Min], [DoChia], [DoChiaKiem], [PPTH], [DonViSD], [KiemDinhVien], [SoTem], [NhanMac], [Tem], [DayDu], [DongHoThangDo], [BoPhan], [KiemtraNgoai], [DDCT1min], [DDCT105max], [DDCT1max], [DDGTmin], [DDGT05max], [DDGTmax], [DDCT2min], [DDCT205max], [DDCT2max], [DDmin], [DD05max], [DDmax], [KiemtraDoDong], [LLCT1min], [LLCT105max], [LLCT1max], [LLCT2min], [LLCT205max], [LLCT2max], [LLCT3min], [LLCT305max], [LLCT3max], [LLCLLonmin], [LLCLLon05max], [LLCLLonmax], [LLCLCPmin], [LLCLCP05max], [LLCLCPmax], [KiemtraLapLai], [LTMucTai], [LTChiThiG], [LTChiThiI1], [LTChiThiI2], [LTChiThiI3], [LTChiThiI4], [LTCLLN], [LTCLCP], [KiemtraLechTam], [MTL1], [MTL2], [MTL3], [MTL4], [MTL5], [CTCT1], [CTCT2], [CTCT3], [CTCT4], [CTCT5], [CTCG1], [CTCG2], [CTCG3], [CTCG4], [SST1], [SST2], [SST3], [SST4], [SST5], [SSG1], [SSG2], [SSG3], [SSG4], [DHS1], [DHS2], [DHS3], [DHS4], [SSCP1], [SSCP2], [SSCP3], [SSCP4], [SSCP5], [KiemtraSaiSo], [KetLuan], [DiaChiSD], [GCN]) VALUES (N'213/LX', 3, N'Cân đồng hồ lò xo', N'CĐH15     ', N'III       ', N'Nhơn Hòa-Việt Nam', 2019, N'Định kỳ', N'16/06/2021', N'15', N'0.5', 50, 50, N'ĐLVN 30 : 2021', N'Chợ Vườn Chuối', N'Tran Toan Thang', N'21T0001', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'0.5', N'7.475', N'14.95', N'25.00', N'50.00', N'75.00', N'0.525', N'7.525', N'15.025', N'25/25', N'50/50', N'75/75', N'Đạt', N'0.5', N'7.475', N'14.95', N'0.5', N'7.475', N'14.95', N'0.5', N'7.5', N'14.975', N'.00', N'25.00', N'25.00', N'25.00', N'50.00', N'75.00', N'Đạt', N'5', N'5', N'5', N'5', N'5', N'5', N'0', N'50.00', N'Đạt', N'0.5', N'2.5', N'7.5', N'10', N'15', N'0.5', N'2.5', N'7.475', N'9.975', N'14.95', N'0.5', N'2.5', N'7.5', N'9.975', N'.00', N'.00', N'-25.00', N'-25.00', N'-50.00', N'.00', N'.00', N'.00', N'-25.00', N'.00', N'.00', N'25.00', N'.00', N'.025', N'.025', N'.05', N'.05', N'.075', N'Đạt', N'Đạt yêu cầu kỹ thuật đo lường', N'Nguyễn Đình Chiểu, Quận 3, Tp. Hồ Chí Minh', N'')
INSERT [dbo].[canloxo] ([SoBienBan], [SoCan], [TenCan], [Kieu], [CapChinhXac], [NuocSX], [NamSX], [CheDoKD], [NgayKD], [Max], [Min], [DoChia], [DoChiaKiem], [PPTH], [DonViSD], [KiemDinhVien], [SoTem], [NhanMac], [Tem], [DayDu], [DongHoThangDo], [BoPhan], [KiemtraNgoai], [DDCT1min], [DDCT105max], [DDCT1max], [DDGTmin], [DDGT05max], [DDGTmax], [DDCT2min], [DDCT205max], [DDCT2max], [DDmin], [DD05max], [DDmax], [KiemtraDoDong], [LLCT1min], [LLCT105max], [LLCT1max], [LLCT2min], [LLCT205max], [LLCT2max], [LLCT3min], [LLCT305max], [LLCT3max], [LLCLLonmin], [LLCLLon05max], [LLCLLonmax], [LLCLCPmin], [LLCLCP05max], [LLCLCPmax], [KiemtraLapLai], [LTMucTai], [LTChiThiG], [LTChiThiI1], [LTChiThiI2], [LTChiThiI3], [LTChiThiI4], [LTCLLN], [LTCLCP], [KiemtraLechTam], [MTL1], [MTL2], [MTL3], [MTL4], [MTL5], [CTCT1], [CTCT2], [CTCT3], [CTCT4], [CTCT5], [CTCG1], [CTCG2], [CTCG3], [CTCG4], [SST1], [SST2], [SST3], [SST4], [SST5], [SSG1], [SSG2], [SSG3], [SSG4], [DHS1], [DHS2], [DHS3], [DHS4], [SSCP1], [SSCP2], [SSCP3], [SSCP4], [SSCP5], [KiemtraSaiSo], [KetLuan], [DiaChiSD], [GCN]) VALUES (N'214/LX', 4, N'Cân đồng hồ lò xo 4', N'CĐH15     ', N'III       ', N'Nhơn Hòa-Việt Nam', 2019, N'Định kỳ', N'16/06/2021', N'15', N'0.5', 50, 50, N'ĐLVN 30 : 2021', N'Chợ Vườn Chuối', N'Dao Duy Tuong', N'', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'0.5', N'7.475', N'14.95', N'25.00', N'50.00', N'75.00', N'0.525', N'7.525', N'15.025', N'25/25', N'50/50', N'75/75', N'Đạt', N'0.5', N'7.475', N'14.95', N'0.5', N'7.475', N'14.95', N'0.5', N'7.5', N'14.975', N'.00', N'25.00', N'25.00', N'25.00', N'50.00', N'75.00', N'Đạt', N'5', N'5', N'5', N'5', N'5', N'5', N'0', N'50.00', N'Đạt', N'0.5', N'2.5', N'7.5', N'10', N'15', N'0.5', N'2.5', N'7.475', N'9.975', N'14.95', N'0.5', N'2.5', N'7.5', N'9.975', N'.00', N'.00', N'-25.00', N'-25.00', N'-50.00', N'.00', N'.00', N'.00', N'-25.00', N'.00', N'.00', N'25.00', N'.00', N'.025', N'.025', N'.05', N'.05', N'.075', N'Đạt', N'Đạt yêu cầu kỹ thuật đo lường', N'Nguyễn Đình Chiểu, Quận 3, Tp. Hồ Chí Minh', N'')
INSERT [dbo].[canloxo] ([SoBienBan], [SoCan], [TenCan], [Kieu], [CapChinhXac], [NuocSX], [NamSX], [CheDoKD], [NgayKD], [Max], [Min], [DoChia], [DoChiaKiem], [PPTH], [DonViSD], [KiemDinhVien], [SoTem], [NhanMac], [Tem], [DayDu], [DongHoThangDo], [BoPhan], [KiemtraNgoai], [DDCT1min], [DDCT105max], [DDCT1max], [DDGTmin], [DDGT05max], [DDGTmax], [DDCT2min], [DDCT205max], [DDCT2max], [DDmin], [DD05max], [DDmax], [KiemtraDoDong], [LLCT1min], [LLCT105max], [LLCT1max], [LLCT2min], [LLCT205max], [LLCT2max], [LLCT3min], [LLCT305max], [LLCT3max], [LLCLLonmin], [LLCLLon05max], [LLCLLonmax], [LLCLCPmin], [LLCLCP05max], [LLCLCPmax], [KiemtraLapLai], [LTMucTai], [LTChiThiG], [LTChiThiI1], [LTChiThiI2], [LTChiThiI3], [LTChiThiI4], [LTCLLN], [LTCLCP], [KiemtraLechTam], [MTL1], [MTL2], [MTL3], [MTL4], [MTL5], [CTCT1], [CTCT2], [CTCT3], [CTCT4], [CTCT5], [CTCG1], [CTCG2], [CTCG3], [CTCG4], [SST1], [SST2], [SST3], [SST4], [SST5], [SSG1], [SSG2], [SSG3], [SSG4], [DHS1], [DHS2], [DHS3], [DHS4], [SSCP1], [SSCP2], [SSCP3], [SSCP4], [SSCP5], [KiemtraSaiSo], [KetLuan], [DiaChiSD], [GCN]) VALUES (N'215/LX', 4, N'Cân đồng hồ lò xo 5', N'CĐH15     ', N'III       ', N'Nhơn Hòa-Việt Nam', 2019, N'Định kỳ', N'16/06/2021', N'15', N'0.5', 50, 50, N'ĐLVN 30 : 2021', N'Chợ Vườn Chuối', N'Dao Duy Tuong', N'', N'Không đạt', N'Không đạt', N'Không đạt', N'Không đạt', N'Không đạt', N'Không đạt', N'0.5', N'7.475', N'14.95', N'25.00', N'50.00', N'75.00', N'0.525', N'7.525', N'15.025', N'25/25', N'50/50', N'75/75', N'Đạt', N'0.5', N'7.475', N'14.95', N'0.5', N'7.475', N'14.95', N'0.5', N'7.5', N'14.975', N'.00', N'25.00', N'25.00', N'25.00', N'50.00', N'75.00', N'Đạt', N'5', N'5', N'5', N'5', N'5', N'5', N'0', N'50.00', N'Đạt', N'0.5', N'2.5', N'7.5', N'10', N'15', N'0.5', N'2.5', N'7.475', N'9.975', N'14.95', N'0.5', N'2.5', N'7.5', N'9.975', N'.00', N'.00', N'-25.00', N'-25.00', N'-50.00', N'.00', N'.00', N'.00', N'-25.00', N'.00', N'.00', N'25.00', N'.00', N'.025', N'.025', N'.05', N'.05', N'.075', N'Đạt', N'Không đạt yêu cầu kỹ thuật đo lường', N'Nguyễn Đình Chiểu, Quận 3, Tp. Hồ Chí Minh', N'')
INSERT [dbo].[canloxo] ([SoBienBan], [SoCan], [TenCan], [Kieu], [CapChinhXac], [NuocSX], [NamSX], [CheDoKD], [NgayKD], [Max], [Min], [DoChia], [DoChiaKiem], [PPTH], [DonViSD], [KiemDinhVien], [SoTem], [NhanMac], [Tem], [DayDu], [DongHoThangDo], [BoPhan], [KiemtraNgoai], [DDCT1min], [DDCT105max], [DDCT1max], [DDGTmin], [DDGT05max], [DDGTmax], [DDCT2min], [DDCT205max], [DDCT2max], [DDmin], [DD05max], [DDmax], [KiemtraDoDong], [LLCT1min], [LLCT105max], [LLCT1max], [LLCT2min], [LLCT205max], [LLCT2max], [LLCT3min], [LLCT305max], [LLCT3max], [LLCLLonmin], [LLCLLon05max], [LLCLLonmax], [LLCLCPmin], [LLCLCP05max], [LLCLCPmax], [KiemtraLapLai], [LTMucTai], [LTChiThiG], [LTChiThiI1], [LTChiThiI2], [LTChiThiI3], [LTChiThiI4], [LTCLLN], [LTCLCP], [KiemtraLechTam], [MTL1], [MTL2], [MTL3], [MTL4], [MTL5], [CTCT1], [CTCT2], [CTCT3], [CTCT4], [CTCT5], [CTCG1], [CTCG2], [CTCG3], [CTCG4], [SST1], [SST2], [SST3], [SST4], [SST5], [SSG1], [SSG2], [SSG3], [SSG4], [DHS1], [DHS2], [DHS3], [DHS4], [SSCP1], [SSCP2], [SSCP3], [SSCP4], [SSCP5], [KiemtraSaiSo], [KetLuan], [DiaChiSD], [GCN]) VALUES (N'216/LX', 4, N'Cân đồng hồ lò xo 5', N'CĐH15     ', N'III       ', N'Nhơn Hòa-Việt Nam', 2019, N'Định kỳ', N'16/06/2021', N'15', N'0.5', 50, 50, N'ĐLVN 30 : 2021', N'Chợ Vườn Chuối', N'Dao Duy Tuong', N'', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'Đạt', N'0.5', N'7.475', N'14.95', N'25.00', N'50.00', N'75.00', N'0.525', N'7.525', N'15.025', N'25/25', N'50/50', N'75/75', N'Đạt', N'0.5', N'7.475', N'14.95', N'0.5', N'7.475', N'14.95', N'0.5', N'7.5', N'14.975', N'.00', N'25.00', N'25.00', N'25.00', N'50.00', N'75.00', N'Đạt', N'5', N'5', N'5', N'5', N'5', N'5', N'0', N'50.00', N'Đạt', N'0.5', N'2.5', N'7.5', N'10', N'15', N'0.5', N'2.5', N'7.475', N'9.975', N'14.95', N'0.5', N'2.5', N'7.5', N'9.975', N'.00', N'.00', N'-25.00', N'-25.00', N'-50.00', N'.00', N'.00', N'.00', N'-25.00', N'.00', N'.00', N'25.00', N'.00', N'.025', N'.025', N'.05', N'.05', N'.075', N'Đạt', N'Đạt yêu cầu kỹ thuật đo lường', N'Nguyễn Đình Chiểu, Quận 3, Tp. Hồ Chí Minh', N'211/GCNCLX')
