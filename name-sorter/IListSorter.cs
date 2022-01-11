using System.Collections.Generic;

namespace name_sorter
{
    public interface IListSorter
    {
        public List<string> Sort(List<string> sortableList, IComparer<Person> comparer);
    }
}
