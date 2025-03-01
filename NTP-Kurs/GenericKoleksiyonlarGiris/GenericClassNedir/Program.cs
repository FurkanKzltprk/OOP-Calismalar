using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();
            List<Musteri> musterilerim = repositoryMusteri.Getir(); 

        }
    }
}
