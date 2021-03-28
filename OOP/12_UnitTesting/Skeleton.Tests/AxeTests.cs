using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DurabilityAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10,10);
            Dummy dummy = new Dummy(10,10);
        
            //Act
            axe.Attack(dummy);
            var expected = 9;
            var acctual = axe.DurabilityPoints;

            //Assert
            Assert.AreEqual( expected, acctual );
        }

        [Test]
        public void AttackWithBrockenWeapon()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);
            
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy)); // if throws Expeseption

            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message); // if returns any message

        }
    }
}