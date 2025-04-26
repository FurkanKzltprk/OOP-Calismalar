using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_H5_Form_ArabaGaleri
{


    public class Araba
    {
        public string marka;
        public short model;
        public string renk;
        public Araba(string marka, short model, string renk)
        {

            this.marka = marka;
            this.model = model; 
            this.renk = renk;
        }
    }
    public class Galeri
    {
        private List <Araba> arabalar = new List<Araba> ();//§

        public void arabaEkle(Araba a)
        {

            arabalar.Add(a);

        }
        public void arabaSat(Araba a)
        {
            if (arabalar.Contains(a))
            {
                arabalar.Remove(a);
            }
        }
        public string[] arabaListele()
        {
            string [] s = new string[arabalar.Count];

            for (int i = 0; i < arabalar.Count; i++)
            {
                s[i] = arabalar[i].marka +" " + arabalar[i].model+" " + arabalar[i].renk;
            }
            return  s;

        }


    }
}
