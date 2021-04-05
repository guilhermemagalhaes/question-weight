using System;
using System.Collections.Generic;
using System.Text;

namespace question_weight.service.Service.Base
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity CreateOrUpdate(TEntity entity);

        TEntity Get(long id);

        IList<TEntity> GetAll();

        void Delete(long id);
    }
}
