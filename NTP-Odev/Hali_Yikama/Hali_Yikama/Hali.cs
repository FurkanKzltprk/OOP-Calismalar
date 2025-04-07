using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hali_Yikama
{
    internal class Hali
    {
        public int Id { get; set; }

        private double _metrekare;

        public double Metrekare
        {

            get { return _metrekare; }

            set
            {
                if (value > 0)
                {
                    _metrekare = value;
                }
                else
                {
                    Console.WriteLine("Metrekare değeri negatif olamaz !!");
                }



            }

        }
        public DateTime AlimTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }

        private string _durum;
        public string Durum {

            get { return _durum; }


            set
            {
                if(value == "Teslim Edildi" || value == "Yıkamada")
                {
                    _durum =value;
                }
                else
                {
                    Console.WriteLine("Yanlış durum seçtiniz. (Sadece 'Teslim Edildi' veya 'Yıkamada' olabilir.)");

                }
            }
        
        }

        public double Ucret {
            get
            {
                return Metrekare * 20;
            } 
            /*set metodu yok çünkü 20 tl varsayılan değer
            otomatik hesaplanıyor */
            
        
        }

        /*halının bilgisini kolayca alabilmek için Form üzerinde bu metodu burada hazır 
        olarak yazdım */
        public override string ToString()
        {
            return $" Halı ID: {Id} | m²: {Metrekare} | Ücret: {Ucret} TL | Durum: {Durum}";
        }



        public Hali(int id, double metrekare,DateTime alimTarihi , DateTime teslimTarihi,string durum)
        {
            Id = id;
            Metrekare = metrekare;
            AlimTarihi = alimTarihi;
            TeslimTarihi = teslimTarihi;
            Durum = durum;
            
        }

    }
}
