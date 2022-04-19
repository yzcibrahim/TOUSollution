using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber
{
    public class Test
    {
        public static int instanceCount=0;
        Deneme _d;
        public Test(Deneme d)
        {
            _d = d;
            instanceCount++;
        }
    }
}
