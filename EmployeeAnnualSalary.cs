using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIEmployesSalary.Model
{
   
    public class EmployeeAnnualSalary : Employ
    {
        public decimal? AnnualSalary; // Cálculo del salario anual

        public EmployeeAnnualSalary(int id, string employeeName, decimal employeeSalary,
     int employeeAge, string profileImage)
            : base(id, employeeName, employeeSalary, employeeAge, profileImage)
        {
        }
    }
}
