
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/06/2018 10:17:04
-- Generated from EDMX file: C:\Users\FSANCHEZ\Desktop\Proyecto-Propietaria\ProyectoPropietaria\RRHH.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RRHH];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Candidatos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Candidatos];
GO
IF OBJECT_ID(N'[dbo].[Capacitaciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Capacitaciones];
GO
IF OBJECT_ID(N'[dbo].[Competencias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Competencias];
GO
IF OBJECT_ID(N'[dbo].[Departamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departamento];
GO
IF OBJECT_ID(N'[dbo].[Empleados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados];
GO
IF OBJECT_ID(N'[dbo].[ExperienciaLaboral]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExperienciaLaboral];
GO
IF OBJECT_ID(N'[dbo].[Idiomas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Idiomas];
GO
IF OBJECT_ID(N'[dbo].[Puestos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Puestos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Candidatos'
CREATE TABLE [dbo].[Candidatos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [Cedula] varchar(11)  NOT NULL,
    [PuestoAspirante] varchar(30)  NOT NULL,
    [Deparamento] varchar(30)  NOT NULL,
    [SalarioDeseado] float  NOT NULL,
    [Competencias] varchar(200)  NOT NULL,
    [Capacitaciones] varchar(200)  NOT NULL,
    [Experiencia] varchar(200)  NOT NULL,
    [Recomendacion] varchar(30)  NOT NULL
);
GO

-- Creating table 'Capacitaciones'
CREATE TABLE [dbo].[Capacitaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(100)  NOT NULL,
    [Nivel] varchar(22)  NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFinalizacion] datetime  NOT NULL,
    [Institucion] varchar(25)  NOT NULL,
    [Idiomas] varchar(30)  NOT NULL
);
GO

-- Creating table 'Departamento'
CREATE TABLE [dbo].[Departamento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreDepartamento] varchar(30)  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'Empleados'
CREATE TABLE [dbo].[Empleados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [Cedula] varchar(11)  NOT NULL,
    [FechaIngreso] datetime  NOT NULL,
    [Departamento] varchar(30)  NOT NULL,
    [Puesto] varchar(30)  NOT NULL,
    [Salario] float  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'ExperienciaLaboral'
CREATE TABLE [dbo].[ExperienciaLaboral] (
    [Id] int  NOT NULL,
    [Empresa] varchar(50)  NOT NULL,
    [Puesto] varchar(50)  NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFinalizacion] datetime  NULL
);
GO

-- Creating table 'Idiomas'
CREATE TABLE [dbo].[Idiomas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(12)  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'Puestos'
CREATE TABLE [dbo].[Puestos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(30)  NOT NULL,
    [NivelRiesgo] varchar(5)  NOT NULL,
    [SalarioMinimo] float  NOT NULL,
    [SalarioMaximo] float  NOT NULL,
    [Departamento] varchar(30)  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'Competencias'
CREATE TABLE [dbo].[Competencias] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(300)  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Candidatos'
ALTER TABLE [dbo].[Candidatos]
ADD CONSTRAINT [PK_Candidatos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Capacitaciones'
ALTER TABLE [dbo].[Capacitaciones]
ADD CONSTRAINT [PK_Capacitaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departamento'
ALTER TABLE [dbo].[Departamento]
ADD CONSTRAINT [PK_Departamento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [PK_Empleados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExperienciaLaboral'
ALTER TABLE [dbo].[ExperienciaLaboral]
ADD CONSTRAINT [PK_ExperienciaLaboral]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Idiomas'
ALTER TABLE [dbo].[Idiomas]
ADD CONSTRAINT [PK_Idiomas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Puestos'
ALTER TABLE [dbo].[Puestos]
ADD CONSTRAINT [PK_Puestos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'Competencias'
ALTER TABLE [dbo].[Competencias]
ADD CONSTRAINT [PK_Competencias]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------