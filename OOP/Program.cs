using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1=new Insan() { Ad = "ibrahim", Soyad = "yazıcı" };
            Hayvan h1 = new Hayvan() { Ad = "tom", Soyad = "cat" };
            Konusturma k = new Konusturma(h1);
            k.konus();

            Konusturma k1 = new Konusturma(i1);

            return;

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
