CREATE PROCEDURE [dbo].[InsertUsers]
   @Username       NVARCHAR(255),  
   @Password       NVARCHAR(255),
   @FirstName      NVARCHAR(255),  
   @LastName       NVARCHAR(255),
   @MobileNumber    NVARCHAR(20),   
   @GenderId       SMALLINT,
   @BirthDate       DATETIME,
   @userId         INT OUTPUT

   AS
   BEGIN  
   INSERT INTO dbo.Users (Username, [Password], FirstName, LastName, MobileNumber, GenderId, BirthDate)    
   VALUES (@Username, @Password, @FirstName, @LastName, @MobileNumber, @GenderId, @BirthDate);

   SET @userId = SCOPE_IDENTITY()
   END

   CREATE TABLE [dbo].[Users] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [UserName]     VARCHAR (50)  NOT NULL,
    [password]     NCHAR (10)    NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [MobileNumber] NVARCHAR (20) NOT NULL,
    [BirthDate]    DATETIME      NULL,
    [GenderId]     NVARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
