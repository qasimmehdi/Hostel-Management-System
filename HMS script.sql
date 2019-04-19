
CREATE TABLE [dbo].[Admin](
	[A_ID] [int] NOT NULL,
	[A_Name] [nvarchar](50) NOT NULL,
	[A_Username] [nvarchar](50) NOT NULL,
	[A_Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Emp_ID] [int] IDENTITY(1,1) NOT NULL,
	[Emp_Name] [nvarchar](50) NULL,
	[Job] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Emp_Salary] [int] NULL,
	[Phone_No] [nvarchar](50) NULL,
	[Building_ID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[Furniture_ID] [int] IDENTITY(1,1) NOT NULL,
	[Room_ID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Furniture_Type]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture_Type](
	[Furniture_ID] [int] IDENTITY(1,1) NOT NULL,
	[Furniture_Type] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hostel]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hostel](
	[Building_ID] [int] IDENTITY(1,1) NOT NULL,
	[Total_Rooms] [int] NOT NULL,
	[Students_Residing] [int] NOT NULL,
	[Annual_Expenses] [int] NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Building_Name] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[S_ID] [int] NOT NULL,
	[S_Username] [nvarchar](50) NOT NULL,
	[S_Email] [nvarchar](50) NOT NULL,
	[S_Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Payment_ID] [int] IDENTITY(1,1) NOT NULL,
	[Allocation_ID] [int] NOT NULL,
	[Status] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[Room_ID] [int] IDENTITY(1,1) NOT NULL,
	[Capacity] [int] NULL,
	[Building_ID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[S_Allocation]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[S_Allocation](
	[Allocation_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_ID] [int] NOT NULL,
	[Room_ID] [int] NOT NULL,
	[Start_Date] [nvarchar](50) NOT NULL,
	[End_Date] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[S_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_Name] [nvarchar](50) NULL,
	[S_FatherName] [nvarchar](50) NULL,
	[S_University] [nchar](10) NULL,
	[Department] [nvarchar](50) NULL,
	[Phone_No] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Address_of_Origin] [nvarchar](50) NULL,
	[City_of_Origin] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Visitor]    Script Date: 4/20/2019 3:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitor](
	[CNIC] [nvarchar](50) NOT NULL,
	[S_ID] [int] NULL,
	[Visitor_Name] [nvarchar](50) NULL,
	[Times_Visited] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Emp_ID], [Emp_Name], [Job], [Address], [Emp_Salary], [Phone_No], [Building_ID]) VALUES (1, N'Shazad', N'SE', N'h.no 113/5,sector 11-d,North', 5000, N'03203090919', 20)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Furniture] ON 

INSERT [dbo].[Furniture] ([Furniture_ID], [Room_ID]) VALUES (1, 24)
SET IDENTITY_INSERT [dbo].[Furniture] OFF
SET IDENTITY_INSERT [dbo].[Furniture_Type] ON 

INSERT [dbo].[Furniture_Type] ([Furniture_ID], [Furniture_Type]) VALUES (1, N'chair')
SET IDENTITY_INSERT [dbo].[Furniture_Type] OFF
SET IDENTITY_INSERT [dbo].[Hostel] ON 

INSERT [dbo].[Hostel] ([Building_ID], [Total_Rooms], [Students_Residing], [Annual_Expenses], [Address], [City], [Building_Name]) VALUES (1, 0, 20, 5000, N'Street', N'Karachi', N'Aslam Bhai')
SET IDENTITY_INSERT [dbo].[Hostel] OFF
INSERT [dbo].[Login] ([S_ID], [S_Username], [S_Email], [S_Password]) VALUES (1, N'qasim', N'qasim@gmail.com', N'123')
INSERT [dbo].[Login] ([S_ID], [S_Username], [S_Email], [S_Password]) VALUES (2, N'ali', N'ali@gmail.com', N'123')
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([Payment_ID], [Allocation_ID], [Status]) VALUES (1, 1, N'unpaid')
INSERT [dbo].[Payment] ([Payment_ID], [Allocation_ID], [Status]) VALUES (2, 12, N'paid')
SET IDENTITY_INSERT [dbo].[Payment] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([Room_ID], [Capacity], [Building_ID]) VALUES (1, 5, 32)
SET IDENTITY_INSERT [dbo].[Room] OFF
SET IDENTITY_INSERT [dbo].[S_Allocation] ON 

INSERT [dbo].[S_Allocation] ([Allocation_ID], [S_ID], [Room_ID], [Start_Date], [End_Date]) VALUES (1, 1, 13, N'01-1-1998', N'1-2-1998')
SET IDENTITY_INSERT [dbo].[S_Allocation] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([S_ID], [S_Name], [S_FatherName], [S_University], [Department], [Phone_No], [Age], [Address_of_Origin], [City_of_Origin]) VALUES (3, N'Shahzad', N'Shiraz', N'KIET      ', N'MBA', N'03203090919', 20, N'h.no 113/5,sector 11-d,North Karachi', N'Karac')
SET IDENTITY_INSERT [dbo].[Students] OFF
INSERT [dbo].[Visitor] ([CNIC], [S_ID], [Visitor_Name], [Times_Visited]) VALUES (N'4210197470841', 20, N'Qasim', 5)

