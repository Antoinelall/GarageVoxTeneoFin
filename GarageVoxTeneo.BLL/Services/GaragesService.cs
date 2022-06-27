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
    public class GaragesService : IGaragesService
    {
        private IGaragesRepository garagesRepository;

        public GaragesService(IGaragesRepository garagesRepository)
        {
            this.garagesRepository = garagesRepository;
        }
        public GaragesDTO GetById(int id)
        {
            return garagesRepository.GetById(id).ToDTO();
        }

        public IEnumerable<GaragesDTO> GetAll()
        {
            return garagesRepository.GetAll().Select(b => b.ToDTO());
        }

        public GaragesDTO Insert(GaragesDTO Garages)
        {
            int IdGarage = garagesRepository.Insert(Garages.ToEntity());

            Garages.IdGarage = IdGarage;
            return Garages;
        }
        public bool Update(int id, GaragesDTO G)
        {
            return garagesRepository.Update(id, G.ToEntity());
        }
        public bool Delete(int id)
        {
            return garagesRepository.Delete(id);
        }

        public IEnumerable<GaragesDTO> GetByName(string name)
        {
            return garagesRepository.GetAll().Where(m => m.Name.ToLower().Contains(name)).Select(b => b.ToDTO());
        }
    }
}
