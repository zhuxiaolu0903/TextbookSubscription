using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextbookSubscription.Domain.IRepositories;
using TextbookSubscription.IApplication;
using TextbookSubscription.Infrastructure;
using TextbookSubscription.ViewModels;

namespace TextbookSubscription.Application
{
    public class SchoolAppl : ISchoolAppl
    {
        private ISchoolRepository _rep;
        private ITypeAdapter _adapter;

        public SchoolAppl(ISchoolRepository rep,ITypeAdapter adapter)
        {
            this._rep = rep;
            this._adapter = adapter;
        }

        /// <summary>
        /// 获取所有学院列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SchoolView> GetAll()
        {
            var SchoolList = _rep.GetAll();
            return _adapter.Adapt<SchoolView>(SchoolList);
        }

        /// <summary>
        /// 获取学院ID
        /// </summary>
        /// <param name="schoolName"></param>
        /// <returns></returns>
        public string GetSchoolID(string schoolName)
        {
            var SchoolID = _rep.Single(t => t.SchoolName == schoolName).SchoolID;
            return SchoolID;
        }
    }
}
