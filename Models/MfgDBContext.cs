using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class MfgDBContext : DbContext
    {
        public MfgDBContext()
            : base("name=MfgDBEntities")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MfgDBContext, WebTez.Migrations.Configuration>("MfgDBEntities"));
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Facultie> Facultie { get; set; }
        public DbSet<InternshipInformation> InternshipInformation { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<ResponsiblePerson> ResponsiblePerson { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Universitiy> Universitiy { get; set; }
        public DbSet<WorkingInformation> WorkingInformation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}