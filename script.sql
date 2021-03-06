USE [master]
GO
/****** Object:  Database [TPFinal]    Script Date: 4/8/2020 01:38:25 ******/
CREATE DATABASE [TPFinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TPFinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TPFinal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TPFinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TPFinal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TPFinal] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TPFinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TPFinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPFinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPFinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPFinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPFinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPFinal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TPFinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPFinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPFinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPFinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPFinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPFinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPFinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPFinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPFinal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TPFinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPFinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPFinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPFinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPFinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPFinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPFinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPFinal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TPFinal] SET  MULTI_USER 
GO
ALTER DATABASE [TPFinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPFinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPFinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPFinal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TPFinal] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TPFinal]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 4/8/2020 01:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caja](
	[id_caja] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [float] NULL,
 CONSTRAINT [PK_Caja] PRIMARY KEY CLUSTERED 
(
	[id_caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 4/8/2020 01:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cli] [int] IDENTITY(1,1) NOT NULL,
	[Nom_cli] [varchar](50) NULL,
	[Ape_cli] [nvarchar](50) NULL,
	[DNI_cli] [int] NULL,
	[Mail_cli] [nvarchar](50) NULL,
	[Cel_cli] [nvarchar](15) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 4/8/2020 01:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compras](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[fecha_compra] [date] NULL,
	[monto_compra] [float] NULL,
	[proveedorDeCompra] [varchar](1000) NULL,
	[prodComprado] [varchar](100) NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MovExtras]    Script Date: 4/8/2020 01:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MovExtras](
	[ID_ME] [int] IDENTITY(1,1) NOT NULL,
	[MONTO] [float] NOT NULL,
	[ING] [varchar](2) NULL,
	[EGR] [varchar](2) NULL,
	[FECHA] [date] NULL,
	[HORA] [time](7) NULL,
	[CONCEPTO] [nvarchar](50) NULL,
 CONSTRAINT [PK_MovExtras] PRIMARY KEY CLUSTERED 
(
	[ID_ME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 4/8/2020 01:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_prod] [int] IDENTITY(1,1) NOT NULL,
	[Nom_prod] [nvarchar](50) NULL,
	[Tipo_prod] [nvarchar](50) NULL,
	[Precio_pro] [float] NULL,
	[Stock_pro] [int] NULL,
	[PrecioCompra_prod] [float] NULL,
	[Marca_pro] [nvarchar](50) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 4/8/2020 01:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[id_prov] [int] IDENTITY(1,1) NOT NULL,
	[Nom_prov] [nvarchar](50) NULL,
	[Dir_prov] [nvarchar](50) NULL,
	[Tel_prov] [nvarchar](50) NULL,
	[Mail_prov] [nvarchar](50) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[id_prov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 4/8/2020 01:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[id_vent] [int] IDENTITY(1,1) NOT NULL,
	[Cli_ven] [varchar](120) NULL,
	[Total_vendido] [float] NULL,
	[Remito_ven] [int] NULL,
	[Fecha_ven] [date] NULL,
	[Hora_ven] [time](7) NULL,
	[Detalle_Ven] [nvarchar](500) NULL,
	[Evento] [nchar](10) NULL,
	[FechaEvento] [date] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[id_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Caja] ON 

INSERT [dbo].[Caja] ([id_caja], [Monto]) VALUES (1, 110300)
SET IDENTITY_INSERT [dbo].[Caja] OFF
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (1, N'CASUAL', N'CLIENTE', 0, N'', N'')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (2, N'Homer', N'Simpson', 13521456, N'hsimpson@fox.com', N'1125698741')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (3, N'Marge', N'Simpson', 45879794, N'margesimpson@fox.com', N'15245441')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (4, N'Lisa', N'Simpson', 50897841, N'lisasimpson@fox.com', N'74859621')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (5, N'Bart', N'Simpson', 48254154, N'elbarto@fox.com', N'85214702')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (6, N'Ned', N'Flanders', 74185201, N'nedflanders@fox.com', N'326598741')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (7, N'Reverendo', N'Alegria', 12345674, N'alegria@fox.com', N'159753684')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (8, N'Milhouse', N'Van houten', 41526387, N'milhouse@fox.com', N'156413258')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (9, N'Armando', N'Barreda', 0, N'', N'')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (12, N'Goku', N'Kakaroto', 26232656, N'goku@toei.com', N'15691459')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (13, N'Carlito', N'Tevez', 23440923, N'asd', N'123')
INSERT [dbo].[Clientes] ([id_cli], [Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli], [Cel_cli]) VALUES (14, N'Mona', N'Gimenez', 11229988, N'asd', N'123')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
SET IDENTITY_INSERT [dbo].[Compras] ON 

INSERT [dbo].[Compras] ([id_compra], [fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES (1, CAST(N'2020-06-16' AS Date), 1500, N'Santander', N'VINO')
INSERT [dbo].[Compras] ([id_compra], [fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES (2, CAST(N'2020-06-16' AS Date), 2315.96, N'Proveedor 2', N'VINO')
INSERT [dbo].[Compras] ([id_compra], [fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES (3, CAST(N'2020-06-16' AS Date), 1925.23, N'Santander', N'VINO BLANCO')
INSERT [dbo].[Compras] ([id_compra], [fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES (4, CAST(N'2020-06-16' AS Date), 3000, N'Proveedor 2', N'VINO')
INSERT [dbo].[Compras] ([id_compra], [fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES (5, CAST(N'2020-06-16' AS Date), 500, N'Santander', N'COCA COLA')
INSERT [dbo].[Compras] ([id_compra], [fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES (6, CAST(N'2020-06-16' AS Date), 10, N'Proveedor 2', N'FERNET')
INSERT [dbo].[Compras] ([id_compra], [fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES (7, CAST(N'2020-06-16' AS Date), 1000, N'Santander', N'VINO BLANCO')
INSERT [dbo].[Compras] ([id_compra], [fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES (8, CAST(N'2020-06-17' AS Date), 1325, N'Proveedor 2', N'FANTA')
SET IDENTITY_INSERT [dbo].[Compras] OFF
SET IDENTITY_INSERT [dbo].[MovExtras] ON 

INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1, 25.25, N'SI', N'NO', CAST(N'2020-06-06' AS Date), CAST(N'17:26:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (3, 25.25, N'SI', N'NO', CAST(N'2020-06-06' AS Date), CAST(N'17:26:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (4, 25, N'SI', N'NO', CAST(N'2020-06-12' AS Date), CAST(N'20:10:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (6, 48.1, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'10:40:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (7, 152.2, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'10:54:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (8, 132.2, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'10:54:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (9, 1542.21, N'NO', N'SI', CAST(N'2020-06-13' AS Date), CAST(N'11:29:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (10, 2000, N'NO', N'SI', CAST(N'2020-06-13' AS Date), CAST(N'11:29:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (11, 2000, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'11:29:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (12, 2000, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'11:30:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (13, 1230, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'11:31:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (14, 1230.13, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'11:32:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (15, 1230.13, N'NO', N'SI', CAST(N'2020-06-13' AS Date), CAST(N'11:32:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (16, 3000, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'11:36:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (17, 6700.6, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'11:36:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (18, 2533.12, N'NO', N'SI', CAST(N'2020-06-13' AS Date), CAST(N'11:36:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (19, 231, N'NO', N'SI', CAST(N'2020-06-13' AS Date), CAST(N'11:38:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (20, 12, N'SI', N'NO', CAST(N'2020-06-13' AS Date), CAST(N'19:18:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (21, 159, N'NO', N'SI', CAST(N'2020-06-19' AS Date), CAST(N'16:01:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (22, 200, N'SI', N'NO', CAST(N'2020-07-29' AS Date), CAST(N'21:03:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (23, 2500, N'SI', N'NO', CAST(N'2020-07-29' AS Date), CAST(N'21:04:00' AS Time), NULL)
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (24, 2500, N'SI', N'NO', CAST(N'2020-07-29' AS Date), CAST(N'21:54:00' AS Time), N'Ingreso Prueba')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (25, 3500, N'SI', N'NO', CAST(N'2020-07-29' AS Date), CAST(N'21:56:00' AS Time), N'Ingreso Prueba')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (26, 1500, N'SI', N'NO', CAST(N'2020-07-29' AS Date), CAST(N'22:28:00' AS Time), N'Ingreso por Venta N°18')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (27, 2500, N'NO', N'SI', CAST(N'2020-07-29' AS Date), CAST(N'22:39:00' AS Time), N'Extraccion Prueba')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (28, 3800, N'NO', N'SI', CAST(N'2020-07-30' AS Date), CAST(N'01:20:00' AS Time), N'Probando Egreso')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1024, 8750, N'SI', N'NO', CAST(N'2020-08-03' AS Date), CAST(N'21:02:00' AS Time), N'Ingreso por Venta N°19')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1025, 10000, N'SI', N'NO', CAST(N'2020-08-03' AS Date), CAST(N'21:05:00' AS Time), N'Ingreso por Venta N°20')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1026, 6250, N'SI', N'NO', CAST(N'2020-08-03' AS Date), CAST(N'21:26:00' AS Time), N'Ingreso por Venta N°21')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1027, 3000, N'SI', N'NO', CAST(N'2020-08-03' AS Date), CAST(N'21:36:00' AS Time), N'Ingreso por Venta N°22')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1028, 1250, N'SI', N'NO', CAST(N'2020-08-03' AS Date), CAST(N'23:46:00' AS Time), N'Ingreso por Venta N°23')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1029, 7100.88, N'NO', N'SI', CAST(N'2020-08-04' AS Date), CAST(N'00:35:00' AS Time), N'Egreso Sergio')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1030, 1556, N'NO', N'SI', CAST(N'2020-08-04' AS Date), CAST(N'00:36:00' AS Time), N'Egreso Sergio')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1031, 2300, N'SI', N'NO', CAST(N'2020-08-04' AS Date), CAST(N'00:36:00' AS Time), N'Ingres Sergio')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1032, 25000, N'SI', N'NO', CAST(N'2020-08-04' AS Date), CAST(N'00:39:00' AS Time), N'Ingreso por Venta N°24')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1033, 20000, N'SI', N'NO', CAST(N'2020-08-04' AS Date), CAST(N'01:06:00' AS Time), N'Ingreso por Venta N°25')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1034, 16000, N'SI', N'NO', CAST(N'2020-08-04' AS Date), CAST(N'01:07:00' AS Time), N'Ingreso por Venta N°26')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1035, 3000, N'SI', N'NO', CAST(N'2020-08-04' AS Date), CAST(N'01:23:00' AS Time), N'Ingreso por Venta N°27')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1036, 10000, N'SI', N'NO', CAST(N'2020-08-04' AS Date), CAST(N'01:27:00' AS Time), N'Ingreso por Venta N°28')
INSERT [dbo].[MovExtras] ([ID_ME], [MONTO], [ING], [EGR], [FECHA], [HORA], [CONCEPTO]) VALUES (1037, 5000, N'SI', N'NO', CAST(N'2020-08-04' AS Date), CAST(N'01:27:00' AS Time), N'Ingreso por Venta N°29')
SET IDENTITY_INSERT [dbo].[MovExtras] OFF
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([id_prod], [Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES (19, N'VINO BLANCO', N'SI', 0, 993, 0, N'FIRULETE')
INSERT [dbo].[Productos] ([id_prod], [Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES (20, N'VINO TINTO', N'SI', 0, 9993, 0, N'MENDOZA')
INSERT [dbo].[Productos] ([id_prod], [Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES (21, N'COCA', N'NO', 0, 1998, 0, N'COCA-COLA')
INSERT [dbo].[Productos] ([id_prod], [Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES (22, N'FANTA', N'NO', 0, 997, 0, N'COCA-COLA')
INSERT [dbo].[Productos] ([id_prod], [Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES (23, N'FERNET', N'SI', 0, 998, 0, N'BRANCA')
INSERT [dbo].[Productos] ([id_prod], [Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES (24, N'AGUA', N'NO', 500, 9977, 0, N'MINERAL')
INSERT [dbo].[Productos] ([id_prod], [Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES (1019, N'ENTRADAS', N'NO', 250, 99782, 0, N'ENTRADAS')
INSERT [dbo].[Productos] ([id_prod], [Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES (1020, N'ENTRADAS TARJETERO', N'NO', 200, 99779, 0, N'ENTRADAS')
SET IDENTITY_INSERT [dbo].[Productos] OFF
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([id_prov], [Nom_prov], [Dir_prov], [Tel_prov], [Mail_prov]) VALUES (8, N'Proveedor01', N'Calle falsa 1234', N'15461254', N'mail@mail.com')
INSERT [dbo].[Proveedores] ([id_prov], [Nom_prov], [Dir_prov], [Tel_prov], [Mail_prov]) VALUES (9, N'zaraza', N'Don Bosco 2739', N'789451254', N'unlz@yahooo.com')
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1, N'apellido Alejandro', 5, 1, CAST(N'2020-06-09' AS Date), CAST(N'16:04:00' AS Time), N'', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (2, N'apellido Alejandro', 625, 2, CAST(N'2020-06-10' AS Date), CAST(N'10:45:00' AS Time), N'', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (3, N'apellido Alejandro', 500, 3, CAST(N'2020-06-10' AS Date), CAST(N'10:48:00' AS Time), N'', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (4, N'apellido Alejandro', 500, 4, CAST(N'2020-06-10' AS Date), CAST(N'10:56:00' AS Time), N'', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (5, N'apellido Alejandro', 500, 5, CAST(N'2020-06-10' AS Date), CAST(N'11:03:00' AS Time), N'', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (6, N'apellido Alejandro', 25, 6, CAST(N'2020-06-10' AS Date), CAST(N'11:05:00' AS Time), N'', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (7, N'apellido Alejandro', 500, 7, CAST(N'2020-06-10' AS Date), CAST(N'11:35:00' AS Time), N'', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (8, N'apellido Alejandro', 650, 8, CAST(N'2020-06-10' AS Date), CAST(N'15:44:00' AS Time), N'apellido Alejandro Compro el dia 10/6/2020, con un gasto de  $650 los siguiente productos: 505050', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (9, N'apellido Alejandro', 650, 9, CAST(N'2020-06-10' AS Date), CAST(N'15:47:00' AS Time), N'apellido Alejandro Compro el dia 10/6/2020, con un gasto de  $650 los siguiente productos: vino, vino blanco, fernet, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (10, N'apellido Alejandro', 5000, 10, CAST(N'2020-06-10' AS Date), CAST(N'16:09:00' AS Time), N'apellido Alejandro Compro el dia 10/6/2020, con un gasto de  $5000 los siguiente productos: fernet, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (11, N'Lopez Ariel black', 2500, 11, CAST(N'2020-06-10' AS Date), CAST(N'16:13:00' AS Time), N'Lopez Ariel black Compro el dia 10/6/2020, con un gasto de  $2500 los siguiente productos: vino blanco, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (12, N'apellido Alejandro', 1775, 12, CAST(N'2020-06-10' AS Date), CAST(N'20:08:00' AS Time), N'apellido Alejandro Compro el dia 10/6/2020, con un gasto de  $1775 los siguiente productos: vino, vino blanco, fernet, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (13, N'Homer Simpson', 650, 13, CAST(N'2020-06-10' AS Date), CAST(N'20:20:00' AS Time), N'Homer Simpson Compro el dia 10/6/2020, con un gasto de  $650 los siguiente productos: vino blanco, fernet, vino, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (14, N'apellido Alejandro', 2500, 14, CAST(N'2020-06-11' AS Date), CAST(N'09:50:00' AS Time), N'apellido Alejandro Compro el dia 11/6/2020, con un gasto de  $2500 los siguiente productos: vino blanco, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (15, N'Gaudio Gaston', 2500, 15, CAST(N'2020-06-11' AS Date), CAST(N'09:50:00' AS Time), N'Gaudio Gaston Compro el dia 11/6/2020, con un gasto de  $2500 los siguiente productos: vino blanco, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (27, N'Alegria Reverendo', 0, 16, CAST(N'2020-07-27' AS Date), CAST(N'22:38:00' AS Time), N'Alegria Reverendo Compro el dia 2020-07-27, con un gasto de  $0 los siguiente productos: VINO BLANCO, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (28, N'Gimenez Mona', 0, 17, CAST(N'2020-07-27' AS Date), CAST(N'22:53:00' AS Time), N'Gimenez Mona Compro el dia 2020-07-27, con un gasto de  $0 los siguiente productos: VINO TINTO, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (29, N'Alegria Reverendo', 1500, 18, CAST(N'2020-07-29' AS Date), CAST(N'22:28:00' AS Time), N'Alegria Reverendo Compro el dia 2020-07-29, con un gasto de  $1500 los siguiente productos: AGUA, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1029, N'Tevez Carlito', 8750, 19, CAST(N'2020-08-03' AS Date), CAST(N'21:02:00' AS Time), N'Tevez Carlito Compro el dia 2020-08-03, con un gasto de  $8750 los siguiente productos: ENTRADAS, ', NULL, NULL)
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1030, N'Simpson Lisa', 10000, 20, CAST(N'2020-08-03' AS Date), CAST(N'21:05:00' AS Time), N'Simpson Lisa Compro el dia 2020-08-03, con un gasto de  $10000 los siguiente productos: ENTRADAS, ', NULL, CAST(N'2020-01-08' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1031, N'Simpson Homer', 6250, 21, CAST(N'2020-08-03' AS Date), CAST(N'21:26:00' AS Time), N'Simpson Homer Compro el dia 2020-08-03, con un gasto de  $6250 los siguiente productos: ENTRADAS, ', NULL, CAST(N'2020-01-08' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1032, N'Alegria Reverendo', 3000, 22, CAST(N'2020-08-03' AS Date), CAST(N'21:36:00' AS Time), N'Alegria Reverendo Compro el dia 2020-08-03, con un gasto de  $3000 los siguiente productos: ENTRADAS, ', NULL, CAST(N'2020-01-08' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1033, N'Alegria Reverendo', 1250, 23, CAST(N'2020-08-03' AS Date), CAST(N'23:46:00' AS Time), N'Alegria Reverendo Compro el dia 2020-08-03, con un gasto de  $1250 los siguiente productos: ENTRADAS, ', NULL, CAST(N'2020-08-01' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1034, N'Gimenez Mona', 25000, 24, CAST(N'2020-08-04' AS Date), CAST(N'00:39:00' AS Time), N'Gimenez Mona Compro el dia 2020-08-04, con un gasto de  $25000 los siguiente productos: ENTRADAS, ', NULL, CAST(N'2020-07-14' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1035, N'Simpson Homer', 20000, 25, CAST(N'2020-08-04' AS Date), CAST(N'01:06:00' AS Time), N'Simpson Homer Compro el dia 2020-08-04, con un gasto de  $20000 los siguiente productos: ENTRADAS TARJETERO, ', NULL, CAST(N'2000-01-03' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1036, N'Simpson Bart', 16000, 26, CAST(N'2020-08-04' AS Date), CAST(N'01:07:00' AS Time), N'Simpson Bart Compro el dia 2020-08-04, con un gasto de  $16000 los siguiente productos: ENTRADAS TARJETERO, ', NULL, CAST(N'2020-08-10' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1037, N'Simpson Bart', 3000, 27, CAST(N'2020-08-04' AS Date), CAST(N'01:23:00' AS Time), N'Simpson Bart Compro el dia 2020-08-04, con un gasto de  $3000 los siguiente productos: ENTRADAS TARJETERO, ', N'          ', CAST(N'2020-08-08' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1038, N'Simpson Bart', 10000, 28, CAST(N'2020-08-04' AS Date), CAST(N'01:27:00' AS Time), N'Simpson Bart Compro el dia 2020-08-04, con un gasto de  $10000 los siguiente productos: AGUA, ', NULL, CAST(N'2000-01-01' AS Date))
INSERT [dbo].[Ventas] ([id_vent], [Cli_ven], [Total_vendido], [Remito_ven], [Fecha_ven], [Hora_ven], [Detalle_Ven], [Evento], [FechaEvento]) VALUES (1039, N'Tevez Carlito', 5000, 29, CAST(N'2020-08-04' AS Date), CAST(N'01:27:00' AS Time), N'Tevez Carlito Compro el dia 2020-08-04, con un gasto de  $5000 los siguiente productos: ENTRADAS TARJETERO, ', NULL, CAST(N'2000-01-16' AS Date))
SET IDENTITY_INSERT [dbo].[Ventas] OFF
USE [master]
GO
ALTER DATABASE [TPFinal] SET  READ_WRITE 
GO
