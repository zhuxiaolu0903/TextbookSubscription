
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

        /// <summary>
        /// 获取学院ID
        /// </summary>
        /// <param name="schoolName"></param>
        /// <returns></returns>
        [Cache(CacheMethod.Get)]
        string GetSchoolID(string schoolName);
    }
}
