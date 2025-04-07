using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayList_Odev
{
    public class ArrayList
    {
        
        

        private object[] items; //veri dizisi

        private int sayac; // toplamda kaç eleman var.

        public int Sayac //sayac değişkenine istenmeyen değer atanmasını engeller.
                        // kapsülleme !!
        {
            get { return sayac; }  //dışarıdan sadece okunur
        }

        public ArrayList() //kurucu metodu
        {
            items = new object[4]; //4 başlangıç değeri oto. değerş.
            sayac = 0;
        }
        private void KapasiteArttır()
        {
            if (sayac >= items.Length)
            {
                object[] newItems = new object[items.Length+1];
                for (int i = 0; i < items.Length; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
        }

        public void Add(object item)
        {
            KapasiteArttır();
            items[sayac] = item;  // dizinin sonuna ekler
            sayac++;
        }

        public void Insert(int index, object item)
        {
            if (index < 0 || index > sayac)
            {
                throw new ArgumentOutOfRangeException();
            }
            KapasiteArttır();

            for (int i = sayac; i > index; i--)
            {
                items[i] = items[i - 1];
            }
            items[index] = item;
            sayac++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= sayac)
            {
                throw new ArgumentOutOfRangeException ();

            }
            for (int i= index; i< sayac -1; i++)
            {
                items[i] = items[i + 1];
            }
            items[sayac - 1] = null;
            sayac--;
        }

        public object Get(int index) 
        {
        if(index < 0 || index >= sayac) { throw new ArgumentOutOfRangeException(); }
        return items[index];
        
        }

        public int Count
        {
            get { return sayac; }

        
        }

        public override string ToString() //ToString hazır olarak var zaten
                                          // ama ben o metodun davarnışımı değiştirmek
                                          // istiyorum ondan dolayı override ediyorum.
        {
            string sonuc = "";
            for(int i=0; i< sayac; i++)
            {
                sonuc += items[i];
                if(i < sayac - 1)
                {
                    sonuc = sonuc +  ", ";
                }
            }
            return sonuc;
        }

    }
}

