using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextbookSubscription.Domain;
using TextbookSubscription.Domain.Entity;
using TextbookSubscription.Domain.IRepositories;

namespace TextbookSubscription.Repository
{
    public class SchoolRepository : EFRepository<School>, ISchoolRepository
    {
        public SchoolRepository(IRepositoryDbContext context) : base(context)
        {
        }
    }
}
