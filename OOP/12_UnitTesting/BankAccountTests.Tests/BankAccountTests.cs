using System;
using NUnit.Framework;
using UnitTestingLab;

namespace Problem01.Tests
{
    public class BankAccountTests
    {
        [Test]
        public void ValidateDepositAmount()
        {
            //Arrange
            BanckAccount banckAccount = new BanckAccount();

            //Act
            var expectedResult = 20;
            banckAccount.Deposit(20);
            var actual = banckAccount.Amount;

            //Assert    
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
