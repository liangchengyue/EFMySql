﻿using Core;
using EntityFramwork.EntityFramworks.Maps;
using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EntityFramwork.EntityFramworks
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
   public class EFMySqlDbConText:DbContext
    {
        public virtual IDbSet<Student> Students { get; set; }
        public virtual IDbSet<Course> Courses { get; set; }
        public virtual IDbSet<SC> SCs { get; set; }
        public EFMySqlDbConText() : base("name=EFMySql")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new SCMap());
        }
    }
}
