USE [FOPROLYD_recep]
GO
/****** Object:  User [foprolyduser]    Script Date: 14/01/2020 9:01:23 ******/
CREATE USER [foprolyduser] FOR LOGIN [foprolyd] WITH DEFAULT_SCHEMA=[db_accessadmin]
GO
/****** Object:  Table [dbo].[atencion]    Script Date: 14/01/2020 9:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[atencion](
	[ID_atencion] [int] IDENTITY(1,1) NOT NULL,
	[Rubro_atencion] [varchar](25) NOT NULL,
	[Tipo_atencion] [varchar](15) NOT NULL,
	[Observacion_atencion] [varchar](350) NULL,
	[Fecha_atencion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_atencion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[audiencias]    Script Date: 14/01/2020 9:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[audiencias](
	[ID_a] [int] IDENTITY(1,1) NOT NULL,
	[Rubro_a] [varchar](25) NOT NULL,
	[Fecha_a] [datetime] NOT NULL,
	[Hora_a] [varchar](10) NOT NULL,
	[nombre_a] [varchar](50) NOT NULL,
	[telefono_a] [varchar](10) NULL,
	[audiencia_main] [varchar](50) NULL,
	[observaciones_a] [varchar](350) NULL,
	[Identificador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_a] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[correspondencias]    Script Date: 14/01/2020 9:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[correspondencias](
	[ID_correspondencia] [int] IDENTITY(1,1) NOT NULL,
	[Rubro_correspondencia] [varchar](25) NOT NULL,
	[Fecha_correspondencia] [datetime] NOT NULL,
	[Identificador_c] [int] NOT NULL,
	[observaciones] [varchar](350) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_correspondencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[llamadas]    Script Date: 14/01/2020 9:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[llamadas](
	[ID_llama] [int] IDENTITY(1,1) NOT NULL,
	[Rubro_llamada] [varchar](12) NOT NULL,
	[Fecha_llamada] [datetime] NOT NULL,
	[Identificador] [int] NOT NULL,
	[Categoria] [varchar](15) NOT NULL,
	[Notas] [varchar](170) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_llama] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
