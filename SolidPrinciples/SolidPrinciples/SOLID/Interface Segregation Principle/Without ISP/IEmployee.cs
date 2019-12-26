using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Interface_Segregation_Principle.Without_ISP
{
    public interface IEmployee
    {
        bool InsertEmployeeDetails();
        bool DeleteEmployeeDetails();
        bool GeneratePngImage();
        bool GenerateGifImage();
    }
}
