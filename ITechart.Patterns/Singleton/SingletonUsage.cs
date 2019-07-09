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
            using (AccessToDB access = AccessToDB.GetAccess())
            {
                PeopleOuput(access);

                Console.WriteLine("\nTrying to another access while singleton instance exists:");
                using (AccessToDB anotherAccess = AccessToDB.GetAccess()) { }
            }

            Console.WriteLine("\nTrying to another access after the instance dispose:");
            using (AccessToDB access = AccessToDB.GetAccess())
            {
                PeopleOuput(access);
            }
        }

        private static void PeopleOuput(AccessToDB access)
        {
            foreach (var person in access.People)
            {
                Console.WriteLine($"Name: {person?.Name}, Age: {person?.Age}");
            }
        }
    }
}
