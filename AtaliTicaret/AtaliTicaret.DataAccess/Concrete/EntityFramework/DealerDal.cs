using AtaliTicaret.DataAccess.Abstract;
using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.DataAccess.Concrete.EntityFramework
{
    public class DealerDal:EfRepositoryBase<Dealer>,IDealerDal
    {
        public DealerDal(AtaliTicaretContext x):base(x)
        {

        }
    }
}
