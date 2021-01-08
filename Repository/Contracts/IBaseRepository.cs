using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IBaseRepository<TEntity>
    {
        void Add(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
