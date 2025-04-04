using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ders_H5_uyg
{
    public class Fabrika
    {
        public string Ad { get; set; }

        private List<Isci> Calisanlar { get; set; } = new List<Isci>(); //§

        public void CalisanEkle(Isci isci)
        {
            Calisanlar.Add(isci);   
        }

        public List<Isci> CalisanlariListele ()
        {
            return Calisanlar;

        }


    }
}
