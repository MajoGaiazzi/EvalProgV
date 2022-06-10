CREATE TABLE [dbo].[Curriculum] (
    [Id]    INT             IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (MAX)  NULL,
    [Apellido] NVARCHAR (MAX)  NULL,
    [Genero] VARCHAR  NOT NULL,
	[Edad] INT  NOT NULL,
	[Telefono] INT  NOT NULL,
	[Mail] VARCHAR  NOT NULL,
	[FechaNac] DATE  NOT NULL,



    CONSTRAINT [PK_Curriculum] PRIMARY KEY CLUSTERED ([Id] ASC)
);

