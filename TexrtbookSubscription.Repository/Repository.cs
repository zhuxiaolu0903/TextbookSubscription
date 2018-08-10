namespace TextbookSubscription.Repository
{
    using TextbookSubscription.Domain.IRepositories;
    using System.Collections.Generic;
    using TextbookSubscription.Domain.EFDbContext;
    using System;
    using System.Linq.Expressions;
    using System.Linq;


    /// <summary>
    /// 规定仓库的基础方法
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected readonly TbMISDbContext context;

        public Repository(TbMISDbContext dbContext)
        {
            context = dbContext;
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(string Id)
        {
            return context.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public void Remove(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
