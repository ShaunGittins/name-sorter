using Xunit;

namespace name_sorter.xUnitTest
{
    public class CompareByLastNameOnlyTest
    {
        [Theory]
        [InlineData("Kristen Stewart", "Martha Stewart")]
        [InlineData("Will Smith", "Jaden Smith")]
        [InlineData("Mariah Carey", "Drew Carey")]
        [InlineData("Beau Tristan Bentley", "Harry Bentley")]
        public void TestSameLastName(string mockPersonLeftString, string mockPersonRightString)
        {
            CompareByLastNameOnly comparer = new();

            Person mockPersonLeft = new(mockPersonLeftString);
            Person mockPersonRight = new(mockPersonRightString);

            int actual = comparer.Compare(mockPersonLeft, mockPersonRight);
            int expected = 0; // zero means the comparer considers them equal

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Harry Potter", "Ron Weasley")]
        [InlineData("Marin Alvarez", "Adonis Julius Archer")]
        [InlineData("Beau Tristan Bentley", "Hunter Uriah Mathew Clarke")]
        [InlineData("Leo Gardner", "Shelby Nathan Yoder")]
        public void TestDifferentLastNameAlreadySorted(string mockPersonLeftString, string mockPersonRightString)
        {
            CompareByLastNameOnly comparer = new();

            Person mockPersonLeft = new(mockPersonLeftString);
            Person mockPersonRight = new(mockPersonRightString);

            int actual = comparer.Compare(mockPersonLeft, mockPersonRight);
            int expected = -1; // negative means the comparer considers first value lower (first)

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Ron Weasley", "Harry Potter")]
        [InlineData("Frankie Conner Ritter", "Mikayla Lopez")]
        [InlineData("Janet Parsons", "Vaughn Lewis")]
        [InlineData("Beau Tristan Bentley", "Marin Alvarez")]
        public void TestDifferentLastNameNotAlreadySorted(string mockPersonLeftString, string mockPersonRightString)
        {
            CompareByLastNameOnly comparer = new();

            Person mockPersonLeft = new(mockPersonLeftString);
            Person mockPersonRight = new(mockPersonRightString);

            int actual = comparer.Compare(mockPersonLeft, mockPersonRight);
            int expected = 1; // positive means the comparer considers first value higher (second)

            Assert.Equal(expected, actual);
        }
    }
}
