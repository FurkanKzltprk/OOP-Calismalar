using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterfaceKullaniriz
{
    public class MySql : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("Mysql ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("Mysql güncelledi");
        }

        public void sil()
        {
            Console.WriteLine("Mysql sildi");
        }
    }
}
