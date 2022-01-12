using System;
using System.Collections.Generic;

namespace name_sorter
{
    public static class PersonListPrinter
    {
        public static void PrintAllPeople(List<Person> people)
        {
            if (people.Count != 0)
            {
                Console.WriteLine("Sorted People:");
                foreach (Person person in people) Console.WriteLine(person.GetFullName);
            }
        }
    }
}
