using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Dependency_Inversion_Principle.With_DIP
{
    public class SMS:IMessenger
    {
        public int SendMessage()
        {
            // Code for Sending SMS
            return 1;
        }
    }
}
