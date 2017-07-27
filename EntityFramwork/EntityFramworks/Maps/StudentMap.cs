using Core;
using System.Data.Entity.ModelConfiguration;

namespace EntityFramwork.EntityFramworks.Maps
{
    public partial class StudentMap: EntityTypeConfiguration<Student>
    {

        public StudentMap() : this("dbo")
        {

        }

        public StudentMap(string v)
        {
            ToTable("Student", v);
            HasKey(x => x.No);

            Property(x => x.Name).IsRequired();
            Property(x => x.Gender).IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }
}
