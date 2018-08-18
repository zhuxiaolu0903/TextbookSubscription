namespace TextbookSubscription.IApplication
{
    using System.Collections.Generic;
    using TextbookSubscription.ViewModels;
    using TextbookSubscription.Infrastructure.Cache;

    public interface IDepartmentAppl
    {
        /// <summary>
        /// 获取学院的教研室
        /// </summary>
        /// <returns>教研室视图集合</returns>
        [Cache(CacheMethod.Get)]
        IEnumerable<DepartmentView> GetDepartmentList(string schoolName);
    }
}
