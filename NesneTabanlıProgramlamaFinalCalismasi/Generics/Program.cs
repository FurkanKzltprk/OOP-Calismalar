using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{

    class Depo<T>
    {
        private T veri;

        public void Kaydet(T data)
        {

            veri = data;

        }

        public T Getir()
        {
            return veri;
        }
        public void Yazdir<T>(T veri)
        {
            Console.WriteLine(veri);
        }
    }
    class merhaba
    {

        public void Yazdir<T>(T veri)
        {

            Console.WriteLine(veri);
        }
    }

    class Kütüphane<T>
    {
        public void Yazdir<U>(U veri)
        {
            Console.WriteLine(veri);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler = new List<string> { "Ali", "Ayşe", "Mehmet", "Zeynep", "Murat" };

            var eGecenler = isimler.FindAll(s => s.Contains("e"));
            Console.WriteLine("E harfi içerenler");

            foreach (var e in eGecenler) { Console.WriteLine(e); }

            isimler.Sort();
            Console.WriteLine("Alfabetik sıralama");
            foreach (var e in isimler) { Console.WriteLine(e); }














































            //List<int> a = new List<int>();

            //a.Add(1);
            //a.Add(2);
            //a.Add(4);
            //a.Add(6);

            //foreach (int i in a)
            //{
            //    Console.WriteLine(i);
            //}
            //a.Remove(4);
            //Console.WriteLine("****************");
            //Console.WriteLine("****************");
            //foreach (int i in a)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("**************************");
            //Console.WriteLine("**************************");


            //Kütüphane<int> s = new Kütüphane<int>();

            //s.Yazdir<int>(125);
            //s.Yazdir<string>("Furkan");



            //Console.WriteLine("**************************");
            //Console.WriteLine("**************************");


            //var intDepo = new Depo<int>();
            //intDepo.Kaydet(100);
            //Console.WriteLine(intDepo.Getir()); //çıktı: 100

            //var stringDepo = new Depo<string>();
            //stringDepo.Kaydet("Furkan");
            //Console.WriteLine(stringDepo.Getir()); //çıktı : Furkan

            ////kendi koleksiyonumuzu yazdık ayrıca metotlarını da yazdık
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            ////Karışık tipli veri yönetimi 
            //Dictionary<int, string> ogrenciSozluk = new Dictionary<int, string>();

            //ogrenciSozluk.Add(1, "Furkan");
            //ogrenciSozluk.Add(2, "Ahmet");

            //Console.WriteLine(ogrenciSozluk[1]);
            //Console.WriteLine(ogrenciSozluk[2]);

            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            ////kendi generic metodunu yazma ve kullanma

            //merhaba m = new merhaba();
            //m.Yazdir<int>(100);


            //List<int> sayilar = new List<int>();

            //sayilar.Add(12);
            //sayilar.Add(24);
            //sayilar.Add(99);
            //sayilar.Add(75);
            //sayilar.Add(45);
            ////sayilar.Remove(12);

            //List<string> isimler = new List<string>();

            //isimler.Add("ayşe");
            //isimler.Add("Furkan");
            //isimler.Add("Elif");
            //isimler.Add("Ahmet");

            //isimler.Remove("Furkan");
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine($"isimler : {isim}");

            //}


            //var maxSayi = sayilar.Max();
            //Console.WriteLine($"En büyük sayi : {maxSayi}");

            //Console.WriteLine($"Eleman sayisi : {sayilar.Count}");


            //Console.WriteLine("Liste elemanları :");
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}


            //List<int> sayilar = new List<int> { 10, 5, 20, 15 };
            //sayilar.Sort();
            //Console.WriteLine("Sirali sayilar");
            //foreach (int i in sayilar)
            //{
            //    Console.WriteLine(i);


            //}

            //List<int> ciftSayilar = sayilar.FindAll(s => s % 2 == 0);

            //Console.WriteLine("Çift sayilar");
            //foreach (int i in ciftSayilar)
            //{
            //    Console.WriteLine(i);

            //}

            //List<int> rastgeleSayilar = new List<int> { 4, 62, 54, 2, 54, 7, 9, 77, 33, 60 };

            //var ondanBuyuk = rastgeleSayilar.FindAll(s => s > 10);
            //Console.WriteLine("greater than 10");

            //foreach(int i in ondanBuyuk) { Console.WriteLine(i); }















        }
    }
}
