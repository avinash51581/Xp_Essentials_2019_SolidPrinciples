using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Single_Responsibility_Principle.Without_SRP
{
    public class Employee
    {
        public int EmloyeeId { get; set; }
        public string EmployeeName { get; set; }

        //Method to insert employee details
        public bool InsertEmployeeDetails(Employee emp)
        {
            return true;
        }

        //Method to generate image(png/jpeg/gif) for an employee
        public bool GenerateEmployeeImage(Employee emp)
        {
            return true;
        }
    }
}
