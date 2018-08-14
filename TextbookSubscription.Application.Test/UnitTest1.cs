using System;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextbookManage.Domain.IRepositories;
using TextbookManage.Repositories.EntityFramework;
using TextbookSubscription.IApplication;
using TextbookSubscription.Infrastructure;

namespace TextbookSubscription.Application.Test
{
    [TestClass]
    public class UnitTest1
    {
        private ISchoolAppl _rep;
        private ITypeAdapter _adapter;

        //仓储上下文
        IRepositoryContext _context;
        //事务
        TransactionScope _trans;

        [TestInitialize]
        public void Initialize()
        {
            _context = new EntityFrameworkRepositoryContext();
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
