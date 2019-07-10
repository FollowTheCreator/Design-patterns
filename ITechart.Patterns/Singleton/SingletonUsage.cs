using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Singleton.DbContexts;
using ITechart.Patterns.Singleton.Models;

namespace ITechart.Patterns.Singleton
{
    class SingletonUsage
    {
        public static void UseSingleton()
        {
            Console.WriteLine("First access:");
            var context = GetContext();
            var people = context.People
                        .ToList()
                        .Select(person => new Person()
                        {
                            Id = person.Id,
                            Name = person.Name,
                            Age = person.Age
                        })
                        .ToList();
            PeopleOuput(people);

            Console.WriteLine("\nTrying to another access while singleton instance exists:");
            var context2 = GetContext();
            var agesSum = context.People.Sum(item => item.Age);
            Console.WriteLine($"Sum of ages: {agesSum}");
        }

        private static PersonContext GetContext()
        {
            return AccessToDB.GetContext(
                () => Console.WriteLine("new instance was created"),
                () => Console.WriteLine("using existing instance")
            );
        }

        private static void PeopleOuput(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person?.Name}, Age: {person?.Age}");
            }
        }
    }
}
