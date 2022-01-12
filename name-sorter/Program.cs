using System.Collections.Generic;

namespace name_sorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = PersonIO.Read(args);

            CompareByLastnameFirst comparer = new();
            people.Sort(comparer);

            FileListWriter fileWriter = new(@"\sorted-names-list.txt");
            PersonIO.Write(fileWriter, people);

            ConsoleListWriter consoleWriter = new();
            PersonIO.Write(consoleWriter, people);
        }
    }
}
