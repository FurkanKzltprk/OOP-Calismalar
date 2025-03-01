using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterfaceKullaniriz
{
    public class Oracle : IMusteri   //  IMusteri oracle=  new Oracle();
    {
        public void ekle()
        {
            Console.WriteLine("Oracle ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("Oracle güncelledi");
        }

        public void sil()
        {
            Console.WriteLine("Oracle sildi");
        }
    }
}
