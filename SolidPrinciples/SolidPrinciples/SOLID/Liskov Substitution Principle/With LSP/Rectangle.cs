using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Liskov_Substitution_Principle.With_LSP
{
    public class Rectangle:Area
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override int CalculateArea()
        {
            int result = Height * Width;
            return result;
        }
    }
}
