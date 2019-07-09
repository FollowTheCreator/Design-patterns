using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Singleton.Models;

namespace ITechart.Patterns.Singleton.DbContexts
{
    class PersonContext : DbContext
    {
        public PersonContext() : base("Person") { }

        public DbSet<Person> People { get; set; }
    }
}
