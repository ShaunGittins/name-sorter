using Xunit;

namespace name_sorter.xUnitTest
{
    public class CompareByLastNameOnlyTest
    {
        [Fact]
        public void TestSameLastName()
        {
            CompareByLastNameOnly comparer = new();

            Person[] mockPeople = { new("Kristen Stewart"), new("Martha Stewart") };

            int actual = comparer.Compare(mockPeople[0], mockPeople[1]);
            int expected = 0; // zero means the comparer considers them equal

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDifferentLastNameAlreadySorted()
        {
            CompareByLastNameOnly comparer = new();

            Person[] mockPeople = { new("Harry Potter"), new("Ron Weasley") };

            int actual = comparer.Compare(mockPeople[0], mockPeople[1]);
            int expected = -1; // negative means the comparer considers first value lower (first)

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDifferentLastNameNotAlreadySorted()
        {
            CompareByLastNameOnly comparer = new();

            Person[] mockPeople = { new("Ron Weasley"), new("Harry Potter") };

            int actual = comparer.Compare(mockPeople[0], mockPeople[1]);
            int expected = 1; // positive means the comparer considers first value higher (second)

            Assert.Equal(expected, actual);
        }
    }
}
