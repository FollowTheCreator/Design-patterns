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
    static class AccessToDB
    {
        private static PersonContext _db;

        public static PersonContext GetContext(Action onNew, Action onExisting)
        {
            if(_db == null)
            {
                onNew?.Invoke();
                _db = new PersonContext();
            }
            else
            {
                onExisting?.Invoke();
            }

            return _db;
        }
    }
}
