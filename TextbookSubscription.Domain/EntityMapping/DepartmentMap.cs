using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TextbookSubscription.Domain.Entity;

namespace TextbookSubscription.Domain.EntityMapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            //主键
            HasKey(t => t.DepartmentID);
            //Property(t => t.DepartmentID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //属性
            Property(t => t.DepartmentName).IsRequired();
            Property(t => t.SchoolID).IsRequired();
            Property(t => t.Telephone).HasMaxLength(11);

            //对应数据库表
            ToTable("Department", "dbo");

            Ignore(t => t.ID);
        }
    }
}
