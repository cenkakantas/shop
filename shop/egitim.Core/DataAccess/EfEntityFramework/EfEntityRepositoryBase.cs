using egitim.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace egitim.Core.DataAccess.EfEntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
          using (var context=new TContext())
            {
                var addedEntity = context.Add(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var delete = context.Remove(entity);
                delete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return expression == null ? context.Set<TEntity>().SingleOrDefault() :
                    context.Set<TEntity>().Where(expression).SingleOrDefault();
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return expression == null ? context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(expression).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var update = context.Entry(entity);
                update.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
