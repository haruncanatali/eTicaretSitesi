using AtaliTicaret.Business.Abstract;
using AtaliTicaret.DataAccess.Abstract;
using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AtaliTicaret.Business.Concreate
{
    public class ProductManager : IProductService
    {

        IProductDal _dal;

        public ProductManager(IProductDal x)
        {
            _dal = x;
        }


        public void Add(Product entity)
        {
            _dal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _dal.Delete(entity);
        }

        public List<Product> GetEntities(Expression<Func<Product, bool>> filter)
        {
            return _dal.GetEntities(filter);
        }

        public Product GetEntity(Expression<Func<Product, bool>> filter)
        {
            return _dal.GetEntity(filter);
        }

        public IEnumerable<Product> GetProductsFromInTheBasket(List<int> keys)
        {
            return _dal.GetProductsFromInTheBasket(keys);
        }

        public void Update(Product entity)
        {
            _dal.Update(entity);
        }
    }
}
