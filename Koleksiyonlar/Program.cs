using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Hamit", "Merve", "Erva" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            ////yukarıdaki isimler dizisini genişleterek bir eleman daha eklemeye çalışıyoruz.

            //isimler = new string[4]; // Fakat burada yaptığımız aslında bellekte isimler dizisi için tekrar 4 elemanlık bir yer açmak oluyor.
            //isimler[3] = "Fahrettin"; // Bu eklemiş olduğumuz eleman aslında yukarıdaki isimler dizisine değil bu yeni isimler dizisine ekleniyor.
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]);// Bu satırın sonucunda biz ekrana Hamit yazmasını beklerken yeni isimler dizisinin 0 ıncı indisi boş olduğu için ekranda sonucu boş dönüyor.



            //************BUNDAN SONRASI BENİM İÇİN ÇOK ÖNEMLİ********************
            /*Gerçek hayatta programlar yazarken array-dizilerde genişletme ve elaman sayısı arttırılamadığı için ve
            bu şekilde sıkıntılar yaşadığımız için biz bundan sonra collections-koleksiyonları kullanacağız. */

            List<string> isimler2 = new List<string> { "Hamit", "Merve", "Erva" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Fahrettin");
            isimler2.Add("Ali");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
