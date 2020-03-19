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
            bool positiveBalance = Program.WithdrawFunds(testAmount) <= Program.Balance;
            Assert.True(positiveBalance);
        }

        [Fact]
        public void WithdrawFundsShouldNotReturnNegativeBalance()
        {
            decimal testAmount = 100000;
            bool negativeBalance = Program.WithdrawFunds(testAmount) == Program.Balance;
            Assert.True(negativeBalance);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(839.94)]
        public void DepositFundsShouldOnlyDepositPositiveAmounts(decimal depositAmount)
        {
            bool positiveDeposit = Program.DepositFunds(depositAmount) > Program.Balance;
            Assert.True(positiveDeposit);
        }

        [Fact]
        public void DepositFundsShouldNotDepositNegativeAmounts()
        {
            decimal testAmount = -143.50M;
            bool negativeDeposit = Program.DepositFunds(testAmount) == Program.Balance;
            Assert.True(negativeDeposit);
        }
    }
}
