using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Liskov_Substitution_Principle.With_LSP
{
    public class Square:Area
    {
        public int Side { get; set; }
        public override int CalculateArea()
        {
            int result = Side * Side;
            return result;
        }
    }
}
