using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter
{
    internal class PersonFile
    {
        internal static List<Person> Read(string[] args)
        {
            List<Person> result = new();
            if (args.Length == 1)
            {
                List<string> content = File.ReadAllLines(Directory.GetCurrentDirectory() + args[0]).ToList();
                result = FilePersonConverter.ToPersonList(content);
            }
            else
            {
                Console.WriteLine("No source text file entered.\n");
            }
            return result;
        }

        internal static void Write(List<Person> people, string targetFile)
        {
            List<string> sortedPeople = FilePersonConverter.ToStringList(people);
            File.WriteAllLines(Directory.GetCurrentDirectory() + targetFile, sortedPeople);
        }
    }
}
