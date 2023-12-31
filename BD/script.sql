USE [master]
GO
/****** Object:  Database [Papeleria]    Script Date: 24/10/2023 04:23:02 p. m. ******/
CREATE DATABASE [Papeleria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Papeleria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Papeleria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Papeleria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Papeleria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Papeleria] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Papeleria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Papeleria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Papeleria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Papeleria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Papeleria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Papeleria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Papeleria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Papeleria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Papeleria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Papeleria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Papeleria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Papeleria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Papeleria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Papeleria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Papeleria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Papeleria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Papeleria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Papeleria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Papeleria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Papeleria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Papeleria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Papeleria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Papeleria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Papeleria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Papeleria] SET  MULTI_USER 
GO
ALTER DATABASE [Papeleria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Papeleria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Papeleria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Papeleria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Papeleria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Papeleria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Papeleria] SET QUERY_STORE = ON
GO
ALTER DATABASE [Papeleria] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Papeleria]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripción] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente_Detalles]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente_Detalles](
	[ID_Cliente] [int] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [nchar](12) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[CURP] [varchar](50) NOT NULL,
	[RFC] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente_Detalles] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente_Deudor]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente_Deudor](
	[ID_Cliente] [int] NOT NULL,
	[monto_total] [float] NOT NULL,
	[prox_pago] [float] NOT NULL,
	[estado_deuda] [varchar](50) NOT NULL,
	[comentarios] [varchar](200) NULL,
 CONSTRAINT [PK_Cliente_Deudor] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra_A_Proveedores]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra_A_Proveedores](
	[ID_Compra] [int] IDENTITY(1,1) NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
	[fecha_compra] [date] NOT NULL,
	[vencimiento] [date] NOT NULL,
	[monto_pendiente] [float] NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[comentarios] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Compra_A_Proveedores] PRIMARY KEY CLUSTERED 
(
	[ID_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas_Por_Cobrar]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas_Por_Cobrar](
	[ID_Ventas] [int] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[monto_pendiente] [float] NOT NULL,
	[fecha_vencimiento] [date] NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[comentarios] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas_Por_Pagar]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas_Por_Pagar](
	[ID_Proveedor] [int] NOT NULL,
	[Monto_Pago] [float] NOT NULL,
	[Fecha_Compra] [date] NOT NULL,
	[Fecha_Vencimiento] [date] NOT NULL,
	[Fecha_Prox_Pago] [date] NOT NULL,
	[Estado_Cuenta] [varchar](20) NOT NULL,
	[ID_Compra] [int] NOT NULL,
	[Monto_Total] [float] NOT NULL,
	[Comentarios_Adicionales] [varchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Empleados]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Empleados](
	[ID_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Puesto] [varchar](50) NOT NULL,
	[Fecha_contract] [date] NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Pago] [float] NOT NULL,
	[Fecha_proximo_pago] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Genero] [char](10) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos_Proveedor]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos_Proveedor](
	[ID_Proveedor] [int] NOT NULL,
	[fecha_compra] [date] NOT NULL,
	[fecha_entrega] [date] NOT NULL,
	[estado_pedido] [varchar](50) NOT NULL,
	[monto] [float] NOT NULL,
	[descripcion] [varchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[ID_Categoria] [int] NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Estado_Producto] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores_Detalles]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores_Detalles](
	[ID_Proveedor] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Proveedores_Detalles] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Position] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[MontoTotal] [float] NOT NULL,
	[FechaVenta] [date] NOT NULL,
	[Comentarios] [varchar](200) NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas_Contado]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Contado](
	[ID_Venta] [int] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[monto_total] [float] NOT NULL,
	[metodo_pago] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas_Credito]    Script Date: 24/10/2023 04:23:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Credito](
	[ID_Venta] [int] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[prox_pago] [date] NOT NULL,
	[monto_pago] [float] NOT NULL,
	[vencimiento] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cliente_Detalles]    Script Date: 24/10/2023 04:23:02 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Cliente_Detalles] ON [dbo].[Cliente_Detalles]
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_Proveedor]    Script Date: 24/10/2023 04:23:02 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Pedidos_Proveedor] ON [dbo].[Pedidos_Proveedor]
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente_Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Detalles_Clientes] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cliente_Detalles] CHECK CONSTRAINT [FK_Cliente_Detalles_Clientes]
GO
ALTER TABLE [dbo].[Cliente_Deudor]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Deudor_Clientes] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Cliente_Deudor] CHECK CONSTRAINT [FK_Cliente_Deudor_Clientes]
GO
ALTER TABLE [dbo].[Compra_A_Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Compra_A_Proveedores_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedores] ([ID_Proveedor])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Compra_A_Proveedores] CHECK CONSTRAINT [FK_Compra_A_Proveedores_Proveedores]
GO
ALTER TABLE [dbo].[Cuentas_Por_Cobrar]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_Por_Cobrar_Clientes] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Cuentas_Por_Cobrar] CHECK CONSTRAINT [FK_Cuentas_Por_Cobrar_Clientes]
GO
ALTER TABLE [dbo].[Cuentas_Por_Cobrar]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_Por_Cobrar_Ventas] FOREIGN KEY([ID_Ventas])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
ALTER TABLE [dbo].[Cuentas_Por_Cobrar] CHECK CONSTRAINT [FK_Cuentas_Por_Cobrar_Ventas]
GO
ALTER TABLE [dbo].[Cuentas_Por_Pagar]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_Por_Pagar_Compra_A_Proveedores] FOREIGN KEY([ID_Compra])
REFERENCES [dbo].[Compra_A_Proveedores] ([ID_Compra])
GO
ALTER TABLE [dbo].[Cuentas_Por_Pagar] CHECK CONSTRAINT [FK_Cuentas_Por_Pagar_Compra_A_Proveedores]
GO
ALTER TABLE [dbo].[Cuentas_Por_Pagar]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_Por_Pagar_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedores] ([ID_Proveedor])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Cuentas_Por_Pagar] CHECK CONSTRAINT [FK_Cuentas_Por_Pagar_Proveedores]
GO
ALTER TABLE [dbo].[Detalles_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Empleados_Empleados] FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[Empleados] ([ID_Empleado])
GO
ALTER TABLE [dbo].[Detalles_Empleados] CHECK CONSTRAINT [FK_Detalles_Empleados_Empleados]
GO
ALTER TABLE [dbo].[Pedidos_Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Proveedor_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedores] ([ID_Proveedor])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pedidos_Proveedor] CHECK CONSTRAINT [FK_Pedidos_Proveedor_Proveedores]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Categorias] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
GO
ALTER TABLE [dbo].[Proveedores_Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores_Detalles_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedores] ([ID_Proveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Proveedores_Detalles] CHECK CONSTRAINT [FK_Proveedores_Detalles_Proveedores]
GO
ALTER TABLE [dbo].[Ventas_Contado]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Contado_Clientes] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Ventas_Contado] CHECK CONSTRAINT [FK_Ventas_Contado_Clientes]
GO
ALTER TABLE [dbo].[Ventas_Contado]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Contado_Ventas] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
ALTER TABLE [dbo].[Ventas_Contado] CHECK CONSTRAINT [FK_Ventas_Contado_Ventas]
GO
ALTER TABLE [dbo].[Ventas_Credito]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Credito_Clientes] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Ventas_Credito] CHECK CONSTRAINT [FK_Ventas_Credito_Clientes]
GO
ALTER TABLE [dbo].[Ventas_Credito]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Credito_Ventas] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
ALTER TABLE [dbo].[Ventas_Credito] CHECK CONSTRAINT [FK_Ventas_Credito_Ventas]
GO
USE [master]
GO
ALTER DATABASE [Papeleria] SET  READ_WRITE 
GO
