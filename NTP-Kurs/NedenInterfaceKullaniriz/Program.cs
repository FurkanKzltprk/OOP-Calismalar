using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterfaceKullaniriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface'imizi implement'e eden classlarımızdan oluşturduğumuz örneği INTERFACE KARŞILAYABİLİR.

            // Sqlserver  MySql   Oracle


            MusteriController musteriController = new MusteriController();
            musteriController.musteriEkle(new SqlServer());
            musteriController.musteriEkle(new MySql());
            musteriController.musteriEkle(new Oracle());

            Console.ReadLine();
        }
    }
}
