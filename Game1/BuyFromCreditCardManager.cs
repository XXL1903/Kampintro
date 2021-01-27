using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class BuyFromCreditCardManager : IBuyManager
    {
        public void Ode()
        {
            Console.WriteLine("Kredi Kartından Ödeme Alındı");
        }
    }
}
