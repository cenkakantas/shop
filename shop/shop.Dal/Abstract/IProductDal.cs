using egitim.Core.DataAccess;
using shop.Entities;
using System.Collections.Generic;

namespace shop.Dal.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<Product> GetPopulerProduct();
    }
}
