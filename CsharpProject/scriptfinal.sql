USE [connectdb]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/4/2021 1:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [nchar](30) NOT NULL,
	[EmpName] [nchar](100) NOT NULL,
	[Password] [nchar](13) NOT NULL,
	[Phone] [nchar](15) NOT NULL,
	[Salary] [int] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Role] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movie]    Script Date: 5/4/2021 1:19:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieId] [nchar](10) NOT NULL,
	[Title] [nchar](100) NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[Income] [int] NOT NULL,
	[IDBM] [float] NOT NULL,
	[Genre] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderHistory]    Script Date: 5/4/2021 1:19:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderHistory](
	[Id] [nchar](10) NOT NULL,
	[Item] [nchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Date] [nchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/4/2021 1:19:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[pid] [nchar](10) NOT NULL,
	[pname] [nchar](30) NOT NULL,
	[price] [int] NOT NULL,
	[catagory] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Employee] ([Id], [EmpName], [Password], [Phone], [Salary], [Address], [Role]) VALUES (N'E-001                         ', N'Tarek                                                                                               ', N'123          ', N'01609439416    ', 40000, N'Ashara,Cumilla', N'owner     ')
INSERT [dbo].[Employee] ([Id], [EmpName], [Password], [Phone], [Salary], [Address], [Role]) VALUES (N'E-002                         ', N'Sagor                                                                                               ', N'456          ', N'1309654456     ', 25000, N'kuril', N'manager   ')
INSERT [dbo].[Employee] ([Id], [EmpName], [Password], [Phone], [Salary], [Address], [Role]) VALUES (N'E-003                         ', N'Naima                                                                                               ', N'123          ', N'01234567896    ', 1234, N'aefd', N'salesman  ')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [Income], [IDBM], [Genre]) VALUES (N'm-001     ', N'Saw7                                                                                                ', CAST(N'2008-03-14' AS Date), 435, 5.8, N'Horror              ')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [Income], [IDBM], [Genre]) VALUES (N'm-002     ', N'The Nun                                                                                             ', CAST(N'2015-04-07' AS Date), 535, 6.8, N'Horror              ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-000     ', N'burger                                            ', 300, 0, 1, N'12-3-2000                                         ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-001     ', N'chichen Fry                                       ', 100, 10, 1, N'5/2/2021 9:44:07 PM                               ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-002     ', N'chichen Fry                                       ', 100, 0, 2, N'5/2/2021 9:46:34 PM                               ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-002     ', N'maxican Burger                                    ', 300, 0, 2, N'5/2/2021 9:46:45 PM                               ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-002     ', N'chichen Fry                                       ', 100, 10, 2, N'5/2/2021 9:47:07 PM                               ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-003     ', N'chichen Fry                                       ', 180, 10, 2, N'5/2/2021 10:03:02 PM                              ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-004     ', N'chichen Fry                                       ', 200, 0, 2, N'5/2/2021 10:05:20 PM                              ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-005     ', N'maxican Burger                                    ', 540, 10, 2, N'5/2/2021 10:05:47 PM                              ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-006     ', N'Chicken Grill                                     ', 360, 0, 1, N'5/3/2021 10:32:54 PM                              ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-007     ', N'chichen Fry                                       ', 300, 0, 3, N'5/4/2021 12:28:45 AM                              ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-007     ', N'Rice                                              ', 85, 5, 3, N'5/4/2021 12:29:47 AM                              ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-008     ', N'maxican Burger                                    ', 600, 0, 2, N'5/4/2021 12:41:39 AM                              ')
INSERT [dbo].[OrderHistory] ([Id], [Item], [Price], [Discount], [Quantity], [Date]) VALUES (N'O-008     ', N'Mixed Shawrma                                     ', 150, 0, 1, N'5/4/2021 12:42:06 AM                              ')
INSERT [dbo].[Product] ([pid], [pname], [price], [catagory]) VALUES (N'P-002     ', N'maxican Burger                ', 300, N'Fast Food                     ')
INSERT [dbo].[Product] ([pid], [pname], [price], [catagory]) VALUES (N'P-003     ', N'chichen Fry                   ', 100, N'Fast Food                     ')
INSERT [dbo].[Product] ([pid], [pname], [price], [catagory]) VALUES (N'P-004     ', N'Cocacola                      ', 35, N'Soft Drinks                   ')
INSERT [dbo].[Product] ([pid], [pname], [price], [catagory]) VALUES (N'P-005     ', N'Rice                          ', 30, N'Bangla                        ')
INSERT [dbo].[Product] ([pid], [pname], [price], [catagory]) VALUES (N'P-006     ', N'American Pizza                ', 300, N'Fast Food                     ')
INSERT [dbo].[Product] ([pid], [pname], [price], [catagory]) VALUES (N'P-007     ', N'Chicken Grill                 ', 360, N'Chiness                       ')
INSERT [dbo].[Product] ([pid], [pname], [price], [catagory]) VALUES (N'P-008     ', N'Mixed Shawrma                 ', 150, N'Fast Food                     ')
