using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Singleton.DbContexts;
using ITechart.Patterns.Singleton.Models;
using ITechart.Patterns.Singleton.Signals;

namespace ITechart.Patterns.Singleton
{
    class AccessToDB : IDisposable
    {
        private static PersonContext db;

        private static AccessToDB Access;

        public List<Person> People { get; private set; }

        private AccessToDB(List<Person> people)
        {
            People = people;
        }

        public static AccessToDB GetAccess()
        {
            if(Access == null)
            {
                db = new PersonContext();
                var dbpeople = db.People;
                var people = new List<Person>();
                foreach(Person person in dbpeople)
                {
                    people.Add(new Person() { Id = person.Id, Name = person.Name, Age = person.Age });
                }
                Access = new AccessToDB(people);
            }
            else
            {
                SingletonSignal.Signal();
            }
            return Access;
        }

        public void Dispose()
        {
            db.Dispose();
            Access = null;
            DisposeSignal.Signal();
        }
    }
}
