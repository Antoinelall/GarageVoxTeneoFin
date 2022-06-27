using GarageVoxTeneo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageVoxTeneo.DAL.Interfaces
{
    public interface ICarsRepository : IRepository<int, CarsEntities>
    {
    }
}
