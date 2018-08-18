namespace TextbookSubscription.Repository
{
    using TextbookSubscription.Domain;
    using TextbookSubscription.Domain.Entity;
    using TextbookSubscription.Domain.IRepositories;

    public class SchoolRepository : EFRepository<School>, ISchoolRepository
    {
        public SchoolRepository(IRepositoryDbContext context) 
            : base(context)
        {

        }

        public string GetSchoolIDByName(string shcoolName)
        {
            var school = Single(s => s.SchoolName == shcoolName);
            return school.SchoolID;
        }
    }
}
