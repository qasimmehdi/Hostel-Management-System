USE [master]
GO
/****** Object:  Database [HostelManagement]    Script Date: 4/21/2019 7:36:07 AM ******/
CREATE DATABASE [HostelManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HostelManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS12\MSSQL\DATA\HostelManagement.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HostelManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS12\MSSQL\DATA\HostelManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HostelManagement] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HostelManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HostelManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HostelManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HostelManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HostelManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HostelManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [HostelManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HostelManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HostelManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HostelManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HostelManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HostelManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HostelManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HostelManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HostelManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HostelManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HostelManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HostelManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HostelManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HostelManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HostelManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HostelManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HostelManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HostelManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HostelManagement] SET  MULTI_USER 
GO
ALTER DATABASE [HostelManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HostelManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HostelManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HostelManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [HostelManagement]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 4/21/2019 7:36:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[A_ID] [int] IDENTITY(1,1) NOT NULL,
	[A_Name] [nvarchar](50) NOT NULL,
	[A_Username] [nvarchar](50) NOT NULL,
	[A_Email] [nvarchar](50) NOT NULL,
	[A_Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/21/2019 7:36:07 AM ******/
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
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/21/2019 7:36:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[Furniture_ID] [int] IDENTITY(1,1) NOT NULL,
	[Room_ID] [int] NULL,
	[Furniture_Type] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Furniture_Type]    Script Date: 4/21/2019 7:36:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture_Type](
	[Furniture_ID] [int] IDENTITY(1,1) NOT NULL,
	[Furniture_Type] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hostel]    Script Date: 4/21/2019 7:36:07 AM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 4/21/2019 7:36:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[S_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_Username] [nvarchar](50) NOT NULL,
	[S_Email] [nvarchar](50) NOT NULL,
	[S_Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 4/21/2019 7:36:07 AM ******/
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
/****** Object:  Table [dbo].[Room]    Script Date: 4/21/2019 7:36:07 AM ******/
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
/****** Object:  Table [dbo].[S_Allocation]    Script Date: 4/21/2019 7:36:07 AM ******/
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
/****** Object:  Table [dbo].[Students]    Script Date: 4/21/2019 7:36:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[S_ID] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Visitor]    Script Date: 4/21/2019 7:36:07 AM ******/
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
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([A_ID], [A_Name], [A_Username], [A_Email], [A_Password]) VALUES (1, N'Shazad Shiraz', N'shazad1', N'shazad@gmail.com', N'1234')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Emp_ID], [Emp_Name], [Job], [Address], [Emp_Salary], [Phone_No], [Building_ID]) VALUES (1, N'Shazad', N'SE', N'h.no 113/5,sector 11-d,North', 5000, N'03203090919', 1)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Furniture] ON 

INSERT [dbo].[Furniture] ([Furniture_ID], [Room_ID], [Furniture_Type]) VALUES (1, 1, N'Sofa')
INSERT [dbo].[Furniture] ([Furniture_ID], [Room_ID], [Furniture_Type]) VALUES (6, 25, N'Bed')
SET IDENTITY_INSERT [dbo].[Furniture] OFF
SET IDENTITY_INSERT [dbo].[Furniture_Type] ON 

INSERT [dbo].[Furniture_Type] ([Furniture_ID], [Furniture_Type]) VALUES (1, N'chair')
INSERT [dbo].[Furniture_Type] ([Furniture_ID], [Furniture_Type]) VALUES (3, N'Bed')
SET IDENTITY_INSERT [dbo].[Furniture_Type] OFF
SET IDENTITY_INSERT [dbo].[Hostel] ON 

INSERT [dbo].[Hostel] ([Building_ID], [Total_Rooms], [Students_Residing], [Annual_Expenses], [Address], [City], [Building_Name]) VALUES (1, 0, 20, 5000, N'Street', N'Karachi', N'Aslam Bhai')
SET IDENTITY_INSERT [dbo].[Hostel] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([S_ID], [S_Username], [S_Email], [S_Password]) VALUES (1, N'qasim', N'qasim@gmail.com', N'1234')
INSERT [dbo].[Login] ([S_ID], [S_Username], [S_Email], [S_Password]) VALUES (2, N'ali', N'ali@gmail.com', N'123')
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([Payment_ID], [Allocation_ID], [Status]) VALUES (1, 1, N'Paid')
INSERT [dbo].[Payment] ([Payment_ID], [Allocation_ID], [Status]) VALUES (2, 1, N'Unpaid')
SET IDENTITY_INSERT [dbo].[Payment] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([Room_ID], [Capacity], [Building_ID]) VALUES (1, 5, 32)
SET IDENTITY_INSERT [dbo].[Room] OFF
SET IDENTITY_INSERT [dbo].[S_Allocation] ON 

INSERT [dbo].[S_Allocation] ([Allocation_ID], [S_ID], [Room_ID], [Start_Date], [End_Date]) VALUES (1, 1, 13, N'01-1-1998', N'1-2-1998')
SET IDENTITY_INSERT [dbo].[S_Allocation] OFF
INSERT [dbo].[Students] ([S_ID], [S_Name], [S_FatherName], [S_University], [Department], [Phone_No], [Age], [Address_of_Origin], [City_of_Origin]) VALUES (3, N'Shahzad', N'Shiraz', N'KIET      ', N'MBA', N'03203090919', 20, N'h.no 113/5,sector 11-d,North Karachi', N'Karac')
INSERT [dbo].[Visitor] ([CNIC], [S_ID], [Visitor_Name], [Times_Visited]) VALUES (N'4210197470841', 20, N'Qasim', 5)
INSERT [dbo].[Visitor] ([CNIC], [S_ID], [Visitor_Name], [Times_Visited]) VALUES (N'234234234', 3, N'Qasim', 3)
USE [master]
GO
ALTER DATABASE [HostelManagement] SET  READ_WRITE 
GO
