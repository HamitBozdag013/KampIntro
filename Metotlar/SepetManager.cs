using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, " + urun.Adi + " Sepete eklendi. Fiyatı: " + urun.Fiyati);
        }
    }
}
