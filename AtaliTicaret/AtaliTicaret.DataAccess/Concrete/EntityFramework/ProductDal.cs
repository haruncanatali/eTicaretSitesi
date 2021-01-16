using AtaliTicaret.DataAccess.Abstract;
using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AtaliTicaret.DataAccess.Concrete.EntityFramework
{
    public class ProductDal:EfRepositoryBase<Product>,IProductDal
    {
        AtaliTicaretContext context;
        public ProductDal(AtaliTicaretContext x):base(x)
        {
            context = x;
        }

        public IEnumerable<Product> GetProductsFromInTheBasket(List<int> keys)
        {
            IEnumerable<Product> liste = from nesne in context.Products where keys.Contains(nesne.ProductId) select nesne;

            return liste;
        }
    }
}
