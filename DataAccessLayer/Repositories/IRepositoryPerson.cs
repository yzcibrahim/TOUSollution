using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IRepositoryPerson
    {
        void AddOrUpdate(Person person);
        void Delete(Person person);
        List<Person> List();
        void SaveChanges();
    }
}
