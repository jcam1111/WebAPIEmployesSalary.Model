using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIEmployesSalary.Model
{
   
    public class EmployResponse
    {
        public string Status { get; set; }
        public List<EmployeeAnnualSalary> Data { get; set; }
        public string Message { get; set; }
    }
    
}
