using GarageVoxTeneo.DAL.Entities;
using GarageVoxTeneo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Connections;

namespace GarageVoxTeneo.DAL.Repositories
{
    public class CarsRepositories : RepositoryBase<int, CarsEntities>, ICarsRepository
    {
        public CarsRepositories(Connection connection)
          : base(connection, "Cars", "IdCars")
        { }

        public override int Insert(CarsEntities entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName}(Brand, Model, Year, Color, Mileage, Engine, Power, RegistrationDate, Price)" +
                $" OUTPUT inserted.{TableId}" +
                " VALUES (@Brand, @Model, @Year, @Color, @Mileage, @Engine, @Power, @RegistrationDate, @Price)");

            cmd.AddParameter("Brand", entity.Brand);
            cmd.AddParameter("Model", entity.Model);
            cmd.AddParameter("Year", entity.Year);
            cmd.AddParameter("Color", entity.Color);
            cmd.AddParameter("Mileage", entity.Mileage);
            cmd.AddParameter("Engine", entity.Engine);
            cmd.AddParameter("Power", entity.Power);
            cmd.AddParameter("RegistrationDate", entity.RegistrationDate);
            cmd.AddParameter("Price", entity.Price);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(int id, CarsEntities entity)
        {
            Command cmd = new Command($"UPDATE {TableName} " +
                " SET Brand = @Brand," +
                "     Brand = @Brand," +
                "     Model = @Model" +
                "     Year = @Year" +
                "     Color = @Color" +
                "     Mileage = @Mileage" +
                "     Engine = @Engine" +
                "     Power = @Power" +
                "     RegistrationDate = @RegistrationDate" +
                "     Price = @Price" +
                $" WHERE {TableId} = @Id");

            cmd.AddParameter("IdCars", id);
            cmd.AddParameter("Brand", entity.Brand);
            cmd.AddParameter("Model", entity.Model);
            cmd.AddParameter("Year", entity.Year);
            cmd.AddParameter("Color", entity.Color);
            cmd.AddParameter("Mileage", entity.Mileage);
            cmd.AddParameter("Engine", entity.Engine);
            cmd.AddParameter("Power", entity.Power);
            cmd.AddParameter("RegistrationDate", entity.RegistrationDate);
            cmd.AddParameter("Price", entity.Price);

            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        protected override CarsEntities MapRecordToEntity(IDataRecord record)
        {
            return new CarsEntities()
            {
                IdCars = (int)record[TableId],
                Brand = (string)record["Brand"],
                Model = (string)record["Model"],
                Year = (int)record["Year"],
                Color = (string)record["Color"],
                Mileage = (int)record["Mileage"],
                Engine = (string)record["Engine"],
                Power = (int)record["Power"],
                RegistrationDate = (DateTime)record["RegistrationDate"],
                Price = (int)record["Price"],

            };
        }
        public IEnumerable<CarsEntities> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Cars");

            return _Connection.ExecuteReader(cmd, MapRecordToEntity);
        }

        public CarsEntities GetById(int id)
        {
            Command cmd = new Command("SELECT * FROM Cars WHERE IdCars = @IdCar");

            cmd.AddParameter("IdCars", id);

            return _Connection.ExecuteReader(cmd, MapRecordToEntity).SingleOrDefault();
        }
        public IEnumerable<CarsEntities> GetByGarage(int id)
        {
            Command cmd = new Command("SELECT C.* FROM Cars C JOIN Garages G ON C.Id_Garage = G.IdGarage WHERE G.IdGarage = @id");

            cmd.AddParameter("IdGarage", id);

            return _Connection.ExecuteReader(cmd, MapRecordToEntity);
        }
    }
}
