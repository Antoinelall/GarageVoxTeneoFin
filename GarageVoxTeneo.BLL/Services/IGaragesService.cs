using GarageVoxTeneo.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageVoxTeneo.BLL.Services
{
    public interface IGaragesService
    {
        IEnumerable<GaragesDTO> GetAll();
        GaragesDTO GetById(int id);
        IEnumerable<GaragesDTO> GetByName(string name);
        GaragesDTO Insert(GaragesDTO garage);
        bool Update(int id, GaragesDTO garage);

        bool Delete(int id);

    }
}
