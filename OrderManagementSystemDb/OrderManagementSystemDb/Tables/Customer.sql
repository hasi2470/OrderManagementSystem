CREATE TABLE [dbo].[Customer]
(
	[Cust_Id] INT NOT NULL PRIMARY KEY,
	[Name] nvarchar(50) NOT NULL,
	[Address] nvarchar(100),
	[Contact_num] nvarchar(13),
	[UserName] nvarchar(20) NOT NULL UNIQUE,
	[Password] nvarchar(20) NOT NULL
)
