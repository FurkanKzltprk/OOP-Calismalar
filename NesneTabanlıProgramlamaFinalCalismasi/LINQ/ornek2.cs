using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Ornek2
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
            new Student { Name = "Ali", Age = 17 },
            new Student { Name = "Zeynep", Age = 20 },
            new Student { Name = "Mehmet", Age = 19 },
            new Student { Name = "Elif", Age = 16 },
        };

            var filtre = students
                .Where(s => s.Age > 18)              // Yaşı 18'den büyük olanlar
                .OrderBy(s => s.Name)                // İsme göre sıralama
                .Select(s => s.Name);                // Sadece isimleri al

            foreach (var name in filtre)
            {
                Console.WriteLine(name);             // İsimleri yazdır
            }
        }
    }
}
