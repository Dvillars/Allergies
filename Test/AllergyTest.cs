using Xunit;

namespace Allergies
{
    public class AllergyTest
    {
        [Fact]
        public void CoinCount_ConvertInputToCoins_75To3Quarters()
        {
            //Arrange
            int test = 75;
            Coin testCoin = new Coin();

            //Act
            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            //Assert
            Assert.Equal("3 Quarters ", result);
        }
    }
}
