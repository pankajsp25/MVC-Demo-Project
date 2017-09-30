using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameWrokWithCodeFirstApproch
{
    public class EmpDbContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDbModel>
    {
        protected override void Seed(EmployeeDbModel context)
        {
            Department d1 = new Department()
            {
                DepartmentName = "Dep1",
                Employees = new List<Employee>()
                {

                    new Employee()
                    {
                        Name="Emp1",
                        Addtess="aaa",
                        Phone="564556",
                        Gender="Male"

                    },
                    new Employee()
                    {
                        Name="Emp2",
                        Addtess="aaa",
                        Phone="564556",
                        Gender="Male"

                    }
                }

            };

            Department d2 = new Department()
            {
                DepartmentName = "Dep1",
                Employees = new List<Employee>()
                {

                    new Employee()
                    {
                        Name="Emp1",
                        Addtess="aaa",
                        Phone="564556",
                        Gender="Male"

                    },
                    new Employee()
                    {
                        Name="Emp2",
                        Addtess="aaa",
                        Phone="564556",
                        Gender="Male"

                    }
                }

            };
            Department d3 = new Department()
            {
                DepartmentName = "Dep1",
                Employees = new List<Employee>()
                {

                    new Employee()
                    {
                        Name="Emp1",
                        Addtess="aaa",
                        Phone="564556",
                        Gender="Male"

                    },
                    new Employee()
                    {
                        Name="Emp2",
                        Addtess="aaa",
                        Phone="564556",
                        Gender="Male"

                    }
                }

            };

            context.Departments.Add(d1);
            context.Departments.Add(d2);
            context.Departments.Add(d3);
            base.Seed(context);
        }
    }
}