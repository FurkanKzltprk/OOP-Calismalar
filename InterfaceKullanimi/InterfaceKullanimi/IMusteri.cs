using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    public interface IMusteri
    {
        // interfacede metotları tanımlarız {} scope olmaz 
        // erişim belirleyicisi de olmaz public,private,vb.
        void ekle();
        void sil();
        void guncelle();
        void getir();


    }
}
