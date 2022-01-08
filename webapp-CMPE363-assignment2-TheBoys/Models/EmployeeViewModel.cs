using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapp_CMPE363_assignment2_TheBoys.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }
    }
}