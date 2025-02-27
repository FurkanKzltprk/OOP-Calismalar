using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarileOrnekUygulama
{
    public class Program
    {


        static void main(string[] args)
        {

            Musteri musteri = new Musteri(1, "furkan", "kzltprk", "Erkek", "Furkan@gmail.com");

            /*  musteri.id = 1;
              musteri.isim = "furkan";
              musteri.cinsiyet = "Errkek";
              musteri.emailAdres = "furkan@mail.com";*/

            MusteriDurum donenDurum = musteri.musteriEkle(musteri);

            if (donenDurum == MusteriDurum.kayitbasarili) // çok daha düzgün ve anlamlı bir geri dönüş sistemi
                                                          // enumlarla yapılır.
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir.");

            }
            Console.ReadLine();

        }


    }





}
 





