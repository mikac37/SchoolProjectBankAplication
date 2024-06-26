USE [Banka]
GO
ALTER TABLE [dbo].[Klijent] DROP CONSTRAINT [FK_Klijent_Racun]
GO
/****** Object:  Table [dbo].[Racun]    Script Date: 19.06.2024 11:32:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Racun]') AND type in (N'U'))
DROP TABLE [dbo].[Racun]
GO
/****** Object:  Table [dbo].[Klijent]    Script Date: 19.06.2024 11:32:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Klijent]') AND type in (N'U'))
DROP TABLE [dbo].[Klijent]
GO
/****** Object:  Table [dbo].[Klijent]    Script Date: 19.06.2024 11:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klijent](
	[IDKlijent] [int] NOT NULL,
	[ImePrezime] [nvarchar](50) NOT NULL,
	[Stanje] [int] NOT NULL,
	[Racun] [int] NOT NULL,
 CONSTRAINT [PK_Klijent] PRIMARY KEY CLUSTERED 
(
	[IDKlijent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Racun]    Script Date: 19.06.2024 11:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Racun](
	[IDRacun] [int] NOT NULL,
	[Tip] [nvarchar](50) NOT NULL,
	[Kartica] [nvarchar](50) NOT NULL,
	[Cekovi] [int] NOT NULL,
 CONSTRAINT [PK_Racun] PRIMARY KEY CLUSTERED 
(
	[IDRacun] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Klijent] ([IDKlijent], [ImePrezime], [Stanje], [Racun]) VALUES (1, N'Pera Peric', 1000, 1)
INSERT [dbo].[Klijent] ([IDKlijent], [ImePrezime], [Stanje], [Racun]) VALUES (2, N'Marko Markovic', 1500, 2)
INSERT [dbo].[Klijent] ([IDKlijent], [ImePrezime], [Stanje], [Racun]) VALUES (3, N'Petar Petrovic', 2000, 3)
INSERT [dbo].[Klijent] ([IDKlijent], [ImePrezime], [Stanje], [Racun]) VALUES (4, N'Ana Ivanovic', 2500, 4)
INSERT [dbo].[Klijent] ([IDKlijent], [ImePrezime], [Stanje], [Racun]) VALUES (5, N'Jelena Nikolic', 3000, 5)
GO
INSERT [dbo].[Racun] ([IDRacun], [Tip], [Kartica], [Cekovi]) VALUES (1, N'Namenski', N'da', 5)
INSERT [dbo].[Racun] ([IDRacun], [Tip], [Kartica], [Cekovi]) VALUES (2, N'Nenamenski', N'ne', 5)
INSERT [dbo].[Racun] ([IDRacun], [Tip], [Kartica], [Cekovi]) VALUES (3, N'Dinarski', N'da', 5)
INSERT [dbo].[Racun] ([IDRacun], [Tip], [Kartica], [Cekovi]) VALUES (4, N'Devizni', N'ne', 5)
INSERT [dbo].[Racun] ([IDRacun], [Tip], [Kartica], [Cekovi]) VALUES (5, N'Devizni', N'da', 6)
GO
ALTER TABLE [dbo].[Klijent]  WITH CHECK ADD  CONSTRAINT [FK_Klijent_Racun] FOREIGN KEY([Racun])
REFERENCES [dbo].[Racun] ([IDRacun])
GO
ALTER TABLE [dbo].[Klijent] CHECK CONSTRAINT [FK_Klijent_Racun]
GO
