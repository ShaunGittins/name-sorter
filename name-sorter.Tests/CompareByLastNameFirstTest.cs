using Xunit;

namespace name_sorter.xUnitTest
{
    public class CompareByLastNameFirstTest
    {
        [Theory]
        [InlineData("Kristen Stewart", "Kristen Stewart")]
        [InlineData("Will Smith", "Will Smith")]
        [InlineData("Beau Tristan Bentley", "Beau Tristan Bentley")]
        public void TestExactSameName(string mockPersonLeftString, string mockPersonRightString)
        {
            CompareByLastnameFirst comparer = new();

            Person mockPersonLeft = new(mockPersonLeftString);
            Person mockPersonRight = new(mockPersonRightString);

            int actual = comparer.Compare(mockPersonLeft, mockPersonRight);
            int expected = 0; // zero means the comparer considers them equal

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Kristen Stewart", "Martha Stewart")]
        [InlineData("Will Smith", "Jaden Smith")]
        [InlineData("Mariah Carey", "Drew Carey")]
        [InlineData("Beau Tristan Bentley", "Harry Bentley")]
        public void TestSameLastNameDifferentFirstNames(string mockPersonLeftString, string mockPersonRightString)
        {
            CompareByLastnameFirst comparer = new();

            Person mockPersonLeft = new(mockPersonLeftString);
            Person mockPersonRight = new(mockPersonRightString);

            int actual = comparer.Compare(mockPersonLeft, mockPersonRight);
            int notExpected = 0; // zero means the comparer considers them equal

            Assert.NotEqual(notExpected, actual);
        }

        [Theory]
        [InlineData("Harry Potter", "Ron Weasley")]
        [InlineData("Marin Alvarez", "Adonis Julius Archer")]
        [InlineData("Beau Tristan Bentley", "Hunter Uriah Mathew Clarke")]
        [InlineData("Leo Gardner", "Shelby Nathan Yoder")]
        [InlineData("Leo Gardner", "Shelby Gardner")]
        [InlineData("Leo Jones Gardner", "Shelby Gardner")]
        [InlineData("Harry Potter", "James Potter")]
        public void TestDifferentLastNameAlreadySorted(string mockPersonLeftString, string mockPersonRightString)
        {
            CompareByLastnameFirst comparer = new();

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
        [InlineData("Marin Bentley", "Beau Tristan Bentley")]
        [InlineData("Shelby Gardner", "Leo Gardner")]
        [InlineData("James Potter", "Harry Potter")]
        public void TestDifferentLastNameNotAlreadySorted(string mockPersonLeftString, string mockPersonRightString)
        {
            CompareByLastnameFirst comparer = new();

            Person mockPersonLeft = new(mockPersonLeftString);
            Person mockPersonRight = new(mockPersonRightString);

            int actual = comparer.Compare(mockPersonLeft, mockPersonRight);
            int expected = 1; // positive means the comparer considers first value higher (second)

            Assert.Equal(expected, actual);
        }
    }
}
