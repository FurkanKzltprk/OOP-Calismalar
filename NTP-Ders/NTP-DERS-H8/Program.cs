using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_DERS_H8
{

    //bir oyun içerisinde karakter sınıfı vb. KALITIM için örnek
    class Karakter
    {
        public Karakter()
        {
            Console.WriteLine("Karakter oluşturuldu");
        }
        public void HareketEt()
        {
            Console.WriteLine("KArakter hareket ediyor");
        }
        public void GeriDon()
        {
            Console.WriteLine("karakter geri döndü");
        }
    }

    class KosanKarakter : Karakter
    {
        public KosanKarakter()
        {
            Console.WriteLine("KosanKarakter Olusturuldu");


        }
        public void Kos()
        {
            Console.WriteLine("Karakter koşuyor");
        }

    }

    class UcanKarakter : Karakter 
    {
        public UcanKarakter()
        {
            Console.WriteLine("Ucan Karakter oluşturuldu");
        }

    
    }

    public class Program
    {

        static void Main(string[] args)
        {
            //Hafta7 kalıtım(2).pdf dosyasındaki örnekleri işliyor LABTA
            //teoride kalıtım,polymorphism,override,overload işledi.

            KosanKarakter k = new KosanKarakter();


        }
    }
}
