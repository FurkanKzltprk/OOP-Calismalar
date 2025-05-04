using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Exercise_ex1
{

    #region Örnek1,senaryo2



    public class Personel
    {
        private const Decimal AsgariUcret = 2000;
        private const Decimal AileGecimIndirim = 500;

        public string Isim { get; set; }
        protected Decimal maas;

        public Decimal Maas
        {
            get
            {
                return Maas;
            }

        }
        public Personel()
        {
            //To do
        }

        public virtual void Maashesapla()
        {
            maas = AsgariUcret + AileGecimIndirim;
        }

    }

    public class Calisan : Personel
    {
        public Calisan()
        {
            //to do
        }

        public override void Maashesapla()
        {
            base.Maashesapla();
            maas *= 1.5M;
        }
    }


    public class Mudur : Personel
    {

        public Mudur()
        {
            // to do

        }

        public override void Maashesapla()
        {
            base.Maashesapla();
            maas = 4M;
        }
        #endregion

        #region Örnek2,OgrenciBurs
        //public class Ogrenci
        //{
        //    private const Decimal BirimDersUcreti = 60;

        //    public string Isim { get; set; }

        //    public short KrediSayisi { get; set; }


        //    public Decimal ToplamDersUcreti { get; protected set; }

        //    public Ogrenci()
        //    {

        //    }
        //    public virtual void DersUcretiHesapla()
        //    {
        //        ToplamDersUcreti = BirimDersUcreti * KrediSayisi;
        //    }

        //    public class BursluOgrenci : Ogrenci
        //    {
        //        public short BursOrani  { get; set; }

        //        public decimal BursIndirimi { get; protected set; }

        //        public BursluOgrenci()
        //        {
        //            //To do 
        //        }
        //        public override void DersUcretiHesapla()
        //        {
        //            base.DersUcretiHesapla();
        //            BursIndirimi = (ToplamDersUcreti * BursOrani) / 100;
        //            ToplamDersUcreti -= BursIndirimi;
        //        }


        //    }



        #endregion

        #region Örnek3

        //class baseclass
        //{
        //    public void writeBase()
        //    {
        //        Console.WriteLine("Base class ...");
        //    }
        //}


        //class DerivedClass : baseclass
        //{
        //    public void writeDerived() { Console.WriteLine("Derived class..."); }
        //}

        #endregion


        internal class Program
            {
            #region örnek3

            //static void Main(string[] args)
            //{
            //baseclass bc = new baseclass();

            //bc.writeBase();

            //DerivedClass dr = new DerivedClass();
            //dr.writeDerived();

            //}
            #endregion


        }
    }
    }
