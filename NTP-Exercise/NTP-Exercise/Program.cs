using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Exercise
{
    //sanal yapılar virtual üzerine basit bir örnek

    #region Örnek1
    //class Obje
    //{

    //    public virtual void Bilgi()
    //    {
    //        Console.WriteLine("Ben bir objeyim");
    //    }

    //}


    //class terlik : Obje
    //{
    //    public override void Bilgi()
    //    {

    //        Console.WriteLine("Ben bir terliğim");
    //    }
    //}

    //class kalem : Obje
    //{
    //    public override void Bilgi()
    //    {
    //        Console.WriteLine("Ben bir kalemim");
    //    }
    //}
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            #region Örnek1
            //kalem k = new kalem();
            //k.Bilgi();

            //terlik t = new terlik();
            //t.Bilgi();
            #endregion

            #region Örnek2
            //Maymun m = new Maymun();
            //m.konus();
            //Inek i = new Inek();
            //i.konus();


            #endregion

        }

        #region Örnek2

        //class Memeli
        //{
        //   virtual public void konus()
        //    {
        //        Console.WriteLine("Ben konuşmuyorum...");
        //    }
        //}

        //class Maymun : Memeli
        //{

        //    public override void konus()
        //    {
        //        Console.WriteLine("Ben maymun...");
        //    }

        //}

        //class Inek : Memeli
        //{
        //    public override void konus()
        //    {
        //        Console.WriteLine("Ben ineğim...");
        //    }

        //}
        #endregion
    }
}
