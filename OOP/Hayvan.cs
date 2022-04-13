using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Hayvan:ICanli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public void Ses()
        {
            Console.WriteLine("BEN HAYVANIMmmmm");
        }

        public void KendiniTanit()
        {
            Console.WriteLine($"ben hayvanım benim adıım{Ad}");
           // base.KendiniTanit();
        }

    }
}
