using AtaliTicaret.Business.Abstract;
using AtaliTicaret.DataAccess.Abstract;
using AtaliTicaret.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AtaliTicaret.Business.Concreate
{
    public class DealerManager : IDealerService
    {

        IDealerDal _dal;
        public DealerManager(IDealerDal x)
        {
            _dal = x;
        }

        public void Add(Dealer entity)
        {
            _dal.Add(entity);
        }

        public void Delete(Dealer entity)
        {
            _dal.Delete(entity);
        }

        public List<Dealer> GetEntities(Expression<Func<Dealer, bool>> filter)
        {
            return _dal.GetEntities(filter);
        }

        public Dealer GetEntity(Expression<Func<Dealer, bool>> filter)
        {
            return _dal.GetEntity(filter);
        }

        public void Update(Dealer entity)
        {
            _dal.Update(entity);
        }
    }
}
