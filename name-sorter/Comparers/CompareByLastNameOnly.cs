using System.Collections;
using System.Collections.Generic;

namespace name_sorter
{
    public class CompareByLastNameOnly : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return new CaseInsensitiveComparer().Compare(x.LastName, y.LastName);
        }
    }
}
