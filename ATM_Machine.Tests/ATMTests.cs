using System;
using Xunit;

namespace ATM_Machine.Tests
{
    public class ATMTests
    {
        [Fact]
        public void New_ATM_Should_Have_Balance_of_100()
        {
            // Arrange
            ATM myATM = new ATM();

            // Act

            // Assert
            Assert.Equal(100.00, myATM.Balance);
        }

        [Fact]
        public void GetBalance_Should_Return_Our_Balance()
        {
            //Arrange
            ATM myATM = new ATM();
            myATM.Balance = 1000;

            //Act
            double myBalance = myATM.GetBalance();

            //Assert
            Assert.Equal(1000, myBalance);
        }

        [Fact]
        public void Withdraw_Should_Decrease_Balance_by_10()
        {
            //Arrange
            ATM myATM = new ATM();

            //Act
            myATM.Withdraw();

            //Assert
            Assert.Equal(90, myATM.Balance);
        }

    }
}
