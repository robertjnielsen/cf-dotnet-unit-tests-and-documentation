using System;
using Xunit;
using UnitTestingAndDocumentation;

namespace UnitTestingAndDocumentationTests
{
    public class ProgramTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        [InlineData(30)]
        public void WithdrawFundsShouldReturnPositiveBalance(decimal testAmount)
        {
            bool positiveBalance = Program.WithdrawFunds(testAmount) > 0;
            Assert.True(positiveBalance);
        }

        [Fact]
        public void WithdrawFundsShouldNotReturnNegativeBalance()
        {
            decimal testAmount = 100000;
            bool negativeBalance = Program.WithdrawFunds(testAmount) > 0;
            Assert.True(negativeBalance);
        }
    }
}
