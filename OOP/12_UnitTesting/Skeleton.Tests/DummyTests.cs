using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int dummyHealth = 10;
        private const int dummyxp = 100;

        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
           this.dummy = new Dummy(dummyHealth, dummyxp);
        }

        [TestCase(10, 10)]
        public void DummyLossesHealthIfAttacs(int health, int xp)
        {
            Dummy dummy = new Dummy(health, xp);
            dummy.TakeAttack(5);

            var expected = 5;
            var actual = dummy.Health;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DeadDummyThrowExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(0, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(20));
        }

        [Test]
        public void DeadDummyCanGIveXp()
        {
            Dummy dummy = new Dummy(0, 10);

            var expected = 10;
            var actual = dummy.GiveExperience();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AliveDummyCanNotGiveXp()
        {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience(),
                "Alive dummie give XP !");
        }

        [Test]
        public void CotainsString()
        {
            string expected = "123";

            Assert.That(expected, Does.Contain("1"));
        }

        [Test]
        public void CollectionContains()
        {
            var collection = Enumerable.Range(0, 100);

            Assert.That(collection, Has.Member(4));
        }

        [TearDown]
        public void Clean()
        {

        }
    }
}
