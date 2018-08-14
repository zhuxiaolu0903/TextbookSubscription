using System.Collections.Generic;
using TextbookSubscription.ViewModels;
using TextbookSubscription.Infrastructure.Cache;
using System;

namespace TextbookSubscription.IApplication
{
    public interface IDepartmentAppl
    {
        /// <summary>
        /// 获取学院的教研室
        /// </summary>
        /// <returns></returns>
        [Cache(CacheMethod.Get)]
        IEnumerable<DepartmentView> GetDepartmentList(string schoolName);
    }
}
