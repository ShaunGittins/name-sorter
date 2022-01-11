﻿using System;
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
                string path = Directory.GetCurrentDirectory();
                List<string> unsortedPeople = File.ReadAllLines(path + fileName).ToList();

                List<string> sortedPeople = PeopleSorter.Sort(unsortedPeople, new CompareByLastnameFirst());

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
