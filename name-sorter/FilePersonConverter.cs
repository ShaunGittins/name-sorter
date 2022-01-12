using System.Collections.Generic;

namespace name_sorter
{
    public static class FilePersonConverter
    {
        public static List<Person> ToPersonList(List<string> stringList)
        {
            List<Person> result = new();
            foreach (string person in stringList)
            {
                result.Add(new(person));
            }
            return result;
        }

        public static List<string> ToStringList(List<Person> personList)
        {
            List<string> result = new();
            foreach (Person person in personList)
            {
                result.Add(person.GetFullName);
            }
            return result;
        }
    }
}
