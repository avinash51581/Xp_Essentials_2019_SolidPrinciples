using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Dependency_Inversion_Principle.With_DIP
{
    public class Email:IMessenger
    {
        public int SendMessage()
        {
            // Code for Sending email
            return 1;
        }
    }
}
