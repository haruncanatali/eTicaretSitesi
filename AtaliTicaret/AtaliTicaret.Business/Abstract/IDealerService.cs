using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AtaliTicaret.Business.Abstract
{
    public interface IDealerService
    {
        void Add(Dealer entity);
        void Update(Dealer entity);
        void Delete(Dealer entity);
        List<Dealer> GetEntities(Expression<Func<Dealer, bool>> filter);
        Dealer GetEntity(Expression<Func<Dealer, bool>> filter);
    }
}
