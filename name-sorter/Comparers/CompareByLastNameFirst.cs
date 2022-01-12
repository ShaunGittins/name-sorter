using System.Collections.Generic;

namespace name_sorter
{
    public class CompareByLastnameFirst : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.LastName.CompareTo(y.LastName);
            if (result == 0) result = x.FirstNames.CompareTo(y.FirstNames);
            return result;
        }
    }
}
