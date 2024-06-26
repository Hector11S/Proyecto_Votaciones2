USE [BD_SistemaVotaciones]
GO
/****** Object:  Schema [Acce]    Script Date: 10/4/2024 10:46:59 ******/
CREATE SCHEMA [Acce]
GO
/****** Object:  Schema [Gral]    Script Date: 10/4/2024 10:46:59 ******/
CREATE SCHEMA [Gral]
GO
/****** Object:  Schema [Vota]    Script Date: 10/4/2024 10:46:59 ******/
CREATE SCHEMA [Vota]
GO
/****** Object:  Table [Acce].[tbPantallas]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbPantallas](
	[Pant_Id] [int] IDENTITY(1,1) NOT NULL,
	[Pant_Descripcion] [varchar](50) NOT NULL,
	[Pant_UsuarioCreacion] [int] NOT NULL,
	[Pant_FechaCreacion] [datetime] NOT NULL,
	[Pant_UsuarioModifica] [int] NULL,
	[Pant_FechaModifica] [datetime] NULL,
	[Pant_Estado] [bit] NOT NULL,
	[Pant_Esquema] [varchar](50) NULL,
	[Pant_Controlador] [varchar](50) NOT NULL,
	[Pant_IconoBootstrap] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Pant_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbPantallasPorRoles]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbPantallasPorRoles](
	[Paro_Id] [int] IDENTITY(1,1) NOT NULL,
	[Rol_Id] [int] NOT NULL,
	[Pant_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Paro_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbRoles]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbRoles](
	[Rol_Id] [int] IDENTITY(1,1) NOT NULL,
	[Rol_Descripcion] [varchar](50) NOT NULL,
	[Rol_UsuarioCreacion] [int] NOT NULL,
	[Rol_FechaCreacion] [datetime] NOT NULL,
	[Rol_UsuarioModifica] [int] NULL,
	[Rol_FechaModifica] [datetime] NULL,
	[Rol_Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Rol_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbUsuarios]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbUsuarios](
	[Usua_Id] [int] IDENTITY(1,1) NOT NULL,
	[Usua_Usuario] [varchar](50) NOT NULL,
	[Usua_Contra] [varchar](max) NOT NULL,
	[Usua_Admin] [bit] NOT NULL,
	[Empl_Id] [int] NOT NULL,
	[Rol_Id] [int] NOT NULL,
	[Usua_UsuarioCreacion] [int] NOT NULL,
	[Usua_FechaCreacion] [datetime] NOT NULL,
	[Usua_UsuarioModifica] [int] NULL,
	[Usua_FechaModifica] [datetime] NULL,
	[Usua_Activo] [bit] NOT NULL,
	[Usua_Imagen] [varchar](max) NOT NULL,
 CONSTRAINT [PK__tbUsuari__E863C8EE2E2D9E68] PRIMARY KEY CLUSTERED 
(
	[Usua_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbCargos]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbCargos](
	[Carg_Id] [int] IDENTITY(1,1) NOT NULL,
	[Carg_Descripcion] [varchar](50) NOT NULL,
	[Carg_UsuarioCreacion] [int] NOT NULL,
	[Carg_FechaCreacion] [datetime] NOT NULL,
	[Carg_UsuarioModifica] [int] NULL,
	[Carg_FechaModifica] [datetime] NULL,
	[Carg_Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Carg_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbDepartamentos]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbDepartamentos](
	[Dept_Codigo] [varchar](2) NOT NULL,
	[Dept_Descripcion] [varchar](50) NULL,
	[Dept_UsuarioCreacion] [int] NOT NULL,
	[Dept_FechaCreacion] [datetime] NOT NULL,
	[Dept_UsuarioModifica] [int] NULL,
	[Dept_FechaModifica] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Dept_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbEmpleados]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbEmpleados](
	[Empl_UsuarioCreacion] [int] NOT NULL,
	[Empl_FechaCreacion] [datetime] NOT NULL,
	[Empl_UsuarioModifica] [int] NULL,
	[Empl_FechaModifica] [datetime] NULL,
	[Empl_Estado] [bit] NOT NULL,
	[Part_Id] [int] NOT NULL,
	[Carg_Id] [int] NOT NULL,
	[Empl_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Empl_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbEstadosCiviles]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbEstadosCiviles](
	[Esta_Id] [int] IDENTITY(1,1) NOT NULL,
	[Esta_Descripcion] [varchar](50) NOT NULL,
	[Esta_UsuarioCreacion] [int] NOT NULL,
	[Esta_FechaCreacion] [datetime] NOT NULL,
	[Esta_UsuarioModifica] [int] NULL,
	[Esta_FechaModifica] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Esta_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbMesas]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbMesas](
	[Mesa_Id] [int] IDENTITY(1,1) NOT NULL,
	[Mesa_UsuarioCreacion] [int] NOT NULL,
	[Mesa_FechaCreacion] [datetime] NOT NULL,
	[Mesa_UsuarioModifica] [int] NULL,
	[Mesa_FechaModifica] [datetime] NULL,
	[Mesa_Estado] [bit] NOT NULL,
	[Mesa_Numero] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mesa_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbMunicipios]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbMunicipios](
	[Muni_Codigo] [varchar](4) NOT NULL,
	[Muni_Descripcion] [varchar](50) NOT NULL,
	[Dept_Codigo] [varchar](2) NOT NULL,
	[Muni_UsuarioCreacion] [int] NOT NULL,
	[Muni_FechaCreacion] [datetime] NOT NULL,
	[Muni_UsuarioModifica] [int] NULL,
	[Muni_FechaModifica] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Muni_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbSedes]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbSedes](
	[Sede_Id] [int] IDENTITY(1,1) NOT NULL,
	[Sede_Descripcion] [varchar](50) NOT NULL,
	[Muni_Codigo] [varchar](4) NOT NULL,
	[Sede_UsuarioCreacion] [int] NOT NULL,
	[Sede_FechaCreacion] [datetime] NOT NULL,
	[Sede_UsuarioModifica] [int] NULL,
	[Sede_FechaModifica] [datetime] NULL,
	[Sede_Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sede_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbVotantes]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbVotantes](
	[Vota_Id] [int] IDENTITY(1,1) NOT NULL,
	[Vota_Nombre] [varchar](50) NOT NULL,
	[Vota_Apellidos] [varchar](50) NOT NULL,
	[Vota_DNI] [varchar](50) NOT NULL,
	[Vota_YaVoto] [bit] NOT NULL,
	[Muni_Codigo] [varchar](4) NOT NULL,
	[Esta_Id] [int] NOT NULL,
	[Vota_UsuarioCreacion] [int] NOT NULL,
	[Vota_FechaCreacion] [datetime] NOT NULL,
	[Vota_UsuarioModifica] [int] NULL,
	[Vota_FechaModifica] [datetime] NULL,
	[MePS_Id] [int] NULL,
	[Vota_Permitido] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Vota_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Vota].[tbAlcaldes]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Vota].[tbAlcaldes](
	[Alca_Imagen] [varchar](max) NOT NULL,
	[Muni_Codigo] [varchar](4) NOT NULL,
	[Part_Id] [int] NOT NULL,
	[Alca_UsuarioCreacion] [int] NOT NULL,
	[Alca_FechaCreacion] [datetime] NOT NULL,
	[Alca_UsuarioModifica] [int] NULL,
	[Alca_FechaModifica] [datetime] NULL,
	[Alca_Estado] [bit] NOT NULL,
	[Alca_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Alca_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Vota].[tbEmpleadosPorMesaElectoral]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Vota].[tbEmpleadosPorMesaElectoral](
	[EPME_Id] [int] IDENTITY(1,1) NOT NULL,
	[MePS_Id] [int] NOT NULL,
	[Empl_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EPME_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Vota].[tbMesasPorSedes]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Vota].[tbMesasPorSedes](
	[MePS_Id] [int] IDENTITY(1,1) NOT NULL,
	[Mesa_Id] [int] NOT NULL,
	[Sede_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MePS_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Vota].[tbPartidos]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Vota].[tbPartidos](
	[Part_Id] [int] IDENTITY(1,1) NOT NULL,
	[Part_Descripcion] [varchar](50) NULL,
	[Part_UsuarioCreacion] [int] NOT NULL,
	[Part_FechaCreacion] [datetime] NOT NULL,
	[Part_UsuarioModifica] [int] NULL,
	[Part_FechaModifica] [datetime] NULL,
	[Part_Estado] [bit] NOT NULL,
	[Part_Imagen] [varchar](max) NOT NULL,
	[Part_Color] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Part_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Vota].[tbPresidentes]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Vota].[tbPresidentes](
	[Pres_Id] [int] NOT NULL,
	[Pres_Imagen] [varchar](max) NOT NULL,
	[Part_Id] [int] NOT NULL,
	[Pres_UsuarioCreacion] [int] NOT NULL,
	[Pres_FechaCreacion] [datetime] NOT NULL,
	[Pres_UsuarioModifica] [int] NULL,
	[Pres_FechaModifica] [datetime] NULL,
	[Pres_Estado] [bit] NOT NULL,
 CONSTRAINT [PK__tbPresid__84FF9A16A022EE79] PRIMARY KEY CLUSTERED 
(
	[Pres_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Vota].[tbVotosPorMesas]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Vota].[tbVotosPorMesas](
	[VoMe_Id] [int] IDENTITY(1,1) NOT NULL,
	[MePS_Id] [int] NOT NULL,
	[VoMe_CandidatoId] [int] NOT NULL,
	[VoMe_EsPresidente] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VoMe_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Vota].[tbVotosPorMesas_Bitacora]    Script Date: 10/4/2024 10:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Vota].[tbVotosPorMesas_Bitacora](
	[VoMe_Id] [int] NOT NULL,
	[MePS_Id] [int] NOT NULL,
	[VoMe_CandidatoId] [int] NOT NULL,
	[VoMe_EsPresidente] [bit] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Acce].[tbPantallas] ON 

INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (1, N'Roles', 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'Acceso', N'Roles', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (2, N'Departamentos', 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'General', N'Departamentos', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (4, N'Alcalde', 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'Votaciones', N'Alcalde', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (5, N'Ganadores', 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'Graficos', N'Ganadores', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (6, N'Municipios', 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'General', N'Municipios', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (7, N'Sedes', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'General', N'Sedes', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (8, N'Mesas', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'General', N'Mesas', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (9, N'Estados Civiles', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'General', N'EstadosCiviles', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (10, N'Votantes', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'General', N'Votantes', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (11, N'Cargos', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'General', N'Cargos', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (12, N'Empleados', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'General', N'Empleados', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (13, N'Roles', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'Acceso', N'Roles', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (14, N'Usuarios', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'Acceso', N'Usuarios', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (15, N'Alcaldes', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'Votaciones', N'Alcaldes', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (16, N'Partidos', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'Votaciones', N'Partidos', N'bi bi-circle')
INSERT [Acce].[tbPantallas] ([Pant_Id], [Pant_Descripcion], [Pant_UsuarioCreacion], [Pant_FechaCreacion], [Pant_UsuarioModifica], [Pant_FechaModifica], [Pant_Estado], [Pant_Esquema], [Pant_Controlador], [Pant_IconoBootstrap]) VALUES (17, N'Presidentes', 4, CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'Votaciones', N'Presidentes', N'bi bi-circle')
SET IDENTITY_INSERT [Acce].[tbPantallas] OFF
GO
SET IDENTITY_INSERT [Acce].[tbPantallasPorRoles] ON 

INSERT [Acce].[tbPantallasPorRoles] ([Paro_Id], [Rol_Id], [Pant_Id]) VALUES (2, 4, 2)
INSERT [Acce].[tbPantallasPorRoles] ([Paro_Id], [Rol_Id], [Pant_Id]) VALUES (3, 4, 16)
INSERT [Acce].[tbPantallasPorRoles] ([Paro_Id], [Rol_Id], [Pant_Id]) VALUES (4, 4, 16)
INSERT [Acce].[tbPantallasPorRoles] ([Paro_Id], [Rol_Id], [Pant_Id]) VALUES (5, 4, 15)
SET IDENTITY_INSERT [Acce].[tbPantallasPorRoles] OFF
GO
SET IDENTITY_INSERT [Acce].[tbRoles] ON 

INSERT [Acce].[tbRoles] ([Rol_Id], [Rol_Descripcion], [Rol_UsuarioCreacion], [Rol_FechaCreacion], [Rol_UsuarioModifica], [Rol_FechaModifica], [Rol_Estado]) VALUES (4, N'ROL J', 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), 4, CAST(N'2024-04-10T10:44:54.910' AS DateTime), 1)
INSERT [Acce].[tbRoles] ([Rol_Id], [Rol_Descripcion], [Rol_UsuarioCreacion], [Rol_FechaCreacion], [Rol_UsuarioModifica], [Rol_FechaModifica], [Rol_Estado]) VALUES (6, N'RolNuevo', 4, CAST(N'2024-04-10T10:25:23.960' AS DateTime), NULL, NULL, 1)
INSERT [Acce].[tbRoles] ([Rol_Id], [Rol_Descripcion], [Rol_UsuarioCreacion], [Rol_FechaCreacion], [Rol_UsuarioModifica], [Rol_FechaModifica], [Rol_Estado]) VALUES (7, N'Empleado', 4, CAST(N'2024-04-10T16:30:00.063' AS DateTime), NULL, NULL, 1)
INSERT [Acce].[tbRoles] ([Rol_Id], [Rol_Descripcion], [Rol_UsuarioCreacion], [Rol_FechaCreacion], [Rol_UsuarioModifica], [Rol_FechaModifica], [Rol_Estado]) VALUES (8, N'RolX', 4, CAST(N'2024-04-10T10:34:16.777' AS DateTime), NULL, NULL, 1)
SET IDENTITY_INSERT [Acce].[tbRoles] OFF
GO
SET IDENTITY_INSERT [Acce].[tbUsuarios] ON 

INSERT [Acce].[tbUsuarios] ([Usua_Id], [Usua_Usuario], [Usua_Contra], [Usua_Admin], [Empl_Id], [Rol_Id], [Usua_UsuarioCreacion], [Usua_FechaCreacion], [Usua_UsuarioModifica], [Usua_FechaModifica], [Usua_Activo], [Usua_Imagen]) VALUES (4, N'h', N'h', 1, 3, 4, 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), 1, N'https://votacionesblobstorage.blob.core.windows.net/main/Usuario_0.png')
INSERT [Acce].[tbUsuarios] ([Usua_Id], [Usua_Usuario], [Usua_Contra], [Usua_Admin], [Empl_Id], [Rol_Id], [Usua_UsuarioCreacion], [Usua_FechaCreacion], [Usua_UsuarioModifica], [Usua_FechaModifica], [Usua_Activo], [Usua_Imagen]) VALUES (17, N'Usuario01', N'0A47151A074E633AB7B6BED6AAB724ABBDDCD3250F80A06BC612A233A907805101F2441B5B2926E54CE8AC8CFBC074BB7A56748830487DF09591DBE167E800F6', 1, 8, 4, 4, CAST(N'2024-04-10T01:49:09.523' AS DateTime), NULL, NULL, 1, N'https://votacionesblobstorage.blob.core.windows.net/main/Usuario_0.png')
SET IDENTITY_INSERT [Acce].[tbUsuarios] OFF
GO
SET IDENTITY_INSERT [Gral].[tbCargos] ON 

INSERT [Gral].[tbCargos] ([Carg_Id], [Carg_Descripcion], [Carg_UsuarioCreacion], [Carg_FechaCreacion], [Carg_UsuarioModifica], [Carg_FechaModifica], [Carg_Estado]) VALUES (4, N'Jefe', 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1)
INSERT [Gral].[tbCargos] ([Carg_Id], [Carg_Descripcion], [Carg_UsuarioCreacion], [Carg_FechaCreacion], [Carg_UsuarioModifica], [Carg_FechaModifica], [Carg_Estado]) VALUES (5, N'string', 4, CAST(N'2024-04-08T17:30:53.247' AS DateTime), NULL, NULL, 1)
INSERT [Gral].[tbCargos] ([Carg_Id], [Carg_Descripcion], [Carg_UsuarioCreacion], [Carg_FechaCreacion], [Carg_UsuarioModifica], [Carg_FechaModifica], [Carg_Estado]) VALUES (6, N'Cargo 01', 4, CAST(N'2024-04-08T11:31:59.063' AS DateTime), NULL, NULL, 1)
SET IDENTITY_INSERT [Gral].[tbCargos] OFF
GO
INSERT [Gral].[tbDepartamentos] ([Dept_Codigo], [Dept_Descripcion], [Dept_UsuarioCreacion], [Dept_FechaCreacion], [Dept_UsuarioModifica], [Dept_FechaModifica]) VALUES (N'01', N'Atlántida', 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), 4, CAST(N'2024-04-06T16:07:48.720' AS DateTime))
INSERT [Gral].[tbDepartamentos] ([Dept_Codigo], [Dept_Descripcion], [Dept_UsuarioCreacion], [Dept_FechaCreacion], [Dept_UsuarioModifica], [Dept_FechaModifica]) VALUES (N'05', N'Cortés', 4, CAST(N'2024-04-06T16:09:21.053' AS DateTime), NULL, NULL)
GO
INSERT [Gral].[tbEmpleados] ([Empl_UsuarioCreacion], [Empl_FechaCreacion], [Empl_UsuarioModifica], [Empl_FechaModifica], [Empl_Estado], [Part_Id], [Carg_Id], [Empl_Id]) VALUES (4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1, 1, 4, 3)
INSERT [Gral].[tbEmpleados] ([Empl_UsuarioCreacion], [Empl_FechaCreacion], [Empl_UsuarioModifica], [Empl_FechaModifica], [Empl_Estado], [Part_Id], [Carg_Id], [Empl_Id]) VALUES (4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL, 1, 1, 4, 8)
GO
SET IDENTITY_INSERT [Gral].[tbEstadosCiviles] ON 

INSERT [Gral].[tbEstadosCiviles] ([Esta_Id], [Esta_Descripcion], [Esta_UsuarioCreacion], [Esta_FechaCreacion], [Esta_UsuarioModifica], [Esta_FechaModifica]) VALUES (1, N'Soltero', 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [Gral].[tbEstadosCiviles] OFF
GO
SET IDENTITY_INSERT [Gral].[tbMesas] ON 

INSERT [Gral].[tbMesas] ([Mesa_Id], [Mesa_UsuarioCreacion], [Mesa_FechaCreacion], [Mesa_UsuarioModifica], [Mesa_FechaModifica], [Mesa_Estado], [Mesa_Numero]) VALUES (1, 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1, 2)
SET IDENTITY_INSERT [Gral].[tbMesas] OFF
GO
INSERT [Gral].[tbMunicipios] ([Muni_Codigo], [Muni_Descripcion], [Dept_Codigo], [Muni_UsuarioCreacion], [Muni_FechaCreacion], [Muni_UsuarioModifica], [Muni_FechaModifica]) VALUES (N'0501', N'San Pedro Sula', N'01', 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [Gral].[tbMunicipios] ([Muni_Codigo], [Muni_Descripcion], [Dept_Codigo], [Muni_UsuarioCreacion], [Muni_FechaCreacion], [Muni_UsuarioModifica], [Muni_FechaModifica]) VALUES (N'0502', N'Choloma', N'05', 4, CAST(N'2024-04-08T00:17:01.603' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [Gral].[tbSedes] ON 

INSERT [Gral].[tbSedes] ([Sede_Id], [Sede_Descripcion], [Muni_Codigo], [Sede_UsuarioCreacion], [Sede_FechaCreacion], [Sede_UsuarioModifica], [Sede_FechaModifica], [Sede_Estado]) VALUES (1, N'Sur', N'0501', 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1)
SET IDENTITY_INSERT [Gral].[tbSedes] OFF
GO
SET IDENTITY_INSERT [Gral].[tbVotantes] ON 

INSERT [Gral].[tbVotantes] ([Vota_Id], [Vota_Nombre], [Vota_Apellidos], [Vota_DNI], [Vota_YaVoto], [Muni_Codigo], [Esta_Id], [Vota_UsuarioCreacion], [Vota_FechaCreacion], [Vota_UsuarioModifica], [Vota_FechaModifica], [MePS_Id], [Vota_Permitido]) VALUES (3, N'pepe', N'mario', N'0501200504200', 1, N'0501', 1, 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1, 1)
INSERT [Gral].[tbVotantes] ([Vota_Id], [Vota_Nombre], [Vota_Apellidos], [Vota_DNI], [Vota_YaVoto], [Muni_Codigo], [Esta_Id], [Vota_UsuarioCreacion], [Vota_FechaCreacion], [Vota_UsuarioModifica], [Vota_FechaModifica], [MePS_Id], [Vota_Permitido]) VALUES (6, N'marcos', N'felipe', N'0501200504201', 1, N'0501', 1, 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1, 1)
INSERT [Gral].[tbVotantes] ([Vota_Id], [Vota_Nombre], [Vota_Apellidos], [Vota_DNI], [Vota_YaVoto], [Muni_Codigo], [Esta_Id], [Vota_UsuarioCreacion], [Vota_FechaCreacion], [Vota_UsuarioModifica], [Vota_FechaModifica], [MePS_Id], [Vota_Permitido]) VALUES (8, N'Victor', N'Espinoza', N'0501200504202', 1, N'0501', 1, 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1, 1)
INSERT [Gral].[tbVotantes] ([Vota_Id], [Vota_Nombre], [Vota_Apellidos], [Vota_DNI], [Vota_YaVoto], [Muni_Codigo], [Esta_Id], [Vota_UsuarioCreacion], [Vota_FechaCreacion], [Vota_UsuarioModifica], [Vota_FechaModifica], [MePS_Id], [Vota_Permitido]) VALUES (12, N'Manolo', N'Felipe', N'0501200416442', 1, N'0501', 1, 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1, 1)
INSERT [Gral].[tbVotantes] ([Vota_Id], [Vota_Nombre], [Vota_Apellidos], [Vota_DNI], [Vota_YaVoto], [Muni_Codigo], [Esta_Id], [Vota_UsuarioCreacion], [Vota_FechaCreacion], [Vota_UsuarioModifica], [Vota_FechaModifica], [MePS_Id], [Vota_Permitido]) VALUES (13, N'Karla', N'Gonzales', N'0501200504204', 0, N'0501', 1, 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL, 1, 0)
SET IDENTITY_INSERT [Gral].[tbVotantes] OFF
GO
INSERT [Vota].[tbAlcaldes] ([Alca_Imagen], [Muni_Codigo], [Part_Id], [Alca_UsuarioCreacion], [Alca_FechaCreacion], [Alca_UsuarioModifica], [Alca_FechaModifica], [Alca_Estado], [Alca_Id]) VALUES (N'https://votacionesblobstorage.blob.core.windows.net/main/Alcalde_3.jpg', N'0502', 5, 4, CAST(N'2024-04-08T08:10:36.753' AS DateTime), NULL, NULL, 1, 3)
INSERT [Vota].[tbAlcaldes] ([Alca_Imagen], [Muni_Codigo], [Part_Id], [Alca_UsuarioCreacion], [Alca_FechaCreacion], [Alca_UsuarioModifica], [Alca_FechaModifica], [Alca_Estado], [Alca_Id]) VALUES (N'https://votacionesblobstorage.blob.core.windows.net/main/Alcalde_6.webp', N'0501', 1, 4, CAST(N'2024-04-07T08:50:48.127' AS DateTime), NULL, NULL, 1, 6)
INSERT [Vota].[tbAlcaldes] ([Alca_Imagen], [Muni_Codigo], [Part_Id], [Alca_UsuarioCreacion], [Alca_FechaCreacion], [Alca_UsuarioModifica], [Alca_FechaModifica], [Alca_Estado], [Alca_Id]) VALUES (N'https://votacionesblobstorage.blob.core.windows.net/main/Alcalde_8.jpg', N'0501', 4, 4, CAST(N'2024-04-08T10:03:08.920' AS DateTime), 4, CAST(N'2024-04-10T09:56:41.683' AS DateTime), 1, 8)
GO
SET IDENTITY_INSERT [Vota].[tbEmpleadosPorMesaElectoral] ON 

INSERT [Vota].[tbEmpleadosPorMesaElectoral] ([EPME_Id], [MePS_Id], [Empl_Id]) VALUES (1, 1, 3)
SET IDENTITY_INSERT [Vota].[tbEmpleadosPorMesaElectoral] OFF
GO
SET IDENTITY_INSERT [Vota].[tbMesasPorSedes] ON 

INSERT [Vota].[tbMesasPorSedes] ([MePS_Id], [Mesa_Id], [Sede_Id]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [Vota].[tbMesasPorSedes] OFF
GO
SET IDENTITY_INSERT [Vota].[tbPartidos] ON 

INSERT [Vota].[tbPartidos] ([Part_Id], [Part_Descripcion], [Part_UsuarioCreacion], [Part_FechaCreacion], [Part_UsuarioModifica], [Part_FechaModifica], [Part_Estado], [Part_Imagen], [Part_Color]) VALUES (1, N'NacionalAAA', 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), 4, CAST(N'2024-04-10T10:10:29.683' AS DateTime), 1, N'https://votacionesblobstorage.blob.core.windows.net/main/Partido_.jpg', N'#00aaff')
INSERT [Vota].[tbPartidos] ([Part_Id], [Part_Descripcion], [Part_UsuarioCreacion], [Part_FechaCreacion], [Part_UsuarioModifica], [Part_FechaModifica], [Part_Estado], [Part_Imagen], [Part_Color]) VALUES (4, N'Libre', 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL, 1, N'https://votacionesblobstorage.blob.core.windows.net/main/Flag_of_Honduras.svg.png', N'#000000')
INSERT [Vota].[tbPartidos] ([Part_Id], [Part_Descripcion], [Part_UsuarioCreacion], [Part_FechaCreacion], [Part_UsuarioModifica], [Part_FechaModifica], [Part_Estado], [Part_Imagen], [Part_Color]) VALUES (5, N'Liberal', 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), 4, CAST(N'2024-04-10T10:11:02.133' AS DateTime), 1, N'https://votacionesblobstorage.blob.core.windows.net/main/Partido_.png', N'#6905ff')
INSERT [Vota].[tbPartidos] ([Part_Id], [Part_Descripcion], [Part_UsuarioCreacion], [Part_FechaCreacion], [Part_UsuarioModifica], [Part_FechaModifica], [Part_Estado], [Part_Imagen], [Part_Color]) VALUES (6, N'Partido Chino Comunista', 4, CAST(N'2024-04-10T08:27:02.200' AS DateTime), NULL, NULL, 1, N'https://votacionesblobstorage.blob.core.windows.net/main/Partido_.jpg', N'#ff2e2e')
SET IDENTITY_INSERT [Vota].[tbPartidos] OFF
GO
INSERT [Vota].[tbPresidentes] ([Pres_Id], [Pres_Imagen], [Part_Id], [Pres_UsuarioCreacion], [Pres_FechaCreacion], [Pres_UsuarioModifica], [Pres_FechaModifica], [Pres_Estado]) VALUES (12, N'https://votacionesblobstorage.blob.core.windows.net/main/Alcalde_6.webp', 1, 4, CAST(N'2024-02-02T00:00:00.000' AS DateTime), NULL, NULL, 1)
GO
SET IDENTITY_INSERT [Vota].[tbVotosPorMesas] ON 

INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (1, 1, 1, 0)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (2, 1, 1, 1)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (3, 1, 5, 1)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (4, 1, 1, 0)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (5, 1, 3, 0)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (6, 1, 3, 0)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (7, 1, 0, 0)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (8, 1, 0, 0)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (9, 1, 8, 0)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (10, 1, 0, 1)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (11, 1, 0, 1)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (12, 1, 12, 1)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (13, 1, 12, 1)
INSERT [Vota].[tbVotosPorMesas] ([VoMe_Id], [MePS_Id], [VoMe_CandidatoId], [VoMe_EsPresidente]) VALUES (14, 1, 6, 0)
SET IDENTITY_INSERT [Vota].[tbVotosPorMesas] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tbRoles_Rol_Descripcion]    Script Date: 10/4/2024 10:47:00 ******/
ALTER TABLE [Acce].[tbRoles] ADD  CONSTRAINT [UQ_tbRoles_Rol_Descripcion] UNIQUE NONCLUSTERED 
(
	[Rol_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbUsuari__9ED44AB40B10FC17]    Script Date: 10/4/2024 10:47:00 ******/
ALTER TABLE [Acce].[tbUsuarios] ADD  CONSTRAINT [UQ__tbUsuari__9ED44AB40B10FC17] UNIQUE NONCLUSTERED 
(
	[Usua_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tbCargos_Carg_Descripcion]    Script Date: 10/4/2024 10:47:00 ******/
ALTER TABLE [Gral].[tbCargos] ADD  CONSTRAINT [UQ_tbCargos_Carg_Descripcion] UNIQUE NONCLUSTERED 
(
	[Carg_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_TBDEPARTAMENTOS_Dept_Descripcion]    Script Date: 10/4/2024 10:47:00 ******/
ALTER TABLE [Gral].[tbDepartamentos] ADD  CONSTRAINT [UQ_TBDEPARTAMENTOS_Dept_Descripcion] UNIQUE NONCLUSTERED 
(
	[Dept_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [Acce].[tbPantallas] ADD  DEFAULT ((1)) FOR [Pant_Estado]
GO
ALTER TABLE [Acce].[tbRoles] ADD  DEFAULT ((1)) FOR [Rol_Estado]
GO
ALTER TABLE [Acce].[tbUsuarios] ADD  CONSTRAINT [DF__tbUsuario__Usua___5DCAEF64]  DEFAULT ((0)) FOR [Usua_Admin]
GO
ALTER TABLE [Acce].[tbUsuarios] ADD  CONSTRAINT [DF__tbUsuario__Usua___5EBF139D]  DEFAULT ((1)) FOR [Usua_Activo]
GO
ALTER TABLE [Gral].[tbCargos] ADD  DEFAULT ((1)) FOR [Carg_Estado]
GO
ALTER TABLE [Gral].[tbEmpleados] ADD  DEFAULT ((1)) FOR [Empl_Estado]
GO
ALTER TABLE [Gral].[tbMesas] ADD  DEFAULT ((1)) FOR [Mesa_Estado]
GO
ALTER TABLE [Gral].[tbSedes] ADD  DEFAULT ((1)) FOR [Sede_Estado]
GO
ALTER TABLE [Gral].[tbVotantes] ADD  DEFAULT ((0)) FOR [Vota_YaVoto]
GO
ALTER TABLE [Vota].[tbAlcaldes] ADD  DEFAULT ((1)) FOR [Alca_Estado]
GO
ALTER TABLE [Vota].[tbPartidos] ADD  DEFAULT ((1)) FOR [Part_Estado]
GO
ALTER TABLE [Vota].[tbPresidentes] ADD  CONSTRAINT [DF__tbPreside__Pres___160F4887]  DEFAULT ((1)) FOR [Pres_Estado]
GO
ALTER TABLE [Acce].[tbPantallas]  WITH CHECK ADD  CONSTRAINT [FK_tbPantallas_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Pant_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbPantallas] CHECK CONSTRAINT [FK_tbPantallas_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Acce].[tbPantallas]  WITH CHECK ADD  CONSTRAINT [FK_tbPantallas_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Pant_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbPantallas] CHECK CONSTRAINT [FK_tbPantallas_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Acce].[tbPantallasPorRoles]  WITH CHECK ADD  CONSTRAINT [Fk_tbPantallasPor_Roles_Id] FOREIGN KEY([Rol_Id])
REFERENCES [Acce].[tbRoles] ([Rol_Id])
GO
ALTER TABLE [Acce].[tbPantallasPorRoles] CHECK CONSTRAINT [Fk_tbPantallasPor_Roles_Id]
GO
ALTER TABLE [Acce].[tbPantallasPorRoles]  WITH CHECK ADD  CONSTRAINT [Fk_tbPantallasPorRoles_Pant_Id] FOREIGN KEY([Pant_Id])
REFERENCES [Acce].[tbPantallas] ([Pant_Id])
GO
ALTER TABLE [Acce].[tbPantallasPorRoles] CHECK CONSTRAINT [Fk_tbPantallasPorRoles_Pant_Id]
GO
ALTER TABLE [Acce].[tbRoles]  WITH CHECK ADD  CONSTRAINT [FK_tbRoles_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Rol_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbRoles] CHECK CONSTRAINT [FK_tbRoles_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Acce].[tbRoles]  WITH CHECK ADD  CONSTRAINT [FK_tbRoles_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Rol_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbRoles] CHECK CONSTRAINT [FK_tbRoles_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Acce].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuarios_tbEmpleados_Empl_Id] FOREIGN KEY([Empl_Id])
REFERENCES [Gral].[tbEmpleados] ([Empl_Id])
GO
ALTER TABLE [Acce].[tbUsuarios] CHECK CONSTRAINT [FK_tbUsuarios_tbEmpleados_Empl_Id]
GO
ALTER TABLE [Acce].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuarios_tbRoles_Rol_Id] FOREIGN KEY([Rol_Id])
REFERENCES [Acce].[tbRoles] ([Rol_Id])
GO
ALTER TABLE [Acce].[tbUsuarios] CHECK CONSTRAINT [FK_tbUsuarios_tbRoles_Rol_Id]
GO
ALTER TABLE [Acce].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuarios_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Usua_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbUsuarios] CHECK CONSTRAINT [FK_tbUsuarios_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Acce].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuarios_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Usua_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbUsuarios] CHECK CONSTRAINT [FK_tbUsuarios_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Gral].[tbCargos]  WITH CHECK ADD  CONSTRAINT [FK_tbCargos_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Carg_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbCargos] CHECK CONSTRAINT [FK_tbCargos_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Gral].[tbCargos]  WITH CHECK ADD  CONSTRAINT [FK_tbCargos_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Carg_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbCargos] CHECK CONSTRAINT [FK_tbCargos_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Gral].[tbDepartamentos]  WITH CHECK ADD  CONSTRAINT [FK_tbDepartamentos_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Dept_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbDepartamentos] CHECK CONSTRAINT [FK_tbDepartamentos_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Gral].[tbDepartamentos]  WITH CHECK ADD  CONSTRAINT [FK_tbDepartamentos_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Dept_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbDepartamentos] CHECK CONSTRAINT [FK_tbDepartamentos_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Gral].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_tbAlcaldes_tbVotantes_Empl_Id] FOREIGN KEY([Empl_Id])
REFERENCES [Gral].[tbVotantes] ([Vota_Id])
GO
ALTER TABLE [Gral].[tbEmpleados] CHECK CONSTRAINT [FK_tbAlcaldes_tbVotantes_Empl_Id]
GO
ALTER TABLE [Gral].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [Fk_tbEmpleados_Carg_Id] FOREIGN KEY([Carg_Id])
REFERENCES [Gral].[tbCargos] ([Carg_Id])
GO
ALTER TABLE [Gral].[tbEmpleados] CHECK CONSTRAINT [Fk_tbEmpleados_Carg_Id]
GO
ALTER TABLE [Gral].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [Fk_tbEmpleados_Part_Id] FOREIGN KEY([Part_Id])
REFERENCES [Vota].[tbPartidos] ([Part_Id])
GO
ALTER TABLE [Gral].[tbEmpleados] CHECK CONSTRAINT [Fk_tbEmpleados_Part_Id]
GO
ALTER TABLE [Gral].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_tbEmpleados_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Empl_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbEmpleados] CHECK CONSTRAINT [FK_tbEmpleados_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Gral].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_tbEmpleados_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Empl_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbEmpleados] CHECK CONSTRAINT [FK_tbEmpleados_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Gral].[tbEstadosCiviles]  WITH CHECK ADD  CONSTRAINT [FK_tbEstadosCiviles_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Esta_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbEstadosCiviles] CHECK CONSTRAINT [FK_tbEstadosCiviles_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Gral].[tbEstadosCiviles]  WITH CHECK ADD  CONSTRAINT [FK_tbEstadosCiviles_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Esta_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbEstadosCiviles] CHECK CONSTRAINT [FK_tbEstadosCiviles_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Gral].[tbMesas]  WITH CHECK ADD  CONSTRAINT [FK_tbMesas_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Mesa_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbMesas] CHECK CONSTRAINT [FK_tbMesas_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Gral].[tbMesas]  WITH CHECK ADD  CONSTRAINT [FK_tbMesas_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Mesa_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbMesas] CHECK CONSTRAINT [FK_tbMesas_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Gral].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [Fk_tbMunicipios_Dept_Codigo] FOREIGN KEY([Dept_Codigo])
REFERENCES [Gral].[tbDepartamentos] ([Dept_Codigo])
GO
ALTER TABLE [Gral].[tbMunicipios] CHECK CONSTRAINT [Fk_tbMunicipios_Dept_Codigo]
GO
ALTER TABLE [Gral].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [FK_tbMunicipios_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Muni_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbMunicipios] CHECK CONSTRAINT [FK_tbMunicipios_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Gral].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [FK_tbMunicipios_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Muni_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbMunicipios] CHECK CONSTRAINT [FK_tbMunicipios_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Gral].[tbSedes]  WITH CHECK ADD  CONSTRAINT [FK_tbSedes_tbMunicipios] FOREIGN KEY([Muni_Codigo])
REFERENCES [Gral].[tbMunicipios] ([Muni_Codigo])
GO
ALTER TABLE [Gral].[tbSedes] CHECK CONSTRAINT [FK_tbSedes_tbMunicipios]
GO
ALTER TABLE [Gral].[tbSedes]  WITH CHECK ADD  CONSTRAINT [FK_tbSedes_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Sede_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbSedes] CHECK CONSTRAINT [FK_tbSedes_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Gral].[tbSedes]  WITH CHECK ADD  CONSTRAINT [FK_tbSedes_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Sede_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbSedes] CHECK CONSTRAINT [FK_tbSedes_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Gral].[tbVotantes]  WITH CHECK ADD  CONSTRAINT [Fk_tbVotantes_Esta_Id] FOREIGN KEY([Esta_Id])
REFERENCES [Gral].[tbEstadosCiviles] ([Esta_Id])
GO
ALTER TABLE [Gral].[tbVotantes] CHECK CONSTRAINT [Fk_tbVotantes_Esta_Id]
GO
ALTER TABLE [Gral].[tbVotantes]  WITH CHECK ADD  CONSTRAINT [FK_tbVotantes_MePS_Id] FOREIGN KEY([MePS_Id])
REFERENCES [Vota].[tbMesasPorSedes] ([MePS_Id])
GO
ALTER TABLE [Gral].[tbVotantes] CHECK CONSTRAINT [FK_tbVotantes_MePS_Id]
GO
ALTER TABLE [Gral].[tbVotantes]  WITH CHECK ADD  CONSTRAINT [Fk_tbVotantes_Muni_Id] FOREIGN KEY([Muni_Codigo])
REFERENCES [Gral].[tbMunicipios] ([Muni_Codigo])
GO
ALTER TABLE [Gral].[tbVotantes] CHECK CONSTRAINT [Fk_tbVotantes_Muni_Id]
GO
ALTER TABLE [Gral].[tbVotantes]  WITH CHECK ADD  CONSTRAINT [FK_tbVotantes_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Vota_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbVotantes] CHECK CONSTRAINT [FK_tbVotantes_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Gral].[tbVotantes]  WITH CHECK ADD  CONSTRAINT [FK_tbVotantes_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Vota_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Gral].[tbVotantes] CHECK CONSTRAINT [FK_tbVotantes_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Vota].[tbAlcaldes]  WITH CHECK ADD  CONSTRAINT [Fk_tbAlcaldes_Muni_Id] FOREIGN KEY([Muni_Codigo])
REFERENCES [Gral].[tbMunicipios] ([Muni_Codigo])
GO
ALTER TABLE [Vota].[tbAlcaldes] CHECK CONSTRAINT [Fk_tbAlcaldes_Muni_Id]
GO
ALTER TABLE [Vota].[tbAlcaldes]  WITH CHECK ADD  CONSTRAINT [Fk_tbAlcaldes_Part_Id] FOREIGN KEY([Part_Id])
REFERENCES [Vota].[tbPartidos] ([Part_Id])
GO
ALTER TABLE [Vota].[tbAlcaldes] CHECK CONSTRAINT [Fk_tbAlcaldes_Part_Id]
GO
ALTER TABLE [Vota].[tbAlcaldes]  WITH CHECK ADD  CONSTRAINT [FK_tbAlcaldes_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Alca_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Vota].[tbAlcaldes] CHECK CONSTRAINT [FK_tbAlcaldes_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Vota].[tbAlcaldes]  WITH CHECK ADD  CONSTRAINT [FK_tbAlcaldes_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Alca_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Vota].[tbAlcaldes] CHECK CONSTRAINT [FK_tbAlcaldes_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Vota].[tbAlcaldes]  WITH CHECK ADD  CONSTRAINT [FK_tbAlcaldes_tbVotantes_Alca_Id] FOREIGN KEY([Alca_Id])
REFERENCES [Gral].[tbVotantes] ([Vota_Id])
GO
ALTER TABLE [Vota].[tbAlcaldes] CHECK CONSTRAINT [FK_tbAlcaldes_tbVotantes_Alca_Id]
GO
ALTER TABLE [Vota].[tbEmpleadosPorMesaElectoral]  WITH CHECK ADD  CONSTRAINT [FK_tbEmpleadosPorMesaElectoral_tbEmpleados] FOREIGN KEY([Empl_Id])
REFERENCES [Gral].[tbEmpleados] ([Empl_Id])
GO
ALTER TABLE [Vota].[tbEmpleadosPorMesaElectoral] CHECK CONSTRAINT [FK_tbEmpleadosPorMesaElectoral_tbEmpleados]
GO
ALTER TABLE [Vota].[tbEmpleadosPorMesaElectoral]  WITH CHECK ADD  CONSTRAINT [FK_tbEmpleadosPorMesaElectoral_tbMesasPorSedes] FOREIGN KEY([MePS_Id])
REFERENCES [Vota].[tbMesasPorSedes] ([MePS_Id])
GO
ALTER TABLE [Vota].[tbEmpleadosPorMesaElectoral] CHECK CONSTRAINT [FK_tbEmpleadosPorMesaElectoral_tbMesasPorSedes]
GO
ALTER TABLE [Vota].[tbPartidos]  WITH CHECK ADD  CONSTRAINT [FK_tbPartidos_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Part_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Vota].[tbPartidos] CHECK CONSTRAINT [FK_tbPartidos_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Vota].[tbPartidos]  WITH CHECK ADD  CONSTRAINT [FK_tbPartidos_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Part_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Vota].[tbPartidos] CHECK CONSTRAINT [FK_tbPartidos_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Vota].[tbPresidentes]  WITH CHECK ADD  CONSTRAINT [Fk_tbPartidos_Part_Id] FOREIGN KEY([Part_Id])
REFERENCES [Vota].[tbPartidos] ([Part_Id])
GO
ALTER TABLE [Vota].[tbPresidentes] CHECK CONSTRAINT [Fk_tbPartidos_Part_Id]
GO
ALTER TABLE [Vota].[tbPresidentes]  WITH CHECK ADD  CONSTRAINT [FK_tbPresidentes_tbUsuarios_Usua_UsuarioCreacion] FOREIGN KEY([Pres_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Vota].[tbPresidentes] CHECK CONSTRAINT [FK_tbPresidentes_tbUsuarios_Usua_UsuarioCreacion]
GO
ALTER TABLE [Vota].[tbPresidentes]  WITH CHECK ADD  CONSTRAINT [FK_tbPresidentes_tbUsuarios_Usua_UsuarioModifica] FOREIGN KEY([Pres_UsuarioModifica])
REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
ALTER TABLE [Vota].[tbPresidentes] CHECK CONSTRAINT [FK_tbPresidentes_tbUsuarios_Usua_UsuarioModifica]
GO
ALTER TABLE [Vota].[tbPresidentes]  WITH CHECK ADD  CONSTRAINT [Fk_tbVotantes_Pres_Id] FOREIGN KEY([Pres_Id])
REFERENCES [Gral].[tbVotantes] ([Vota_Id])
GO
ALTER TABLE [Vota].[tbPresidentes] CHECK CONSTRAINT [Fk_tbVotantes_Pres_Id]
GO
ALTER TABLE [Vota].[tbVotosPorMesas]  WITH CHECK ADD  CONSTRAINT [FK_tbVotosPorMesas_tbMesasPorSedes] FOREIGN KEY([MePS_Id])
REFERENCES [Vota].[tbMesasPorSedes] ([MePS_Id])
GO
ALTER TABLE [Vota].[tbVotosPorMesas] CHECK CONSTRAINT [FK_tbVotosPorMesas_tbMesasPorSedes]
GO
/****** Object:  StoredProcedure [Acce].[SP_Pantallas_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create         PROCEDURE [Acce].[SP_Pantallas_Mostrar]
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Acce.tbPantallas
	END TRY
	BEGIN CATCH
        SELECT 0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_PantallasPorRoles_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE       PROCEDURE [Acce].[SP_PantallasPorRoles_Eliminar]
(
	@Rol_Id int,
	@Pant_Id int
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Acce.tbPantallasPorRoles
			WHERE tbPantallasPorRoles.Rol_Id = @Rol_Id 
				AND tbPantallasPorRoles.Pant_Id = @Pant_Id 
		COMMIT TRANSACTION
		SELECT 1 AS Resultado
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_PantallasPorRoles_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE       PROCEDURE [Acce].[SP_PantallasPorRoles_Insertar]
(
	@Rol_Id INT, 
	@Pant_Id INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		INSERT INTO [Acce].[tbPantallasPorRoles] (
			[Rol_Id], 
			[Pant_Id]
		)
		VALUES(
			@Rol_Id,
			@Pant_Id
		)
		COMMIT TRANSACTION
		SELECT 1 AS Resultado;
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_PantallasPorRoles_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE         PROCEDURE [Acce].[SP_PantallasPorRoles_Mostrar]
AS
BEGIN
	BEGIN TRY
		SELECT 
			Paro_Id,
			Rol_Id,
			tbPantallasPorRoles.Pant_Id,
			tbPantallas.Pant_Descripcion,
			tbPantallas.Pant_Controlador
		FROM Acce.tbPantallasPorRoles INNER JOIN Acce.tbPantallas
			ON tbPantallasPorRoles.Pant_Id = tbPantallas.Pant_Id
	END TRY
	BEGIN CATCH
        SELECT 0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Roles_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE       PROCEDURE [Acce].[SP_Roles_Editar]
(
	@Rol_Id int,
	@Rol_Descripcion VARCHAR(50), 
	@Rol_UsuarioModifica INT, 
	@Rol_FechaModifica DATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		UPDATE [Acce].[tbRoles] 
		SET
			[Rol_Descripcion] = @Rol_Descripcion, 
			[Rol_UsuarioModifica] = @Rol_UsuarioModifica, 
			[Rol_FechaModifica] = @Rol_FechaModifica 
		WHERE tbRoles.Rol_Id = @Rol_Id
		COMMIT TRANSACTION
		SELECT 1 AS Resultado
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Roles_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE         PROCEDURE [Acce].[SP_Roles_Eliminar]
(
	@Rol_Id INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DELETE FROM [Acce].[tbRoles] 
		WHERE tbRoles.Rol_Id = @Rol_Id
		COMMIT TRANSACTION
		SELECT 1 AS Resultado
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Roles_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE         PROCEDURE [Acce].[SP_Roles_Insertar]
(
	@Rol_Descripcion VARCHAR(50), 
	@Rol_UsuarioCreacion INT, 
	@Rol_FechaCreacion DATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		INSERT INTO [Acce].[tbRoles] (
			[Rol_Descripcion], 
			[Rol_UsuarioCreacion], 
			[Rol_FechaCreacion]		
		)
		VALUES(
			@Rol_Descripcion, 
			@Rol_UsuarioCreacion, 
			@Rol_FechaCreacion 		
		)
		COMMIT TRANSACTION
		SELECT 1 AS Resultado
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Roles_Listar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE       PROCEDURE [Acce].[SP_Roles_Listar]
(
	@Rol_Id INT
)
AS
BEGIN
	BEGIN TRY
		SELECT * 
		FROM Acce.tbRoles 
		WHERE tbRoles.Rol_Id = @Rol_Id
	END TRY
	BEGIN CATCH
        SELECT 0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Roles_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create         PROCEDURE [Acce].[SP_Roles_Llenar]
(
	@Rol_Id int
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Acce.tbRoles
		where tbRoles.Rol_Id = @Rol_Id
	END TRY
	BEGIN CATCH
        SELECT 0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Roles_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE       PROCEDURE [Acce].[SP_Roles_Mostrar]
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Acce.tbRoles
	END TRY
	BEGIN CATCH
        SELECT 0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_ActivarDesactivar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE         PROCEDURE [Acce].[SP_Usuarios_ActivarDesactivar]
(
	@Usua_Id int
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		UPDATE [Acce].[tbUsuarios] 
		SET Usua_Activo = (SELECT CASE WHEN tbUsuarios.Usua_Activo = 1 THEN 0 ELSE 1 END FROM Acce.tbUsuarios)
		WHERE tbUsuarios.Usua_Id = @Usua_Id
		COMMIT TRANSACTION
		SELECT 1 AS RESULTADO
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROCEDURE [Acce].[SP_Usuarios_Editar]
(
	@Usua_Id int, 
	@Usua_Usuario varchar(50), 
	@Usua_Contra varchar(max), 
	@Usua_Admin bit, 
	@Empl_Id int, 
	@Rol_Id int, 
	@Usua_UsuarioModifica int, 
	@Usua_FechaModifica datetime, 
	@Usua_Imagen varchar(max)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		UPDATE [Acce].[tbUsuarios]
		SET 
			Usua_Usuario = @Usua_Usuario, 
			Usua_Admin = @Usua_Admin, 
			Empl_Id = @Empl_Id, 
			Rol_Id = @Rol_Id, 
			Usua_UsuarioModifica = @Usua_UsuarioModifica, 
			Usua_FechaModifica = @Usua_FechaModifica, 
			Usua_Imagen	= @Usua_Imagen
		where tbUsuarios.Usua_Id = @Usua_Id
		COMMIT TRANSACTION
		SELECT 1 AS Resultado;
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROCEDURE [Acce].[SP_Usuarios_Eliminar]
(
	@Rol_Id int, 
	@Pant_Id int 
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		delete from [Acce].[tbPantallasPorRoles]
		where Rol_Id = @Rol_Id AND Pant_Id = @Pant_Id
		COMMIT TRANSACTION
		SELECT 1 AS RESULTADO;
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_IniciarSesion]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Acce].[SP_Usuarios_IniciarSesion]
(
	@Usua_Usuario varchar(50), 
	@Usua_Contra nvarchar(max) 
)
AS
BEGIN
	BEGIN TRY
		DECLARE @ContraHasheada NVARCHAR(MAX) = CONVERT(NVARCHAR (MAX), HASHBYTES ('SHA2_512', @Usua_Contra), 2);
		SELECT
			tbUsuarios.Usua_Id,
			tbUsuarios.Usua_Usuario,
			tbUsuarios.Usua_Admin,
			tbUsuarios.Usua_Imagen,
			tbUsuarios.Empl_Id,
			tbUsuarios.Usua_Activo,
			CONCAT(tbVotantes.Vota_Nombre, ' ', tbVotantes.Vota_Apellidos) AS Vota_NombreCompleto,
			tbVotantes.Muni_Codigo,
			tbEmpleados.Carg_Id,
			tbCargos.Carg_Descripcion,
			tbUsuarios.Rol_Id
		FROM [Acce].[tbUsuarios] INNER JOIN Gral.tbEmpleados
			ON tbUsuarios.Empl_Id = tbEmpleados.Empl_Id INNER JOIN Gral.tbVotantes
			ON tbEmpleados.Empl_Id = tbVotantes.Vota_Id INNER JOIN Gral.tbCargos
			ON tbEmpleados.Carg_Id = tbCargos.Carg_Id INNER JOIN Acce.tbRoles
			ON tbUsuarios.Rol_Id = tbRoles.Rol_Id
		WHERE tbUsuarios.Usua_Usuario = @Usua_Usuario AND 
			tbUsuarios.Usua_Contra = @ContraHasheada AND
			tbUsuarios.Usua_Activo = 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROCEDURE [Acce].[SP_Usuarios_Insertar]
(
	@Usua_Usuario varchar(50), 
	@Usua_Contra nvarchar(max), 
	@Usua_Admin bit, 
	@Empl_Id int, 
	@Rol_Id int, 
	@Usua_UsuarioCreacion int, 
	@Usua_FechaCreacion datetime, 
	@Usua_Imagen varchar(max)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DECLARE @ContraHasheada NVARCHAR(MAX) = CONVERT(NVARCHAR (MAX), HASHBYTES ('SHA2_512', @Usua_Contra), 2);
		insert into [Acce].[tbUsuarios](
			Usua_Usuario, 
			Usua_Contra, 
			Usua_Admin, 
			Empl_Id, 
			Rol_Id, 
			Usua_UsuarioCreacion, 
			Usua_FechaCreacion, 
			Usua_Imagen
		)
		VALUES(
			@Usua_Usuario, 
			@ContraHasheada, 
			@Usua_Admin, 
			@Empl_Id, 
			@Rol_Id, 
			@Usua_UsuarioCreacion, 
			@Usua_FechaCreacion, 
			@Usua_Imagen)
		COMMIT TRANSACTION
		SELECT 1 AS Resultado;
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create         PROCEDURE [Acce].[SP_Usuarios_Llenar]
(
	@Usua_Id int
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Acce.tbUsuarios 
		where tbUsuarios.Usua_Id = @Usua_Id
	END TRY
	BEGIN CATCH
        SELECT 0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_LlenarByEmpl]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create           PROCEDURE [Acce].[SP_Usuarios_LlenarByEmpl]
(
	@Empl_Id int
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Acce.tbUsuarios 
		where tbUsuarios.Empl_Id = @Empl_Id
	END TRY
	BEGIN CATCH
        SELECT 0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create         PROCEDURE [Acce].[SP_Usuarios_Mostrar]
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Acce.tbUsuarios
	END TRY
	BEGIN CATCH
        SELECT 0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Acce].[SP_Usuarios_ReestablecerContrasena]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Acce].[SP_Usuarios_ReestablecerContrasena]
	@Usua_Id INT,
	@Usua_Contra NVARCHAR(MAX),
	@Usua_UsuarioModifica INT,
	@Usua_FechaModifica DATETIME
AS
BEGIN
	BEGIN TRY
        DECLARE @ContraHasheada NVARCHAR(MAX) = CONVERT(NVARCHAR (MAX), HASHBYTES ('SHA2_512', @Usua_Contra), 2);		

		UPDATE Acce.tbUsuarios
		SET Usua_Contra = @ContraHasheada,
			Usua_UsuarioModifica = @Usua_UsuarioModifica,
			Usua_FechaModifica = @Usua_FechaModifica
		WHERE Usua_Id = @Usua_Id

		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Cargos_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Cargos_Editar]
    @Carg_Id INT,
    @Carg_Descripcion VARCHAR(50),
    @Carg_UsuarioModifica INT,
    @Carg_FechaModifica DATETIME
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        UPDATE Gral.tbCargos
        SET Carg_Descripcion = @Carg_Descripcion,
            Carg_UsuarioModifica = @Carg_UsuarioModifica,
            Carg_FechaModifica = @Carg_FechaModifica
        WHERE Carg_Id = @Carg_Id;
		COMMIT TRANSACTION
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Cargos_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Cargos_Eliminar]
    @Carg_Id INT
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        DELETE FROM Gral.tbCargos
        WHERE Carg_Id = @Carg_Id;
        COMMIT TRANSACTION
		SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
		IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Cargos_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Cargos_Insertar]
    @Carg_Descripcion VARCHAR(50),
    @Carg_UsuarioCreacion INT,
    @Carg_FechaCreacion DATETIME
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        INSERT INTO Gral.tbCargos (Carg_Descripcion, Carg_UsuarioCreacion, Carg_FechaCreacion, Carg_Estado)
        VALUES (@Carg_Descripcion, @Carg_UsuarioCreacion, @Carg_FechaCreacion, 1); -- Se establece el estado como activo (1)
        COMMIT TRANSACTION
		SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
		IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Cargos_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Cargos_Llenar]
(
	@Carg_Id int
)
AS
BEGIN
    BEGIN TRY
        SELECT *
        FROM Gral.tbCargos
		where tbCargos.Carg_Id = @Carg_Id
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Cargos_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Cargos_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT *
        FROM Gral.tbCargos
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Departamentos_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Gral].[SP_Departamentos_Editar]
    @Dept_Codigo VARCHAR(2),
    @Dept_Descripcion VARCHAR(50),
    @Dept_UsuarioModifica INT,
    @Dept_FechaModifica DATETIME
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        UPDATE Gral.tbDepartamentos
        SET Dept_Descripcion = @Dept_Descripcion,
            Dept_UsuarioModifica = @Dept_UsuarioModifica,
            Dept_FechaModifica = @Dept_FechaModifica
        WHERE Dept_Codigo = @Dept_Codigo;
        SELECT 1 AS Resultado;
		COMMIT
    END TRY
    BEGIN CATCH
		ROLLBACK;
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Departamentos_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Gral].[SP_Departamentos_Eliminar]
    @Dept_Codigo VARCHAR(2)
AS
BEGIN
    BEGIN TRY
        DELETE FROM Gral.tbDepartamentos
        WHERE Dept_Codigo = @Dept_Codigo;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Departamentos_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Gral].[SP_Departamentos_Insertar]
    @Dept_Codigo VARCHAR(2),
    @Dept_Descripcion VARCHAR(50),
    @Dept_UsuarioCreacion INT,
    @Dept_FechaCreacion DATETIME
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        INSERT INTO Gral.tbDepartamentos (Dept_Codigo, Dept_Descripcion, Dept_UsuarioCreacion, Dept_FechaCreacion)
        VALUES (@Dept_Codigo, @Dept_Descripcion, @Dept_UsuarioCreacion, @Dept_FechaCreacion);
        SELECT 1 AS Resultado;
		COMMIT
    END TRY
    BEGIN CATCH
		ROLLBACK
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Departamentos_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Departamentos_Llenar]
(
	@Dept_Codigo VARCHAR(2)
)
AS 
BEGIN
    BEGIN TRY
        SELECT *
        FROM Gral.tbDepartamentos
		WHERE tbDepartamentos.Dept_Codigo = @Dept_Codigo
    END TRY
    BEGIN CATCH 
        SELECT 0 ;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Departamentos_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Departamentos_Mostrar]
AS 
BEGIN
    BEGIN TRY
        SELECT 
            Dept_Codigo,
            Dept_Descripcion
        FROM Gral.tbDepartamentos 
    END TRY
    BEGIN CATCH 
        SELECT 0 ;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Empleados_ActivarDesactivar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create           PROCEDURE [Gral].[SP_Empleados_ActivarDesactivar]
(
	@Empl_Id int
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		UPDATE [Gral].[tbEmpleados] 
		SET Empl_Estado = (SELECT CASE WHEN tbEmpleados.Empl_Estado = 1 THEN 0 ELSE 1 END FROM Gral.tbEmpleados)
		WHERE tbEmpleados.Empl_Id = @Empl_Id
		COMMIT TRANSACTION
		SELECT 1 AS RESULTADO
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Empleados_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Empleados_Editar]
    @Empl_Id INT,
    @Empl_UsuarioModifica INT,
    @Empl_FechaModifica DATETIME,
    @Part_Id INT,
    @Carg_Id INT
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        UPDATE Gral.tbEmpleados
        SET Empl_UsuarioModifica = @Empl_UsuarioModifica,
            Empl_FechaModifica = @Empl_FechaModifica,
            Part_Id = @Part_Id,
            Carg_Id = @Carg_Id
        WHERE Empl_Id = @Empl_Id;
		COMMIT TRANSACTION
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
		IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Empleados_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Gral].[SP_Empleados_Eliminar]
    @Empl_Id INT
AS
BEGIN
    BEGIN TRY
        UPDATE Gral.tbEmpleados
        SET Empl_Estado = 0 
        WHERE Empl_Id = @Empl_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Empleados_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Empleados_Insertar]
    @Empl_UsuarioCreacion INT,
    @Empl_FechaCreacion DATETIME,
    @Part_Id INT,
    @Carg_Id INT
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        INSERT INTO Gral.tbEmpleados (Empl_UsuarioCreacion, Empl_FechaCreacion, Part_Id, Carg_Id)
        VALUES (@Empl_UsuarioCreacion, @Empl_FechaCreacion, @Part_Id, @Carg_Id);
        COMMIT TRANSACTION
		SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Empleados_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Empleados_Llenar]
(
	@Empl_Id int
)
AS
BEGIN
    BEGIN TRY
        SELECT 
			Empl_Id,
			CONCAT(tbVotantes.Vota_Nombre, ' ', tbVotantes.Vota_Apellidos) AS Vota_NombreCompleto, 
			Part_Id,
			Carg_Id,
			Empl_Estado
        FROM Gral.tbEmpleados INNER JOIN Gral.tbVotantes
			ON tbEmpleados.Empl_Id = tbVotantes.Vota_Id
        WHERE Empl_Estado = 1 AND Empl_Id = @Empl_Id;
        
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Empleados_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Empleados_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT
            Empl_Id,
            Part_Id,
            Carg_Id
        FROM Gral.tbEmpleados
        WHERE Empl_Estado = 1;
        
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_EstadosCiviles_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_EstadosCiviles_Editar]
(
    @Esta_Id INT,
    @Esta_Descripcion VARCHAR(50), 
    @Esta_UsuarioModifica INT, 
    @Esta_FechaModifica DATETIME
)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        UPDATE [Gral].[tbEstadosCiviles] 
        SET
            [Esta_Descripcion] = @Esta_Descripcion, 
            [Esta_UsuarioModifica] = @Esta_UsuarioModifica, 
            [Esta_FechaModifica] = @Esta_FechaModifica 
        WHERE [tbEstadosCiviles].[Esta_Id] = @Esta_Id
        COMMIT TRANSACTION
        SELECT 1 AS RESULTADO
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_EstadosCiviles_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create         PROCEDURE [Gral].[SP_EstadosCiviles_Eliminar]
(
	@Esta_Id INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DELETE FROM [Gral].[tbEstadosCiviles]
		WHERE tbEstadosCiviles.Esta_Id = @Esta_Id
		COMMIT TRANSACTION
		SELECT 1 AS RESULTADO
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
	END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_EstadosCiviles_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_EstadosCiviles_Insertar]
(
    @Esta_Descripcion VARCHAR(50), 
    @Esta_UsuarioCreacion INT, 
    @Esta_FechaCreacion DATETIME
)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        INSERT INTO [Gral].[tbEstadosCiviles] (
            [Esta_Descripcion], 
            [Esta_UsuarioCreacion], 
            [Esta_FechaCreacion] 
        )
        VALUES(
            @Esta_Descripcion,
            @Esta_UsuarioCreacion,
            @Esta_FechaCreacion
        )
        COMMIT TRANSACTION
        SELECT 1 AS RESULTADO
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_EstadosCiviles_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [Gral].[SP_EstadosCiviles_Llenar]
(
	@Esta_Id int
)
AS
BEGIN
    BEGIN TRY
        SELECT *
        FROM Gral.tbEstadosCiviles
		where tbEstadosCiviles.Esta_Id = @Esta_Id
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_EstadosCiviles_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [Gral].[SP_EstadosCiviles_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT *
        FROM Gral.tbEstadosCiviles
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_MarcarVotanteComoYaVoto]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_MarcarVotanteComoYaVoto]
(
    @Vota_DNI VARCHAR(50)
)
AS
BEGIN
    BEGIN TRY
        UPDATE Gral.tbVotantes
        SET Vota_YaVoto = 1
        WHERE Vota_DNI = @Vota_DNI;

 
        SELECT 1 AS Resultado; 
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado; 
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Mesas_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Mesas_Editar]
(
    @Mesa_Id INT,
	@Mesa_Numero INT,
    @Mesa_UsuarioModifica INT, 
    @Mesa_FechaModifica DATETIME
)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        UPDATE [Gral].[tbMesas] 
        SET
			[Mesa_Numero] = @Mesa_Numero,
            [Mesa_UsuarioModifica] = @Mesa_UsuarioModifica, 
            [Mesa_FechaModifica] = @Mesa_FechaModifica 
        WHERE [tbMesas].[Mesa_Id] = @Mesa_Id
        COMMIT TRANSACTION
        SELECT 1 AS RESULTADO
    END TRY
    BEGIN CATCH
		IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Mesas_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create       PROCEDURE [Gral].[SP_Mesas_Eliminar]
(
    @Mesa_Id INT
)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        delete from [Gral].[tbMesas] 
        WHERE [tbMesas].[Mesa_Id] = @Mesa_Id
        COMMIT TRANSACTION
        SELECT 1 AS ResultCode
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Mesas_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Mesas_Insertar]
(
	@Mesa_Numero INT,
    @Mesa_UsuarioCreacion INT, 
    @Mesa_FechaCreacion DATETIME
)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        INSERT INTO [Gral].[tbMesas] (
			[Mesa_Numero],
            [Mesa_UsuarioCreacion], 
            [Mesa_FechaCreacion] 
        )
        VALUES(
			@Mesa_Numero,
            @Mesa_UsuarioCreacion,
            @Mesa_FechaCreacion
        )
        COMMIT TRANSACTION
        SELECT 1 AS RESULTADO
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Mesas_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create       PROCEDURE [Gral].[SP_Mesas_Llenar]
(
	@Mesa_Id int
)
AS
BEGIN
    BEGIN TRY
        SELECT *
		FROM Gral.tbMesas 
		where tbMesas.Mesa_Id = @Mesa_Id
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Mesas_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create       PROCEDURE [Gral].[SP_Mesas_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT *
		FROM Gral.tbMesas
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Municipios_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Municipios_Editar]
    @Muni_Codigo VARCHAR(4),
    @Muni_Descripcion VARCHAR(50),
    --@Dept_Codigo VARCHAR(2),
    @Muni_UsuarioModifica INT,
    @Muni_FechaModifica DATETIME
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        UPDATE Gral.tbMunicipios
        SET Muni_Descripcion = @Muni_Descripcion,
            --Dept_Codigo = @Dept_Codigo,
            Muni_UsuarioModifica = @Muni_UsuarioModifica,
            Muni_FechaModifica = @Muni_FechaModifica
        WHERE Muni_Codigo = @Muni_Codigo;
        COMMIT TRANSACTION
		SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
		IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Municipios_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Municipios_Eliminar]
    @Muni_Codigo VARCHAR(4)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        DELETE FROM Gral.tbMunicipios
        WHERE Muni_Codigo = @Muni_Codigo;
		COMMIT TRANSACTION
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Municipios_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Municipios_Insertar]
    @Muni_Codigo VARCHAR(4),
    @Muni_Descripcion VARCHAR(50),
    @Dept_Codigo VARCHAR(2),
    @Muni_UsuarioCreacion INT,
    @Muni_FechaCreacion DATETIME
AS
BEGIN
    BEGIN TRY
		begin transaction
        INSERT INTO Gral.tbMunicipios (Muni_Codigo, Muni_Descripcion, Dept_Codigo, Muni_UsuarioCreacion, Muni_FechaCreacion)
        VALUES (@Muni_Codigo, @Muni_Descripcion, @Dept_Codigo, @Muni_UsuarioCreacion, @Muni_FechaCreacion);
        commit transaction
		SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Municipios_Listar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Municipios_Listar]
(
	@Dept_Codigo varchar(2)
)
AS 
BEGIN
    BEGIN TRY
        SELECT *
        FROM Gral.tbMunicipios
		where tbMunicipios.Dept_Codigo = @Dept_Codigo
    END TRY
    BEGIN CATCH 
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Municipios_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create     PROCEDURE [Gral].[SP_Municipios_Llenar]
(
	@Muni_Codigo varchar(4)
)
AS 
BEGIN
    BEGIN TRY
        SELECT *
        FROM Gral.tbMunicipios
		where tbMunicipios.Muni_Codigo = @Muni_Codigo
    END TRY
    BEGIN CATCH 
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Municipios_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Municipios_Mostrar]
AS 
BEGIN
    BEGIN TRY
        SELECT 
            Muni_Codigo,
            Muni_Descripcion,
            Dept_Codigo
 
        FROM Gral.tbMunicipios


        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH 
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Sedes_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Sedes_Editar]
(
    @Sede_Id INT,
    @Sede_Descripcion VARCHAR(50),
    @Muni_Codigo INT,
    @Sede_UsuarioModifica INT, 
    @Sede_FechaModifica DATETIME
)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        UPDATE [Gral].[tbSedes] 
        SET
            [Sede_Descripcion] = @Sede_Descripcion,
            [Muni_Codigo] = @Muni_Codigo,
            [Sede_UsuarioModifica] = @Sede_UsuarioModifica, 
            [Sede_FechaModifica] = @Sede_FechaModifica 
        WHERE [tbSedes].[Sede_Id] = @Sede_Id
        COMMIT TRANSACTION
        SELECT 1 AS ResultCode
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Sedes_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create     PROCEDURE [Gral].[SP_Sedes_Eliminar]
(
    @Sede_Id INT
)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        delete from [Gral].[tbSedes] 
        WHERE [tbSedes].[Sede_Id] = @Sede_Id
        COMMIT TRANSACTION
        SELECT 1 AS ResultCode
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Sedes_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Sedes_Insertar]
(
    @Sede_Descripcion VARCHAR(50),
    @Muni_Codigo INT,
    @Sede_UsuarioCreacion INT,
    @Sede_FechaCreacion DATETIME
)
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
        INSERT INTO [Gral].[tbSedes] (
            [Sede_Descripcion],
            [Muni_Codigo],
            [Sede_UsuarioCreacion],
            [Sede_FechaCreacion]
        )
        VALUES(
            @Sede_Descripcion,
            @Muni_Codigo,
            @Sede_UsuarioCreacion,
            @Sede_FechaCreacion
        )
        COMMIT TRANSACTION
        SELECT 1 AS RESULTADO
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Sedes_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROCEDURE [Gral].[SP_Sedes_Llenar]
(
	@Sede_Id int
)
AS
BEGIN
    BEGIN TRY
        SELECT *
		FROM Gral.tbSedes
		where tbSedes.Sede_Id = @Sede_Id
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Sedes_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROCEDURE [Gral].[SP_Sedes_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT *
		FROM Gral.tbSedes
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Gral].[SP_Votantes_BuscarPorDNI]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Votantes_BuscarPorDNI]
    @Vota_DNI VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @YaVoto BIT;

    SELECT @YaVoto = Vota_YaVoto
    FROM [Gral].[tbVotantes]
    WHERE Vota_DNI = @Vota_DNI;

    IF @YaVoto IS NOT NULL
        RETURN 1;
    ELSE
        RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Votantes_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Gral].[SP_Votantes_Editar]
    @Vota_Id INT,
    @Vota_Nombre VARCHAR(50),
    @Vota_Apellidos VARCHAR(50),
    @Vota_DNI VARCHAR(50),
    @Vota_YaVoto BIT,
    @Muni_Codigo VARCHAR(4),
    @Esta_Id INT,
    @MePS_Id INT,
    @Vota_UsuarioModifica INT,
    @Vota_FechaModifica DATETIME
AS
BEGIN
    BEGIN TRY
        UPDATE Gral.tbVotantes
        SET Vota_Nombre = @Vota_Nombre,
            Vota_Apellidos = @Vota_Apellidos,
            Vota_DNI = @Vota_DNI,
            Vota_YaVoto = @Vota_YaVoto,
            Muni_Codigo = @Muni_Codigo,
            Esta_Id = @Esta_Id,
            MePS_Id = @MePS_Id,
            Vota_UsuarioModifica = @Vota_UsuarioModifica,
            Vota_FechaModifica = @Vota_FechaModifica
        WHERE Vota_Id = @Vota_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Votantes_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Gral].[SP_Votantes_Eliminar]
    @Vota_Id INT
AS
BEGIN
    BEGIN TRY
        DELETE FROM Gral.tbVotantes
        WHERE Vota_Id = @Vota_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Votantes_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Gral].[SP_Votantes_Insertar]
    @Vota_Nombre VARCHAR(50),
    @Vota_Apellidos VARCHAR(50),
    @Vota_DNI VARCHAR(50),
    @Vota_YaVoto BIT,
    @Muni_Codigo VARCHAR(4),
    @Esta_Id INT,
    @MePS_Id INT,
    @Vota_UsuarioCreacion INT,
    @Vota_FechaCreacion DATETIME
AS
BEGIN
    BEGIN TRY
        INSERT INTO Gral.tbVotantes (Vota_Nombre, Vota_Apellidos, Vota_DNI, Vota_YaVoto, Muni_Codigo, Esta_Id, MePS_Id, Vota_UsuarioCreacion, Vota_FechaCreacion)
        VALUES (@Vota_Nombre, @Vota_Apellidos, @Vota_DNI, @Vota_YaVoto, @Muni_Codigo, @Esta_Id, @MePS_Id, @Vota_UsuarioCreacion, @Vota_FechaCreacion);
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Votantes_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[SP_Votantes_Llenar]
(
	@Vota_DNI VARCHAR(50)
)
AS
BEGIN
    BEGIN TRY
        SELECT
            Vota_Id,
            Vota_Nombre,
            Vota_Apellidos,
            Vota_DNI,
            Vota_YaVoto,
			Vota_Permitido,
            vot.Muni_Codigo,
			mun.Muni_Descripcion,
            vot.Esta_Id,
			est.Esta_Descripcion,
            MePS_Id
        FROM Gral.tbVotantes as vot inner join Gral.tbEstadosCiviles as est
		on est.Esta_Id = vot.Esta_Id inner join Gral.tbMunicipios as mun
		on mun.Muni_Codigo = vot.Muni_Codigo
        WHERE Vota_DNI = @Vota_DNI;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Votantes_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Gral].[SP_Votantes_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT
            Vota_Id,
            Vota_Nombre,
            Vota_Apellidos,
            Vota_DNI,
            Vota_YaVoto,
            vot.Muni_Codigo,
			mun.Muni_Descripcion,
            vot.Esta_Id,
			est.Esta_Descripcion,
            MePS_Id
        FROM Gral.tbVotantes as vot inner join Gral.tbEstadosCiviles as est
		on est.Esta_Id = vot.Esta_Id inner join Gral.tbMunicipios as mun
		on mun.Muni_Codigo = vot.Muni_Codigo
        WHERE Vota_YaVoto = 1;
        
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[SP_Votantes_MostrarCandidatos]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [Gral].[SP_Votantes_MostrarCandidatos]
AS
BEGIN
    BEGIN TRY
        SELECT
            Vota_Id,
            Vota_Nombre,
            Vota_Apellidos,
            Vota_DNI,
            Vota_YaVoto,
            vot.Muni_Codigo,
			mun.Muni_Descripcion,
            vot.Esta_Id,
			est.Esta_Descripcion,
            MePS_Id
        FROM Gral.tbVotantes as vot inner join Gral.tbEstadosCiviles as est
		on est.Esta_Id = vot.Esta_Id inner join Gral.tbMunicipios as mun
		on mun.Muni_Codigo = vot.Muni_Codigo
    
        

    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Alca_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Vota].[SP_Alca_Editar]
    @Alca_Id INT,
    @Alca_Imagen VARCHAR(MAX),
    @Muni_Codigo VARCHAR(4),
    @Part_Id INT,
    @Alca_UsuarioModifica INT,
    @Alca_FechaModifica DATETIME

AS
BEGIN
    BEGIN TRY
        UPDATE Vota.tbAlcaldes
        SET Alca_Imagen = @Alca_Imagen,
            Muni_Codigo = @Muni_Codigo,
            Part_Id = @Part_Id,
            Alca_UsuarioModifica = @Alca_UsuarioModifica,
            Alca_FechaModifica = @Alca_FechaModifica
    
        WHERE Alca_Id = @Alca_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Alca_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Vota].[SP_Alca_Eliminar]
    @Alca_Id INT
AS
BEGIN
    BEGIN TRY
        UPDATE Vota.tbAlcaldes
        SET Alca_Estado = 0 
        WHERE Alca_Id = @Alca_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Alca_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Vota].[SP_Alca_Insertar]
    @Alca_Imagen VARCHAR(MAX),
    @Muni_Codigo VARCHAR(4),
    @Part_Id INT,
    @Alca_UsuarioCreacion INT,
    @Alca_FechaCreacion DATETIME,
    @Alca_Id INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
		DECLARE @Alca_Estado int = (SELECT Alca_Estado FROM Vota.tbAlcaldes WHERE tbAlcaldes.Alca_Id = @Alca_Id)

		IF @Alca_Estado IS NULL
		BEGIN
			INSERT INTO Vota.tbAlcaldes (Alca_Imagen, Muni_Codigo, Part_Id, Alca_UsuarioCreacion, Alca_FechaCreacion, Alca_Id)
			VALUES (@Alca_Imagen, @Muni_Codigo, @Part_Id, @Alca_UsuarioCreacion, @Alca_FechaCreacion, @Alca_Id);
			SELECT 1 AS Resultado;
		END
		ELSE IF @Alca_Estado = 0 BEGIN
			UPDATE Vota.tbAlcaldes
			SET Alca_Imagen = @Alca_Imagen,
				Muni_Codigo = @Muni_Codigo,
				Part_Id = @Part_Id,
				Alca_UsuarioCreacion = @Alca_UsuarioCreacion,
				Alca_FechaCreacion = @Alca_FechaCreacion,
				Alca_Estado = 1
			WHERE Alca_Id = @Alca_Id;
			SELECT 1 AS Resultado;
		END 
		ELSE BEGIN
			SELECT 0 AS Resultado
		END

        
        COMMIT TRANSACTION; 
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            0 AS Resultado; 
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Alcaldes_Listar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Vota].[SP_Alcaldes_Listar]
(
	@Alca_Id int
)
AS
BEGIN
    BEGIN TRY
        SELECT
            Alca_Id,
            Alca_Imagen,
            tbAlcaldes.Muni_Codigo,
            tbMunicipios.Dept_Codigo,
            Part_Id,
            Alca_UsuarioCreacion,
            Alca_FechaCreacion,
            Alca_UsuarioModifica,
            Alca_FechaModifica,
            Alca_Estado,
			tbVotantes.Vota_DNI,
			CONCAT(tbVotantes.Vota_Nombre, ' ', tbVotantes.Vota_Apellidos) AS Vota_NombreCompleto
        FROM Vota.tbAlcaldes INNER JOIN Gral.tbVotantes
			ON tbVotantes.Vota_Id = tbAlcaldes.Alca_Id INNER JOIN Gral.tbMunicipios
			ON tbAlcaldes.Muni_Codigo = tbMunicipios.Muni_Codigo
        WHERE Alca_Id = @Alca_Id;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Alcaldes_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Vota].[SP_Alcaldes_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT
            Alca_Id,
            Alca_Imagen,
            tbAlcaldes.Muni_Codigo,
            tbMunicipios.Dept_Codigo,
            Part_Id,
            Alca_UsuarioCreacion,
            Alca_FechaCreacion,
            Alca_UsuarioModifica,
            Alca_FechaModifica,
            Alca_Estado,
			tbVotantes.Vota_DNI,
			CONCAT(tbVotantes.Vota_Nombre, ' ', tbVotantes.Vota_Apellidos) AS Vota_NombreCompleto
        FROM Vota.tbAlcaldes INNER JOIN Gral.tbVotantes
			ON tbVotantes.Vota_Id = tbAlcaldes.Alca_Id INNER JOIN Gral.tbMunicipios
			ON tbAlcaldes.Muni_Codigo = tbMunicipios.Muni_Codigo
        WHERE Alca_Estado = 1;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Partidos_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Vota].[SP_Partidos_Editar]
(
    @Part_Id INT,
    @Part_Descripcion VARCHAR(50),
    @Part_Color VARCHAR(50),
    @Part_UsuarioModifica INT, 
    @Part_FechaModifica DATETIME,
    @Part_Imagen VARCHAR(MAX)
)
AS
BEGIN
    BEGIN TRY
        UPDATE [Vota].[tbPartidos] 
        SET
            [Part_Descripcion] = @Part_Descripcion,
			Part_Color = @Part_Color,
            [Part_UsuarioModifica] = @Part_UsuarioModifica, 
            [Part_FechaModifica] = @Part_FechaModifica,
            [Part_Imagen] = @Part_Imagen 
        WHERE [tbPartidos].[Part_Id] = @Part_Id
        SELECT 1 AS Resultado
        COMMIT
    END TRY
    BEGIN CATCH
        ROLLBACK
        SELECT 0 AS Resultado
    END CATCH
END
GO
/****** Object:  StoredProcedure [Vota].[SP_Partidos_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Vota].[SP_Partidos_Insertar]
(
    @Part_Descripcion VARCHAR(50),
    @Part_Color VARCHAR(50),
    @Part_UsuarioCreacion INT,
    @Part_FechaCreacion DATETIME,
    @Part_Imagen VARCHAR(MAX)
)
AS
BEGIN
    BEGIN TRY
        INSERT INTO [Vota].[tbPartidos] (
            [Part_Descripcion],
			Part_Color,
            [Part_UsuarioCreacion],
            [Part_FechaCreacion],
            [Part_Imagen]
        )
        VALUES(
            @Part_Descripcion,
			@Part_Color,
            @Part_UsuarioCreacion,
            @Part_FechaCreacion,
            @Part_Imagen
        )
        SELECT 1 AS Resultado
        COMMIT
    END TRY
    BEGIN CATCH
        ROLLBACK
        SELECT 0 AS Resultado
    END CATCH
END
GO
/****** Object:  StoredProcedure [Vota].[SP_Partidos_Llenar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Vota].[SP_Partidos_Llenar]
(
	@Part_Id int
)
AS
BEGIN
    BEGIN TRY
        SELECT *
        FROM [Vota].[tbPartidos]
        WHERE [Part_Estado] = 1 AND Part_Id = @Part_Id;  
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Partidos_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Vota].[SP_Partidos_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT *
        FROM [Vota].[tbPartidos]
        WHERE [Part_Estado] = 1;  
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Presidentes_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Vota].[SP_Presidentes_Editar]
    @Pres_Id INT,
    @Pres_Imagen VARCHAR(MAX),
    @Part_Id INT,
    @Pres_UsuarioModifica INT,
    @Pres_FechaModifica DATETIME
AS
BEGIN
    BEGIN TRY
        UPDATE Vota.tbPresidentes
        SET Pres_Imagen = @Pres_Imagen,
            Part_Id = @Part_Id,
            Pres_UsuarioModifica = @Pres_UsuarioModifica,
            Pres_FechaModifica = @Pres_FechaModifica
        WHERE Pres_Id = @Pres_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Presidentes_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Vota].[SP_Presidentes_Eliminar]
    @Pres_Id INT
AS
BEGIN
    BEGIN TRY
        UPDATE Vota.tbPresidentes
        SET Pres_Estado = 0 
        WHERE Pres_Id = @Pres_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Presidentes_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedimiento para insertar un nuevo presidente
CREATE PROCEDURE [Vota].[SP_Presidentes_Insertar]
    @Pres_Id INT,
    @Pres_Imagen VARCHAR(MAX),
    @Part_Id INT,
    @Pres_UsuarioCreacion INT,
    @Pres_FechaCreacion DATETIME
AS
BEGIN
    BEGIN TRY
        INSERT INTO Vota.tbPresidentes (Pres_Id, Pres_Imagen, Part_Id, Pres_UsuarioCreacion, Pres_FechaCreacion)
        VALUES (@Pres_Id, @Pres_Imagen, @Part_Id, @Pres_UsuarioCreacion, @Pres_FechaCreacion);
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Presidentes_Listar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Vota].[SP_Presidentes_Listar]
(
	@Pres_Id int
)
AS
BEGIN
    BEGIN TRY
        SELECT
            Pres_Id,
            Pres_Imagen,
            Part_Id,
			Pres_UsuarioCreacion,
            Pres_FechaCreacion,
            Pres_UsuarioModifica,
            Pres_FechaModifica,
            Pres_Estado
        FROM Vota.tbPresidentes
        WHERE Pres_Estado = 1 AND Pres_Id = @Pres_Id;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_Presidentes_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Vota].[SP_Presidentes_Mostrar]
AS
BEGIN
    BEGIN TRY
        SELECT
            Pres_Id,
            Pres_Imagen,
            Part_Id
        FROM Vota.tbPresidentes
        WHERE Pres_Estado = 1;
        
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_VotosPorMesas_Editar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Vota].[SP_VotosPorMesas_Editar]
    @VoMe_Id INT,
    @MePS_Id INT,
    @VoMe_CandidatoId INT,
    @VoMe_EsPresidente BIT
AS
BEGIN
    BEGIN TRY
        UPDATE Vota.tbVotosPorMesas
        SET MePS_Id = @MePS_Id,
            VoMe_CandidatoId = @VoMe_CandidatoId,
            VoMe_EsPresidente = @VoMe_EsPresidente
        WHERE VoMe_Id = @VoMe_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_VotosPorMesas_Eliminar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Vota].[SP_VotosPorMesas_Eliminar]
    @VoMe_Id INT
AS
BEGIN
    BEGIN TRY
        DELETE FROM Vota.tbVotosPorMesas
        WHERE VoMe_Id = @VoMe_Id;
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_VotosPorMesas_Insertar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Vota].[SP_VotosPorMesas_Insertar]
    @MePS_Id INT,
    @VoMe_CandidatoId INT,
    @VoMe_EsPresidente BIT
AS
BEGIN
    BEGIN TRY
        INSERT INTO Vota.tbVotosPorMesas (MePS_Id, VoMe_CandidatoId, VoMe_EsPresidente)
        VALUES (@MePS_Id, @VoMe_CandidatoId, @VoMe_EsPresidente);
        SELECT 1 AS Resultado;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Vota].[SP_VotosPorMesas_Mostrar]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Vota].[SP_VotosPorMesas_Mostrar]
AS 
BEGIN
    BEGIN TRY
  SELECT 
    Vot.Vota_Nombre AS Nombre,
    Vot.Vota_Apellidos AS Apellidos,
    CASE 
        WHEN VoMe.VoMe_EsPresidente = 1 THEN 'Presidente' 
        ELSE 'Alcalde' 
    END AS Cargo,
    VoMe.VoMe_CandidatoId AS CandidatoId,
    COUNT(*) AS TotalVotos
FROM 
    Vota.tbVotosPorMesas VoMe
LEFT JOIN 
    BD_SistemaVotaciones.Vota.tbPresidentes Pres ON VoMe.VoMe_CandidatoId = Pres.Pres_Id AND VoMe.VoMe_EsPresidente = 1
LEFT JOIN 
    BD_SistemaVotaciones.Vota.tbAlcaldes Alca ON VoMe.VoMe_CandidatoId = Alca.Alca_Id AND VoMe.VoMe_EsPresidente = 0
LEFT JOIN 
    Gral.tbVotantes Vot ON VoMe.VoMe_CandidatoId = Vot.Vota_Id
GROUP BY 
    VoMe.VoMe_EsPresidente, VoMe.VoMe_CandidatoId, Vot.Vota_Nombre, Vot.Vota_Apellidos
ORDER BY 
    Cargo, TotalVotos DESC;

    END TRY
    BEGIN CATCH 
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Vota].[SP_VotosPorMesas_MostrarAlcaldes]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [Vota].[SP_VotosPorMesas_MostrarAlcaldes]
AS 
BEGIN
    BEGIN TRY
        SELECT 
            Vot.Vota_Nombre AS NombreAlcalde,
            Vot.Vota_Apellidos AS ApellidoAlcalde,
            'Alcalde' AS CargoAlcalde,
            VoMe.VoMe_CandidatoId AS CandidatoIdAlcalde,
            COUNT(*) AS TotalVotosAlcalde
        FROM 
            Vota.tbVotosPorMesas VoMe
        INNER JOIN 
            Gral.tbVotantes Vot ON VoMe.VoMe_CandidatoId = Vot.Vota_Id
        WHERE 
            VoMe.VoMe_EsPresidente = 0
        GROUP BY 
            VoMe.VoMe_CandidatoId, Vot.Vota_Nombre, Vot.Vota_Apellidos
        ORDER BY 
            TotalVotosAlcalde DESC;
    END TRY
    BEGIN CATCH 
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Vota].[SP_VotosPorMesas_MostrarAlcaldes_PorMunicipio]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [Vota].[SP_VotosPorMesas_MostrarAlcaldes_PorMunicipio]
    @Muni_Codigo VARCHAR(4)
AS 
BEGIN
    BEGIN TRY
        SELECT 
            Vot.Vota_Nombre AS NombreAlcalde,
            Vot.Vota_Apellidos AS ApellidoAlcalde,
            'Alcalde' AS CargoAlcalde,
            Alc.Alca_Id AS CandidatoIdAlcalde,
            Part.Part_Color AS ColorPartido, 
            COUNT(*) AS TotalVotosAlcalde
        FROM 
            Vota.tbVotosPorMesas VoMe
        LEFT JOIN 
            Vota.tbAlcaldes Alc ON Alc.Alca_Id = VoMe.VoMe_CandidatoId
        LEFT JOIN 
            Gral.tbVotantes Vot ON Alc.Alca_Id = Vot.Vota_Id
        LEFT JOIN 
            Vota.tbPartidos Part ON Part.Part_Id = Alc.Part_Id
        WHERE 
            VoMe.VoMe_EsPresidente = 0
            AND Vot.Muni_Codigo = @Muni_Codigo
        GROUP BY 
            Alc.Alca_Id, Vot.Vota_Nombre, Vot.Vota_Apellidos, Part.Part_Color
        ORDER BY 
            TotalVotosAlcalde DESC;
    END TRY
    BEGIN CATCH 
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Vota].[SP_VotosPorMesas_MostrarAlcaldesPorMunicipio]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [Vota].[SP_VotosPorMesas_MostrarAlcaldesPorMunicipio]
    @Muni_Codigo VARCHAR(4)
AS 
BEGIN
    BEGIN TRY
        SELECT 
            Vot.Vota_Nombre AS NombreAlcalde,
            Vot.Vota_Apellidos AS ApellidoAlcalde,
            'Alcalde' AS CargoAlcalde,
            VoMe.VoMe_CandidatoId AS CandidatoIdAlcalde,
            COUNT(*) AS TotalVotosAlcalde
        FROM 
            Vota.tbVotosPorMesas VoMe
        LEFT JOIN 
            Gral.tbVotantes Vot ON VoMe.VoMe_CandidatoId = Vot.Vota_Id
        WHERE 
            VoMe.VoMe_EsPresidente = 0
            AND EXISTS (
                SELECT 1
                FROM [Vota].[tbAlcaldes] alc
                WHERE alc.Alca_Id = VoMe.VoMe_CandidatoId
                AND alc.Muni_Codigo = @Muni_Codigo
            )
        GROUP BY 
            VoMe.VoMe_CandidatoId, Vot.Vota_Nombre, Vot.Vota_Apellidos
        ORDER BY 
            TotalVotosAlcalde DESC;
    END TRY
    BEGIN CATCH 
        SELECT 0 AS Resultado;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Vota].[SP_VotosPorMesas_MostrarPresidentes]    Script Date: 10/4/2024 10:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Vota].[SP_VotosPorMesas_MostrarPresidentes]
AS 
BEGIN
    BEGIN TRY
        SELECT 
            Vot.Vota_Nombre AS NombrePresidente,
            Vot.Vota_Apellidos AS ApellidoPresidente,
            'Presidente' AS CargoPresidente,
            VoMe.VoMe_CandidatoId AS CandidatoIdPresidente,
            Part.Part_Color AS ColorPartido,
            COUNT(*) AS TotalVotosPresidentes
       FROM 
            Vota.tbVotosPorMesas VoMe
        LEFT JOIN 
            Gral.tbVotantes Vot ON VoMe.VoMe_CandidatoId = Vot.Vota_Id
        LEFT JOIN 
            Vota.tbPresidentes presi ON presi.Pres_Id = VoMe.VoMe_CandidatoId
        LEFT JOIN 
            Vota.tbPartidos Part ON Part.Part_Id = presi.Part_Id
        WHERE 
            VoMe.VoMe_EsPresidente = 1
        GROUP BY 
            VoMe.VoMe_CandidatoId, Vot.Vota_Nombre, Vot.Vota_Apellidos, Part.Part_Color
        ORDER BY 
            TotalVotosPresidentes DESC;
    END TRY
    BEGIN CATCH 
        SELECT 0 AS Resultado;
    END CATCH
END
GO
