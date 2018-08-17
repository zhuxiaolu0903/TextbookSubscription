using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextbookSubscription.Repository;
using TextbookSubscription.Domain;
using System.Linq;

namespace TextbookSubscription.RepositoryTests
{
    /// <summary>
    /// SchoolRepositoryTest 的摘要说明
    /// </summary>
    [TestClass]
    public class SchoolRepositoryTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void RetriveAllSchool()
        {
            SchoolRepository rep = new SchoolRepository(new EFRepositoryDbContext());
            //SELECT COUNT(*) FROM Term = 16
            int totalCount = 55;
            var schoollist = rep.GetAll();
            foreach (var t in schoollist)
            {
                TestContext.WriteLine(t.SchoolName);
            }
            Assert.AreEqual(totalCount, schoollist.Count());
        }
    }
}
