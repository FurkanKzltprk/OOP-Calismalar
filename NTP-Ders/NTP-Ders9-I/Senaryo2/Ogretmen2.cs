using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ders9_I.Senaryo2
{
    internal class Ogretmen2 : Kisi , ICalisabilen2
    {
        public string Calis()
        {

            return "(2)Ogretirim";
        }

        public override string BilgiGoster()
        {
            return base.BilgiGoster();
        }
    }
}
