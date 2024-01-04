CREATE PROCEDURE dbo.InsertCustomer
   @Username          NVARCHAR(255),  
   @Password          NVARCHAR(255),
   @FirstName         NVARCHAR(255),  
   @LastName          NVARCHAR(255),
   @Email             NVARCHAR(255), 
   @MobileNumber      NVARCHAR(20),   
   @GenderId          SMALLINT,
   @BirthDate         DATETIME,
   @HomeAddress       NVARCHAR(255)


   AS
   BEGIN  
   INSERT INTO dbo.Customer (Username, [Password], FirstName, LastName, Email, MobileNumber, GenderId, BirthDate,HomeAddress)    
   VALUES (@Username, @Password, @FirstName, @LastName, @Email, @MobileNumber, @GenderId, @BirthDate, @HomeAddress);
   END

     EXEC dbo.InsertCustomer
   @Username = 'jahan',
   @Password = 'lhgfv55',
   @FirstName= 'jahangir',
   @LastName = 'gholami',
   @Email    = 'jahan@gmail.com',
   @MobileNumber='09128554474',
   @GenderId = 2,
   @BirthDate= NULL,
   @HomeAddress= 'marzdaran'

   SELECT * FROM dbo.Customer
          