using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class BuyFromPhoneManager : IBuyManager
    {
        public void Ode()
        {
            Console.WriteLine("Telefondan Ödeme Alındı.");
        }
    }
}
