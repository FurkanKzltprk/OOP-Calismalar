using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ders_H4__Gr_
{


    class Person
    {



        private string _name;  // Backing field for Name
        private int _age;      // Backing field for Age

        // Name özelliği (otomatik özellik yerine özel getter ve setter kullanıyoruz)
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Age özelliği, negatif değerleri engelleyen setter
        public int Age
        {
            get { return _age; }
            set
            {
                // Negatif değer kontrolü
                if (value < 0)
                {
                    Console.WriteLine("Yaş negatif olamaz!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        // Person hakkında bilgi yazdırma metodu
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class propertiesKullanimi1
    {
       /* static void Main(string[] args)
        {
            // Person sınıfından bir nesne oluşturuyoruz
            Person person1 = new Person();

            // Özellikleri kullanarak değer atıyoruz
            person1.Name = "Ahmet";

            // Yaş değeri negatif verilirse, set metodu engeller ve hata mesajı yazdırır
            person1.Age = -5;  // Burada negatif bir değer girildi, hata mesajı alacağız
            person1.Age = 30;  // Geçerli bir yaş değeri

            // Özellikleri ekrana yazdırıyoruz
            person1.PrintInfo();*/
       // }
    }
}
