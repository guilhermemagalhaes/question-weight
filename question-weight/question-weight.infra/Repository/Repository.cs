using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_weight.infra.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            this._context = context;
        }

        public virtual TEntity CreateOrUpdate(TEntity entity)
        {
            EntityEntry<TEntity> entry = _context.Entry(entity);
            IKey primaryKey = entry.Metadata.FindPrimaryKey();
            if (primaryKey != null)
            {
                object[] keys = primaryKey.Properties.Select(x => x.FieldInfo.GetValue(entity))
                                                .ToArray();
                TEntity result = _context.Find<TEntity>(keys);
                if (result == null)
                {
                    _context.Add(entity);
                }
                else
                {
                    _context.Entry(result).State = EntityState.Detached;
                    _context.Update(entity);

                }
                _context.SaveChanges();
            }

            return entity;
        }

        public virtual void Delete(long id)
        {
            _context.Set<TEntity>().Remove(_context.Set<TEntity>().Find(id));
            _context.SaveChanges();
        }

        public virtual TEntity Get(long id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }
    }
}
