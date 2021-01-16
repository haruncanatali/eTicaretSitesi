using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AtaliTicaret.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        List<Product> GetEntities(Expression<Func<Product, bool>> filter);
        Product GetEntity(Expression<Func<Product, bool>> filter);
        IEnumerable<Product> GetProductsFromInTheBasket(List<int> keys);
    }
}
