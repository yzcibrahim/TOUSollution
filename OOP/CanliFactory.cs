using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class HayvanFactory
    {
        public ICanli HayvanUret(string tip)
        {
            if (tip == "H")
            {
                return new Hayvan();
            }
            else if (tip == "I")
            {
                return new Insan();
            }
            else
            {
                return null;
            }
        }

    }
}
