CREATE TABLE [dbo].[Cars]
(
	[IdCars] INT NOT NULL PRIMARY KEY identity, 
    [Brand] NVARCHAR(50) NOT NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [Year] INT NOT NULL, 
    [Color] NCHAR(50) NOT NULL, 
    [Mileage] INT NOT NULL DEFAULT 0, 
    [Engine] NVARCHAR(50) NOT NULL, 
    [Power] INT NOT NULL, 
    [RegistrationDate] DATETIME NOT NULL, 
    [Price] INT NOT NULL, 
    [Id_Garage] INT NOT NULL, 
    CONSTRAINT [FK_Cars__Garage] FOREIGN KEY ([Id_Garage]) REFERENCES [Garages]([IdGarage]), 
)
