using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    public class Program
    {
        static void Main(string[] args)
        {
            // https://medium.com/codable/interfacelerin-mantigi-nedir-1-hikayeli-f9b960228328
            // Interface'lerden bir tane örnek oluşturamazsınız.
            // Interface'i implement'e eden classdan aldığımız örneği interface karşılayabilir.
            // Interface içerisinde metotları tanımlarız. Classlarda da içeriğini doldururuz.
            // Interface içindeki metotların ERİŞİM BELİRLEYİCİLERİ ve İÇERİĞİ olmaz.
            // Interface leri miras alan sinıflar, içerisinde tanımlanan tum metodları Implemente etmek zorundadir.
            // Bir Class sadece bir class tan türetebilirken, bir Class birden cok Interface ten türetilebilir.

            Musteri musteri = new Musteri();
            musteri.ekle();
            musteri.sil();
        }
    }
}
