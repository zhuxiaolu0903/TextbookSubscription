using System.Collections.Generic;
using TextbookSubscription.Domain.IRepositories;
using TextbookSubscription.IApplication;
using TextbookSubscription.Infrastructure;
using TextbookSubscription.ViewModels;

namespace TextbookSubscription.Application
{
    public class SchoolAppl : ISchoolAppl
    {
        private ISchoolRepository _schoolRep;
        private ITypeAdapter _adapter;

        public SchoolAppl(ISchoolRepository schoolRep,ITypeAdapter adapter)
        {
            _schoolRep = schoolRep;
            _adapter = adapter;
        }

        public IEnumerable<SchoolView> GetAll()
        {
            var SchoolList = _schoolRep.GetAll();
            return _adapter.Adapt<SchoolView>(SchoolList);
        }
    }
}
