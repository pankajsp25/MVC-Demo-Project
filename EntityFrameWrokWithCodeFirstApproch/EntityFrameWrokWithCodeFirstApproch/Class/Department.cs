﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWrokWithCodeFirstApproch
{
    public class Department
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}