using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ATM_Machine.Tests
{
    public class CheckingTests
    {
        Checking myChecking;

        public CheckingTests()
        {
            myChecking = new Checking();        
        }

        [Fact]
        public void New_Checking_Should_Set_Minimum_Required_Balance_of_200()
        {
            // Arrange 

            // Act

            // Assert
            Assert.Equal(200.00, myChecking.MinimumRequiredBalance);
        }

        [Fact]
        public void New_Checking_Should_Set_Check_Number_to_1()
        {
            // Arrange 

            // Act

            // Assert
            Assert.Equal(1, myChecking.CheckNumber);

        }

        [Fact]
        public void WriteCheck_Should_Increase_CheckNumber_by_1()
        {
            // Arrange 
            myChecking.CheckNumber = 1;

            // Act
            myChecking.WriteCheck();

            // Assert
            Assert.Equal(2, myChecking.CheckNumber);
        }







    }
}
