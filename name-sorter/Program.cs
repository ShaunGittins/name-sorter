using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sortedFile = @"\sorted-names-list.txt";

            if (args.Length == 1)
            {
                // Read File
                string path = Directory.GetCurrentDirectory();
                string unsortedFile = args[0];
                List<string> unsortedPeople = File.ReadAllLines(path + unsortedFile).ToList();

                // Sort
                List<Person> people = new();
                foreach (string person in unsortedPeople) people.Add(new(person));

                people.Sort(new CompareByLastnameFirst());

                List<string> sortedPeople = new();
                foreach (Person person in people) sortedPeople.Add(person.GetFullName);

                // Write FIle
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
