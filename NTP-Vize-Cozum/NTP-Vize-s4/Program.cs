using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Vize_s4
{

    public class Kitap
    {
        public int Numara { get; set; }
        public string Ad { get; set; }

        public Kitap(int numara, string ad)
        {
            Numara = numara;
            Ad = ad;
        }

        public override string ToString()
        {
            return $"Kitap No : {Numara},Ad : {Ad}";


        }

    }


    public class Raf
    {
        public List<Kitap> kitaplar = new List<Kitap>();
        //List<Kitap> kitaplar {  get; set; } 
        public Raf()
        {
            kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }
    }


    public class Oda
    {

        public List<Raf> raflar = new List<Raf>();

        public Oda()
        {
            raflar = new List<Raf>();

        }
        public void RafEkle(Raf raf)
        {
            raflar.Add(raf);

        }
    }


    public class Bina
    {
        public List<Oda> odalar = new List<Oda>();

        public Bina()
        {
            odalar = new List<Oda>();
        }

        public void OdaEkle(Oda oda)
        {
            odalar.Add(oda);

        }


        public void TumKitaplarListele()
        {

            foreach (var oda in odalar)
            {
                foreach (var raf in oda.raflar)
                {
                    foreach (var kitap in raf.kitaplar)
                    {
                        Console.WriteLine(kitap);
                    }

                }
            }

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Kitap k1 = new Kitap(1, "Sefiller");
            Kitap k2 = new Kitap(2, "Suç ve Ceza");
            Kitap k3 = new Kitap(3, "Suç ");
            Kitap k4 = new Kitap(4, "Dil risalesi");
            Kitap k5 = new Kitap(5, "Yabancı");
            Kitap k6 = new Kitap(6, "İrade terbiyesi");

            Raf raf1 = new Raf();
            raf1.KitapEkle(k1);
            raf1.KitapEkle(k2);
            raf1.KitapEkle(k3);

            Raf raf2 = new Raf();

            raf2.KitapEkle(k4);
            raf2.KitapEkle(k5);
            raf2.KitapEkle(k6);

            Oda oda1 = new Oda();
            oda1.RafEkle(raf1);
            oda1.RafEkle(raf2);

            Bina bina = new Bina();
            bina.OdaEkle(oda1);

            Console.WriteLine("****************************");
            bina.TumKitaplarListele();

            Console.ReadLine();


        }
    }
}










