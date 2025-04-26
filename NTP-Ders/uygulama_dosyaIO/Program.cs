using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = @"C:\Users\Furkan\OneDrive\Desktop\dosya\notlar.txt";
        string outputFile = @"C:\Users\Furkan\OneDrive\Desktop\dosya\sonuclar.txt";

        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    string isim = parts[0].Trim();
                    int vize = int.Parse(parts[1].Trim());
                    int final = int.Parse(parts[2].Trim());

                    double ortalama = vize * 0.4 + final * 0.6;
                    string durum = ortalama >= 50 ? "Geçti" : "Kaldı"; //? turnery operatörü

                    writer.WriteLine($"{isim} - Ortalama: {ortalama:F2} - {durum}");
                }
            }
        }

        Console.WriteLine("İşlem tamamlandı. 'sonuclar.txt' dosyasını kontrol et.");
    }
}
