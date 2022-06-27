using GarageVoxTeneo.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageVoxTeneo.BLL.Services
{
    public interface ICarsService
    {
        IEnumerable<CarsDTO> GetAll();
        CarsDTO GetById(int id);

        IEnumerable<CarsDTO> GetByGarage(int id);

        CarsDTO Insert(CarsDTO car);
        bool Update(int id, CarsDTO car);

        bool Delete(int id);
    }
}
