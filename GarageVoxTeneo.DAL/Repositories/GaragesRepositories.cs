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
    public class GaragesRepositories : RepositoryBase<int, GarageEntities>, IGaragesRepository
    {
        public GaragesRepositories(Connection connection)
             : base(connection, "Garages", "IdGarage")
        { }

        public override int Insert(GarageEntities entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName}(Name, Address, PhoneNumber, Email, MaxCarsStock)" +
                $" OUTPUT inserted.{TableId}" +
                " VALUES (@Name, @Address, @PhoneNumber, @Email, @MaxCarsStock)");

            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Address", entity.Address);
            cmd.AddParameter("PhoneNumber", entity.PhoneNumber);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("MaxCarsStock", entity.MaxCarsStock);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(int id, GarageEntities entity)
        {
            Command cmd = new Command($"UPDATE {TableName} " +
                " SET Name = @Name," +
                "     Address = @Address," +
                "     PhoneNumber = @PhoneNumber" +
                "     Email = @Email" +
                "     CoMaxCarsStocklor = @MaxCarsStock" +
                $" WHERE {TableId} = @Id");

            cmd.AddParameter("IdGarage", id);
            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Address", entity.Address);
            cmd.AddParameter("PhoneNumber", entity.PhoneNumber);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("MaxCarsStock", entity.MaxCarsStock);

            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        protected override GarageEntities MapRecordToEntity(IDataRecord record)
        {
            return new GarageEntities()
            {
                IdGarage = (int)record[TableId],
                Name = (string)record["Name"],
                Address = (string)record["Address"],
                PhoneNumber = (string)record["PhoneNumber"],
                Email = (string)record["Email"],
                MaxCarsStock = (int)record["MaxCarsStock"],
            };
        }
        public override IEnumerable<GarageEntities> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Garages");

            return _Connection.ExecuteReader(cmd, MapRecordToEntity);
        }

        public override GarageEntities GetById(int id)
        {
            Command cmd = new Command("SELECT * FROM Garages WHERE IdGarage = @IdGarage");

            cmd.AddParameter("IdGarage", id);

            return _Connection.ExecuteReader(cmd, MapRecordToEntity).SingleOrDefault();
        }

    }
}
