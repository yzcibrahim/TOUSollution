using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfRehber.Repositories;

namespace WpfRehber.Helpers
{
    public class RepositoryFactory
    {
        public PersonRepositoryJson CreateRepository(string repStr)
        {
            if (repStr == "Person")
            {
                return new PersonRepositoryJson();
            }
            return null;
        }
    }
}
