using NUnit.Framework;
using Answer;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase(7, 1, 5, 3, 6, 4, ExpectedResult = 5)]
        [TestCase(7, 6, 4, 3, 1, ExpectedResult = 0)]
        [TestCase(ExpectedResult = 0)]
        public int MaxProfit(params int[] prices)
        {
            var sut = new Solution();

            return sut.MaxProfit(prices);
        }
    }
}