using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    delegate void Yazdir(string mesaj);
    delegate void Islemler();
    internal class Program
    {
       static void MesajYaz(string mesaj)
        {
            Console.WriteLine(mesaj);

        }

        static void Metot1()
        {
            Console.WriteLine("Metot1 çalıştı");
        }
        static void Metot2()
        {
            Console.WriteLine("Metot2 çalıştı");
        }

        static void Main(string[] args)
        {

            Islemler islem = Metot1;
            islem += Metot2;

            islem();


            Yazdir yaz = MesajYaz;
            yaz("Merhaba");

            Console.ReadLine();

        }
    }
}
