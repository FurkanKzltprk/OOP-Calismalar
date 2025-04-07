using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();


            list.Add("kiraz");
            list.Add("portakal");
            list.Add(42);
            list.Add(true);
            //normalde 4 taneydi 5.si eklenince KapasiteArttır() metodu çalıştı.
            list.Add("Karpuz");

            Console.WriteLine("Liste içeriği (Add sonrası): "+list.ToString());
            Console.WriteLine("Liste uzunluğu :" + list.Count);

            // insert testi
            list.Insert(2, "Muz");
            Console.WriteLine("Insert sonrasi liste : " + list.ToString());

            //get testi
            Console.WriteLine("3.indeksin elemanı :" +list.Get(3));

            //removeAt testi

            list.RemoveAt(2);
            Console.WriteLine("RemoveAt sonrası liste : "+ list.ToString());

            //Çoklu insert ve remove testleri

            list.Insert(0, "baş");
            list.RemoveAt(4);
            Console.WriteLine("Çoklu işlemler sonrası liste : " + list.ToString());



            

        }
    }
}
