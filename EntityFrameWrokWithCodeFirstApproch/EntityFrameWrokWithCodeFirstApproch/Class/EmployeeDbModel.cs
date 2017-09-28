using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFrameWrokWithCodeFirstApproch
{
    public class EmployeeDbModel : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}