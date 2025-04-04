using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ders_H5_uyg
{
    public class KimlikBilgisi
    {
        public ulong TCKimlikNo { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }   

        public string AdSoyad
        {
            get
            {
                string adSoyad = (this.Ad + " " + this.Soyad).ToUpper();
                return adSoyad;
            }
        }

        public string DogumYeri { get; set; }

        public DateTime  DogumTarihi { get; set; }


    }
}
