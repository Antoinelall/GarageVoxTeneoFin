CREATE TABLE [dbo].[Garages]
(
	[IdGarage] INT NOT NULL PRIMARY KEY identity, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(250) NOT NULL, 
    [MaxCarsStock] INT NOT NULL
)
