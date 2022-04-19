using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PersonRepository : IRepositoryPerson
    {
        PeopleDbContext _context;
        public PersonRepository(PeopleDbContext context)
        {
            _context = context;
        }
        public void AddOrUpdate(Person person)
        {
            if (person.Id <= 0)
                _context.Set<Person>().Add(person);
            else
            {
                var updateEdilecek = _context.Set<Person>().FirstOrDefault(c => c.Id == person.Id);
                updateEdilecek.Name = person.Name;
                updateEdilecek.Phone = person.Phone;
                updateEdilecek.Surname = person.Surname;
            }
            SaveChanges();
        }

        public void Delete(Person person)
        {
            _context.Set<Person>().Remove(person);
            SaveChanges();
        }

        public void Delete(int id)
        {
            Person silinecek = _context.Set<Person>().First(c => c.Id == id);
            Delete(silinecek);
        }

        public List<Person> List()
        {
            return _context.Set<Person>().ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
