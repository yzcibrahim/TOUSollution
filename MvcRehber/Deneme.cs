using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber
{
    public class Deneme
    {
        public static int instanceCount = 0;
        public Deneme()
        {
            instanceCount++;
        }
        public string Name { get { return instanceCount + " deneme"; } }
    }
}
