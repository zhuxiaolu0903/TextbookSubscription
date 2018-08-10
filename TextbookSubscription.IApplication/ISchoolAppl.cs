
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
        /// <returns></returns>
        [Cache(CacheMethod.Get)]
        IEnumerable<SchoolView> GetAll();
    }
}
