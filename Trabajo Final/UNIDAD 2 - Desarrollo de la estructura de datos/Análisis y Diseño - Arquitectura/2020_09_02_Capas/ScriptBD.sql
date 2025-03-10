USE [master]
GO
/****** Object:  Database [Gestion]    Script Date: 22/05/2020 23:11:37 ******/
CREATE DATABASE [Gestion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Gestion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gestion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Gestion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Gestion] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestion] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gestion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gestion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestion] SET RECOVERY FULL 
GO
ALTER DATABASE [Gestion] SET  MULTI_USER 
GO
ALTER DATABASE [Gestion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gestion] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Gestion', N'ON'
GO
ALTER DATABASE [Gestion] SET QUERY_STORE = OFF
GO
USE [Gestion]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Gestion]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 22/05/2020 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[Legajo] [int] NOT NULL,
	[Nombre] [nvarchar](20) NULL,
	[Apellido] [nvarchar](20) NULL,
	[fecing] [date] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 22/05/2020 23:11:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefono](
	[Tel_id] [int] NOT NULL,
	[Tel_Numero] [nvarchar](20) NULL,
	[Tel_Alu_Legajo] [int] NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[Tel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Alumno] ([Legajo], [Nombre], [Apellido], [fecing], [Activo]) VALUES (1, N'Ana', N'Martinez', CAST(N'2000-01-01' AS Date), 1)
INSERT [dbo].[Alumno] ([Legajo], [Nombre], [Apellido], [fecing], [Activo]) VALUES (2, N'Juancito', N'Perez', CAST(N'2010-02-10' AS Date), 0)
INSERT [dbo].[Alumno] ([Legajo], [Nombre], [Apellido], [fecing], [Activo]) VALUES (3, N'Analia', N'Xeler', CAST(N'2017-09-08' AS Date), 0)
INSERT [dbo].[Alumno] ([Legajo], [Nombre], [Apellido], [fecing], [Activo]) VALUES (4, N'Guillermo', N'Duclos', CAST(N'2012-01-01' AS Date), 1)
INSERT [dbo].[Alumno] ([Legajo], [Nombre], [Apellido], [fecing], [Activo]) VALUES (5, N'Tomas', N'Duclos', CAST(N'2010-01-01' AS Date), 1)
INSERT [dbo].[Alumno] ([Legajo], [Nombre], [Apellido], [fecing], [Activo]) VALUES (6, N'Dario', N'Perez', CAST(N'2020-01-01' AS Date), 1)
INSERT [dbo].[Alumno] ([Legajo], [Nombre], [Apellido], [fecing], [Activo]) VALUES (9, N'Cecilia', N'Argentina', CAST(N'2019-01-01' AS Date), 0)
INSERT [dbo].[Alumno] ([Legajo], [Nombre], [Apellido], [fecing], [Activo]) VALUES (10, N'Sol', N'Carfre', CAST(N'2010-01-01' AS Date), 1)
INSERT [dbo].[Telefono] ([Tel_id], [Tel_Numero], [Tel_Alu_Legajo]) VALUES (1, N'15-5388-3456', 1)
INSERT [dbo].[Telefono] ([Tel_id], [Tel_Numero], [Tel_Alu_Legajo]) VALUES (2, N'4703-234', 1)
INSERT [dbo].[Telefono] ([Tel_id], [Tel_Numero], [Tel_Alu_Legajo]) VALUES (3, N'15-0987-5432', 2)
USE [master]
GO
ALTER DATABASE [Gestion] SET  READ_WRITE 
GO
