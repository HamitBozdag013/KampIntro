using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //İlk Bireysel Müşteriyi oluşturalım.
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "36050978";
            customer1.FirstName = "Hamit";
            customer1.LastName = "Bozdağ";
            customer1.IdentificationNumber = "52516400508";

            //İlk Tüzel Müşteriyi oluşturalım.
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "78956214";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "14752368";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            //Burada Customer Class'ı hem IndividualCustomer Class ının hem de CorporateCustomer Class ının referansını tutabilmektedir.

            //Bu yüzden CustomerManager class ına hem IndividualCustomer Class ının hem de CorporateCustomer Class ının nesnelerini gönderebilriz. Buna Polymorphism denir.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
