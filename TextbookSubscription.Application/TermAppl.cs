namespace TextbookSubscription.Application
{
    using System.Collections.Generic;
    using TextbookSubscription.Repository;
    using Domain.EFDbContext;
    using IApplication;
    using ViewModels;
    using DTOAdapter;

    public class TermAppl : ITermAppl
    {
        private TermRepository _rep;
        private AutoMapperTypeAdapter _adpater;
        public IEnumerable<TermView> GetAll()
        {
            var termList = _rep.GetAll();
            return _adpater.Adapt<TermView>(termList);
        }

        public TermView GetCurrent()
        {
            throw new System.NotImplementedException();
        }
    }
}
