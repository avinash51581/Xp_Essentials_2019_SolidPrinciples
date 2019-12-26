using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Liskov_Substitution_Principle.Without_LSP
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    public class Square : Rectangle
    {
        public int _Width;
        public int _Height;

        public override int Width
        {
	        get { 
		            return _Width;
                }
	        set 
	            { 
		            _Width = value;
	            }
        }

        public override int Height
        {
            get
            {
                return _Height;
            }
            set
            {
                _Height = value;
            }
        }
    }


    public class PermanentEmployee : Rectangle
    {
        public override string GetProjectDetails(int EmployeeId)
        {
            return "";
        }

        public override string GetEmployeeDetails(int EmployeeId)
        {
            return "";
        }
    }

}
