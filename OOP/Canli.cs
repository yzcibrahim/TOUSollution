using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Canli
    {
        private string _ad;
        private string _soyad;

        public string Ad 
        {
            get
            {
                return _ad;
            } 
        }
        public string TamAd
        {
            get
            {
                return $" {_soyad} {_ad}";
            }
            set
            {
                string[] val = value.Split(" ");
                _ad = val[0];
                _soyad = val[1];
            }
        }

        public abstract void KendiniTanit();
    }
}
