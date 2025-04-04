using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Vize_Uygulama
{

    class Pasaport
    {
        public string ulkekodu;
        private int seriNo;
        private Kisi sahip;

        public Pasaport(string ulkekodu, int seriNo, Kisi sahip)
        {

            this.sahip = sahip;
            this.ulkekodu = ulkekodu;
            this.seriNo = seriNo;

        }
    }

    class Kisi
    {
        public int id;
        public string isim;
        public Pasaport psprt;

        public Kisi(string isim, int id)
        {
            this.isim = isim;
            this.id = id;

        }
    }
    class Ucus
    {
        List<Kisi> kisiler = new List<Kisi>();

        public void ekle(Kisi kisi)
        {
            if (!kisiler.Contains(kisi)) //içermiyorsa ekle 
            {
                kisiler.Add(kisi);
            }

        }

        public void YolcuListele()
        {
            foreach (Kisi k in kisiler)
            {
                Console.WriteLine(k.id + " " + k.isim + " " + k.psprt.ulkekodu);
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Kisi k1 = new Kisi("furkan",123);
                Kisi k2 = new Kisi("ahmet",1234);

                Pasaport p = new Pasaport("EN",1234,k1);
                Pasaport p1 = new Pasaport("TR",1234,k2);

                k1.psprt = p;
                k2.psprt = p1;
                Ucus u = new Ucus();
                u.ekle(k1);
                u.ekle(k2);
                u.YolcuListele();
                Console.ReadKey();  


            }




        }
    }
}
