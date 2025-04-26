using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NTP_ZZ_Karısık
{
    internal class Program
    {
        //public enum gun { pazartesi,salı,çarşamba,perşembe,cuma,cumartesi,pazar};

        //public static gun gunOtele(gun g, int kacgunsonra)
        //{

        //    gun yenigun = (gun) (((int)g + kacgunsonra) % 7);
        //    return yenigun;
        //}

        class ogrenci
        {
            public string id;
            private int yas;
            private string name = "unnamed";
            public string _name
            {

                get { return name + ":D"; }

                set
                {
                    if (value.Length > 10)
                    {
                        Console.WriteLine("isim fazla uzun");
                    }
                    else
                    {
                        name = value;

                    }


                }

            }
            public int _yas
            {
                get
                {
                    Console.WriteLine("yas degeri :" + yas);
                    return yas;
                }

                set { yas = value; }

            }

            public ogrenci(string id, int yas, string name)
            {
                this.id = id;
                this.yas = yas;
                this.name = name;
            }

        }
        static void Main(string[] args)
        {
            ogrenci ogr = new ogrenci("1", 12, "mustafa");
            ogrenci ogr2 = new ogrenci("1", 12, "");


            Console.WriteLine(ogr._name);
            ogr._name = "asdsakdlşakdsşlas";
        }
    }
}
