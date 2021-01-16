using AtaliTicaret.Business.Abstract;
using AtaliTicaret.DataAccess.Abstract;
using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AtaliTicaret.Business.Concreate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _dal;

        public CategoryManager(ICategoryDal x)
        {
            _dal = x;
        }

        public void Add(Category entity)
        {
            _dal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _dal.Delete(entity);
        }

        public List<Category> GetEntities(Expression<Func<Category, bool>> filter)
        {
           return _dal.GetEntities(filter);
        }

        public Category GetEntity(Expression<Func<Category, bool>> filter)
        {
            return _dal.GetEntity(filter);
        }

        public void Update(Category entity)
        {
            _dal.Update(entity); 
        }
    }
}
