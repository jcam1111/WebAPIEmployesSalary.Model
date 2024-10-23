using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIEmployesSalary.Model
{    
    public class Employ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string ProfileImage { get; set; }

        public Employ(int id, string employeeName, decimal employeeSalary, int employeeAge, string profileImage)
        {
            Id = id;
            Name = employeeName;
            Salary = employeeSalary;
            Age = employeeAge;
            ProfileImage = profileImage;
        }
    }


}
