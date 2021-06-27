using egitim.Core.DataAccess.EfEntityFramework;
using shop.Dal.Abstract;
using shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace shop.Dal.Concrate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EgitimDbContext>, IProductDal
    {
        public List<Product> GetPopulerProduct()
        {
            throw new NotImplementedException();// nasıl algoritma kuracağımı bulamadım
        }
    }
}
