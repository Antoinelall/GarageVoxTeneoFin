using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageVoxTeneo.DAL.Interfaces
{
    public interface IRepository<TKey, TEntity>
    {
        TKey Insert(TEntity entity);
        TEntity GetById(TKey id);
        IEnumerable<TEntity> GetAll();
        bool Update(TKey id, TEntity entity);
        bool Delete(TKey id);
    }
}
