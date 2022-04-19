using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Konusturma
    {
        private ICanli _canli;
        public Konusturma(ICanli canli)
        {
            _canli = canli;//new Insan() { Ad = "ibrahim", Soyad = "yazıcı" };
        }
        public void konus()
        {

            _canli.KendiniTanit();
        }



    }
}
