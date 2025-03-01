using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGiris
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Hayvan hayvan = new Hayvan("Hayvan");
             hayvan.konus();

             Hayvan kedi = new Kedi("maya"); // buraya dikkat
             kedi.konus();                   // Hayvan sınıfından kedi nesnesi 
                                             // Kedi sınıfınını consturctoruna !!!

             Kopek kopek = new Kopek("karabaş");
             kopek.konus();

             Console.ReadLine();*/


            HayvanlariKonustur(new Kedi("minnoş"));  //farklı bir yaklaşım
            HayvanlariKonustur(new Kopek("Karabaş"));

            Console.ReadLine();
        }
        public static void HayvanlariKonustur(Hayvan hayvan) 
        //bir tip tüm tipler gibi davranabildiği 
        //hepsini tek bir metot parametresi olarak alabiliyor.   
        {
            hayvan.konus();
        }
    }
}
