using System;

class ana
{
    public ana()
    {
        Console.WriteLine("ana sınıfının parametre almayan yapıcı metodu");
    }
}

class yavru : ana
{
    public yavru(int a)
    {
        Console.WriteLine("yavru sınıfının parametre alan yapıcı metodu." +
            " alınan parametre: " + a);
    }
}

class esss
{
    static void Main()
    {
        yavru y = new yavru(5);
    }
}