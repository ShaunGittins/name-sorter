using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter
{
    internal class Program
    {
        static void Main(string[] fileName)
        {
            string sortedFile = @"\sorted-names-list.txt";

            if (fileName.Length == 1)
            {
                // Read file
                string path = Directory.GetCurrentDirectory();
                List<string> content = File.ReadAllLines(path + fileName[0]).ToList();
                List<Person> people = FilePersonConverter.ToPersonList(content);

                // Sort
                CompareByLastnameFirst comparer = new();
                people.Sort(comparer);

                // Write File
                List<string> sortedPeople = FilePersonConverter.ToStringList(people);
                File.WriteAllLines(path + sortedFile, sortedPeople);

                // Print to console
                Console.WriteLine("Sorted People:");
                foreach (string person in sortedPeople) Console.WriteLine(person);
            }
            else
            {
                Console.WriteLine("No source text file entered.\n");
            }
        }
    }
}
