using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuSollution.Entities;

namespace WpfRehber.Repositories
{
    public class PersonRepository
    {
        static List<Person> _people=new List<Person>();

        public void Add(Person person)
        {
            _people.Add(person);
        }
        public void Delete(Person person)
        {
            _people.Remove(person);
        }

        public List<Person> List()
        {
            return _people.ToList();
        }

    }
}
