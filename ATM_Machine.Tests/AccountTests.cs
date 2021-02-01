using System;
using Xunit;

namespace ATM_Machine.Tests
{
    public class AccountTests
    {
        Account myAccount;

        public AccountTests()
        {
            myAccount = new Account();
        }


        [Fact]
        public void New_Account_Should_Have_Balance_of_100()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(100.00, myAccount.Balance);

        }

        [Fact]
        public void GetBalance_Should_Return_Our_Balance()
        {
            // Arrange
            // Account myAccount = new Account();
            myAccount.Balance = 1000;

            // Act
            double myBalance = myAccount.GetBalance();

            // Assert
            Assert.Equal(1000, myBalance);
        }

        [Fact]
        public void Withdraw_Should_Decrease_Balance_By_10()
        {
            // Arrange
            // Account myAccount = new Account();
            myAccount.Balance = 50;
            double finalBalance = myAccount.Balance - 10;

            // Act
            myAccount.Withdraw();

            // Assert
            Assert.Equal(finalBalance, myAccount.Balance);

        }

        [Fact]
        public void Deposit_Should_Increase_Balance_By_50()
        {
            // Arrange
            myAccount.Balance = 50;
            double finalBalance = myAccount.Balance + 50;

            //Act
            myAccount.Deposit();

            // Assert
            Assert.Equal(100, myAccount.Balance);

        }











    }
}
