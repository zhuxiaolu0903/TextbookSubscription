namespace TextbookSubscription.Domain.IRepositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using EFDbContext;

    /// <summary>
    /// 规定所有接口仓库的基础方法
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// 根据标识获得实体
        /// </summary>
        /// <param name="Id">实体对象的Id</param>
        /// <returns>单一实体对象</returns>
        TEntity Get(string Id);

        /// <summary>
        /// 获得全部实体
        /// </summary>
        /// <returns>全部实体</returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// 根据谓词返回实体对象
        /// </summary>
        /// <param name="predicate">查询条件</param>
        /// <returns>实体对象集合</returns>
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 增加单个对象
        /// </summary>
        /// <param name="entity">对象实体</param>
        void Add(TEntity entity);

        /// <summary>
        /// 增加对象集合
        /// </summary>
        /// <param name="entities">对象实体集合</param>
        void Add(IEnumerable<TEntity> entities);

        /// <summary>
        /// 删除对象实体
        /// </summary>
        /// <param name="entity">对象实体</param>
        void Remove(TEntity entity);

        /// <summary>
        /// 删除对象集合
        /// </summary>
        /// <param name="entities">对象实体集合</param>
        void Remove(IEnumerable<TEntity> entities);

    }
}
