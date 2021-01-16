using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        IEnumerable<Product> GetProductsFromInTheBasket(List<int> keys);
    }
}
