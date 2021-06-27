using egitim.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace egitim.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> expression = null);
        List<T> GetList(Expression<Func<T, bool>> expression = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
