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
        /// <returns>所有学期视图</returns>
        [Cache(CacheMethod.Get)]
        IEnumerable<TermView> GetAll();

        /// <summary>
        /// 获得当前学期
        /// </summary>
        /// <returns>当前学期视图</returns>
        [Cache(CacheMethod.Get)]
        TermView GetCurrent();
    }
}
