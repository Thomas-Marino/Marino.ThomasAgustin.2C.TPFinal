USE [master]
GO
/****** Object:  Database [DeliveredDB]    Script Date: 18/11/2023 05:42:28 ******/
CREATE DATABASE [DeliveredDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DeliveredDB', FILENAME = N'D:\SQL\MSSQL16.MSSQLSERVER\MSSQL\DATA\DeliveredDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DeliveredDB_log', FILENAME = N'D:\SQL\MSSQL16.MSSQLSERVER\MSSQL\DATA\DeliveredDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DeliveredDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeliveredDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DeliveredDB] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [DeliveredDB] SET ANSI_NULLS ON 
GO
ALTER DATABASE [DeliveredDB] SET ANSI_PADDING ON 
GO
ALTER DATABASE [DeliveredDB] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [DeliveredDB] SET ARITHABORT ON 
GO
ALTER DATABASE [DeliveredDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DeliveredDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DeliveredDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DeliveredDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DeliveredDB] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [DeliveredDB] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [DeliveredDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DeliveredDB] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [DeliveredDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DeliveredDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DeliveredDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DeliveredDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DeliveredDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DeliveredDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DeliveredDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DeliveredDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DeliveredDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DeliveredDB] SET RECOVERY FULL 
GO
ALTER DATABASE [DeliveredDB] SET  MULTI_USER 
GO
ALTER DATABASE [DeliveredDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DeliveredDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DeliveredDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DeliveredDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DeliveredDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DeliveredDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DeliveredDB', N'ON'
GO
ALTER DATABASE [DeliveredDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [DeliveredDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DeliveredDB]
GO
/****** Object:  Table [dbo].[personas]    Script Date: 18/11/2023 05:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personas](
	[dni] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[usuario] [varchar](15) NOT NULL,
	[contraseña] [varchar](12) NOT NULL,
 CONSTRAINT [pk_dni] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 18/11/2023 05:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[categoria] [varchar](20) NOT NULL,
	[precio] [float] NOT NULL,
	[stock] [int] NOT NULL,
	[publicador] [varchar](15) NOT NULL,
 CONSTRAINT [pk_id_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [usuario], [contraseña]) VALUES (33823250, N'Pepe', N'Martinez', N'PepeVentas', N'PepeVentas')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [usuario], [contraseña]) VALUES (44823250, N'Thomas', N'Marino', N'Toti_22', N'Prueba')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [usuario], [contraseña]) VALUES (99999999, N'Elon', N'Musk', N'Elon_musk', N'123')
GO
SET IDENTITY_INSERT [dbo].[productos] ON 

INSERT [dbo].[productos] ([id_producto], [nombre], [categoria], [precio], [stock], [publicador]) VALUES (5015, N'Auriculares usados', N'Tecnología', 20000, 1, N'Toti_22')
INSERT [dbo].[productos] ([id_producto], [nombre], [categoria], [precio], [stock], [publicador]) VALUES (5016, N'Mesita de luz', N'Muebles', 15000, 1, N'Toti_22')
INSERT [dbo].[productos] ([id_producto], [nombre], [categoria], [precio], [stock], [publicador]) VALUES (5017, N'Bicicleta usada', N'Vehiculos', 35000, 1, N'Toti_22')
INSERT [dbo].[productos] ([id_producto], [nombre], [categoria], [precio], [stock], [publicador]) VALUES (5018, N'Caja de herramientas', N'Herramientas', 10000, 1, N'Toti_22')
INSERT [dbo].[productos] ([id_producto], [nombre], [categoria], [precio], [stock], [publicador]) VALUES (5019, N'Tesla model R2D2', N'Vehiculos', 5000000, 50, N'Elon_musk')
INSERT [dbo].[productos] ([id_producto], [nombre], [categoria], [precio], [stock], [publicador]) VALUES (5020, N'Sillon de dos plazas', N'Muebles', 300000, 3, N'PepeVentas')
INSERT [dbo].[productos] ([id_producto], [nombre], [categoria], [precio], [stock], [publicador]) VALUES (5021, N'Sillas de comedor ', N'Muebles', 12000, 12, N'PepeVentas')
INSERT [dbo].[productos] ([id_producto], [nombre], [categoria], [precio], [stock], [publicador]) VALUES (5022, N'Martillo premium', N'Herramientas', 50000, 10, N'PepeVentas')
SET IDENTITY_INSERT [dbo].[productos] OFF
GO
USE [master]
GO
ALTER DATABASE [DeliveredDB] SET  READ_WRITE 
GO
