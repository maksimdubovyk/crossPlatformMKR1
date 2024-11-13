using Mkr;

namespace MkrTests
{
    public class GetMaxProfitTest
    {
        [Theory]
        [InlineData(new int[] { 73, 31, 96, 24, 46 }, 380)]
        [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 55)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 100)]
        [InlineData(new int[] { 15, 3, 27, 8, 20, 5, 15 }, 151)]
        [InlineData(new int[] { 5, 5, 5, 5, 5 }, 25)]
        public void GetMaxProfit_VariousInputs_ReturnsExpectedResult(int[] prices, int expected)
        {
            // Act
            int result = ProfitUtils.GetMaxProfit(prices);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}