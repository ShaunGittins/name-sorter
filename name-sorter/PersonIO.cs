using System.Collections.Generic;

namespace name_sorter
{
    internal class PersonIO
    {
        internal static List<Person> Read(IListReader reader)
        {
            List<string> people = reader.ReadList();
            return FilePersonConverter.ToPersonList(people);
        }

        internal static void Write(IListWriter writer, List<Person> people)
        {
            List<string> sortedPeople = FilePersonConverter.ToStringList(people);
            writer.WriteList(sortedPeople);
        }
    }
}
