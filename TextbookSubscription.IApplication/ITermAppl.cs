namespace TextbookSubscription.IApplication
{
    using System.Collections.Generic;
    using ViewModels;
    using Infrastructure.Cache;

    public interface ITermAppl
    {
        /// <summary>
        /// 获得全部学期列表
        /// </summary>
        /// <returns></returns>
        [Cache(CacheMethod.Get)]
        IEnumerable<TermView> GetAll();

        /// <summary>
        /// 获得当前学期
        /// </summary>
        /// <returns></returns>
        [Cache(CacheMethod.Get)]
        TermView GetCurrent();
    }
}
