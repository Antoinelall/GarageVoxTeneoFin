using GarageVoxTeneo.BLL.DTO;
using GarageVoxTeneo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageVoxTeneo.BLL.Mapper
{
    public static class CarsMapper
    {
        public static CarsDTO ToDTO(this CarsEntities entity)
        {
            return new CarsDTO()
            {
                IdCars = entity.IdCars,
                Brand = entity.Brand,
                Model = entity.Model,
                Year = entity.Year,
                Color = entity.Color,
                Mileage = entity.Mileage,
                Engine = entity.Engine,
                Power = entity.Power,
                RegistrationDate = entity.RegistrationDate,
                Price = entity.Price,
            };
        }

        public static CarsEntities ToEntity(this CarsDTO dto)
        {
            return new CarsEntities()
            {
                IdCars = dto.IdCars,
                Brand = dto.Brand,
                Model = dto.Model,
                Year = dto.Year,
                Color = dto.Color,
                Mileage = dto.Mileage,
                Engine = dto.Engine,
                Power = dto.Power,
                RegistrationDate = dto.RegistrationDate,
                Price = dto.Price,
            };
        }
    }
}
