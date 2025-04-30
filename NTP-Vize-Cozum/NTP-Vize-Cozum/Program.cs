using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Vize_Cozum
{

    class Hali
    {


        private int alan;

        public int Alan
        {
            get { return AlanHesapla(); }
        }

        public int Genislik { get; set; }
        public int Uzunluk { get; set; }

        public int AlanHesapla()
        {
            return Uzunluk * Genislik;
        }

        public Hali(int genislik, int uzunluk)
        {
            Genislik = genislik;
            Uzunluk = uzunluk;

            AlanHesapla();
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //soru2
            Hali halim = new Hali(5, 10); // 5 genişlik, 10 uzunluk
                                          // veya
            Hali halim2 = new Hali(0, 0);
            halim2.Genislik = 3;
            halim2.Uzunluk = 4;
            halim2.AlanHesapla();
            int alanDegeri = halim2.Alan;
            Console.WriteLine(halim.Alan);

            Console.WriteLine(halim2.Alan);

        }
    }
}
