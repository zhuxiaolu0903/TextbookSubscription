namespace TextbookSubscription.Domain.EFDbContext
{
    using System.Data.Entity;
    using Entity;
    using EntityMapping;

    public partial class TbMISDbContext : DbContext
    {
        public TbMISDbContext()
            : base("name=TbMISDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TermMap());
        }

        public virtual DbSet<Term> Term { get; set; }
    }

}
