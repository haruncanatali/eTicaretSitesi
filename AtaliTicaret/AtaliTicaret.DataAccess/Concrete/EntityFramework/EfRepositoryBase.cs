using AtaliTicaret.DataAccess.Abstract;
using AtaliTicaret.Entites.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AtaliTicaret.DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() 
    {

        protected readonly AtaliTicaretContext context;

        public EfRepositoryBase(AtaliTicaretContext x)
        {
            context = x;
        }

        public void Add(TEntity entity)
        {
            
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges(); 
        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();      
        }

        public List<TEntity> GetEntities(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetEntity(Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

     
    }
}
