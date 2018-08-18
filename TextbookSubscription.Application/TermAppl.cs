namespace TextbookSubscription.Application
{
    using System.Collections.Generic;
    using TextbookSubscription.Domain.IRepositories;
    using IApplication;
    using ViewModels;
    using TextbookSubscription.Infrastructure;

    public class TermAppl : ITermAppl
    {
        private ITermRepository _termRep;
        private ITypeAdapter _adpater;

        public TermAppl(ITermRepository termRep, ITypeAdapter adapter)
        {
            _termRep = termRep;
            _adpater = adapter;
        }

        public IEnumerable<TermView> GetAll()
        {
            var termViewList = _termRep.GetAll();
            return _adpater.Adapt<TermView>(termViewList);
        }

        public TermView GetCurrent()
        {
            var termView = _termRep.Single(t => t.IsCurrentTerm == "1");
            return _adpater.Adapt<TermView>(termView);
        }
    }
}
