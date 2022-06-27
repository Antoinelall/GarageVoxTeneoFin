using GarageVoxTeneo.BLL.DTO;
using GarageVoxTeneo.BLL.Mapper;
using GarageVoxTeneo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageVoxTeneo.BLL.Services
{
    public class CarsService : ICarsService
    {
        private ICarsRepository carsRepository;

        public CarsService(ICarsRepository carsRepository)
        {
            this.carsRepository = carsRepository;
        }


        public CarsDTO GetById(int id)
        {
            return carsRepository.GetById(id).ToDTO();
        }

        public IEnumerable<CarsDTO> GetAll()
        {
            return carsRepository.GetAll().Select(b => b.ToDTO());
        }

        public CarsDTO Insert(CarsDTO cars)
        {
            int IdCars = carsRepository.Insert(cars.ToEntity());

            cars.IdCars = IdCars;
            return cars;
        }
        public IEnumerable<CarsDTO> GetByGarage(int id)
        {
            return carsRepository.GetAll().Where(c => c.Id_Garage.Equals(id)).Select(b => b.ToDTO());
        }
        public bool Update(int id, CarsDTO H)
        {
            return carsRepository.Update(id, H.ToEntity());
        }
        public bool Delete(int id)
        {
            return carsRepository.Delete(id);
        }
    }
}
