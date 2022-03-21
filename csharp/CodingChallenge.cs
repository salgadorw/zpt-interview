using Interview.Fixtures;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Interview
{
 
    public class CodingChallenge: IClassFixture<TestsFixture>
    {
        private readonly TestsFixture fixture; 

        public CodingChallenge(TestsFixture fixture)
		{

            this.fixture = fixture;
		}

        [Fact]
        public void Test()
        {
            //arrange
            var converter = new ConvertRomanToArabicNumber();
            var number = "I";
            //act

           var result = converter.Convert(number);

            //assert

            Assert.Equal(1,result);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            var converter = new ConvertRomanToArabicNumber();
            var number = "IV";
            //act

            var result = converter.Convert(number);

            //assert

            Assert.Equal(4, result);
        }

        [Fact]
        public void Test3()
        {
            //arrange
            var converter = new ConvertRomanToArabicNumber();
            var number = "CMXCIV";
            //act

            var result = converter.Convert(number);

            //assert

            Assert.Equal(994, result);
        }

        [Fact]
        public void FixtureData_True_DataDefaultSizeGenerated()
		{
            var randomNumbers = fixture.GeneateRandomNumbers();		
            Assert.True(randomNumbers.Count() == 100);
        }

        [Fact]
        public void FixtureData_True_DataGenerated()
        {
            var randomNumbers = fixture.GeneateRandomNumbers(totalNumbers:1);
            Assert.True(randomNumbers.Any());
        }
    }
}
