using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Dependency_Inversion_Principle.Without_DIP
{
    public class Email
    {
        public int SendMessage()
        {
            return 1;
        }
    }

    public class Notify
    {
        private Email email;
        public Notify()
        {
            email = new Email();
        }

        //Here Notify class is totally depends on Email class,as we can only send Email only...
        //if we want to send SMS we need to modify Email class

        public void SendNotification()
        {
            email.SendMessage();
        }
        
    }
}
