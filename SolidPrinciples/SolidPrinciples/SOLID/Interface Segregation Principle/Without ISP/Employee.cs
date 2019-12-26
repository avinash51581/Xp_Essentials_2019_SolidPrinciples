using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Interface_Segregation_Principle.Without_ISP
{
    public class Employee:IEmployee
    {
        public bool InsertEmployeeDetails()
        {
            return true;
        }

        public bool DeleteEmployeeDetails()
        {
            return true;
        }

        public bool GeneratePngImage()
        {
            return true;
        }

        public bool GenerateGifImage()
        {
            return true;
        }

    }
}
