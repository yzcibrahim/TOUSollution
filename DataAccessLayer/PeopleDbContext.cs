using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PeopleDbContext:DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options):base(options)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
