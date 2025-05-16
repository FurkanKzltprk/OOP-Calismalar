using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ders9_I.Senaryo2
{
    public abstract class Kisi
    {
        public string isim { get; set; }

        public virtual string BilgiGoster()
        {

            return "İsim: " + isim;
        }
    }
}
