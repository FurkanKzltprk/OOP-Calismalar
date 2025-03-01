using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlarGiris
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add(3);
            koleksiyon.Add("ahmet");
            koleksiyon.Add(3.14); */

            // Tür denetlemesi yapmıyor bu bir sorun  çözüm : Generic Collection

            //↓↓↓↓↓↓↓↓ eskiden generic koleksiyonlar olmadan nasıl yapılır dı  ? ↓↓↓↓↓↓↓↓

           
        }
        //eski çözüm yöntemi↓↓↓↓↓↓↓↓↓↓↓¦ ‼
        public void degerAta (int deger)
        {
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add(deger);
        }


        
}
    }

