using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<string> meyveler = new List<string>
            {
                "Elma","Armut","kivi","aa","Ananas","Erik","Muz"


            };
            var aIcerenler = meyveler.Where(m => m.ToLower().Contains("a"));

            var sirali = meyveler.OrderBy(m => m.Length);


            Console.WriteLine("Harf sayısına göre sıralanmış meyveler : ");
            foreach (var meyve2 in sirali)
            {
                Console.WriteLine($"{meyve2} ({meyve2.Length} harf ) ");

            }

            Console.WriteLine("******************************************");
            Console.WriteLine("******************************************");



            Console.WriteLine("a harfi içerenler");


            foreach (var meyve in aIcerenler)
            {
                Console.WriteLine(meyve);

            }

            


        }
    }
}
