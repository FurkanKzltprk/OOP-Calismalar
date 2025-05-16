using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        }
    }
}
