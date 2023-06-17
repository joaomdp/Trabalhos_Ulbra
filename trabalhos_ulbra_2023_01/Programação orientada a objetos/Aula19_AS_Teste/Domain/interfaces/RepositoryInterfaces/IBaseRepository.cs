using System.Collections.Generic;

namespace Aula19_AS_Teste
{
    public interface IBaseRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
