using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //Console.WriteLine(sayi1); // ekranda 30 yazar

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // Console.WriteLine(sayilar1[0]); //ekranda 999 yazar

            /*Önemli!!
            int, double, float, bool, decimal... --> value-değer tip yani sadece değer odaklı
            array, class, interface... --> referans tip yani adres odaklı
            olarak çalışırlar.. */


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Hamit";
            person2 = person1;
            person1.FirstName = "Fahrettin";
           // Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Merve";

            Employee employee = new Employee();
            employee.FirstName = "Erva";


            Person person3 = customer;
            // Console.WriteLine(person3.FirstName);


            //customer = employee; // Hata verir çünkü birbrinin mirasçısı değiller ve farklı classlar

            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);
            //Aşağıdaki public void Add(Person person) yazdığımız için Person ve Person ın mirsacısı olan tüm class için kullanabiliyoruz.

        }

        class Person // base class
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        //base class Person - ebeveyn clas Person
        class Customer : Person //Person class ından miras aldık
        {
            public string CreditCardNumber { get; set; }
        }

        //base class Person - ebeveyn clas Person
        class Employee : Person //Person class ından miras aldık
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {           
            //public void Add(Customer customer) { } // yazarsam sadece Customer classına ekleme yapabilirim.
            //public void Add(Employee employee) { } // yazarsam sadece Employee classına ekleme yapabilrim.
         
            public void Add(Person person) // Hem Person hem Customer hem de Employee claslarına ekleme yapabilirim.
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
