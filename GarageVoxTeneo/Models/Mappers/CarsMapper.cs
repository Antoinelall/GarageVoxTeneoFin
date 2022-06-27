using GarageVoxTeneo.BLL.DTO;

namespace GarageVoxTeneo.Models.Mappers
{
    internal static class CarsMapper
    {
        public static Cars ToModel(this CarsDTO dto)
        {
            return new Cars()
            {
                IdCars = dto.IdCars,
                Model = dto.Model,
                Year = dto.Year,
                Color = dto.Color,
                Mileage = dto.Mileage,
                Engine = dto.Engine,
                Power = dto.Power,
                RegistrationDate = dto.RegistrationDate,
                Price = dto.Price,
                Id_Garage = dto.Id_Garage
            };
        }
    }
}
