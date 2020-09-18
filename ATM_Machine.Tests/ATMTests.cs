using System;
using Xunit;

namespace ATM_Machine.Tests
{
    public class ATMTests
    {
        ATM myAtm;

        public ATMTests()
        {
            myAtm = new ATM();
        }

        [Fact]
        public void New_ATM_Should_Have_Balance_of_100()
        {
            // Arrange
            // ATM myAtm = new ATM();

            // Act

            // Assert
            Assert.Equal(100.00, myAtm.Balance);
        }

        [Fact]
        public void GetBalance_Should_Return_Our_Balance()
        {
            // Arrange
            // ATM myAtm = new ATM();
            myAtm.Balance = 1000000;

            // Act
            double myBalance = myAtm.GetBalance();

            // Assert
            Assert.Equal(1000000, myBalance);
        }

        [Fact]
        public void Withdraw_Should_Decrease_Balance_by_10()
        {
            // Arrange
            myAtm.Balance = 50;
            double finalBalance = myAtm.Balance - 10;

            // Act
            myAtm.Withdraw();

            // Assert
            Assert.Equal(finalBalance, myAtm.Balance);

        }
    }
}
