using Core;
using System.Data.Entity.ModelConfiguration;

namespace EntityFramwork.EntityFramworks.Maps
{
    public partial class SCMap: EntityTypeConfiguration<SC>
    {

        public SCMap() : this("dbo")
        {

        }

        public SCMap(string v)
        {
            ToTable("SC", v);
            HasKey(x => x.Id);
            

            HasOptional(s => s.Student).WithMany(b => b.SCs).HasForeignKey(c => c.StudentNo).WillCascadeOnDelete(false);
            HasOptional(s => s.Course).WithMany(b => b.SCs).HasForeignKey(c => c.CourseNo).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }
}
