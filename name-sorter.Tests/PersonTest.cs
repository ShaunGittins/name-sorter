using System;
using Xunit;
using name_sorter;

namespace name_sorter.xUnitTest
{
    public class PersonTest
    {
        [Fact]
        public void TestGetFullName()
        {
            string[] firstNames = new string[] { "Peter", "Benjamin" };
            string lastName = "Parker";

            Person person = new();
            person.FirstNames = firstNames;
            person.LastName = lastName;

            string expected = "Peter Benjamin Parker";
            string actual = person.GetFullName;

            Assert.Equal(expected, actual);
        }
    }
}
