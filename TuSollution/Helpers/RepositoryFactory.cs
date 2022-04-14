using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRehber.Helpers
{
    public class RepositoryFactory
    {
        public IRepositoryPerson CreateRepository(string repStr)
        {
            if (repStr == "Person")
            {
                return new PersonRepositoryJson();
            }
            return null;
        }
    }
}
