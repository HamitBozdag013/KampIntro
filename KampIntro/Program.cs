using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "C# Kursu", "Pyton Kursu", "C++ Kursu", "java Kursu" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n For dongusu burada bitiyor.. \n");

            //foreach dongusu dizilerde, dizi elemanlarını daha rahat gezmek için kullanılır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
