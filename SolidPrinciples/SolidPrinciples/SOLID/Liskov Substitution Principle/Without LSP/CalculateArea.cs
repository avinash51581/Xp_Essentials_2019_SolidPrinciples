using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Liskov_Substitution_Principle.Without_LSP
{
    public class CalculateArea
    {
        public int CalculateRectangleArea(Rectangle rect)
        {
            int result = rect.Height * rect.Width;
            return result;
        }
        public int CalculateSquareArea(Square sqr)
        {
            int result = sqr.Height * sqr.Width;
            return result;
        }
    }
}
