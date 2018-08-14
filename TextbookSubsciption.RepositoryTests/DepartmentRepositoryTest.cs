using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextbookSubscription.Domain;
using TextbookSubscription.Repository;

namespace TextbookSubscription.RepositoryTests
{
    [TestClass]
    public class DepartmentRepositoryTest
    {
        public TestContext TestContext { set; get; }

        [TestMethod]
        public void RetriveAllDepartment()
        {
            DepartmentRepository rep = new DepartmentRepository(new EFRepositoryDbContext());
            int totalcount = 320;
            var departmentList = rep.GetAll();
            foreach(var t in departmentList)
            {
                TestContext.WriteLine(t.DepartmentName);
            }
            Assert.AreEqual(totalcount,departmentList.Count());
        }
    }
}
