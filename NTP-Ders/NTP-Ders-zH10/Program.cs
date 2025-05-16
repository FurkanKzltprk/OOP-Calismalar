using System;

public delegate void MyDelegate(int Deger1, int Deger2);

class Program
{
    //delegate ile ilgili derste yapılan örnek 5/16/2025

    static void Toplama(int Sayi1, int Sayi2)
    {
        Console.WriteLine("{0} + {1} = {2}", Sayi1, Sayi2, Sayi1 + Sayi2);
    }

    static void Carpma(int Sayi1, int Sayi2)
    {
        Console.WriteLine("{0} * {1} = {2}", Sayi1, Sayi2, Sayi1 * Sayi2);
    }

    static void Bolme(int Sayi1, int Sayi2)
    {
        Console.WriteLine("{0} / {1} = {2}", Sayi1, Sayi2, Sayi1 / Sayi2);
    }

    static void Main(string[] args)
    {
        MyDelegate delege = null;

        // Delegate metot ekleme
        delege += new MyDelegate(Toplama);
        delege += new MyDelegate(Carpma);
        delege += new MyDelegate(Bolme);

        Console.WriteLine("Delegeler ilk çağrı:");
        int X = 18, Y = 3;
        delege(X, Y);

        // Delegate metotlarını listeleme
        Delegate[] DlgList = delege.GetInvocationList();
        Console.WriteLine("\nDelegenin temsil ettiği metotlar:");
        for (int i = 0; i < DlgList.Length; i++)
        {
            Console.WriteLine(DlgList[i].Method.Name);
        }

        // Delegate metot çıkarma
        delege -= new MyDelegate(Bolme);

        Console.WriteLine("\nDelegeler ikinci çağrı (Bölme çıkarıldı):");
        int X1 = 30, Y1 = 5;
        delege(X1, Y1);

        DlgList = delege.GetInvocationList();
        Console.WriteLine("\nDelegenin temsil ettiği metotlar (Güncel):");
        for (int i = 0; i < DlgList.Length; i++)
        {
            Console.WriteLine(DlgList[i].Method.Name);
        }
        //fkt
        Console.ReadKey();
    }
}