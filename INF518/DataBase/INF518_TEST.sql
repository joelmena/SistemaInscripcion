USE [master]
GO
/****** Object:  Database [INF518_TEST]    Script Date: 6/23/2020 10:37:54 PM ******/
CREATE DATABASE [INF518_TEST]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'INF518', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\INF518.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'INF518_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\INF518_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [INF518_TEST] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [INF518_TEST].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [INF518_TEST] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [INF518_TEST] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [INF518_TEST] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [INF518_TEST] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [INF518_TEST] SET ARITHABORT OFF 
GO
ALTER DATABASE [INF518_TEST] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [INF518_TEST] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [INF518_TEST] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [INF518_TEST] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [INF518_TEST] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [INF518_TEST] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [INF518_TEST] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [INF518_TEST] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [INF518_TEST] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [INF518_TEST] SET  DISABLE_BROKER 
GO
ALTER DATABASE [INF518_TEST] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [INF518_TEST] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [INF518_TEST] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [INF518_TEST] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [INF518_TEST] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [INF518_TEST] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [INF518_TEST] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [INF518_TEST] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [INF518_TEST] SET  MULTI_USER 
GO
ALTER DATABASE [INF518_TEST] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [INF518_TEST] SET DB_CHAINING OFF 
GO
ALTER DATABASE [INF518_TEST] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [INF518_TEST] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [INF518_TEST] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [INF518_TEST] SET QUERY_STORE = OFF
GO
USE [INF518_TEST]
GO
/****** Object:  User [joelmena]    Script Date: 6/23/2020 10:37:54 PM ******/
CREATE USER [joelmena] FOR LOGIN [joelmena] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tblAsignaturas]    Script Date: 6/23/2020 10:37:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAsignaturas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NULL,
	[Descripcion] [varchar](100) NULL,
	[IdCarrera] [int] NULL,
	[Creditos] [int] NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblAsignaturas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAulas]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAulas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Codigo] [varchar](7) NULL,
	[Capacidad] [int] NULL,
	[IdCentro] [int] NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblAulas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCarreras]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCarreras](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Creditos] [int] NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblCarreras] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCentros]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCentros](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[NombreCorto] [varchar](20) NULL,
	[WebSite] [varchar](500) NULL,
	[Telefono] [varchar](15) NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NOT NULL,
	[UrlLogo] [varchar](200) NULL,
 CONSTRAINT [PK_tblCentros] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDetalleInscripcion]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetalleInscripcion](
	[IdInscripcion] [int] NULL,
	[IdSeccion] [int] NULL,
	[Inactivo] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEstadoCivil]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstadoCivil](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEstudiantes]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstudiantes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoEstudiante] [int] NULL,
	[Cedula] [varchar](13) NULL,
	[Matricula] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Sexo] [char](1) NULL,
	[FechaNacimiento] [datetime] NULL,
	[IdEstadoCivil] [int] NULL,
	[TelefonoCasa] [varchar](15) NULL,
	[TelefonoMovil] [varchar](15) NULL,
	[Direccion] [varchar](200) NULL,
	[Email] [varchar](255) NULL,
	[Observaciones] [varchar](max) NULL,
	[UrlFoto] [varchar](200) NULL,
	[IdCarrera] [int] NULL,
	[Balance] [money] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedAt] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblEstudiantes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblInscripciones]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblInscripciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdEstudiante] [int] NULL,
	[Fecha] [datetime] NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblInscripciones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProfesores]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProfesores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](13) NULL,
	[Nombre] [varchar](13) NULL,
	[Apellido] [varchar](13) NULL,
	[Sexo] [char](1) NULL,
	[FechaNacimiento] [datetime] NULL,
	[IdEstadoCivil] [int] NULL,
	[TelefonoCasa] [varchar](15) NULL,
	[TelefonoMovil] [varchar](15) NULL,
	[Direccion] [varchar](200) NULL,
	[Email] [varchar](255) NULL,
	[Observaciones] [varchar](max) NULL,
	[UrlFoto] [varchar](200) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedAt] [datetime] NULL,
	[UpdatedBy] [nchar](10) NULL,
	[DeletedAt] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[Inactivo] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSecciones]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSecciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdCentro] [int] NULL,
	[IdAula] [int] NULL,
	[IdCarrera] [int] NULL,
	[IdAsignatura] [int] NULL,
	[IdProfesor] [int] NULL,
	[Capacidad] [int] NULL,
	[Dia1] [varchar](10) NULL,
	[Hora1] [varchar](10) NULL,
	[Dia2] [varchar](10) NULL,
	[Hora2] [varchar](10) NULL,
	[Numero] [int] NULL,
	[Inactivo] [bit] NULL,
	[Observaciones] [varchar](100) NULL,
 CONSTRAINT [PK_tblSessiones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTipoEstudiantes]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTipoEstudiantes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CostoCredito] [money] NULL,
	[CostoInscripcion] [money] NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblTipoEstudiantes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTipoUsuarios]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTipoUsuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblTipoUsuarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsuarios]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoUsuario] [int] NULL,
	[Usuario] [varchar](100) NULL,
	[Password] [varchar](300) NULL,
	[Nombre] [varchar](100) NULL,
	[Permisos] [varchar](max) NULL,
	[Observaciones] [varchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblUsuarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblAsignaturas] ADD  CONSTRAINT [DF_tblAsignaturas_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblAulas] ADD  CONSTRAINT [DF_tblAulas_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblCarreras] ADD  CONSTRAINT [DF_tblCarreras_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblCentros] ADD  CONSTRAINT [DF_tblCentros_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblDetalleInscripcion] ADD  CONSTRAINT [DF_tblDetalleInscripcion_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblEstudiantes] ADD  CONSTRAINT [DF_tblEstudiantes_Balance]  DEFAULT ((0)) FOR [Balance]
GO
ALTER TABLE [dbo].[tblEstudiantes] ADD  CONSTRAINT [DF_tblEstudiantes_CreateAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[tblEstudiantes] ADD  CONSTRAINT [DF_tblEstudiantes_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblInscripciones] ADD  CONSTRAINT [DF_tblInscripciones_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblProfesores] ADD  CONSTRAINT [DF_tblProfesores_CreateAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[tblProfesores] ADD  CONSTRAINT [DF_tblProfesores_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblSecciones] ADD  CONSTRAINT [DF_tblSessiones_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblTipoEstudiantes] ADD  CONSTRAINT [DF_tblTipoEstudiantes_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblTipoUsuarios] ADD  CONSTRAINT [DF_tblTipoUsuarios_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[tblUsuarios] ADD  CONSTRAINT [DF_tblUsuarios_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarAsignatura]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 16 2020
-- Description:	procedimiento para registrar las asignaturas
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizarAsignatura]
	-- Add the parameters for the stored procedure here
	@id INT,
	@codigo VARCHAR(10),
	@descripcion VARCHAR(100),
	@idCarrera INT,
	@creditos INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblAsignaturas
		SET
			Codigo = @codigo,
			Descripcion = @descripcion,
			IdCarrera = @idCarrera,
			Creditos = @creditos,
			Observaciones = @observaciones
	WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarAula]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 16 2020
-- Description:	procedimiento para registrar las aulas
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizarAula]
	-- Add the parameters for the stored procedure here
	@id INT,
	@descripcion VARCHAR(100),
	@codigo VARCHAR(7),
	@capacidad INT,
	@idCentro INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblAulas
		SET
			Descripcion = @descripcion,
			Codigo = @codigo,
			Capacidad = @capacidad,
			IdCentro = @idCentro,
			Observaciones = @observaciones
	WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarCarrera]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 23 2020
-- Description:	procedimiento para actualizar las carreras
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizarCarrera]
	-- Add the parameters for the stored procedure here
	@id INT,
	@descripcion VARCHAR(100),
	@creditos INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblCarreras
		SET
			Descripcion = @descripcion,
			Creditos = @creditos,
			Observaciones = @observaciones
	WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarCentro]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para registrar centros educativos o recintos
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizarCentro]
	-- Add the parameters for the stored procedure here
	@id INT,
	@descripcion VARCHAR(100),
	@nombreCorto VARCHAR(20),
	@webSite VARCHAR(500),
	@telefono VARCHAR(15),
	@observaciones VARCHAR(MAX),
	@urlLogo VARCHAR(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblCentros
		SET
			Descripcion = @descripcion,
			NombreCorto = @nombreCorto,
			WebSite = @webSite,
			Telefono = @telefono,
			Observaciones = @observaciones,
			UrlLogo = @urlLogo
	WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarEstudiante]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 12 2020
-- Description:	procedimiento para actualizar los datos de los estudiantes
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizarEstudiante]
	-- Add the parameters for the stored procedure here
	@idEstudiante INT,
	@idTipoEstudiante INT,
	@cedula VARCHAR(13),
	@nombre VARCHAR(50),
	@apellido VARCHAR(50),
	@sexo CHAR(1),
	@fechaNacimiento DATETIME,
	@idEstadoCivil VARCHAR(15),
	@telefonoCasa VARCHAR(15),
	@telefonoMovil VARCHAR(15),
	@direccion VARCHAR(200),
	@email VARCHAR(255),
	@observaciones VARCHAR(MAX),
	@urlFoto VARCHAR(200),
	@idCarrera INT,
	@idUsuario INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblEstudiantes
		SET
			IdTipoEstudiante = @idTipoEstudiante,
			Cedula = @cedula,
			Nombre = @nombre,
			Apellido = @apellido,
			Sexo = @sexo,
			FechaNacimiento = @fechaNacimiento,
			IdEstadoCivil = @idEstadoCivil,
			TelefonoCasa = @telefonoCasa,
			TelefonoMovil = @telefonoMovil,
			Direccion = @direccion,
			Email = @email,
			Observaciones = @observaciones,
			UrlFoto = @urlFoto,
			IdCarrera = @idCarrera,
			UpdatedAt = GETDATE(),
			UpdatedBy = @idUsuario
	WHERE ID = @idEstudiante
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarProfesor]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 14 2020
-- Description:	procedimiento para actualizar los datos del profesor
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizarProfesor]
	-- Add the parameters for the stored procedure here
	@idProfesor INT,
	@nombre VARCHAR(50),
	@apellido VARCHAR(50),
	@cedula VARCHAR(13),
	@sexo CHAR(1),
	@fechaNacimiento DATETIME,
	@idEstadoCivil VARCHAR(15),
	@telefonoCasa VARCHAR(15),
	@telefonoMovil VARCHAR(15),
	@direccion VARCHAR(200),
	@email VARCHAR(255),
	@observaciones VARCHAR(MAX),
	@urlFoto VARCHAR(200),
	@idUsuario INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblProfesores
		SET
			Nombre = @nombre,
			Apellido = @apellido,
			Cedula = @cedula,
			Sexo = @sexo,
			FechaNacimiento = @fechaNacimiento,
			IdEstadoCivil = @idEstadoCivil,
			TelefonoCasa = @telefonoCasa,
			TelefonoMovil = @telefonoMovil,
			Direccion = @direccion,
			Email = @email,
			Observaciones = @observaciones,
			UrlFoto = @urlFoto,
			UpdatedAt = GETDATE(),
			UpdatedBy = @idUsuario
	WHERE ID = @idProfesor
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarSeccion]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 23 2020
-- Description:	procedimiento para actualizar las secciones
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizarSeccion]
	-- Add the parameters for the stored procedure here
	@id INT,
	@idCentro INT,
	@idAula INT,
	@idCarrera INT,
	@idProfesor INT,
	@capacidad INT,
	@dia1 VARCHAR(10),
	@hora1 VARCHAR(10),
	@dia2 VARCHAR(10),
	@hora2 VARCHAR(10),
	@numero INT,
	@idAsignatura INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblSecciones
		SET
			IdCentro = @idCentro,
			IdAula = @idAula,
			IdCarrera = @idCarrera,
			IdProfesor = @idProfesor,
			Capacidad = @capacidad,
			Dia1 = @dia1,
			Hora1 = @hora1,
			Dia2 = @dia2,
			Hora2 = @hora2,
			Numero = @numero,
			IdAsignatura = @idAsignatura,
			Observaciones = @observaciones
	WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_asignaturas]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 16 2020
-- Description:	procedimiento para obtener la informacion detalle de la asignatura
-- =============================================
CREATE PROCEDURE [dbo].[sp_asignaturas]
	-- Add the parameters for the stored procedure here
	@filtro VARCHAR(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		a.ID,
		a.Codigo,
		a.Descripcion,
		c.Descripcion [Carrera],
		a.Creditos,
		C.Observaciones
	FROM tblAsignaturas a
	INNER JOIN tblCarreras c
		ON a.IdCarrera = c.ID
	WHERE a.Inactivo = 0
		AND(
			a.Descripcion LIKE CONCAT('%', @filtro, '%')
			OR a.Codigo LIKE CONCAT('%', @filtro, '%')
			OR c.Descripcion LIKE CONCAT('%', @filtro, '%')
		)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_aulas]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 16 2020
-- Description:	procedimiento para obtener el listado de aulas
-- =============================================
CREATE PROCEDURE [dbo].[sp_aulas]
	-- Add the parameters for the stored procedure here
	@filtro VARCHAR(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		a.ID,
		a.Descripcion,
		a.Codigo,
		a.Capacidad,
		c.NombreCorto [Centro],
		a.Observaciones
	FROM tblAulas a
	INNER JOIN tblCentros c
		ON a.IdCentro = c.ID
	WHERE a.Inactivo = 0
		AND(
			a.Descripcion LIKE CONCAT('%', @filtro, '%')
			OR a.Codigo LIKE CONCAT('%', @filtro, '%')
			OR c.NombreCorto LIKE CONCAT('%', @filtro, '%')
		)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_balance]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 8 2020
-- Description:	procedimiento para 
-- =============================================
CREATE PROCEDURE [dbo].[sp_balance]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		Balance
	FROM tblEstudiantes
	WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_carreras]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 7 2020
-- Description:	procedimiento para listar las carreras
-- =============================================
CREATE PROCEDURE [dbo].[sp_carreras]
	-- Add the parameters for the stored procedure here
	@filtro VARCHAR(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		c.ID,
		c.Descripcion,
		c.Creditos,
		c.Observaciones
	FROM tblCarreras c
	WHERE c.Inactivo = 0
		AND c.Descripcion LIKE CONCAT('%', @filtro,'%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cbProfesores]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 16 2020
-- Description:	procedimiento para listar los estudiantes
-- =============================================
CREATE PROCEDURE [dbo].[sp_cbProfesores]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		p.ID,
		CONCAT(p.Nombre, ' ', p.Apellido) [Nombre]
	FROM tblProfesores p
	WHERE Inactivo = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_centros]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 16 2020
-- Description:	procedimiento para obtener la informacion detalle del centro educativo
-- =============================================
CREATE PROCEDURE [dbo].[sp_centros]
	-- Add the parameters for the stored procedure here
	@filtro VARCHAR(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		c.ID,
		c.Descripcion,
		c.NombreCorto,
		c.WebSite,
		c.Telefono,
		c.Observaciones,
		c.UrlLogo
	FROM tblCentros c
	WHERE c.Inactivo = 0
		AND(c.Descripcion LIKE CONCAT('%', @filtro, '%')
			OR c.NombreCorto LIKE CONCAT('%', @filtro, '%'))
END
GO
/****** Object:  StoredProcedure [dbo].[sp_crearTipoEstudiante]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para crear los tipos de estudiantes
-- =============================================
CREATE PROCEDURE [dbo].[sp_crearTipoEstudiante]
	-- Add the parameters for the stored procedure here
	@descripcion VARCHAR(100),
	@costoCredito MONEY,
	@costoInscripcion MONEY,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblTipoEstudiantes(
		Descripcion,
		CostoCredito,
		CostoInscripcion,
		Observaciones,
		Inactivo
	)
	VALUES(
		@descripcion,
		@costoCredito,
		@costoInscripcion,
		@observaciones,
		0
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_crearTipoUsuario]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para crear los tipos de usuarios
-- =============================================
CREATE PROCEDURE [dbo].[sp_crearTipoUsuario]
	-- Add the parameters for the stored procedure here
	@nombre VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblTipoUsuarios(
		Nombre,
		Inactivo
	)
	VALUES(
		@nombre,
		0
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_crearUsuario]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para crear los usuarios
-- =============================================
CREATE PROCEDURE [dbo].[sp_crearUsuario]
	-- Add the parameters for the stored procedure here
	@idTipoUsuario INT,
	@usuario VARCHAR(100),
	@password VARCHAR(300),
	@nombre VARCHAR(100),
	@permisos VARCHAR(max),
	@@observaciones VARCHAR(max),
	@createdBy INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO tblUsuarios(
		IdTipoUsuario,
		Usuario,
		Password,
		Nombre,
		Permisos,
		Observaciones,
		CreatedAt,
		CreatedBy,
		Inactivo
	)
	VALUES(
		@idTipoUsuario,
		@usuario,
		@password,
		@nombre,
		@permisos,
		@@observaciones,
		GETDATE(),
		@createdBy,
		0
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleAsignatura]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle de la asignatura
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleAsignatura]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		a.ID,
		a.Codigo,
		a.Descripcion,
		a.IdCarrera,
		a.Creditos
	FROM tblAsignaturas a
	INNER JOIN tblCarreras c
		ON a.IdCarrera = c.ID
	WHERE a.Inactivo = 0
		AND a.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleAula]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle de la Aula
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleAula]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		a.ID,
		a.Descripcion,
		a.Codigo,
		a.Capacidad,
		a.IdCentro,
		a.Observaciones
	FROM tblAulas a
	WHERE a.Inactivo = 0
		AND a.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleCarrera]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle de la Carrera
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleCarrera]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		c.ID,
		c.Descripcion,
		c.Creditos,
		c.Observaciones
	FROM tblCarreras c
	WHERE c.Inactivo = 0
		AND c.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleCentro]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle del centro educativo
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleCentro]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		c.ID,
		c.Descripcion,
		c.NombreCorto,
		c.WebSite,
		c.Telefono,
		c.Observaciones,
		c.UrlLogo
	FROM tblCentros c
	WHERE c.Inactivo = 0
		AND c.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleEstudiante]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle del estudiante
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleEstudiante]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		e.ID, 
		e.Matricula, 
		e.Nombre, 
		e.Apellido, 
		e.Cedula, 
		e.Sexo, 
		e.FechaNacimiento, 
		e.IdEstadoCivil, 
		e.TelefonoCasa, 
		e.TelefonoMovil,
		e.Direccion,
		e.Email, 
		e.Observaciones,
		e.UrlFoto,
		te.ID [IdTipoEstudiante],
		c.ID [IdCarrera],
		e.Balance
	FROM tblEstudiantes e
	INNER JOIN tblTipoEstudiantes te
		ON e.IdTipoEstudiante = te.ID
	INNER JOIN tblCarreras c
		ON e.IdCarrera = c.ID
	WHERE e.Inactivo = 0
		AND e.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleInscripcion]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para obtener el detalle de la inscripcion
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleInscripcion]
	-- Add the parameters for the stored procedure here
	@idInscripcion INT,
	@idSeccion INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		IdInscripcion,
		IdSeccion
	FROM tblDetalleInscripcion
	WHERE Inactivo = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleProfesor]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle del profesor
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleProfesor]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		p.ID,
		p.Nombre,
		p.Apellido,
		p.Cedula,
		p.Sexo,
		p.FechaNacimiento,
		p.IdEstadoCivil,
		p.TelefonoCasa,
		p.TelefonoMovil,
		p.Direccion,
		p.Email,
		p.Observaciones,
		p.UrlFoto
	FROM tblProfesores p
	WHERE p.Inactivo = 0
		AND p.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleSeccion]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle de la seccion
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleSeccion]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		s.ID,
		s.IdCentro,
		s.IdCarrera,
		s.IdAula,
		s.IdProfesor,
		s.Capacidad,
		s.Dia1,
		s.Hora1,
		s.Dia2,
		s.Hora2,
		s.Numero,
		s.IdAsignatura,
		s.Observaciones
	FROM tblSecciones s
	WHERE s.Inactivo = 0
		AND s.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleTipoEstudiante]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle del tipo de estudiante
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleTipoEstudiante]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		te.ID,
		te.Descripcion,
		te.CostoCredito,
		te.CostoInscripcion,
		te.Observaciones
	FROM tblTipoEstudiantes te
	WHERE te.Inactivo = 0
		AND te.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detalleUsuario]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle del usuario
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleUsuario]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		u.ID,
		u.Nombre,
		u.Usuario,
		tu.Nombre [TipoUsuario],
		u.Permisos
	FROM tblUsuarios u
	INNER JOIN tblTipoUsuarios tu
		ON u.IdTipoUsuario = tu.ID
	WHERE
		u.Inactivo = 0
		AND u.ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_estadoCivil]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 3 2020
-- Description:	procedimiento para listar los estados civiles
-- =============================================
CREATE PROCEDURE [dbo].[sp_estadoCivil]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		ID,
		Nombre
	FROM tblEstadoCivil
END
GO
/****** Object:  StoredProcedure [dbo].[sp_estudiantes]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 14 2020
-- Description:	procedimiento para listar los estudiantes
-- =============================================
CREATE PROCEDURE [dbo].[sp_estudiantes]
	-- Add the parameters for the stored procedure here
	@filtro VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		e.ID,
		e.Matricula,
		e.Nombre,
		e.Apellido,
		e.Cedula,
		e.Sexo,
		e.FechaNacimiento,
		ec.Nombre [EstadoCivil],
		e.TelefonoCasa,
		e.TelefonoMovil,
		e.Direccion,
		e.Email,
		c.Descripcion [Carrera],
		te.Descripcion [TipoEstudiante],
		e.CreatedAt,
		e.Observaciones
	FROM tblEstudiantes e
	INNER JOIN tblEstadoCivil ec
		ON e.IdEstadoCivil = ec.ID
	INNER JOIN tblTipoEstudiantes te
		ON e.IdTipoEstudiante = te.ID
	INNER JOIN tblCarreras c
		ON e.IdCarrera = c.ID
	WHERE c.Inactivo = 0 
		 AND (CONCAT(e.Nombre, ' ', e.Apellido) LIKE CONCAT('%', @filtro, '%')
				OR e.Matricula LIKE CONCAT('%', @filtro, '%')
				OR e.Cedula LIKE CONCAT('%', @filtro, '%'))
END
GO
/****** Object:  StoredProcedure [dbo].[sp_inscribirEstudiante]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para inscribir estudiante
-- =============================================
CREATE PROCEDURE [dbo].[sp_inscribirEstudiante]
	-- Add the parameters for the stored procedure here
	@idEstudiante INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblInscripciones(
		IdEstudiante,
		Fecha,
		Inactivo
	)
	VALUES(
		@idEstudiante,
		GETDATE(),
		0
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_profesores]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 14 2020
-- Description:	procedimiento para listar los estudiantes
-- =============================================
CREATE PROCEDURE [dbo].[sp_profesores]
	-- Add the parameters for the stored procedure here
	@filtro VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		p.ID,
		p.Nombre,
		p.Apellido,
		p.Cedula,
		p.Sexo,
		p.FechaNacimiento,
		ec.Nombre [EstadoCivil],
		p.TelefonoCasa,
		p.TelefonoMovil,
		p.Direccion,
		p.Email,
		p.CreatedAt,
		p.Observaciones
	FROM tblProfesores p
	INNER JOIN tblEstadoCivil ec
		ON p.IdEstadoCivil = ec.ID
	WHERE CONCAT(p.Nombre, ' ', p.Apellido) LIKE CONCAT('%', @filtro, '%')
		OR p.Cedula LIKE CONCAT('%', @filtro, '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_registrarAsignatura]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para registrar las asignaturas
-- =============================================
CREATE PROCEDURE [dbo].[sp_registrarAsignatura]
	-- Add the parameters for the stored procedure here
	@codigo VARCHAR(10),
	@descripcion VARCHAR(100),
	@idCarrera INT,
	@creditos INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblAsignaturas(
		Codigo,
		Descripcion,
		IdCarrera,
		Creditos,
		Observaciones
	)
	VALUES(
		@codigo,
		@descripcion,
		@idCarrera,
		@creditos,
		@observaciones
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_registrarAula]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para registrar las aulas
-- =============================================
CREATE PROCEDURE [dbo].[sp_registrarAula]
	-- Add the parameters for the stored procedure here
	@descripcion VARCHAR(100),
	@codigo VARCHAR(7),
	@capacidad INT,
	@idCentro INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblAulas(
		Descripcion,
		Codigo,
		Capacidad,
		IdCentro,
		Observaciones,
		Inactivo
	)
	VALUES(
		@descripcion,
		@codigo,
		@capacidad,
		@idCentro,
		@observaciones,
		0
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_registrarCarrera]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para registrar las carreras impartidas
-- =============================================
CREATE PROCEDURE [dbo].[sp_registrarCarrera]
	-- Add the parameters for the stored procedure here
	@descripcion VARCHAR(100),
	@creditos INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblCarreras(
		Descripcion,
		Creditos,
		Observaciones,
		Inactivo
	)
	VALUES(
		@descripcion,
		@creditos,
		@observaciones,
		0
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_registrarCentro]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para registrar centros educativos o recintos
-- =============================================
CREATE PROCEDURE [dbo].[sp_registrarCentro]
	-- Add the parameters for the stored procedure here
	@descripcion VARCHAR(100),
	@nombreCorto VARCHAR(20),
	@webSite VARCHAR(500),
	@telefono VARCHAR(15),
	@observaciones VARCHAR(MAX),
	@urlLogo VARCHAR(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblCentros(
		Descripcion,
		NombreCorto,
		WebSite,
		Telefono,
		Observaciones,
		UrlLogo
	)
	VALUES(
		@descripcion,
		@nombreCorto,
		@webSite,
		@telefono,
		@observaciones,
		@urlLogo
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_registrarEstudiante]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para registrar los estudiantes
-- =============================================
CREATE PROCEDURE [dbo].[sp_registrarEstudiante]
	-- Add the parameters for the stored procedure here
	@idTipoEstudiante INT,
	@cedula VARCHAR(13),
	@nombre VARCHAR(50),
	@apellido VARCHAR(50),
	@sexo CHAR(1),
	@fechaNacimiento DATETIME,
	@idEstadoCivil VARCHAR(15),
	@telefonoCasa VARCHAR(15),
	@telefonoMovil VARCHAR(15),
	@direccion VARCHAR(200),
	@email VARCHAR(255),
	@observaciones VARCHAR(MAX),
	@urlFoto VARCHAR(200),
	@idCarrera INT,
	@idUsuario INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @matricula INT
	SET @matricula = (SELECT MAX(Matricula) FROM tblEstudiantes)
	IF @matricula IS NULL
		SET @matricula = 1000
	ELSE
		SET @matricula = @matricula + 1

	INSERT INTO tblEstudiantes(
		IdTipoEstudiante,
		Cedula,
		Nombre,
		Apellido,
		Sexo,
		FechaNacimiento,
		IdEstadoCivil,
		TelefonoCasa,
		TelefonoMovil,
		Direccion,
		Email,
		Observaciones,
		UrlFoto,
		IdCarrera,
		Matricula,
		Balance,
		CreatedAt,
		CreatedBy,
		Inactivo
	)
	VALUES(
		@idTipoEstudiante,
		@cedula,
		@nombre,
		@apellido,
		@sexo,
		@fechaNacimiento,
		@IdEstadoCivil,
		@telefonoCasa,
		@telefonoMovil,
		@direccion,
		@email,
		@observaciones,
		@urlFoto,
		@idCarrera,
		@matricula,
		0,
		GETDATE(),
		@idUsuario,
		0
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_registrarProfesor]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para registrar los estudiantes
-- =============================================
CREATE PROCEDURE [dbo].[sp_registrarProfesor]
	-- Add the parameters for the stored procedure here
	@nombre VARCHAR(50),
	@apellido VARCHAR(50),
	@cedula VARCHAR(13),
	@sexo CHAR(1),
	@fechaNacimiento DATETIME,
	@idEstadoCivil VARCHAR(15),
	@telefonoCasa VARCHAR(15),
	@telefonoMovil VARCHAR(15),
	@direccion VARCHAR(200),
	@email VARCHAR(255),
	@observaciones VARCHAR(MAX),
	@urlFoto VARCHAR(200),
	@idUsuario INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblProfesores(
		Cedula,
		Nombre,
		Apellido,
		Sexo,
		FechaNacimiento,
		IdEstadoCivil,
		TelefonoCasa,
		TelefonoMovil,
		Email,
		Observaciones,
		UrlFoto,
		CreatedAt,
		CreatedBy
	)
	VALUES(
		@cedula,
		@nombre,
		@apellido,
		@sexo,
		@fechaNacimiento,
		@idEstadoCivil,
		@telefonoCasa,
		@telefonoMovil,
		@email,
		@observaciones,
		@urlFoto,
		GETDATE(),
		@idUsuario
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_registrarSeccion]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 17 2020
-- Description:	procedimiento para registrar las secciones
-- =============================================
CREATE PROCEDURE [dbo].[sp_registrarSeccion]
	-- Add the parameters for the stored procedure here
	@idCentro INT,
	@idAula INT,
	@idCarrera INT,
	@idProfesor INT,
	@capacidad INT,
	@dia1 VARCHAR(10),
	@hora1 VARCHAR(10),
	@dia2 VARCHAR(10),
	@hora2 VARCHAR(10),
	@numero INT,
	@idAsignatura INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblSecciones(
		IdCentro,
		IdAula,
		IdCarrera,
		IdProfesor,
		Capacidad,
		Dia1,
		Hora1,
		Dia2,
		Hora2,
		Numero,
		IdAsignatura,
		Observaciones
	)
	VALUES(
		@idCentro,
		@idAula,
		@idCarrera,
		@idProfesor,
		@capacidad,
		@dia1,
		@hora1,
		@dia2,
		@hora2,
		@numero,
		@idAsignatura,
		@observaciones
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_secciones]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para obtener la informacion detalle de la seccion
-- =============================================
CREATE PROCEDURE [dbo].[sp_secciones]
	-- Add the parameters for the stored procedure here
	@filtro VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		s.ID,
		a.Descripcion [Aula],
		CONCAT(P.Nombre, '', P.Apellido) [Profesor],
		s.Capacidad,
		s.Dia1,
		s.Hora1,
		s.Dia2,
		s.Hora2,
		s.Numero,
		asg.Descripcion [Asignatura],
		s.Observaciones
	FROM tblSecciones s
	INNER JOIN tblAulas a
		ON s.IdAula = a.ID
	INNER JOIN tblProfesores p
		ON s.IdProfesor = p.ID
	INNER JOIN tblAsignaturas asg
		ON s.IdAsignatura = asg.ID
	WHERE s.Inactivo = 0
		/*AND(
			a.Descripcion LIKE CONCAT('', @filtro, '')
			OR CONCAT(P.Nombre, '', P.Apellido) LIKE CONCAT('', @filtro, '')
			OR asg.Descripcion LIKE CONCAT('', @filtro, '')
		)*/
END
GO
/****** Object:  StoredProcedure [dbo].[sp_tiposEstudiante]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: junio 7 2020
-- Description:	procedimiento para 
-- =============================================
CREATE PROCEDURE [dbo].[sp_tiposEstudiante]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		ID,
		Descripcion,
		CostoCredito,
		CostoInscripcion,
		Observaciones
	FROM tblTipoEstudiantes
	WHERE Inactivo = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_tiposUsuario]    Script Date: 6/23/2020 10:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alfredo Joel Mena Villafaña
-- Create date: mayo 22 2020
-- Description:	procedimiento para listar los tipos de usuario
-- =============================================
CREATE PROCEDURE [dbo].[sp_tiposUsuario]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
	tu.ID,
	tu.Nombre
FROM tblTipoUsuarios tu
WHERE tu.Inactivo = 0
END
GO
USE [master]
GO
ALTER DATABASE [INF518_TEST] SET  READ_WRITE 
GO
