using System.Collections.Generic;

namespace name_sorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = PersonFile.Read(args);

            CompareByLastnameFirst comparer = new();
            people.Sort(comparer);

            PersonFile.Write(people, @"\sorted-names-list.txt");

            PersonListPrinter.PrintAllPeople(people);
        }
    }
}
