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
    public class DepartmentAppl : IDepartmentAppl
    {
        private IDepartmentRepository _rep;
        private ITypeAdapter _adapter;

        private ISchoolAppl _schoolAppl;

        //private SchoolView _schoolView;

        public DepartmentAppl(IDepartmentRepository rep, ITypeAdapter adapter, ISchoolAppl schoolAppl)
        {
            _rep = rep;
            _adapter = adapter;
            _schoolAppl = schoolAppl;
        }

        public IEnumerable<DepartmentView> GetDepartmentList(string schoolName)
        {
            var schoolID = _schoolAppl.GetSchoolID(schoolName);
            var departmentList = _rep.Find(d => d.SchoolID == schoolID);
            return _adapter.Adapt<DepartmentView>(departmentList);
        }
    }
}
