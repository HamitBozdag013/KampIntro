using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //new Product() ifadesi product1 için bellekte adres ve yer oluşturur.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //Yukarıdakinden farklı olarak bu şekildede ürün ekleyebiliriz
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 10 };

            //PascalCase -> Kelimelerin ilk harfleri büyük        CamelCase -> İlk kelimenin ilk harfi küçük devamındaki kelimerin ilk harfleri büyük       
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);

             
        }
    }
}
