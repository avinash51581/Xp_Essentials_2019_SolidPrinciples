using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Open_Close_Principle.With_OCP
{
    public class IImageGeneration
    {
        //Method to generate Image
        public virtual bool GenerateImage(EmployeeOCP emp);
    }
}
