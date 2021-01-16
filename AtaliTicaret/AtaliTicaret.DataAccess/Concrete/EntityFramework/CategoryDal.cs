using AtaliTicaret.DataAccess.Abstract;
using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.DataAccess.Concrete.EntityFramework
{
    public class CategoryDal:EfRepositoryBase<Category>,ICategoryDal
    {
        public CategoryDal(AtaliTicaretContext x):base(x)
        {

        }
    }
}
