using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        public MyList() //constructor
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //önceki elemanları tutar
            items = new T[items.Length + 1]; //items dizisindeki eleman sayısının 1 fazlası kadar hafızada yeni items dizisi için yer açar.
            for(int i=0; i<tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //items dizisine önceki elemanları geri atanır.
            }

            items[items.Length - 1] = item; //items dizisine son elemanı ekledik.

        }
    }
}
