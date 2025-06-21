using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceKullanimiSoru
{

    public abstract class Sekil
    {
        public String renk { get; set; }
        public readonly double pisayisi = 3.14;

        //1.tarz neden ? 
        //public virtual double AlanHesapla(double r)
        //{
        //    return pisayisi * r * r;
        //}

        //2. tarz neden ? 
        public abstract double AlanHesapla(double yaricap);



    }

    interface IBoyanabilir
    {
        void Boya();
        
        

    }

    public class Daire : Sekil, IBoyanabilir
    {
        //public double Yaricap { get; set; }

        public override double AlanHesapla(double yaricap)
        {

            return pisayisi * yaricap * yaricap;

        }


        public  void Boya()  // bu override edilmiyor neden ? //gerek yok interface imzadır.
        {
            Console.WriteLine($"{renk} renge Boyanıyor");
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Daire D1 = new Daire();
            D1.renk = "mavi";

            Console.WriteLine( "sonuç : " + D1.AlanHesapla(3)); // 

            D1.Boya();

        }
    }
}
