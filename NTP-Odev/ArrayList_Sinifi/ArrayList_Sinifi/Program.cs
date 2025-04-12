using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Sinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            l.Add("Elma");
            l.Add(true);
            l.Add(false);
            l.Add(15);//4.
            l.Add(4.2); //5. bu eklendiği zaman kapasite de arttı otomatik
            l.Add("Furkan");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Add metodu kullanımı sonrası");
            Console.WriteLine(l.ToString()); //toString() override edilmişti

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Insert testi");
            l.Insert(2, "Portakal");
            Console.WriteLine("Insert(2, \"Portakal\") sonrası:");
            Console.WriteLine(l);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("RemoveAt testi");
            // RemoveAt testi
            l.RemoveAt(1);
            Console.WriteLine("RemoveAt(1) sonrası:");
            Console.WriteLine(l);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            // Get testi
            object eleman = l.Get(2);
            Console.WriteLine("Get(2): " + eleman);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // Count testi (property olan)
            Console.WriteLine("Eleman Sayısı (Count): " + l.Count);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            // Count2 metodu testi
            Console.WriteLine("Eleman Sayısı (Count2 metodu): " + l.Count2());


            Console.ReadKey();  // Konsol kapanmasın diye





        }
    }
}
