using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_DERS_H3_Lab
{
    internal class Program
    {
        //14 mart lab konu : params


        /* static int Topla(int[] dizi, out double ort)
         {
             int toplam = 0;
             foreach (int sayi in dizi)
             {
                 toplam += sayi;
             }
             ort = (double)toplam / dizi.Length;
             return toplam;

             // return toplam , ort; böyle bir kullanım olmuyor "out" ile yapılıyor.
         }

         static void yaz(int[] dizi)
         {
             foreach (object i in dizi)
             {
                 Console.Write(i + " \t");
             }
             Console.WriteLine();


         }

         static void Satınal(int id, int urunid)

         {
             Console.WriteLine("metod 1 çalıştırıldı");

         }
         static void Satınal(int id,  params int [] urunid)
             //params kullandık aynı metodu overload ettik aynı isimde 
             // ama parametre sayısı baya arttı
         {
             Console.WriteLine("diğer metod çalıştırıldı");
         }*/


        static void Main(string[] args)
        {

            /*int[] dizi = { 1, 3, 4, 5, 6, 10, 5 };
            yaz(dizi);
            double ort;
            int toplam = Topla(dizi, out ort);
            Console.WriteLine("Toplam : {0} ", toplam);
            Console.WriteLine("Ortalama: {0} ", ort);

            Satınal(5, 10,15);
            Satınal(5, 10);*/


            //----------Dosya işlemleri Yazma-----------

            /*int x = 0;

            try
            {
                //dosyaya yazma
                StreamWriter sw = new StreamWriter("D:\\Text.txt");
                for(x=0; x <= 10; x++)
                {
                    sw.Write(x+", "); 
                }
                sw.Close();
            }
            catch (Exception e)
            {

            }
            Console.WriteLine("işlem bitti");*/
            //----------Dosya işlemleri Okuma-----------

            //benzerleri istenebilir

            Int64 x;
            string path1 = "D:\\Text.txt";
            try
            {
                StreamReader sr = new StreamReader(path1);
                string line = sr.ReadLine();    

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();

                }
                sr.Close();
                Console.ReadLine();

            }
            catch (Exception)
            {


            }
            Console.WriteLine("işlem tamamlandı");


        }

    }
}
