CREATE TABLE [dbo].[Pessoa] (
    [Id]              INT         IDENTITY (0, 1) NOT NULL,
    [nome]            NCHAR (180) NOT NULL,
    [cidade]          NCHAR (50)  NULL,
    [endereco]        NCHAR (150) NULL,
    [celular]         NCHAR (150) NOT NULL,
    [email]           NCHAR (100) NOT NULL,
    [data_nascimento] NCHAR (15)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

