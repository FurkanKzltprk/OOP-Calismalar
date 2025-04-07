using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hali_Yikama
{
    internal class Musteri
    {
        //property olarak tanımladım , kısıtlama yapacam çünkü.
        public int Id { get; set; }
        public string Ad { get; set; }

        private string _telno;
        public string TelNo
        {

            get { return _telno; }
            set 
            {
            if(value.Length == 10 && value.All(char.IsDigit)) //10 haneli ve hepsi rakam kontrolü.
                {
                    _telno = value;
                }
            else
                {
                    Console.WriteLine("Telefon numarası sadece rakamdan oluşabilir ve 10 hanelidir.");
                }
            
            }
        }

        private string _adres; // private olmalı kapsülleme ilkesi bunu gerektiriyor.

        public string Adres {
            get { return _adres; }

            set
            {
                if (value.Length >= 10)
                {
                    _adres = value;
                }
                else
                {
                    Console.WriteLine("Adres en az 10 karakterli olmalı");
                }
            }
        }

        public List<Hali> Halilar { get; set; } = new List<Hali>();
       


        public Musteri(int id, string ad ,string telNo , string adres)
        {

            Id = id;
            Ad = ad;
            TelNo = telNo;
            Adres = adres;
            
        }
    }
}
