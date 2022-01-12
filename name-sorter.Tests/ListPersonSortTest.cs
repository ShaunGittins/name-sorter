using System.Collections.Generic;
using Xunit;

namespace name_sorter.xUnitTest
{
    public class ListPersonSortTest
    {
        [Fact]
        public void TestPersonSort()
        {
            List<Person> people = new() { new Person("Bob Parsons"), new Person("Alex Alvarez"), new Person("Charlie Gardner") };

            MockFirstNameOnlyComparer comparer = new();
            people.Sort(comparer);

            string[] actual = new string[] { people[0].GetFullName, people[1].GetFullName, people[2].GetFullName };
            string[] expected = new string[] { "Alex Alvarez", "Bob Parsons", "Charlie Gardner" };

            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
            Assert.Equal(expected[2], actual[2]);
        }
    }

    internal class MockFirstNameOnlyComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.FirstNames.CompareTo(y.FirstNames);
        }
    }
}
