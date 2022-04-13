using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface ICanli
    {
        string  Ad { get; set; }
        string Soyad { get; set; }
        void KendiniTanit();
    }
}
