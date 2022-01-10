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
                string path = Directory.GetCurrentDirectory();
                string unsortedFile = args[0];
                List<string> unsortedPeople = File.ReadAllLines(path + unsortedFile).ToList();

                List<Person> people = new();
                foreach (string person in unsortedPeople)
                {
                    Person newPerson = new();
                    string[] splitNames = person.Split(' ');

                    newPerson.FirstNames = splitNames[..^1];
                    newPerson.LastName = splitNames[^1];

                    people.Add(newPerson);
                }

                people.Sort(new CompareByLastnameFirst());

                List<string> sortedPeople = new();
                Console.WriteLine("Sorted People:");
                foreach (Person person in people)
                {
                    Console.WriteLine(person.GetFullName);
                    sortedPeople.Add(person.GetFullName);
                }

                File.WriteAllLines(path + sortedFile, sortedPeople);
            }
            else
            {
                Console.WriteLine("No source text file entered.\n");
            }
        }
    }
}
