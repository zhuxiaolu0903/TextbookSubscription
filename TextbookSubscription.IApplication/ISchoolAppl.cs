namespace TextbookSubscription.IApplication
{
    using ViewModels;
    using System.Collections.Generic;
    using Infrastructure.Cache;

    public interface ISchoolAppl
    {
        /// <summary>
        /// 获取全部学院
        /// </summary>
        /// <returns>学院视图集合</returns>
        [Cache(CacheMethod.Get)]
        IEnumerable<SchoolView> GetAll();
    }
}
