using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTP_Ders9_I.Senaryo2;

namespace NTP_Ders9_I
{
    internal class Program
    {

        interface IHayvan
        {
            void sesCikar(); //gövdesiz metot

        }


        class Kedi : IHayvan
        {
            public void sesCikar()
            {
                Console.WriteLine("meow");
            }
        }

        class Kopek : IHayvan
        {
            public void sesCikar()

            {
                Console.WriteLine("Onlar arkadan havlar lar lar lar hav hav hav");

            }

        }

     

        static void Main(string[] args)
        {



            //Kedi kedi = new Kedi();
            //kedi.sesCikar();

            //IHayvan hayvan = new Kopek();
            //hayvan.sesCikar();

            Mudur m = new Mudur();
            Console.WriteLine( m.Calis());
            Ogretmen ogr = new Ogretmen();
            Console.WriteLine(ogr.Calis()); 
            Satisci st = new Satisci();
            Console.WriteLine(st.Calis());
            Console.WriteLine("************************");
            Console.WriteLine("************************");
            Mudur2 m2 = new Mudur2();
            Console.WriteLine(m2.Calis());
            Ogretmen2 ogr2 = new Ogretmen2();
            Console.WriteLine(ogr2.Calis());
            Satisci2 st2 = new Satisci2();
            Console.WriteLine(st2.Calis());

            Console.WriteLine("************************");

            m2.isim = "2.Müdür";
            Console.WriteLine(m2.BilgiGoster());
            ogr2.isim = "2.Ogretmen";
            Console.WriteLine(ogr2.BilgiGoster());
            st2.isim = "2.Satisci";
            Console.WriteLine(st2.BilgiGoster());

            Console.WriteLine("************************");
            Console.WriteLine("************************");




        }
    }
}
