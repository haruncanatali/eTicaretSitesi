using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AtaliTicaret.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        List<Category> GetEntities(Expression<Func<Category, bool>> filter);
        Category GetEntity(Expression<Func<Category, bool>> filter);
    }
}
