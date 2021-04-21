using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //NeedCreditManager needCreditManager = new NeedCreditManager();
            //needCreditManager.Calculate();

            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            //HouseCreditManager houseCreditManager = new HouseCreditManager();
            //houseCreditManager.Calculate();

            
            //Şimdi yukarıdaki işlemleri interface tanımlamamızı kullanarak yapalım

            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();

            ApplyManager applyManager = new ApplyManager();
            //applyManager.MakeAplication(houseCreditManager); // ( ) içinde MakeAplication a hangi krediyi gönderirsek onun hesaplamasını yapar. 

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager, vehicleCreditManager };
                                                                         //Burada ön bilgilendirmesini istediğimiz tüm krediler hesaplanır.
            applyManager.MakeCreditPreliminaryInformation(credits);
        }
    }
}
