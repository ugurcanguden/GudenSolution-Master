using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Guden.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Guden.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter, string includeProperties = null)
        {
            using (var context = new TContext())
            {
                return includeProperties == null ? 
                    context.Set<TEntity>().SingleOrDefault(filter) : 
                    context.Set<TEntity>().Include(includeProperties).SingleOrDefault(filter);
            }
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null)
        {

            using (var context = new TContext())
            {

                return filter == null ?
                      (
                      includeProperties == null ?
                          context.Set<TEntity>().ToList()
                          :
                          context.Set<TEntity>().Include(includeProperties).ToList()
                      )
                      :
                      (
                      includeProperties == null ?
                         context.Set<TEntity>().Where(filter).ToList()
                         :
                         context.Set<TEntity>().Include(includeProperties).Where(filter).ToList()
                      );

            }


        }

        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
    }
}
