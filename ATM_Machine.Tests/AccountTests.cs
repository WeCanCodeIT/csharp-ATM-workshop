using System;
using Xunit;

namespace ATM_Machine.Tests
{
    public class AccountTests
    {
        Account myAccount = new Account();

        [Fact]
        public void New_ATM_Should_Have_Balance_of_100()
        {
            // Arrange
            

            // Act

            // Assert
            Assert.Equal(100.00, myAccount.Balance);
        }

        [Fact]
        public void GetBalance_Should_Return_Our_Balance()
        {
            //Arrange
            myAccount.Balance = 1000;

            //Act
            double myBalance = myAccount.GetBalance();

            //Assert
            Assert.Equal(1000, myBalance);
        }

        [Fact]
        public void Withdraw_Should_Decrease_Balance_by_10()
        {
            //Arrange


            //Act
            myAccount.Withdraw();

            //Assert
            Assert.Equal(90, myAccount.Balance);
        }

        [Fact]
        public void Deposit_Should_Increase_Balance_by_50()
        {
            //Arrange

            //Act
            myAccount.Deposit();

            //Assert
            Assert.Equal(150, myAccount.Balance);
        }

        [Fact]
        public void Deposit_Specific_Amount_Should_Increase_Balance_by_Amount()
        {
            //Arrange


            //Act
            myAccount.Deposit(100);

            //Assert
            Assert.Equal(200, myAccount.Balance);
        }

    }
}
