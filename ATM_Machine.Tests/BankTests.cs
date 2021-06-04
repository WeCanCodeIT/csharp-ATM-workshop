using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATM_Machine.Tests
{
    public class BankTests
    {
        public Bank myBank;
        public BankTests()
        {
            myBank = new Bank();
        }

        [Fact]
        public void AddAccount_Should_Increase_List_Count_by_1()
        {
            // Arrange

            // Act
            myBank.AddAccount(new Savings());

            // Assert
            Assert.Single(myBank.ListOfAccounts);
        }

        [Fact]
        public void RemoveAccount_Should_Decrease_List_Count_by_1()
        {
            // Arrange
            myBank.AddAccount(new Checking());

            // Act
            myBank.RemoveAccount(0);

            // Assert
            Assert.Empty(myBank.ListOfAccounts);

        }

        [Fact]
        public void SearchForAccount_Should_Return_an_Account()
        {
            // Arrange
                        
            // Act

            // Assert
        }

    }
}
