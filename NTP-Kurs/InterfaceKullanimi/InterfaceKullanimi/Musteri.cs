using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{

    public class Musteri : IMusteri,IPersonel
    {

        
        public void ekle()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri geldi");

        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri güncellendi");

        }

        public int Personelekle()
        {
            throw new NotImplementedException();
        }

        public void sil()
        {
            Console.WriteLine("Müşteri silindi");

        }

       
    }
}
