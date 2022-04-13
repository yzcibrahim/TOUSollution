using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Insan : IYasli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public void KendiniTanit()
        {
            Console.WriteLine($"ben insanım benim Adım {Ad}");
        }

        public int YasKac()
        {
            return 15;
        }
    }
}
