using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayList_Sinifi
{
    internal class ArrayList
    {
        private object[] items; //priavte tanımladım , dışarıdan erişilemez (encapsulation)
        private int sayac;      //eleman sayısını gösteren sayac

        public ArrayList() //kurucu metot
        {
            items = new object[4]; //varsayılan olarak başlangıç kapasitesi 4
            sayac = 0; 
            
        }

        public int Sayac => sayac;  //read-only(set yok get var) property tanımlamanın kısa yolu "=>"





        //kapasite kontrolü için bir metot daha gerekiyor 

        public void KapasiteArttır()
        {
            object[] yeniDizi = new object[items.Length*2]; //2 katına çıkarttık "Dinamik" olarak artıyor.
            for (int i = 0; i < items.Length; i++)
            {
                yeniDizi[i] = items[i];

                /* burada bir çeşit kopyalama yaptık , önceki dizinin
                2 katı kapasitede dizi oluşturup önceki dizinin elemanlarını
                yeni diziye attık*/
            }
            items = yeniDizi;


        }
        public void Add(object item)
        {
             //sona öge eklenir.
             if(sayac == items.Length)
            {
                KapasiteArttır();
            }
            items[sayac++] = item;  //önce kullan sonra değerini bir arttır.
            //sayac++; ↑↑↑ bunu yazacağımıza yukarıda ++ yapabiliriz daha hoş olur (post-increment)
                                  //yeni eleman eklediğimiz için sayac değerini 1 arttır. 

        }

        public void Insert(int index , object item) /*Belirtilen indexe elemanı ekler ondan sonraki tüm
                                                     elemanları sağa kaydırır */
        {
            if(index < 0 || index > sayac)
            {
                Console.WriteLine("Hata geçersiz index girdiniz !!! ");
                return;
            }
            if(sayac == items.Length)
            {
                KapasiteArttır();  // dizi tamamen doluysa yeni bir şey eklemek için kapasite artmalı.

            }
            for(int i = sayac; i> index; i--)
            {
                items[i] = items[i-1];
            }
            items[index] = item;
            sayac++;

        }

        public void RemoveAt(int index) /*Belirtilen indexteki elemanı siler
                                         sonraki tüm elemanları sola kaydırır sayac--; */
        {

            if(index<0 || index > sayac)
            {
                Console.WriteLine("Hata : geçersiz index");
                return ;
            }
            //elemanları sola kaydırma
            for (int i = index; i<sayac;i++)
            {
                items[i] = items[i + 1];
            }
            items[sayac - 1] = null; //son elemanı da temizlemek lazım
            sayac--;


        }

        public object Get(int index) // geri dönüş değeri object get ile object istiyoruz çünkü.
        {
            if (index < 0 || index >= sayac)
            {
                Console.WriteLine("Hata : geçersiz indeks");
                return null;
            }
            return items[index];

        }

        
        public int Count //burada "()" yok dikkat et propert olarak alıyoruz ☻☺♥.
        {
            get {  return sayac; }

        }
        public int Count2()  //bu metot hali propery'li de olur 
        {

            return sayac;
        }


        public override string ToString() //ToString hazrıda olduğu için override edip öyle yaptım
                                
        {
            if(sayac == 0)
            {
                return "Liste boş";
            }

            string sonuc = "";
            for(int i = 0; i < sayac; i++)
            {
                sonuc += items[i];

                if(i < sayac - 1)
                {
                    sonuc += ", ";
                }
            }


            return sonuc;
        }

    }
}
