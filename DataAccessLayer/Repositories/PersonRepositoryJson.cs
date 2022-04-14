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
            SaveChanges();
        }
        public void Delete(Person person)
        {
            _people.Remove(person);
            SaveChanges();
        }

        public List<Person> List()
        {
            string fileContent = File.ReadAllText(@"C:\Users\iyazici\source\repos\Tu\WpfRehber\TuSollution\bin\Debug\net5.0-windows\Kisiler.json");
            _people = JsonSerializer.Deserialize<List<Person>>(fileContent);
            return _people.ToList();
        }

        public void SaveChanges() 
        {
            string serializedPeople=JsonSerializer.Serialize(_people);
            File.WriteAllText(@"C:\Users\iyazici\source\repos\Tu\WpfRehber\TuSollution\bin\Debug\net5.0-windows\Kisiler.json", serializedPeople);

        }

    }
}
