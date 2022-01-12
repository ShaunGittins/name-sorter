using System;
using System.Collections;

namespace name_sorter
{
    public class Person
    {
        public Person(string fullName)
        {
            FirstNames = fullName[..fullName.LastIndexOf(" ")];
            LastName = fullName[(fullName.LastIndexOf(" ") + 1)..];
        }

        public string FirstNames { get; set; }
        public string LastName { get; set; }

        public string GetFullName
        {
            get
            {
                return string.Join(' ', FirstNames) + ' ' + LastName;
            }
        }
    }
}
