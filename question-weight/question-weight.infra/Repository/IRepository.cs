using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_weight.infra.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity CreateOrUpdate(TEntity entity);

        TEntity Get(long id);

        IQueryable<TEntity> GetAll();

        void Delete(long id);
    }
}
