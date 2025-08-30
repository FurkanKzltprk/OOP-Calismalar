using System;
using System.Runtime.InteropServices;


//1)Ortak bir sözleşme (arayüz) tanımlıyorum.
//Blender sadece "elektrik ver" işiyle ilgileniyor, diğerleri umrunda değil.
public interface IPriz
{
    void ElektrikVer();
}
//2)Farklı ülkelerin prizleri bu aryüzü uyguluyor , implemente ediyor.
public class TurkiyePrizi : IPriz
{
    public void ElektrikVer() => Console.WriteLine("Türkiye prizi : 220V ");

}
public class AmerikaPrizi : IPriz
{
    public void ElektrikVer() => Console.WriteLine("Amerika prizi : 110V ");

}
public class KibrisPrizi : IPriz
{
    public void ElektrikVer() => Console.WriteLine("Kıbrıs prizi : 240V ");

}


//3)Blender artık prizi kendi içinde üretmiyor ( "new" lemiyor)
//Dışarıdan "hangi prizle çalışacağını" enjekte ediyoruz ( Constructor enjection ) 
public class Blender
{
    private readonly IPriz _priz;

    // ↓↓↓↓ DI (constructor) burada ↓↓↓↓
    public Blender(IPriz priz)
    {
        _priz = priz; //blender sadece "IPriz" bilir, geri kalanı umrunda değil.
    }

    public void Calistir()
    {
        _priz.ElektrikVer(); //hangi priz verilmişse onunla çalışır.
        Console.WriteLine(" !!!!!!  Blender çalıştı !!!!! ");
    }
}

class Program
{
    static void Main()
{
        //Blender hangi prizle çalışacak ? 
        // işte DI (dependency injection ) burada uygulanıyor ve çalışıyor.
        //3 farkı priz ayrı ayrı test edildi esnek bir yapı sağlandı.


        Blender blenderTR = new Blender(new TurkiyePrizi());
        blenderTR.Calistir();

        Blender blenderUS = new Blender(new AmerikaPrizi());
        blenderUS.Calistir();

        Blender blenderCY = new Blender(new KibrisPrizi());
        blenderCY.Calistir();



    }

}
//DI olmadan ↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

//Bu sınıf Sadece Türkiye prizini temsil ediyor.
//class TurkiyePrizi
//{
//    public void ElektirkVer()
//    {
//        Console.WriteLine("Türkiye Prizi : 220V elektrik verildi");
//    }

//}

////Blender kendi içinde Türkiye prizini yaratıyor.
//class Blender
//{
//    //Burada sıkıntı var, blender doğrudan Türkiye prizine BAĞIMLI!
//    private TurkiyePrizi priz = new TurkiyePrizi();

//    public void Calistir()
//    {
//        priz.ElektirkVer();
//        Console.WriteLine("Blender çalıştı! \\n ");
//    }


//}

