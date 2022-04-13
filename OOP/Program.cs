using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICanli canli1 = new Hayvan();
            ICanli hayvan = new Hayvan();
            ICanli ins = new Insan();

            //ins.

            ins.Ad = "ibrahim YAZICI";

           // ((IYasli)ins).YasKac();

            Console.WriteLine(ins.Ad);
            ins.KendiniTanit();
            canli1.KendiniTanit();
            hayvan.KendiniTanit();
            


        }
    }
}
