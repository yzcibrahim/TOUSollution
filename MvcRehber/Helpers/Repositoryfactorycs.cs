using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber.Helpers
{
    public  class Repositoryfactory
    {
        static PersonRepositoryJson _repoPErson;
        public static  IRepositoryPerson CreateRepo(string tip)
        {
            if (_repoPErson == null)
            {
                if (tip == "PERSON")
                {
                    lock (new object())
                    {
                        _repoPErson = new PersonRepositoryJson();
                    }
                    return _repoPErson;
                }
                else
                    return null;
            }
            else
                return _repoPErson;
        }
    }
}
