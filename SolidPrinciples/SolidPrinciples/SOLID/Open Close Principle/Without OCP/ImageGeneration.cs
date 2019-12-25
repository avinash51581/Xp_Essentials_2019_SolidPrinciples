using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Open_Close_Principle.Without_OCP
{
    public class ImageGeneration
    {
        public string ImageType { get; set; }

        //Method to generate image(png/jpeg/gif) for an employee
        public bool GenerateEmployeeImage(Employee emp)
        {
            if (ImageType == "png")
            {
                //Generate png Image
                return true;
            }
            else if (ImageType == "jpeg")
            {
                //Generate jpeg Image
                return true;
            }
            else if (ImageType == "gif")
            {
                //Generate Gif image
                return true;
            }else{
                //Generate other type image
                return true;
            }
        }
    }
}
