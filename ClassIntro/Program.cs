﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Hamit Bozdag";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Mahmut Imre";
            kurs3.IzlenmeOrani = 72;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursunEgitmeni = "Gökhan Tanrıöver";
            kurs4.IzlenmeOrani = 98;

            // Console.WriteLine(kurs1.KursAdi + "  " + kurs1.KursunEgitmeni);

            //Array - Dizi kullanarak dinamikleştirelim

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar) //var yerine Kurs ta yazabiliriz.
            {
                Console.WriteLine(kurs.KursAdi + " --> " + kurs.KursunEgitmeni);
            }

        }
    }

    class Kurs
    {
        // prop yazıp 2 kere tab a bastığımızda aşağıdaki gibi özellik(property) oluşur

        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }



    }
}
