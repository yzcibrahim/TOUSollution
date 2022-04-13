using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Canli canli1 = new Hayvan();
            Canli hayvan = new Hayvan();
            Canli ins = new Insan();

            ins.TamAd = "ibrahim YAZICI";
            Console.WriteLine(ins.TamAd);
            ins.KendiniTanit();
            canli1.KendiniTanit();
            hayvan.KendiniTanit();
            


        }
    }
}
