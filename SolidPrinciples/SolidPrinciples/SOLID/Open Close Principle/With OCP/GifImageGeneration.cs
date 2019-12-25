using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Open_Close_Principle.With_OCP
{
    public class GifImageGeneration:IImageGeneration
    {
        //Method to generate gif Image
        public override bool GenerateImage(EmployeeOCP emp)
        {
            return true;
        }
    }
}
