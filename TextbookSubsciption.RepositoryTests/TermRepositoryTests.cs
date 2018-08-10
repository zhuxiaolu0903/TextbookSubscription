using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextbookSubscription.Domain.EFDbContext;
using System.Linq;
using TextbookSubscription.Repository;
using TextbookSubscription.Domain.Entity;

namespace TextbookSubscription.RepositoryTests
{
    [TestClass]
    public class TermRepositoryTests
    {

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void RetriveAllTerm()
        {
            TermRepository rep = new TermRepository(new TbMISDbContext());
            //SELECT COUNT(*) FROM Term = 16
            int totalCount = 16;
            var termList = rep.GetAll();
            foreach (var t in termList)
            {
                TestContext.WriteLine(t.TermName);
            }
            Assert.AreEqual(totalCount, termList.Count());
        }
    }
}
