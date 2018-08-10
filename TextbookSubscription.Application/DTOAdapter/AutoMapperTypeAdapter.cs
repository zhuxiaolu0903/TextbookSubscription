namespace TextbookSubscription.Application.DTOAdapter
{
    using AutoMapper;
    using Infrastructure;
    using System.Collections.Generic;

    public class AutoMapperTypeAdapter : ITypeAdapter
    {
        public AutoMapperTypeAdapter()
        {
            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
        }

        /// <summary>
        /// 将对象由源类型转换为目标类型
        /// </summary>
        /// <typeparam name="TSource">源类型</typeparam>
        /// <typeparam name="TTarget">目标类型</typeparam>
        /// <param name="source">待转换对象</param>
        /// <returns>目标类型的对象</returns>
        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class, new()
        {
            return Mapper.Map<TSource, TTarget>(source);
        }

        /// <summary>
        /// 将对象由源类型转换为目标类型
        /// </summary>
        /// <typeparam name="TTarget">目标类型</typeparam>
        /// <param name="source">待转换对象</param>
        /// <returns>目标类型的对象</returns>
        public TTarget Adapt<TTarget>(object source)
            where TTarget : class, new()
        {
            return Mapper.Map<TTarget>(source);
        }

        /// <summary>
        /// 将对象集合由源类型转换为目标类型
        /// </summary>
        /// <typeparam name="TSource">源类型</typeparam>
        /// <typeparam name="TTarget">目标类型</typeparam>
        /// <param name="source">待转换对象</param>
        /// <returns>目标类型的对象</returns>
        public IEnumerable<TTarget> Adapt<TSource, TTarget>(IEnumerable<TSource> source)
            where TSource : class
            where TTarget : class, new()
        {
            //目标类型对象列表
            IList<TTarget> list = new List<TTarget>();

            //循环转换
            foreach (var item in source)
            {
                list.Add(Adapt<TSource, TTarget>(item));
            }

            return list;
        }

        /// <summary>
        /// 将对象集合由源类型转换为目标类型
        /// </summary>
        /// <typeparam name="TTarget">目标类型</typeparam>
        /// <param name="source">待转换对象</param>
        /// <returns>目标类型的对象</returns>
        public IEnumerable<TTarget> Adapt<TTarget>(IEnumerable<object> source)
            where TTarget : class, new()
        {
            //目标类型对象列表
            IList<TTarget> list = new List<TTarget>();

            //循环转换
            foreach (var item in source)
            {
                list.Add(Adapt<TTarget>(item));
            }

            return list;
        }
    }
}
