using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_TestandoORM.Domain.Intrefaces
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        Entity GetBayId(int entityId);
        IList<Entity> GetAll();
        void Save(Entity entity);
        void Delete(int entityId);
        void Update(Entity entity);
    }
}