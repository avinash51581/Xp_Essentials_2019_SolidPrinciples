using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Single_Responsibility_Principle.With_SRP
{
    public class EmployeeSRP
    {
        public int EmloyeeId { get; set; }
        public string EmployeeName { get; set; }

        //Method to insert employee details
        public bool InsertEmployeeDetails(EmployeeSRP emp)
        {
            return true;
        }
    }
}
