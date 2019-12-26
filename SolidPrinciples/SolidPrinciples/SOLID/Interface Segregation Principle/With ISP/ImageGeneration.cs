using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Interface_Segregation_Principle.With_ISP
{
    public class ImageGeneration:IImageGeneration
    {
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
