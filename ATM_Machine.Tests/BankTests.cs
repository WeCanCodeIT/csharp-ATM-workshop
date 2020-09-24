using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xunit;

namespace ATM_Machine.Tests
{
    public class BankTests
    {
        Bank myBank;

        public BankTests()
        {
            myBank = new Bank();
        }

        [Fact]
        public void AddAccount_Should_Increase_List_Count_by_1()
        {
            // Arrange
            myBank.ListOfAccounts.Clear();
            Account newAccount = new Account();

            // Act
            myBank.AddAccount(newAccount);

            // Assert
            Assert.Single(myBank.ListOfAccounts);
        }
    }
}
