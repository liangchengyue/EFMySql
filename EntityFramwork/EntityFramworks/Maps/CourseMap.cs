using Core;
using System.Data.Entity.ModelConfiguration;

namespace EntityFramwork.EntityFramworks.Maps
{
    public partial class CourseMap: EntityTypeConfiguration<Course>
    {

        public CourseMap() : this("dbo")
        {

        }

        public CourseMap(string v)
        {
            ToTable("Course", v);
            HasKey(x => x.No);

            Property(x => x.Name).IsRequired();
            Property(x => x.Credit).IsRequired();

            HasOptional(a => a.Parent).WithMany(b => b.Children).HasForeignKey(c => c.ParentNo).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }
}
