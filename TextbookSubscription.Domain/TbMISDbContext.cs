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
            modelBuilder.Configurations.Add(new ProfessionalClassMap());
            modelBuilder.Configurations.Add(new SchoolMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
        }

        public virtual DbSet<Term> Term { get; set; }
        public virtual DbSet<ProfessionalClass> ProfessionalClass {get;set;}
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Department> Department { get; set; }
    }

}
