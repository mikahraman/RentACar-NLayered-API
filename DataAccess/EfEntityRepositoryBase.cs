using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess
{

    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext 
    {
        protected readonly TContext Context; 

        public EfEntityRepositoryBase(TContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {

            var addedEntity = Context.Entry(entity);
            addedEntity.State = EntityState.Added;
            Context.SaveChanges(); 
        }

        public void Delete(TEntity entity)
        {
            var deletedEntity = Context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var updatedEntity = Context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            Context.SaveChanges();
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> filter)
        {

            return Context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {

            return filter == null
                ? Context.Set<TEntity>().ToList()
                : Context.Set<TEntity>().Where(filter).ToList();
        }
    }
}