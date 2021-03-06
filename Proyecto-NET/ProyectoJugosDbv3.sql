USE [master]
GO
/****** Object:  Database [ProyectoJugos]    Script Date: 19/09/2017 18:57:18 ******/
CREATE DATABASE [ProyectoJugos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoJugos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ProyectoJugos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProyectoJugos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ProyectoJugos_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProyectoJugos] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoJugos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoJugos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoJugos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoJugos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoJugos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoJugos] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoJugos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoJugos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoJugos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoJugos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoJugos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoJugos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoJugos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoJugos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoJugos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoJugos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyectoJugos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoJugos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoJugos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoJugos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoJugos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoJugos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoJugos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoJugos] SET RECOVERY FULL 
GO
ALTER DATABASE [ProyectoJugos] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoJugos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoJugos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoJugos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoJugos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProyectoJugos] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ProyectoJugos]
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[fk_tarjeta] [int] NOT NULL,
	[fk_venta] [int] NOT NULL,
	[cc_cliente] [int] NOT NULL,
	[nom_cliente] [varchar](30) NULL,
	[total_efectivo] [int] NULL,
	[total_tarjeta] [int] NULL,
	[vueltas] [int] NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estados_producto]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estados_producto](
	[id_estado_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_estados_producto] PRIMARY KEY CLUSTERED 
(
	[id_estado_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estados_tarjetas]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estados_tarjetas](
	[estados_tarjetas] [int] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](15) NOT NULL,
 CONSTRAINT [PK_estados_tarjetas] PRIMARY KEY CLUSTERED 
(
	[estados_tarjetas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[id_inventario] [int] IDENTITY(1,1) NOT NULL,
	[fk_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_inventario] PRIMARY KEY CLUSTERED 
(
	[id_inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[productos]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productos](
	[id_producto] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio] [int] NOT NULL,
	[fk_estado] [int] NOT NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tarjetas_credito]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tarjetas_credito](
	[id_tarjeta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[fk_estado] [int] NOT NULL,
 CONSTRAINT [PK_tarjetas_credito] PRIMARY KEY CLUSTERED 
(
	[id_tarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[id_ventas] [int] IDENTITY(1,1) NOT NULL,
	[fk_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[total_producto] [int] NOT NULL,
 CONSTRAINT [PK_ventas] PRIMARY KEY CLUSTERED 
(
	[id_ventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[estados_producto] ON 

INSERT [dbo].[estados_producto] ([id_estado_producto], [nombre]) VALUES (1, N'Disponible')
INSERT [dbo].[estados_producto] ([id_estado_producto], [nombre]) VALUES (2, N'Agotado')
SET IDENTITY_INSERT [dbo].[estados_producto] OFF
SET IDENTITY_INSERT [dbo].[estados_tarjetas] ON 

INSERT [dbo].[estados_tarjetas] ([estados_tarjetas], [estado]) VALUES (1, N'Activa')
INSERT [dbo].[estados_tarjetas] ([estados_tarjetas], [estado]) VALUES (2, N'Cancelada')
SET IDENTITY_INSERT [dbo].[estados_tarjetas] OFF
SET IDENTITY_INSERT [dbo].[inventario] ON 

INSERT [dbo].[inventario] ([id_inventario], [fk_producto], [cantidad]) VALUES (1, 3, 4000)
INSERT [dbo].[inventario] ([id_inventario], [fk_producto], [cantidad]) VALUES (2, 5, 1400)
SET IDENTITY_INSERT [dbo].[inventario] OFF
INSERT [dbo].[productos] ([id_producto], [nombre], [precio], [fk_estado]) VALUES (1, N'Papa', 2000, 1)
INSERT [dbo].[productos] ([id_producto], [nombre], [precio], [fk_estado]) VALUES (2, N'Fresa', 10000, 1)
INSERT [dbo].[productos] ([id_producto], [nombre], [precio], [fk_estado]) VALUES (3, N'Peras', 4000, 1)
INSERT [dbo].[productos] ([id_producto], [nombre], [precio], [fk_estado]) VALUES (5, N'Tomate', 1400, 1)
SET IDENTITY_INSERT [dbo].[tarjetas_credito] ON 

INSERT [dbo].[tarjetas_credito] ([id_tarjeta], [nombre], [fk_estado]) VALUES (1, N'Visa', 1)
SET IDENTITY_INSERT [dbo].[tarjetas_credito] OFF
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_tarjetas_credito] FOREIGN KEY([fk_tarjeta])
REFERENCES [dbo].[tarjetas_credito] ([id_tarjeta])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_tarjetas_credito]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_ventas] FOREIGN KEY([fk_venta])
REFERENCES [dbo].[ventas] ([id_ventas])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_ventas]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_ventas1] FOREIGN KEY([fk_venta])
REFERENCES [dbo].[ventas] ([id_ventas])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_ventas1]
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD  CONSTRAINT [FK_inventario_productos] FOREIGN KEY([fk_producto])
REFERENCES [dbo].[productos] ([id_producto])
GO
ALTER TABLE [dbo].[inventario] CHECK CONSTRAINT [FK_inventario_productos]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_productos_estados_producto] FOREIGN KEY([fk_estado])
REFERENCES [dbo].[estados_producto] ([id_estado_producto])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_productos_estados_producto]
GO
ALTER TABLE [dbo].[tarjetas_credito]  WITH CHECK ADD  CONSTRAINT [FK_tarjetas_credito_estados_tarjetas] FOREIGN KEY([fk_estado])
REFERENCES [dbo].[estados_tarjetas] ([estados_tarjetas])
GO
ALTER TABLE [dbo].[tarjetas_credito] CHECK CONSTRAINT [FK_tarjetas_credito_estados_tarjetas]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_productos] FOREIGN KEY([fk_producto])
REFERENCES [dbo].[productos] ([id_producto])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_productos]
GO
/****** Object:  StoredProcedure [dbo].[pa_editar_producto]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pa_editar_producto]

@idproducto int,
@nombre varchar(50),
@precio int,
@estado int
as
update productos set nombre=@nombre, precio=@precio, fk_estado=@estado
where id_producto=@idproducto



GO
/****** Object:  StoredProcedure [dbo].[pa_insertar_inventario]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pa_insertar_inventario]
@idinventario int output,
@fkproducto int,
@cantidad int
as
insert into inventario (fk_producto,cantidad) values (@fkproducto,@cantidad)


GO
/****** Object:  StoredProcedure [dbo].[pa_insertar_producto]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	proc [dbo].[pa_insertar_producto]
@idproducto int,
@nombre varchar (50),
@precio int,
@estado int

as
insert into productos values (@idproducto,@nombre,@precio,@estado)

GO
/****** Object:  StoredProcedure [dbo].[pa_insertar_tarjeta]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pa_insertar_tarjeta]
@idtarjeta int output,
@nombre varchar(20),
@estado int
as
insert into tarjetas_credito (nombre,fk_estado) values (@nombre, @estado )



GO
/****** Object:  StoredProcedure [dbo].[pa_mostrar_productos]    Script Date: 19/09/2017 18:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pa_mostrar_productos]
as
Select top 100 * from productos
order by id_producto desc



GO
USE [master]
GO
ALTER DATABASE [ProyectoJugos] SET  READ_WRITE 
GO
