using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace NTP_Ders_H6
{
    internal class Program
    {
        class KarmasikSayi
        {
            private double msanal, mgercek;
            public double Gercek { get { return mgercek; } set { mgercek = value; } }
            public double Sanal
            {
                get
                {
                    return msanal;
                }
                set
                {
                    msanal = value;
                }
            }
            public KarmasikSayi(double gercek, double sanal)
            {
                msanal = sanal;
                mgercek = gercek;
            }
            public void yaz()
            {
                if (msanal > 0)
                {
                    Console.WriteLine("{0}+{1}i", mgercek, msanal);
                }
                else
                {
                    Console.WriteLine("{0}-{1}i", mgercek, msanal);
                }
            }
            public static KarmasikSayi operator +(KarmasikSayi s1, KarmasikSayi s2)
            {
                double d1 = s1.Sanal + s2.Sanal;
                double d2 = s1.Gercek + s2.Gercek;
                return new KarmasikSayi(d1, d2);
            }

            public static bool operator ==(KarmasikSayi a, KarmasikSayi b) //bunu yazarsan
            {
                return a.Sanal == b.Sanal && a.Gercek == b.Gercek;
            }

            public static bool operator !=(KarmasikSayi a, KarmasikSayi b)//bunu da yazmak zorundasın
            {
                return !(a == b);

            }
        }
        class uye  //indexers ile ilgili örnek 
        {
            private string[] uyeler = { "Ali", "Ahmet", "Ayse" }; //private, sadece indexleyici ile erişilir.
            public string this[int indeks]
            {
                get
                {
                    if (indeks < 0 || indeks >= uyeler.Length)
                    {
                        return null;
                    }
                    else
                    {
                        return uyeler[indeks];
                    }
                }
                set
                {
                    if (!(indeks < 0 || indeks >= uyeler.Length)) //!
                    {
                        uyeler[indeks] = value;
                    }
                }
            }

            public int this[string aranan]  
                                            
            {
                get
                {
                    for (int i = 0; i < uyeler.Length; i++)
                    {
                        if (uyeler[i] == aranan)
                        {
                            return i;
                        }
                    }
                    return -1;

                }
            }




            static void Main(string[] args)
            {
                //// hafta 5'in slaytı işleniyor , operatör aşırı yüklemesi.
                //KarmasikSayi s1 = new KarmasikSayi(3, 6);
                //s1.yaz();
                //KarmasikSayi s2 = new KarmasikSayi(4,-2);
                //s2.yaz();

                //KarmasikSayi t = s1 + s2;
                //Console.WriteLine("Sonuç : " );
                //t.yaz();
                //Console.WriteLine(s1 == s2); // operatör override edildi tersiyle birlikte.


                //------------------------------------------------------

                uye u = new uye();
                Console.WriteLine(u[0]);
                u[1] = "Demet";
                Console.WriteLine(u[1]);
                Console.WriteLine(u[6]);
                Console.WriteLine(u["Ali"]); //büyük küçük harf kontrolü yapılabilir !!




            }
        }
    }
}
