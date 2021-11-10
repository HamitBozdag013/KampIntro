using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // böyle
            Customer customer1 = new Customer() { Id = 1, FirstName = "Hamit", LastName = "Bozdağ", City = "Manisa" };

            // yada böyle
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Merve";
            customer2.LastName = "Bozdağ";
            customer2.City = "Ankara";
            // yazılabilir


            Customer customer3 = new Customer(3, "Erva", "Bozdağ", "Van");

            Console.WriteLine(customer3.FirstName);

        }
    }


    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Parametresizler için defalt constructor çalıştı");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Parametreliler için consturctor çalıştı");

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }

}
