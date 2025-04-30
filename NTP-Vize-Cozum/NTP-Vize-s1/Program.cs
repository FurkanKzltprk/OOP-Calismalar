using System;

class Takvim
{
    public enum haftaGunleri { Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar };
    private static int[] aylar = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    int gun, ay, yil;
    haftaGunleri haftaninGunu;

    public Takvim()  // Varsayılan olarak 1.1.2000 Cumartesi
    {
        gun = 1;
        ay = 1;
        yil = 2000;
        haftaninGunu = haftaGunleri.Cumartesi;
    }

    public Takvim(int gun, int ay, int yil)
    {
        this.gun = gun;
        this.ay = ay;
        this.yil = yil;
        gunHesapla(); // Haftanın gününü hesapla
    }

    bool ArtikYilMi(int y)
    {
        return (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0);
    }

    int GunSayisi()
    {
        int toplam = 0;

        for (int y = 2000; y < yil; y++)
        {
            toplam += ArtikYilMi(y) ? 366 : 365;
        }

        for (int i = 0; i < ay - 1; i++)
        {
            toplam += aylar[i];
            if (i == 1 && ArtikYilMi(yil)) // Şubat
                toplam += 1;
        }

        toplam += gun - 1;

        return toplam;
    }

    public int aradakiGunSayisi(Takvim t)
    {
        return this.GunSayisi() - t.GunSayisi();
    }

    public haftaGunleri gunHesapla()
    {
        int fark = this.GunSayisi(); // 1.1.2000'e göre kaç gün geçti
        int gunIndex = (int)haftaGunleri.Cumartesi;
        gunIndex = (gunIndex + fark) % 7;
        haftaninGunu = (haftaGunleri)gunIndex;
        return haftaninGunu;
    }

    public void gunOtele(int gunSayisi)
    {
        int toplamGun = this.GunSayisi() + gunSayisi;

        // Tarihi sıfırla ve yeniden oluştur
        yil = 2000;
        while (true)
        {
            int yillikGun = ArtikYilMi(yil) ? 366 : 365;
            if (toplamGun >= yillikGun)
            {
                toplamGun -= yillikGun;
                yil++;
            }
            else
            {
                break;
            }
        }

        ay = 1;
        while (true)
        {
            int ayGun = aylar[ay - 1];
            if (ay == 2 && ArtikYilMi(yil)) ayGun++;

            if (toplamGun >= ayGun)
            {
                toplamGun -= ayGun;
                ay++;
            }
            else
            {
                break;
            }
        }

        gun = toplamGun + 1;
        gunHesapla(); // yeni haftanın gününü hesapla
    }

    public override string ToString()
    {
        return $"{gun}.{ay}.{yil} - {haftaninGunu}";
    }
}

class Program
{
    static void Main()
    {
        Takvim t1 = new Takvim(); // 1.1.2000 Cumartesi
        Takvim t2 = new Takvim(1, 1, 2025);

        Console.WriteLine("t1: " + t1);
        Console.WriteLine("t2: " + t2);
        Console.WriteLine("Fark: " + t2.aradakiGunSayisi(t1));

        t2.gunOtele(50);
        Console.WriteLine("50 gün sonra: " + t2);
    }
}
