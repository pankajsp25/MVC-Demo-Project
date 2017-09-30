using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EntityFrameWrokWithCodeFirstApproch
{
    public class EmployeeDbModel : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Login>().Map(Map => { Map.Properties(p => new { p.UserId, p.Name, p.Email, p.Password }); Map.ToTable("Login_Table"); });
            modelBuilder.Entity<Login>().Map(Map => { Map.Properties(p => new { p.UserId, p.Phone, p.Address }); Map.ToTable("Profile_Table"); });

           

                
           
            base.OnModelCreating(modelBuilder);
        }
    }
}