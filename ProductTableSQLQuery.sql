CREATE TABLE [dbo].[Product] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (150)  NOT NULL,
    [BrandName]    NVARCHAR (150)  NULL,
    [Price]        DECIMAL (18, 2) NOT NULL,
    [Count]        INT             NOT NULL,
    [IsActivate]   BIT             DEFAULT ((0)) NOT NULL,
    [CreationDate] DATETIME        DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);