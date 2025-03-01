using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGiris
{
    public class Kedi : Hayvan
    {
        public Kedi(string isim) : base(isim)
        {

        }
        //  override ile bir metodu ezmek istiyorsun 
        //  o metot subclassta 'virtual' ile tanımlanmalı.
        public override void konus()
        {
           Console.WriteLine(getIsim() + " miyavlıyor.... ");
        }

    }
}
