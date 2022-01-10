using System.Collections;
using System.Collections.Generic;

namespace name_sorter
{
    internal class CompareByLastnameFirst : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return new CaseInsensitiveComparer().Compare(x.LastName, y.LastName);
        }
    }
}
