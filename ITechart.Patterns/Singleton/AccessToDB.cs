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
        private static PersonContext _db;

        private static AccessToDB _access;

        private bool disposed = false;

        public List<Person> People { get; private set; }

        private AccessToDB(List<Person> people)
        {
            People = people;
        }

        public static AccessToDB GetAccess()
        {
            if(_access == null)
            {
                _db = new PersonContext();

                var people = _db.People
                    .ToList()
                    .Select(person => new Person()
                    {
                        Id = person.Id,
                        Name = person.Name,
                        Age = person.Age
                    })
                    .ToList();

                _access = new AccessToDB(people);
            }
            else
            {
                SingletonSignal.Signal();
            }
            return _access;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            DisposeSignal.Signal();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                _access = null;
                disposed = true;
            }
        }
    }
}
