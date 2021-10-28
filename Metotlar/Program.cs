using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string urunAdi = "Elma";
            double fiyati = 2.5;
            string aciklama = "Amasya elması";

            Class kullanmadığım zaman her bir ürün için yukarıdaki gibi tek tek tanımlama yapmam gerekir...
            */

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 2;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 1.5;
            urun2.Aciklama = "Diyarbakır karpuzu";
             
            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı: " + urun.Adi);
                Console.WriteLine("Ürünün Fiyatı: " + urun.Fiyati + "TL");
                Console.WriteLine("Ürün Açıklaması: " + urun.Aciklama);
                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine("----------Metotlar---------------");

            //instance - örnek
            //encapsulation - kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);





        }
    }
}
