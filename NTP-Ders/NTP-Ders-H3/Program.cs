using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ders_H3
{
    public class Program
    {
        static int toplaort(int[] d, out double ort)//3.uygulamada kullanılan metot.
        {

            int top = 0;
            foreach (int eleman in d)
            {
                top = top + eleman;
            }
            ort = top / (double)(d.Length);

            return top;

        }
        static void yazdir (params int[] d) //3.uygulamada kullanılan metot2.
        {
            if(d.Length == 0)
            {
                Console.WriteLine("dizi boş");
            }
            else
            {
                foreach(int x in d){
                    Console.WriteLine(x);
                }
            }
        }

        static void Main(string[] args)
        {
            // 3.HAFTA  teori dersindeki örnekler

            /* ArrayList dizi = new ArrayList();
             dizi.Add(5);
             dizi.Add("deneme"); //veri türü ayrımı yok
             dizi.Insert(1, "arada");
             dizi.Add(3.8);
             for (int i = 0; i < dizi.Count; i++)
             {
                 Console.WriteLine(dizi[i]);
             }

             Console.WriteLine(dizi.Contains("deneme"));
             Console.WriteLine(dizi.IndexOf(3.8));
             dizi.Remove("deneme"); //deneme yi ilk gördüğü yerde siler
             dizi.RemoveAt(0);      // burada 0. indistekini siler
             dizi.Clear();  // tüm elemanları temizler.*/

            //-------------------------------------------------------------

            //basit bir liste oluşturup bu listenin elemanları üzerinde işlemler yapma.

            /* int[] dizi = { 1, 3, 5 };

             List<int> d = new List<int>(dizi); // böyle boş tanımlar → içine dizi koyuldu
             Console.WriteLine(d.Count);
             d.Append(5);  // en sona ekliyor
             d.Insert(0, 2); //indise göre değeri ekliyor
             foreach (int i in d)
             {
                 Console.WriteLine(i);
             }

             Console.WriteLine(d.Count);
             Console.WriteLine(d.IndexOf(5));
             Console.WriteLine(d.LastIndexOf(5));*/
            //-------------------------------------------------------------

            //--------------------3.Uygulama-------------------------------

            // ref ve out kullanımına dikkat et ‼

            int[] d = { 1, 3, 5, 7, 8, 10, 13 };
            double o;
            int t = toplaort(d, out o);
            Console.WriteLine("Toplam{0} ve ort : {1}" + " olur.", t, o);

            yazdir();
            yazdir(1, 3, 4);
            yazdir(6);
            

        }
    }
}
