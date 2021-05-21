USE [master]
GO
/****** Object:  Database [DBCvMaker]    Script Date: 05/04/2021 14:48:00 ******/
CREATE DATABASE [DBCvMaker] ON  PRIMARY 
( NAME = N'DBCvMaker', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DBCvMaker.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBCvMaker_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DBCvMaker_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBCvMaker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBCvMaker] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBCvMaker] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBCvMaker] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBCvMaker] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBCvMaker] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBCvMaker] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBCvMaker] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBCvMaker] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBCvMaker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBCvMaker] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBCvMaker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBCvMaker] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBCvMaker] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBCvMaker] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBCvMaker] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBCvMaker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBCvMaker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBCvMaker] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBCvMaker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBCvMaker] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBCvMaker] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBCvMaker] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBCvMaker] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBCvMaker] SET  MULTI_USER 
GO
ALTER DATABASE [DBCvMaker] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBCvMaker] SET DB_CHAINING OFF 
GO
USE [DBCvMaker]
GO
/****** Object:  Table [dbo].[Curriculo]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curriculo](
	[id] [int] NOT NULL,
	[idExperiencia] [int] NULL,
	[idIdioma1] [int] NULL,
	[idIdioma2] [int] NULL,
	[idIdioma3] [int] NULL,
	[idFormacaoG] [int] NULL,
	[idFormacaoPG] [int] NULL,
	[idFormacaoTec] [int] NULL,
	[idade] [int] NULL,
	[nome] [varchar](50) NULL,
	[cpf] [varchar](14) NULL,
	[codEndereco] [int] NULL,
	[telefone] [varchar](14) NULL,
	[email] [varchar](50) NULL,
	[area] [varchar](20) NULL,
	[cargo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enderecos]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enderecos](
	[idEnd] [int] NOT NULL,
	[idCurriculo_end] [int] NULL,
	[estado] [varchar](2) NULL,
	[cidade] [varchar](50) NULL,
	[bairro] [varchar](50) NULL,
	[rua] [varchar](50) NULL,
	[cep] [varchar](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[id] [int] NOT NULL,
	[nome] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Experiencias]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Experiencias](
	[id_experiencia] [int] NOT NULL,
	[id_curriculo_EXP] [int] NULL,
	[nome_empresa] [varchar](50) NULL,
	[inicio_EXP] [date] NULL,
	[fim_EXP] [date] NULL,
	[cargo_EXP] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_experiencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormacaoGraduacao]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormacaoGraduacao](
	[idFormacao_G] [int] NOT NULL,
	[idCurriculo_G] [int] NULL,
	[instituicao_G] [varchar](50) NULL,
	[periodo_G] [int] NULL,
	[turno_G] [varchar](15) NULL,
	[nome_G] [varchar](50) NULL,
	[Tipo_G] [varchar](50) NULL,
	[cidade_G] [varchar](40) NULL,
	[uf_G] [varchar](2) NULL,
	[inicio_G] [date] NULL,
	[fim_G] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFormacao_G] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormacaoPosGraduacao]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormacaoPosGraduacao](
	[idFormacao_PG] [int] NOT NULL,
	[idCurriculo_PG] [int] NULL,
	[instituicao_PG] [varchar](50) NULL,
	[periodo_PG] [int] NULL,
	[turno_PG] [varchar](15) NULL,
	[nome_PG] [varchar](50) NULL,
	[Tipo_PG] [varchar](50) NULL,
	[cidade_PG] [varchar](40) NULL,
	[uf_PG] [varchar](2) NULL,
	[inicio_PG] [date] NULL,
	[fim_PG] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFormacao_PG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormacaoTecnico]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormacaoTecnico](
	[idFormacao_TEC] [int] NOT NULL,
	[idCurriculo_TEC] [int] NULL,
	[instituicao_TEC] [varchar](50) NULL,
	[periodo_TEC] [int] NULL,
	[turno_TEC] [varchar](15) NULL,
	[nome_TEC] [varchar](50) NULL,
	[cidade_TEC] [varchar](40) NULL,
	[uf_TEC] [varchar](2) NULL,
	[inicio_TEC] [date] NULL,
	[fim_TEC] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFormacao_TEC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idiomas](
	[Id_Idioma] [int] NOT NULL,
	[Id_Curriculo] [int] NULL,
	[Idioma] [varchar](20) NULL,
	[Id_Nivel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nivel]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nivel](
	[Id_Nivel] [int] NOT NULL,
	[Descricao] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Nivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoFormacaoG]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoFormacaoG](
	[idTipo] [int] NOT NULL,
	[descricao] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoFormacaoPG]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoFormacaoPG](
	[idTipo] [int] NOT NULL,
	[descricao] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 05/04/2021 14:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[Id] [int] NOT NULL,
	[Texto] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Curriculo] ([id], [idExperiencia], [idIdioma1], [idIdioma2], [idIdioma3], [idFormacaoG], [idFormacaoPG], [idFormacaoTec], [idade], [nome], [cpf], [codEndereco], [telefone], [email], [area], [cargo]) VALUES (1, 1, 1, 2, 3, 1, 1, NULL, 43, N'Alberto Rodriguez', N'999.999.999-99', 1, N'12 98821-4555', N'albert.rdgz@hotmail.com', N'Administração', N'Gerente')
GO
INSERT [dbo].[Curriculo] ([id], [idExperiencia], [idIdioma1], [idIdioma2], [idIdioma3], [idFormacaoG], [idFormacaoPG], [idFormacaoTec], [idade], [nome], [cpf], [codEndereco], [telefone], [email], [area], [cargo]) VALUES (2, 2, NULL, NULL, NULL, 2, NULL, NULL, 27, N'Sara Ferraz', N'111.111.111-11', 2, N'31 99824-4755', N'sara.ferraz1@gmail.com', N'Química', N'Técnica em Química')
GO
INSERT [dbo].[Enderecos] ([idEnd], [idCurriculo_end], [estado], [cidade], [bairro], [rua], [cep]) VALUES (1, 1, N'SP', N'São Caetano do Sul', N'Nova Gerty', N'Bel Alliance', N'09038-124')
GO
INSERT [dbo].[Enderecos] ([idEnd], [idCurriculo_end], [estado], [cidade], [bairro], [rua], [cep]) VALUES (2, 2, N'MG', N'Passa Quatro', N'Vila Nova', N'Maria Cândido Tavares', N'22931-555')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (1, N'SP')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (2, N'RJ')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (3, N'MG')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (4, N'ES')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (5, N'PR')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (6, N'SC')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (7, N'RS')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (8, N'AM')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (9, N'AP')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (10, N'AC')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (11, N'RO')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (12, N'RR')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (13, N'TO')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (14, N'MA')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (15, N'PI')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (16, N'CE')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (17, N'AL')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (18, N'RN')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (19, N'PE')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (20, N'PB')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (21, N'PA')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (22, N'SE')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (23, N'BA')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (24, N'MT')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (25, N'MS')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (26, N'GO')
GO
INSERT [dbo].[Estados] ([id], [nome]) VALUES (27, N'DF')
GO
INSERT [dbo].[Experiencias] ([id_experiencia], [id_curriculo_EXP], [nome_empresa], [inicio_EXP], [fim_EXP], [cargo_EXP]) VALUES (1, 1, N'XP Investimentos', CAST(N'2016-07-13' AS Date), CAST(N'2020-11-18' AS Date), N'Consultor Financeiro')
GO
INSERT [dbo].[Experiencias] ([id_experiencia], [id_curriculo_EXP], [nome_empresa], [inicio_EXP], [fim_EXP], [cargo_EXP]) VALUES (2, 2, N'BASF', CAST(N'2018-03-13' AS Date), CAST(N'2021-01-18' AS Date), N'Trainee em análises químicas')
GO
INSERT [dbo].[FormacaoGraduacao] ([idFormacao_G], [idCurriculo_G], [instituicao_G], [periodo_G], [turno_G], [nome_G], [Tipo_G], [cidade_G], [uf_G], [inicio_G], [fim_G]) VALUES (1, 1, N'UNITAU', NULL, NULL, N'Admnistração de empresas', N'Bacharel', N'Taubaté', N'SP', CAST(N'1999-02-01' AS Date), CAST(N'2003-12-15' AS Date))
GO
INSERT [dbo].[FormacaoGraduacao] ([idFormacao_G], [idCurriculo_G], [instituicao_G], [periodo_G], [turno_G], [nome_G], [Tipo_G], [cidade_G], [uf_G], [inicio_G], [fim_G]) VALUES (2, 2, N'Universidade Católica de Santos', NULL, NULL, N'Química', N'Bacharel', N'Santos', N'SP', CAST(N'2013-02-01' AS Date), CAST(N'2017-12-15' AS Date))
GO
INSERT [dbo].[FormacaoPosGraduacao] ([idFormacao_PG], [idCurriculo_PG], [instituicao_PG], [periodo_PG], [turno_PG], [nome_PG], [Tipo_PG], [cidade_PG], [uf_PG], [inicio_PG], [fim_PG]) VALUES (1, 1, N'Universidade Presbiteriana Mackenzie', 2, N'Noite', N'Gestão de Projetos', N'MBA', N'São Paulo', N'SP', CAST(N'2020-08-28' AS Date), CAST(N'2022-06-03' AS Date))
GO
INSERT [dbo].[Idiomas] ([Id_Idioma], [Id_Curriculo], [Idioma], [Id_Nivel]) VALUES (1, 1, N'Inglês', 4)
GO
INSERT [dbo].[Idiomas] ([Id_Idioma], [Id_Curriculo], [Idioma], [Id_Nivel]) VALUES (2, 1, N'Holandês', 2)
GO
INSERT [dbo].[Idiomas] ([Id_Idioma], [Id_Curriculo], [Idioma], [Id_Nivel]) VALUES (3, 1, N'NULL', 0)
GO
INSERT [dbo].[Nivel] ([Id_Nivel], [Descricao]) VALUES (1, N'Básico')
GO
INSERT [dbo].[Nivel] ([Id_Nivel], [Descricao]) VALUES (2, N'Intermediário')
GO
INSERT [dbo].[Nivel] ([Id_Nivel], [Descricao]) VALUES (3, N'Avançado')
GO
INSERT [dbo].[Nivel] ([Id_Nivel], [Descricao]) VALUES (4, N'Fluente')
GO
INSERT [dbo].[tipoFormacaoG] ([idTipo], [descricao]) VALUES (1, N'Bacharelado')
GO
INSERT [dbo].[tipoFormacaoG] ([idTipo], [descricao]) VALUES (2, N'Tecnólogo')
GO
INSERT [dbo].[tipoFormacaoG] ([idTipo], [descricao]) VALUES (3, N'Licenciatura')
GO
INSERT [dbo].[tipoFormacaoPG] ([idTipo], [descricao]) VALUES (1, N'Mestrado')
GO
INSERT [dbo].[tipoFormacaoPG] ([idTipo], [descricao]) VALUES (2, N'Doutorado')
GO
INSERT [dbo].[tipoFormacaoPG] ([idTipo], [descricao]) VALUES (3, N'Especialização')
GO
INSERT [dbo].[tipoFormacaoPG] ([idTipo], [descricao]) VALUES (4, N'MBA')
GO
INSERT [dbo].[Turnos] ([Id], [Texto]) VALUES (1, N'Manhã')
GO
INSERT [dbo].[Turnos] ([Id], [Texto]) VALUES (2, N'Tarde')
GO
INSERT [dbo].[Turnos] ([Id], [Texto]) VALUES (3, N'Noite')
GO
INSERT [dbo].[Turnos] ([Id], [Texto]) VALUES (4, N'Integral')
GO
USE [master]
GO
ALTER DATABASE [DBCvMaker] SET  READ_WRITE 
GO
