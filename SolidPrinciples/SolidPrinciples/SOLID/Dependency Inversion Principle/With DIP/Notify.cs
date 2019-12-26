using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID.Dependency_Inversion_Principle.With_DIP
{
    public class Notify
    {
        public IMessenger messenger;

        public Notify(IMessenger _messenger)
        {
            messenger = _messenger;
        }
        //Here DI using constructor is used.
        //One can send Email/SMS using respective class implementation

        public void SendNotification()
        {
            messenger.SendMessage();
        }
    }
}
