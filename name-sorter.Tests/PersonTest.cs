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
            string fullName = "Peter Benjamin Parker";

            Person person = new(fullName);

            string expected = "Peter Benjamin Parker";
            string actual = person.GetFullName;

            Assert.Equal(expected, actual);
        }
    }
}
