USE [master]
GO
/****** Object:  Database [InstitutoKhipu]    Script Date: 04/18/2015 19:44:12 ******/
CREATE DATABASE [InstitutoKhipu] ON  PRIMARY 
( NAME = N'InstitutoKhipu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\InstitutoKhipu.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'InstitutoKhipu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\InstitutoKhipu_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [InstitutoKhipu] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InstitutoKhipu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InstitutoKhipu] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [InstitutoKhipu] SET ANSI_NULLS OFF
GO
ALTER DATABASE [InstitutoKhipu] SET ANSI_PADDING OFF
GO
ALTER DATABASE [InstitutoKhipu] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [InstitutoKhipu] SET ARITHABORT OFF
GO
ALTER DATABASE [InstitutoKhipu] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [InstitutoKhipu] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [InstitutoKhipu] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [InstitutoKhipu] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [InstitutoKhipu] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [InstitutoKhipu] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [InstitutoKhipu] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [InstitutoKhipu] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [InstitutoKhipu] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [InstitutoKhipu] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [InstitutoKhipu] SET  ENABLE_BROKER
GO
ALTER DATABASE [InstitutoKhipu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [InstitutoKhipu] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [InstitutoKhipu] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [InstitutoKhipu] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [InstitutoKhipu] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [InstitutoKhipu] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [InstitutoKhipu] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [InstitutoKhipu] SET  READ_WRITE
GO
ALTER DATABASE [InstitutoKhipu] SET RECOVERY FULL
GO
ALTER DATABASE [InstitutoKhipu] SET  MULTI_USER
GO
ALTER DATABASE [InstitutoKhipu] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [InstitutoKhipu] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'InstitutoKhipu', N'ON'
GO
USE [InstitutoKhipu]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/18/2015 19:44:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[CodUsuario] [varchar](8) NOT NULL,
	[contraseña] [varchar](10) NULL,
	[Tipo] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TCarrera]    Script Date: 04/18/2015 19:44:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TCarrera](
	[CodCarrera] [varchar](4) NOT NULL,
	[NomCarrera] [varchar](70) NULL,
	[Descripcion] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodCarrera] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TDocente]    Script Date: 04/18/2015 19:44:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TDocente](
	[CodDocente] [varchar](8) NOT NULL,
	[Dni] [varchar](8) NULL,
	[ApePaterno] [varchar](50) NULL,
	[ApeMaterno] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodDocente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Update]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[Usuario_Update]
	@CodUsuario varchar (8),
	@contraseña varchar (10),
	@Tipo varchar (20)
AS
Begin
	SET NOCOUNT ON
	update Usuario
	set
		contraseña = @contraseña,
		Tipo = @Tipo
	where
		CodUsuario = @CodUsuario
End
GO
/****** Object:  StoredProcedure [dbo].[Usuario_ReadById]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[Usuario_ReadById]
	@CodUsuario varchar (8)
AS
Begin
	SET NOCOUNT ON
	select
	 CodUsuario, contraseña, Tipo
	from Usuario
	where
		CodUsuario = @CodUsuario
End
GO
/****** Object:  StoredProcedure [dbo].[Usuario_ReadAll]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[Usuario_ReadAll]

AS
Begin
	SET NOCOUNT ON
	select
	 CodUsuario, contraseña, Tipo
	from Usuario
End
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Delete]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[Usuario_Delete]
	@CodUsuario varchar (8)
AS
Begin
	SET NOCOUNT ON
	delete from Usuario
	where
		CodUsuario = @CodUsuario
End
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Create]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[Usuario_Create]
	@CodUsuario varchar (8),
	@contraseña varchar (10),
	@Tipo varchar (20)
AS
Begin
	SET NOCOUNT ON
	insert into Usuario
		( CodUsuario, contraseña, Tipo)
	values
		(@CodUsuario,@contraseña,@Tipo)
End
GO
/****** Object:  Table [dbo].[TEstudiante]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TEstudiante](
	[CodEstudiante] [varchar](8) NOT NULL,
	[Dni] [varchar](8) NULL,
	[ApePaterno] [varchar](50) NULL,
	[ApeMaterno] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
	[CodCarrera] [varchar](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodEstudiante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[TDocente_Update]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TDocente_Update]
	@CodDocente varchar (8),
	@Dni varchar (8),
	@ApePaterno varchar (50),
	@ApeMaterno varchar (50),
	@Nombres varchar (50)
AS
Begin
	SET NOCOUNT ON
	update TDocente
	set
		Dni = @Dni,
		ApePaterno = @ApePaterno,
		ApeMaterno = @ApeMaterno,
		Nombres = @Nombres
	where
		CodDocente = @CodDocente
End
GO
/****** Object:  StoredProcedure [dbo].[TDocente_ReadById]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TDocente_ReadById]
	@CodDocente varchar (8)
AS
Begin
	SET NOCOUNT ON
	select
	 CodDocente, Dni, ApePaterno, ApeMaterno, Nombres
	from TDocente
	where
		CodDocente = @CodDocente
End
GO
/****** Object:  StoredProcedure [dbo].[TDocente_ReadAll]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TDocente_ReadAll]

AS
Begin
	SET NOCOUNT ON
	select
	 CodDocente, Dni, ApePaterno, ApeMaterno, Nombres
	from TDocente
End
GO
/****** Object:  StoredProcedure [dbo].[TDocente_Delete]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TDocente_Delete]
	@CodDocente varchar (8)
AS
Begin
	SET NOCOUNT ON
	delete from TDocente
	where
		CodDocente = @CodDocente
End
GO
/****** Object:  StoredProcedure [dbo].[TDocente_Create]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TDocente_Create]
	@CodDocente varchar (8),
	@Dni varchar (8),
	@ApePaterno varchar (50),
	@ApeMaterno varchar (50),
	@Nombres varchar (50)
AS
Begin
	SET NOCOUNT ON
	insert into TDocente
		( CodDocente, Dni, ApePaterno, ApeMaterno, Nombres)
	values
		(@CodDocente,@Dni,@ApePaterno,@ApeMaterno,@Nombres)
End
GO
/****** Object:  StoredProcedure [dbo].[TCarrera_Update]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCarrera_Update]
	@CodCarrera varchar (4),
	@NomCarrera varchar (70),
	@Descripcion varchar (500)
AS
Begin
	SET NOCOUNT ON
	update TCarrera
	set
		NomCarrera = @NomCarrera,
		Descripcion = @Descripcion
	where
		CodCarrera = @CodCarrera
End
GO
/****** Object:  StoredProcedure [dbo].[TCarrera_ReadById]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCarrera_ReadById]
	@CodCarrera varchar (4)
AS
Begin
	SET NOCOUNT ON
	select
	 CodCarrera, NomCarrera, Descripcion
	from TCarrera
	where
		CodCarrera = @CodCarrera
End
GO
/****** Object:  StoredProcedure [dbo].[TCarrera_ReadAll]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCarrera_ReadAll]

AS
Begin
	SET NOCOUNT ON
	select
	 CodCarrera, NomCarrera, Descripcion
	from TCarrera
End
GO
/****** Object:  StoredProcedure [dbo].[TCarrera_Delete]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCarrera_Delete]
	@CodCarrera varchar (4)
AS
Begin
	SET NOCOUNT ON
	delete from TCarrera
	where
		CodCarrera = @CodCarrera
End
GO
/****** Object:  StoredProcedure [dbo].[TCarrera_Create]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCarrera_Create]
	@CodCarrera varchar (4),
	@NomCarrera varchar (70),
	@Descripcion varchar (500)
AS
Begin
	SET NOCOUNT ON
	insert into TCarrera
		( CodCarrera, NomCarrera, Descripcion)
	values
		(@CodCarrera,@NomCarrera,@Descripcion)
End
GO
/****** Object:  Table [dbo].[TModuloCarrera]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TModuloCarrera](
	[CodModulo] [varchar](10) NOT NULL,
	[CodCarrera] [varchar](4) NULL,
	[NroModulo] [int] NULL,
	[Semestre] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodModulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[TModuloCarrera_Update]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TModuloCarrera_Update]
	@CodModulo varchar (10),
	@CodCarrera varchar (4),
	@NroModulo int,
	@Semestre varchar (8)
AS
Begin
	SET NOCOUNT ON
	update TModuloCarrera
	set
		CodCarrera = @CodCarrera,
		NroModulo = @NroModulo,
		Semestre = @Semestre
	where
		CodModulo = @CodModulo
End
GO
/****** Object:  StoredProcedure [dbo].[TModuloCarrera_ReadById]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TModuloCarrera_ReadById]
	@CodModulo varchar (10)
AS
Begin
	SET NOCOUNT ON
	select
	 CodModulo, CodCarrera, NroModulo, Semestre
	from TModuloCarrera
	where
		CodModulo = @CodModulo
End
GO
/****** Object:  StoredProcedure [dbo].[TModuloCarrera_ReadAll]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TModuloCarrera_ReadAll]

AS
Begin
	SET NOCOUNT ON
	select
	 CodModulo, CodCarrera, NroModulo, Semestre
	from TModuloCarrera
End
GO
/****** Object:  StoredProcedure [dbo].[TModuloCarrera_Delete]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TModuloCarrera_Delete]
	@CodModulo varchar (10)
AS
Begin
	SET NOCOUNT ON
	delete from TModuloCarrera
	where
		CodModulo = @CodModulo
End
GO
/****** Object:  StoredProcedure [dbo].[TModuloCarrera_Create]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TModuloCarrera_Create]
	@CodModulo varchar (10),
	@CodCarrera varchar (4),
	@NroModulo int,
	@Semestre varchar (8)
AS
Begin
	SET NOCOUNT ON
	insert into TModuloCarrera
		( CodModulo, CodCarrera, NroModulo, Semestre)
	values
		(@CodModulo,@CodCarrera,@NroModulo,@Semestre)
End
GO
/****** Object:  Table [dbo].[TMatricula]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMatricula](
	[CodMatricula] [varchar](8) NOT NULL,
	[CodEstudiante] [varchar](8) NULL,
	[CodCarrera] [varchar](4) NULL,
	[CodModulo] [varchar](10) NULL,
	[Semestre] [varchar](8) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodMatricula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[TEstudiante_Update]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TEstudiante_Update]
	@CodEstudiante varchar (8),
	@Dni varchar (8),
	@ApePaterno varchar (50),
	@ApeMaterno varchar (50),
	@Nombres varchar (50),
	@CodCarrera varchar (4)
AS
Begin
	SET NOCOUNT ON
	update TEstudiante
	set
		Dni = @Dni,
		ApePaterno = @ApePaterno,
		ApeMaterno = @ApeMaterno,
		Nombres = @Nombres,
		CodCarrera = @CodCarrera
	where
		CodEstudiante = @CodEstudiante
End
GO
/****** Object:  StoredProcedure [dbo].[TEstudiante_ReadById]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TEstudiante_ReadById]
	@CodEstudiante varchar (8)
AS
Begin
	SET NOCOUNT ON
	select
	 CodEstudiante, Dni, ApePaterno, ApeMaterno, Nombres, CodCarrera
	from TEstudiante
	where
		CodEstudiante = @CodEstudiante
End
GO
/****** Object:  StoredProcedure [dbo].[TEstudiante_ReadAll]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TEstudiante_ReadAll]

AS
Begin
	SET NOCOUNT ON
	select
	 CodEstudiante, Dni, ApePaterno, ApeMaterno, Nombres, CodCarrera
	from TEstudiante
End
GO
/****** Object:  StoredProcedure [dbo].[TEstudiante_Delete]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TEstudiante_Delete]
	@CodEstudiante varchar (8)
AS
Begin
	SET NOCOUNT ON
	delete from TEstudiante
	where
		CodEstudiante = @CodEstudiante
End
GO
/****** Object:  StoredProcedure [dbo].[TEstudiante_Create]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TEstudiante_Create]
	@CodEstudiante varchar (8),
	@Dni varchar (8),
	@ApePaterno varchar (50),
	@ApeMaterno varchar (50),
	@Nombres varchar (50),
	@CodCarrera varchar (4)
AS
Begin
	SET NOCOUNT ON
	insert into TEstudiante
		( CodEstudiante, Dni, ApePaterno, ApeMaterno, Nombres, CodCarrera)
	values
		(@CodEstudiante,@Dni,@ApePaterno,@ApeMaterno,@Nombres,@CodCarrera)
End
GO
/****** Object:  Table [dbo].[TCurso]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TCurso](
	[CodCurso] [varchar](8) NOT NULL,
	[NomCurso] [varchar](70) NULL,
	[Horas] [int] NULL,
	[Creditos] [int] NULL,
	[CodModulo] [varchar](10) NULL,
	[CodCarrera] [varchar](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodCurso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[TCurso_Update]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCurso_Update]
	@CodCurso varchar (8),
	@NomCurso varchar (70),
	@Horas int,
	@Creditos int,
	@CodModulo varchar (10),
	@CodCarrera varchar (4)
AS
Begin
	SET NOCOUNT ON
	update TCurso
	set
		NomCurso = @NomCurso,
		Horas = @Horas,
		Creditos = @Creditos,
		CodModulo = @CodModulo,
		CodCarrera = @CodCarrera
	where
		CodCurso = @CodCurso
End
GO
/****** Object:  StoredProcedure [dbo].[TCurso_ReadById]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCurso_ReadById]
	@CodCurso varchar (8)
AS
Begin
	SET NOCOUNT ON
	select
	 CodCurso, NomCurso, Horas, Creditos, CodModulo, CodCarrera
	from TCurso
	where
		CodCurso = @CodCurso
End
GO
/****** Object:  StoredProcedure [dbo].[TCurso_ReadAll]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCurso_ReadAll]

AS
Begin
	SET NOCOUNT ON
	select
	 CodCurso, NomCurso, Horas, Creditos, CodModulo, CodCarrera
	from TCurso
End
GO
/****** Object:  StoredProcedure [dbo].[TCurso_Delete]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCurso_Delete]
	@CodCurso varchar (8)
AS
Begin
	SET NOCOUNT ON
	delete from TCurso
	where
		CodCurso = @CodCurso
End
GO
/****** Object:  StoredProcedure [dbo].[TCurso_Create]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TCurso_Create]
	@CodCurso varchar (8),
	@NomCurso varchar (70),
	@Horas int,
	@Creditos int,
	@CodModulo varchar (10),
	@CodCarrera varchar (4)
AS
Begin
	SET NOCOUNT ON
	insert into TCurso
		( CodCurso, NomCurso, Horas, Creditos, CodModulo, CodCarrera)
	values
		(@CodCurso,@NomCurso,@Horas,@Creditos,@CodModulo,@CodCarrera)
End
GO
/****** Object:  Table [dbo].[TMatriculaSemetre]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMatriculaSemetre](
	[CodMatriculaSemetre] [varchar](8) NOT NULL,
	[CodMatricula] [varchar](8) NULL,
	[CodEstudiante] [varchar](8) NULL,
	[CodCurso] [varchar](8) NULL,
	[CodDocente] [varchar](8) NULL,
	[Semestre] [varchar](8) NULL,
	[NomCurso] [varchar](70) NULL,
	[NotaPromedio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodMatriculaSemetre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[TMatricula_Update]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatricula_Update]
	@CodMatricula varchar (8),
	@CodEstudiante varchar (8),
	@CodCarrera varchar (4),
	@CodModulo varchar (10),
	@Semestre varchar (8),
	@Fecha datetime
AS
Begin
	SET NOCOUNT ON
	update TMatricula
	set
		CodEstudiante = @CodEstudiante,
		CodCarrera = @CodCarrera,
		CodModulo = @CodModulo,
		Semestre = @Semestre,
		Fecha = @Fecha
	where
		CodMatricula = @CodMatricula
End
GO
/****** Object:  StoredProcedure [dbo].[TMatricula_ReadById]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatricula_ReadById]
	@CodMatricula varchar (8)
AS
Begin
	SET NOCOUNT ON
	select
	 CodMatricula, CodEstudiante, CodCarrera, CodModulo, Semestre, Fecha
	from TMatricula
	where
		CodMatricula = @CodMatricula
End
GO
/****** Object:  StoredProcedure [dbo].[TMatricula_ReadAll]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatricula_ReadAll]

AS
Begin
	SET NOCOUNT ON
	select
	 CodMatricula, CodEstudiante, CodCarrera, CodModulo, Semestre, Fecha
	from TMatricula
End
GO
/****** Object:  StoredProcedure [dbo].[TMatricula_Delete]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatricula_Delete]
	@CodMatricula varchar (8)
AS
Begin
	SET NOCOUNT ON
	delete from TMatricula
	where
		CodMatricula = @CodMatricula
End
GO
/****** Object:  StoredProcedure [dbo].[TMatricula_Create]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatricula_Create]
	@CodMatricula varchar (8),
	@CodEstudiante varchar (8),
	@CodCarrera varchar (4),
	@CodModulo varchar (10),
	@Semestre varchar (8),
	@Fecha datetime
AS
Begin
	SET NOCOUNT ON
	insert into TMatricula
		( CodMatricula, CodEstudiante, CodCarrera, CodModulo, Semestre, Fecha)
	values
		(@CodMatricula,@CodEstudiante,@CodCarrera,@CodModulo,@Semestre,@Fecha)
End
GO
/****** Object:  StoredProcedure [dbo].[TMatriculaSemetre_Update]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatriculaSemetre_Update]
	@CodMatriculaSemetre varchar (8),
	@CodMatricula varchar (8),
	@CodEstudiante varchar (8),
	@CodCurso varchar (8),
	@CodDocente varchar (8),
	@Semestre varchar (8),
	@NomCurso varchar (70),
	@NotaPromedio int
AS
Begin
	SET NOCOUNT ON
	update TMatriculaSemetre
	set
		CodMatricula = @CodMatricula,
		CodEstudiante = @CodEstudiante,
		CodCurso = @CodCurso,
		CodDocente = @CodDocente,
		Semestre = @Semestre,
		NomCurso = @NomCurso,
		NotaPromedio = @NotaPromedio
	where
		CodMatriculaSemetre = @CodMatriculaSemetre
End
GO
/****** Object:  StoredProcedure [dbo].[TMatriculaSemetre_ReadById]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatriculaSemetre_ReadById]
	@CodMatriculaSemetre varchar (8)
AS
Begin
	SET NOCOUNT ON
	select
	 CodMatriculaSemetre, CodMatricula, CodEstudiante, CodCurso, CodDocente, Semestre, NomCurso, NotaPromedio
	from TMatriculaSemetre
	where
		CodMatriculaSemetre = @CodMatriculaSemetre
End
GO
/****** Object:  StoredProcedure [dbo].[TMatriculaSemetre_ReadAll]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatriculaSemetre_ReadAll]

AS
Begin
	SET NOCOUNT ON
	select
	 CodMatriculaSemetre, CodMatricula, CodEstudiante, CodCurso, CodDocente, Semestre, NomCurso, NotaPromedio
	from TMatriculaSemetre
End
GO
/****** Object:  StoredProcedure [dbo].[TMatriculaSemetre_Delete]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatriculaSemetre_Delete]
	@CodMatriculaSemetre varchar (8)
AS
Begin
	SET NOCOUNT ON
	delete from TMatriculaSemetre
	where
		CodMatriculaSemetre = @CodMatriculaSemetre
End
GO
/****** Object:  StoredProcedure [dbo].[TMatriculaSemetre_Create]    Script Date: 04/18/2015 19:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		RaPzoD1 
-- Create date:	18/04/2015
-- Description:	
-- Revisions:	
-- =============================================
Create Procedure [dbo].[TMatriculaSemetre_Create]
	@CodMatriculaSemetre varchar (8),
	@CodMatricula varchar (8),
	@CodEstudiante varchar (8),
	@CodCurso varchar (8),
	@CodDocente varchar (8),
	@Semestre varchar (8),
	@NomCurso varchar (70),
	@NotaPromedio int
AS
Begin
	SET NOCOUNT ON
	insert into TMatriculaSemetre
		( CodMatriculaSemetre, CodMatricula, CodEstudiante, CodCurso, CodDocente, Semestre, NomCurso, NotaPromedio)
	values
		(@CodMatriculaSemetre,@CodMatricula,@CodEstudiante,@CodCurso,@CodDocente,@Semestre,@NomCurso,@NotaPromedio)
End
GO
/****** Object:  ForeignKey [FK__TEstudian__CodCa__671F4F74]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TEstudiante]  WITH CHECK ADD FOREIGN KEY([CodCarrera])
REFERENCES [dbo].[TCarrera] ([CodCarrera])
GO
/****** Object:  ForeignKey [FK__TModuloCa__CodCa__6BE40491]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TModuloCarrera]  WITH CHECK ADD FOREIGN KEY([CodCarrera])
REFERENCES [dbo].[TCarrera] ([CodCarrera])
GO
/****** Object:  ForeignKey [FK__TMatricul__CodCa__719CDDE7]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD FOREIGN KEY([CodCarrera])
REFERENCES [dbo].[TCarrera] ([CodCarrera])
GO
/****** Object:  ForeignKey [FK__TMatricul__CodEs__70A8B9AE]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD FOREIGN KEY([CodEstudiante])
REFERENCES [dbo].[TEstudiante] ([CodEstudiante])
GO
/****** Object:  ForeignKey [FK__TMatricul__CodMo__72910220]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD FOREIGN KEY([CodModulo])
REFERENCES [dbo].[TModuloCarrera] ([CodModulo])
GO
/****** Object:  ForeignKey [FK__TCurso__CodCarre__7849DB76]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TCurso]  WITH CHECK ADD FOREIGN KEY([CodCarrera])
REFERENCES [dbo].[TCarrera] ([CodCarrera])
GO
/****** Object:  ForeignKey [FK__TCurso__CodModul__7755B73D]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TCurso]  WITH CHECK ADD FOREIGN KEY([CodModulo])
REFERENCES [dbo].[TModuloCarrera] ([CodModulo])
GO
/****** Object:  ForeignKey [FK__TMatricul__CodCu__02C769E9]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TMatriculaSemetre]  WITH CHECK ADD FOREIGN KEY([CodCurso])
REFERENCES [dbo].[TCurso] ([CodCurso])
GO
/****** Object:  ForeignKey [FK__TMatricul__CodDo__03BB8E22]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TMatriculaSemetre]  WITH CHECK ADD FOREIGN KEY([CodDocente])
REFERENCES [dbo].[TDocente] ([CodDocente])
GO
/****** Object:  ForeignKey [FK__TMatricul__CodEs__01D345B0]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TMatriculaSemetre]  WITH CHECK ADD FOREIGN KEY([CodEstudiante])
REFERENCES [dbo].[TEstudiante] ([CodEstudiante])
GO
/****** Object:  ForeignKey [FK__TMatricul__CodMa__00DF2177]    Script Date: 04/18/2015 19:44:14 ******/
ALTER TABLE [dbo].[TMatriculaSemetre]  WITH CHECK ADD FOREIGN KEY([CodMatricula])
REFERENCES [dbo].[TMatricula] ([CodMatricula])
GO
