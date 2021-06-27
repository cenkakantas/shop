using egitim.Core.DataAccess;
using shop.Entities;
using System.Linq;

namespace shop.Dal.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        IQueryable<Category> GetAsQuerable();
    }
}
