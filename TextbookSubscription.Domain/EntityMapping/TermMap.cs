using System.Data.Entity.ModelConfiguration;
using TextbookSubscription.Domain.Entity;

namespace TextbookSubscription.Domain.EntityMapping
{
    public class TermMap : EntityTypeConfiguration<Term>
    {
        public TermMap()
        {
            //Primary Key
            HasKey(t => t.TermNum);

            //Properties
            Property(t => t.IsCurrentTerm)
                .HasMaxLength(1);

            //Table && Column Mappings
            ToTable("Term", "dbo");
            Property(t => t.TermName).HasColumnName("Term");
        }
    }
}
