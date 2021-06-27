using egitim.Core.DataAccess.EfEntityFramework;
using shop.Dal.Abstract;
using shop.Entities;
using System;
using System.Linq;

namespace shop.Dal.Concrate.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, EgitimDbContext>, ICategoryDal
    {
        public IQueryable<Category> GetAsQuerable()
        {
            var context = new EgitimDbContext();
            return context.Categories.AsQueryable();
        }
    }
}
