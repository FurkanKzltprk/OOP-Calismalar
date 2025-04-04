using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Vize_Uygulama_1
{

    class KarmasikSayi
    {
        private double mGercek;
        private double mSanal;

        public double Gercek
        {
            get { return mGercek; }
            set { mGercek = value; }

        }

        public double Sanal
        {
            get { return mSanal; }
            set { mSanal = value; }

        }

        public KarmasikSayi (double x, double y)
        {
            mGercek = x;    
            mSanal = y;
        }
        public KarmasikSayi()
        {
            mGercek = 0;
            mSanal = 0;
        }
        public KarmasikSayi (KarmasikSayi k)
        {
            mGercek += k.mGercek;
            mSanal += k.mSanal;
        }
        public void Yaz()
        {
            if(mSanal > 0)
            {
                Console.WriteLine("{0}+{1}i",mGercek,mSanal);
            }else
            {
                Console.WriteLine("{0}-{1}i",mGercek-mSanal);
            }
        }
       
        internal class Program
        {
            static void Main(string[] args)
            {
                KarmasikSayi K = new KarmasikSayi(-5, -6);
                K.Yaz();
            }
        }
    }
}
