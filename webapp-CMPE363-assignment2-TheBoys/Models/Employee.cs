using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webapp_CMPE363_assignment2_TheBoys.Models
{
    public class Employee
    {
        [Key]
        public Guid EmpId { get; set; }

        public string EmpName { get; set; }
        public string EmpSurname { get; set; }
        public string EmpAddress { get; set; }
        public string EmpPhone { get; set; }
    }
}