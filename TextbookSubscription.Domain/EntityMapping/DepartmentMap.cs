using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TextbookSubscription.Domain.Entity;

namespace TextbookSubscription.Domain.EntityMapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            //Primary Key
            HasKey(d => d.DepartmentID);

            //Properties
            Property(d => d.DepartmentName).IsRequired();
            Property(d => d.Telephone).HasMaxLength(11);

            //Table && Column Mappings
            ToTable("Department", "dbo");

            //Ignore
            Ignore(t => t.ID);
        }
    }
}
