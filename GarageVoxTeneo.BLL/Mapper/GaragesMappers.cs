using GarageVoxTeneo.BLL.DTO;
using GarageVoxTeneo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageVoxTeneo.BLL.Mapper
{
    public static class GaragesMappers
    {
        public static GaragesDTO ToDTO(this GarageEntities entity)
        {
            return new GaragesDTO()
            {
                IdGarage = entity.IdGarage,
                Name = entity.Name,
                Address = entity.Address,
                PhoneNumber = entity.PhoneNumber,
                Email = entity.Email,
                MaxCarsStock = entity.MaxCarsStock,
                
            };
        }

        public static GarageEntities ToEntity(this GaragesDTO dto)
        {
            return new GarageEntities()
            {
                IdGarage = dto.IdGarage,
                Name = dto.Name,
                Address = dto.Address,
                PhoneNumber= dto.PhoneNumber,
                Email= dto.Email,
                MaxCarsStock= dto.MaxCarsStock,
                
            };
        }
    }
}
