using System.Collections.Generic;

namespace name_sorter
{
    public class PeopleSorter
    {
        public static List<string> Sort(List<string> unsortedPeople, IComparer<Person> comparer)
        {
            List<Person> people = new();
            foreach (string person in unsortedPeople) people.Add(new(person));

            people.Sort(comparer);

            List<string> sortedPeople = new();
            foreach (Person person in people) sortedPeople.Add(person.GetFullName);

            return sortedPeople;
        }
    }
}
