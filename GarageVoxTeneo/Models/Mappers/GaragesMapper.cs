using GarageVoxTeneo.BLL.DTO;

namespace GarageVoxTeneo.Models.Mappers
{
    internal static class GaragesMapper
    {
        public static Garages ToModel(this GaragesDTO dto)
        {
            return new Garages()
            {
                IdGarage = dto.IdGarage,
                Name = dto.Name,
                Address = dto.Address,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                MaxCarsStock = dto.MaxCarsStock
            };
        }

        public static GaragesDTO ToDTO(this Garages garage)
        {
            return new GaragesDTO()
            {
                IdGarage = garage.IdGarage,
                Name = garage.Name,
                Address = garage.Address,
                PhoneNumber = garage.PhoneNumber,
                Email = garage.Email,
                MaxCarsStock = garage.MaxCarsStock
            };
        }
    }
}
