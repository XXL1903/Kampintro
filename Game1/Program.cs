using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuyManager buyFromOnlineManager = new BuyFromOnlineManager();
            IBuyManager buyFromPhoneManager = new BuyFromPhoneManager();
            IBuyManager buyFromCreditCardManager = new BuyFromCreditCardManager();

            OdemeOncesiManager odemeOncesiManager = new OdemeOncesiManager();
            odemeOncesiManager.OdemeBasvur(buyFromPhoneManager);
        }

    }
}
