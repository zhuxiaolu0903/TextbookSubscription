namespace TextbookSubscription.Repository
{
    using TextbookSubscription.Domain.Entity;
    using TextbookSubscription.Domain.EFDbContext;
    using TextbookSubscription.Domain.IRepositories;

    public class TermRepository : Repository<Term>, ITermRepository
    {
        public TermRepository(TbMISDbContext dbContext)
            :base(dbContext)
        {

        }
    }

}
