using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NTP_Ders_H2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //değikenler slaytındyız 

            /*char cinsiyet = 'A';
             int Cinsiyet = cinsiyet;
             Console.WriteLine(Cinsiyet); // çıktı : 65 

            Console.Write("Sayı gir :  ");
            int a = System.Convert.ToInt32(Console.ReadLine());*/

            //----------------------LAB1---------------------

            //lab1 : girilen sayının üssünü alan bir uygulama yapalım.

            //Not : belirli başlı fonksiyonlar var , onları bil mesela Math sınıfı.
            // örnek sırasaıyla 10 10 artarak sinüs 360'a kadar giden fonksiyonu yaz.
            // bunu sınavda sorarsa Math sınıfının metotlarını bilmek zorundasın.

            /*double taban, us;
            Console.Write("Taban gir : ");
            taban = Convert.ToDouble(Console.ReadLine());
            Console.Write("Us gir : ");
            us = Convert.ToDouble(Console.ReadLine());

            double sonuc = Math.Pow(taban, us);

            Console.WriteLine("İşlem sonucu : {0}",sonuc);*/
            //----------------------LAB1---------------------

            //----------------------LAB2 ---------------------
            //Toplama Çıkarma ile ilgili Form uyg. messageBox ile sonuç.


            //----------------------LAB3---------------------

            /* 
            sayi1 
            sayi2 
            
            islem secimi : 
            1-topla
            2-çıkar
            3-Böl
            4-Çarp
            0- çıkış

             */





            int secim;
            int s1, s2;

            do
            {
                Console.WriteLine("iki sayı giriniz : ");
                s1 = Convert.ToInt32(Console.ReadLine());
                s2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İşlem Secimi : ");
                Console.WriteLine("1-Toplama : ");
                Console.WriteLine("2-Cikarma: ");
                Console.WriteLine("3-Bolme: ");
                Console.WriteLine("4-Carpma: ");
                Console.WriteLine("0-Exit: ");

                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("{0}+{1}={2}", s1, s2, (s1 + s2));
                        break;
                    case 2:
                        Console.WriteLine("{0}-{1}={2}", s1, s2, (s1 - s2));
                        break;
                    case 3:
                        Console.WriteLine("{0}/{1}={2}", s1, s2, (s1 / s2));
                        break;
                    case 4:
                        Console.WriteLine("{0}*{1}={2}", s1, s2, (s1 * s2));
                        break;
                    case 0:
                        Console.WriteLine("Çıkış yapıldı");
                        break;

                    default:
                        Console.WriteLine("Yanlış seçim yaptınız."); break;

                }

            } while (secim != 0);

            
        }

    }
}

