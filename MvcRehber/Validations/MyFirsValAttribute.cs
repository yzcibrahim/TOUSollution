using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber.Validations
{
    public class MyFirstValAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value==null)
            {
                ErrorMessage = "Değer boş olamaz";
                return false;
            }
            if (value.ToString().ToUpperInvariant() == "kerim".ToUpperInvariant())
            {
                ErrorMessage = "kerim giremez!";
                return false;
            }
            return true;
        }
    }
}
