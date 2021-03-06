USE [master]
GO
/****** Object:  Database [dbClasses]    Script Date: 20/04/2020 19:08:25 ******/
CREATE DATABASE [dbClasses] ON  PRIMARY 
( NAME = N'dbClasses', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbClasses.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbClasses_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbClasses_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbClasses].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbClasses] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbClasses] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbClasses] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbClasses] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbClasses] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbClasses] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbClasses] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbClasses] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbClasses] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbClasses] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbClasses] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbClasses] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbClasses] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbClasses] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbClasses] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbClasses] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbClasses] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbClasses] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbClasses] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbClasses] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbClasses] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbClasses] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbClasses] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbClasses] SET  MULTI_USER 
GO
ALTER DATABASE [dbClasses] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbClasses] SET DB_CHAINING OFF 
GO
USE [dbClasses]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 20/04/2020 19:08:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](50) NOT NULL,
	[Adress] [nvarchar](100) NOT NULL,
	[Phone] [int] NOT NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK__Person__3214EC07CD625DD6] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [Adress], [Phone], [Date]) VALUES (3, N'SAMUEL', N'MAMANI', N's@gmail.com', N'Nada', 6543234, CAST(N'1990-01-01' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [Adress], [Phone], [Date]) VALUES (4, N'WILDER', N'COPA', N'wil@gmail.com', N'nose ', 7352453, CAST(N'2020-02-26' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [Adress], [Phone], [Date]) VALUES (9, N'test', N'test', N'tes', N'test', 7373, CAST(N'2020-03-24' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [Adress], [Phone], [Date]) VALUES (10, N'tres', N'tres', N'tres', N'tres', 736, CAST(N'2020-03-24' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [Adress], [Phone], [Date]) VALUES (15, N'MANUEL', N'LOPEZ', N'mgmail.com', N'Las lomas tadeo', 783673, CAST(N'2017-04-07' AS Date))
SET IDENTITY_INSERT [dbo].[Person] OFF
USE [master]
GO
ALTER DATABASE [dbClasses] SET  READ_WRITE 
GO
