CREATE TABLE [dbo].[Customer] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [Username]            NVARCHAR (50)  NOT NULL,
    [Password]            NVARCHAR (50)  NOT NULL,
    [FirstName]           NVARCHAR (150) NOT NULL,
    [LastName]            NVARCHAR (150) NOT NULL,
    [BirthDate]           DATETIME       NULL,
    [Email]               NVARCHAR (100) NULL,
    [MobileNumber]        NVARCHAR (20)  NOT NULL,
    [IsValidMobileNumber] BIT            DEFAULT ((0)) NOT NULL,
    [IsValidEmail]        BIT            DEFAULT ((0)) NOT NULL,
    [IsActive]            BIT            DEFAULT ((0)) NOT NULL,
    [CreationDate]        DATETIME       DEFAULT (getdate()) NULL,
    [HomeAddress]         NVARCHAR (150) NULL,
    [GenderId]            NCHAR (10)     NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);