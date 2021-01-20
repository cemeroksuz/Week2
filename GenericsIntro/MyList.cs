using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T>
    {
        T[] items;
        
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //geçici Dizi - dizinin referans numarasını tutmak için
            T[] tempArray = items;
            //items'ın boyutunun 1 büyütülmesi (add ile gelen eleman için yer açıyoruz)
            items = new T[items.Length + 1];
            //geçici dizideki elemanların items'e aktarılması
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //add ile gelen eleman items'in yeni açılan alanına yerleşiyor.
            items[items.Length - 1] = item;
            
            

        }
    }
}
