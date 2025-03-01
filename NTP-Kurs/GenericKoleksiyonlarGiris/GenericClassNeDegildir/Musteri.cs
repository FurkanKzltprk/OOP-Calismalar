using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNeDegildir
{
    internal class Musteri <T>
    {
        public T id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public T email { get; set; }
    }
}
