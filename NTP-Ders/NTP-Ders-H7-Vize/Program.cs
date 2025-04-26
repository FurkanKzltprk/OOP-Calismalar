using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ders_H7_Vize
{
    internal class Program
    {   

        //                    0        1      2     3   4    5
        //enum notu :  byte {basarisiz,gecmez,gecer,orta,iyi,pekiyi } //enum buraya yazılır
        enum renkler : byte { Siyah,Beyaz,Kırmızı,Mavi,Sarı}


        static void Main(string[] args)
        {
            //int sayi = 20;
            //string str = sayi.ToString("X");
            //Console.WriteLine(str);

            //Console.WriteLine("Açı\tSinüs");

            //for (int derece = 0; derece <= 360; derece += 10)
            //{
            //    double radyan = derece * Math.PI / 180; // Dereceyi radyana çevir
            //    double sinus = Math.Sin(radyan); // Radyan cinsinden sinüs hesapla

            //    Console.WriteLine($"{derece}\t{sinus:F4}"); // 4 basamaklı yuvarlama
            //}

            //Console.WriteLine("\\"); // kaçış karakteri içerir. sonuç : \ (bir tane çıkar)

            //Console.WriteLine("Lütfen notunuzu giriniz : (1-10)");
            //notu a = (notu)Convert.ToByte(Console.ReadLine());
            //Console.WriteLine(a); 

            renkler b = (renkler)1;
            Console.WriteLine(b + ", "+ (byte)b);  //sonuç : Beyaz, 1


        }
    }
}
