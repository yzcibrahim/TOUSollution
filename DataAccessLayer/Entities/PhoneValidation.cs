using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class PhoneValidationAttribute:RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            if (!base.IsValid(value))
                return false;
            long val = 0;
            if(!long.TryParse(value.ToString(), out val))
            {
                ErrorMessage = "telefon yalnızca rakam içermelidir";
                return false;
            }
            // if(value.ToString()[0]!='0')
            if (!value.ToString().StartsWith("0"))
            {
                ErrorMessage = "teleofn sıfır ile başlamalı";
                return false;
            }
                return true;

        }
    }
}
