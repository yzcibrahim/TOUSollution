using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PersonRepositoryJson: IRepositoryPerson
    {
        static List<Person> _people=new List<Person>();

        public void AddOrUpdate(Person person)
        {
            _people.Add(person);
        }
        public void Delete(Person person)
        {
            _people.Remove(person);
        }

        public List<Person> List()
        {
            string fileContent = File.ReadAllText("Kişiler.json");
            _people = JsonSerializer.Deserialize<List<Person>>(fileContent);
            return _people.ToList();
        }

        public void SaveChanges() 
        {
            string serializedPeople=JsonSerializer.Serialize(_people);
            File.WriteAllText("Kişiler.json", serializedPeople);

        }

    }
}
