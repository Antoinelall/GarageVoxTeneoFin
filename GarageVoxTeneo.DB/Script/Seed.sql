USE [GarageVoxToneo]
GO

-- Garage
SET IDENTITY_INSERT [Garages] ON;
GO

INSERT INTO [Garages] ([IdGarage], [Name], [Address], [PhoneNumber], [Email], [MaxCarsStock])
 VALUES (1, N'Toyota City Anderlecht', N'Industrielaan 198, 1070 Anderlecht', N'+3228088032', N'toyotacityanderlecht@mail.com', 40),
		(2, N'Ford Smart Lab Brussels', N'Lambermontlaan 1, 1000 Brussel', N'+32478980629', 'fordsmartlabbrussels@mail.com', 35),
		(3, N'ACB Delta', N'Boulevard des Invalides 220, 1160 Auderghem', N'+3223200272', 'acbdelta@mail.com', 15),
		(4, N'Audi Center', N'Grote Baan, 399, 1620 Drogenbos', N'+3223200125', 'audicenter@mail.com', 20)

GO

SET IDENTITY_INSERT [Garages] OFF;
GO

-- Car
SET IDENTITY_INSERT [Cars] ON;
GO
INSERT INTO [Cars] ([IdCars],[Brand], [Model], [Year], [Color], [Mileage], [Engine], [Power], [RegistrationDate], [Price], [Id_Garage])
 VALUES (1,N'Toyota', N'Corolla', 2020, 'White', 120000, 'Hybrid', 60, '2020-01-15', 50000, 1),
		(2,N'Toyota', N'Yaris', 2021, 'Red', 80000, 'Hybrid', 60, '2021-06-20', 40000, 1),
		(3,N'Ford', N'Fiesta', 2022, 'Blue', 65000, 'Hybrid', 60, '2022-01-25', 35000, 2),
		(4,N'Ford', N'Mustang', 2019, 'Yellow', 155000, 'Hybrid', 60, '2019-11-10', 60000, 2),
		(5,N'Renault', N'Kangoo', 2010, 'Green', 230000, 'Fuel', 60, '2010-08-05', 8000, 3),
		(6,N'citroen', N'C4', 2016, 'Black', 180000, 'Fuel', 60, '2016-03-21', 12000, 3),
		(7,N'Audi', N'A3', 2020, 'Grey', 1000, 'Fuel', 60, '2020-01-15', 45000, 4),
		(8,N'Audi', N'Q3', 2021, 'Orange', 20000, 'Fuel', 60, '2021-04-01', 55000, 4)
GO

SET IDENTITY_INSERT [Cars] OFF;
GO