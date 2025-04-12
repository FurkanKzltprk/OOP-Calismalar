using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NTP_Ders_H2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //bu tarzda da tanımlayabiliriz.
            //System.Int32 a = 10;

            //-----------------------------------------------------------------

            //  int b = 12;

            //  Console.WriteLine(b.GetType());  //sonuç: System.Int32

            //-----------------------------------------------------------------


            //int a = 120;
            // byte b;
            //b = a; // hata verir daha az kapasiteli değişkene dönüştürüyoruz.

            //b = (byte)a; // burada sıkıntı olmaz ama veri kaybı olur (byte (255↓))

            //int  a = 356;  
            // b = (byte)a;
            // Console.WriteLine(b); //sonuç 100 çıkar ( a - b'nin sınır sayısı = sonuç)
            // 356 - 256(sınır) 
            //-----------------------------------------------------------------

            //ToString() metoduyla Tip 

            //-----------------------------------------------------------------

            //bool a = true;
            //Console.WriteLine(a.ToString());          // çıktı : "true"

            //int sayi = 98;
            //Console.WriteLine(sayi.ToString());       // çıktı : "98"

            //float sayi2 = 98.875f;
            //Console.WriteLine(sayi2.ToString());      // çıktı : "98,875"
            //-----------------------------------------------------------------
            //Convert sınıfıyla Tür dönüşümü

            //bool b = true;
            //Console.WriteLine(System.Convert.ToString(b));

            //-----------------------------------------------------------------

            // operatörler vb.

            //int i = 50;
            //bool b1 = i is int;
            //Console.WriteLine(b1); // true çıkar

            //-----------------------------------------------------------------

            //byte b1 = 250;   // max boyutu 256 ~ işaretiyle tersini alıyoruz 
            //                 // yani kendisi(b1) + tersi(b2) = 255 olmalı
            //byte b2 = (byte)~b1;
            //Console.WriteLine(b2); // sonuç : 5  

            //-----------------------------------------------------------------

            //bitsel | ~ $  ^ operatörleri örnek kullanımı

            //byte a = 153;          //153 : 1001 1001
            //byte b = 104;          //104 : 0110 1000
            //byte x = (byte)(a | b); //veya 1111 1001
            //Console.WriteLine(x);  //sonuç :  249

            //-----------------------------------------------------------------
            //System.Random rand = new Random();
            //Console.WriteLine(rand.Next(10,100)); //10-100 arası rastgele sayı üretir.

            //-----------------------------------------------------------------

            //1-100 arası tek ve çift sayıların toplamı.

            int tekToplam = 0, ciftToplam = 0;
            for(int i =1; i <= 100; i++)
            {
                if((i%2) == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            Console.WriteLine($"Tek sayıların toplamı : {tekToplam}\nÇift sayıların toplamı : {ciftToplam}\nTüm sayıların toplamı : {tekToplam + ciftToplam}");

            

            //-----------------------------------------------------------------

        }
    }
}
