using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Selam");
            //Console.ReadLine();

            //-----------------------------------------------

            // klavyeden girilen sayıyı gösterme

            /*int number;
            Console.Write("Bir sayı gir : ");
            number = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Girilen sayı : {0}", number);
            // burada {} kullanımı önemli dikkat!!
            Console.ReadLine();*/

            //------------------------------------------------

            /* float number1, number2, product;
             Console.Write("Sayı-1 : ");
             number1 = Convert.ToSingle(Console.ReadLine()); 
             Console.Write("Sayı-2 : ");
             number2 = Convert.ToSingle(Console.ReadLine());
             product = number1 * number2;

             Console.WriteLine("{0} * {1} = {2}",number1,number2,product);
             Console.ReadLine();*/
              

            //-------------------------------------------------

            // Girilen iki sayının toplamını bulma.

            /* int num1, num2, sum;
             Console.WriteLine("İki sayının toplamını gösterme : ");
             Console.Write("1.sayıyı gir : ");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("2.sayıyı gir : ");
             num2 = Convert.ToInt32(Console.ReadLine());

             sum = num1 + num2;
             Console.WriteLine("sonuc : {0}", sum);

             Console.ReadKey(); // bir tuşa basılmasını bekler.*/

            //-------------------------------------------------

            //Bölme sonucu kalanı bulma 

            /*Console.Write("Bolunen sayiyi giriniz : ");
            int bolunen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bolen sayıyı giriniz : ");
            int bolen = Convert.ToInt32(Console.ReadLine());
            

            int quotient = bolunen / bolen;
            int remainder = bolunen % bolen;

            Console.WriteLine("bolunen {0} bolen {1}", bolunen, bolen);
            Console.WriteLine("bolum = " + quotient);
            Console.WriteLine("kalan = " + remainder);
            Console.ReadLine();*/


            //-------------------------------------------------

            // klavyeden girilen stringteki kelime sayısını bulma
            //!!
            /*string sentence;
            Console.Write("String gir : ");
            sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Kelime sayısı : " + words.Length);
            Console.ReadKey();*/

            //-------------------------------------------------
            // a^b işlemini bulma

           /* double taban, us;
            Console.Write("sayı tabanı giriniz :");
            taban = Convert.ToDouble(Console.ReadLine());
            Console.Write("sayı üssü giriniz :");
            us = Convert.ToDouble(Console.ReadLine());

            double sonuc = Math.Pow(taban, us);
            Console.WriteLine("{0}^{1} = {2}",taban ,us,sonuc);
            Console.ReadLine();*/


            //-------------------------------------------------



        }
    }
}
