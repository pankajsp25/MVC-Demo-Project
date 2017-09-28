using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace EntityFrameWrokWithCodeFirstApproch
{
    public class Employee
    {
        public int Id { get; set; }

       
        public string Name { get; set; }

        public string Phone { get; set; }

       
        public string Gender { get; set; }


        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department department { get; set; }

        public string Addtess { get; set; }
    }
}