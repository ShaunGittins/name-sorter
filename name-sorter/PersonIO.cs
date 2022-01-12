using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter
{
    internal class PersonIO
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

        internal static void Write(IListWriter writer, List<Person> people)
        {
            List<string> sortedPeople = FilePersonConverter.ToStringList(people);
            writer.WriteList(sortedPeople);
        }
    }
}
