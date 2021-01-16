using AtaliTicaret.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace AtaliTicaret.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity:class,IEntity,new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetEntities(Expression<Func<TEntity, bool>> filter=null);
        TEntity GetEntity(Expression<Func<TEntity, bool>> filter);
    }
}
