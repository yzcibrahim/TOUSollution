using DataAccessLayer;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber.Helpers
{
    public  class Repositoryfactory
    {
        static IRepositoryPerson _repoPErson;
        public static  IRepositoryPerson CreateRepo(string tip)
        {
            if (_repoPErson == null)
            {
                if (tip == "PERSON")
                {
                    lock (new object())
                    {
                        var optionsBuilder = new DbContextOptionsBuilder<PeopleDbContext>();
                        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TuPeopleInfoDb;Trusted_Connection=True;MultipleActiveResultSets=true");
                        // _repoPErson = new PersonRepositoryJson();
                        PeopleDbContext context = new PeopleDbContext(optionsBuilder.Options);
                        _repoPErson = new PersonRepository(context);
                        
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
