using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Hayvan:Canli
    {

        public void Ses()
        {
            Console.WriteLine("BEN HAYVANIMmmmm");
        }

        public override void KendiniTanit()
        {
            Console.WriteLine($"ben hayvanım benim adıım{Ad}");
           // base.KendiniTanit();
        }

    }
}
