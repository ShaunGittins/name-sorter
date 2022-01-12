using System.Collections.Generic;

namespace name_sorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileListReader fileReader = new(args.Length > 0 ? args[0] : "unsorted-names-list.txt");
            List<Person> people = PersonIO.Read(fileReader);

            CompareByLastnameFirst comparer = new();
            people.Sort(comparer);

            FileListWriter fileWriter = new(@"\sorted-names-list.txt");
            PersonIO.Write(fileWriter, people);

            ConsoleListWriter consoleWriter = new();
            PersonIO.Write(consoleWriter, people);
        }
    }
}
