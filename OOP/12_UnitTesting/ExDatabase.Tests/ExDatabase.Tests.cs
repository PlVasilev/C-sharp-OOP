using System;
using System.Linq;
using System.Reflection;

namespace ExDatabase.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ExDatabaseTests
    {
        private const int ArreyLeght = 16;
        private const int InitalArrayIndex = -1;

        [Test]
        public void EmptyConstructorShouldIntData() // For Constructor
        {
            Database<int> db = new Database<int>();

            Type type = typeof(Database<int>);

            var field = (int[])type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                 .First(f => f.Name == "data")
                 .GetValue(db);

            var lenght = field.Length;

            Assert.AreEqual(lenght, ArreyLeght, "Internal Array.Length is not 16");
        }

        [Test]
        public void EmptyConstructorShouldIntIndexTOMinusOne() // For fileds
        {
            Database<int> db = new Database<int>();

            Type type = typeof(Database<int>);

            var indexValue = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(db);

            Assert.AreEqual(indexValue, InitalArrayIndex, "Initial Array index Must be -1!");
        }

        [TestCase(ArreyLeght + 1)]
        public void CtorShouldThrowInvalidOperationException(int length) // for exception with testcase
        {
            Assert.Throws<InvalidOperationException>
                (() => new Database<int>(new int[length]), "Does Not Throw Exception");
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 100 })]
        [TestCase(new int[] { 32, 21, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void IndexPositionShouldBeSettedCorrectly(int[] values)
        {
            Database<int> db = new Database<int>(values);

            int expectedIndex = values.Length - 1;

            Type type = typeof(Database<int>);
            var indexValue = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(db);

            Assert.AreEqual(expectedIndex, indexValue, "Index values is not as expected!");
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 100 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        public void ShouldAddElementToNextIndex(int[] values)
        {
            Database<int> db = new Database<int>(values);
            db.Add(1);
            Type type = typeof(Database<int>);
            var indexValue = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(db);

            int expected = values.Length;

            Assert.AreEqual(expected, indexValue, "Index values is not as expected!");
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void AddShouldThrowExceptionWhenIsFull(int[] values)
        {
            Assert.Throws<InvalidOperationException>((() =>
            {
                Database<int> db = new Database<int>(values);
                db.Add(1);
            }));
        }

        [TestCase(new int[] { 100 })]
        public void RemoveShloudDecreaceIndex(int[] values)
        {
            Database<int> db = new Database<int>(values);
            db.Remove();

            Type type = typeof(Database<int>);
            var indexValue = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(db);
            int expectedIndex = values.Length - 2;

            Assert.That(indexValue, Is.EqualTo(expectedIndex), "Index is not with correct value after remove");
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenIsEmpty()
        {
            Assert.Throws<InvalidOperationException>((() =>
            {
                Database<int> db = new Database<int>();
                db.Remove();
            }));
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 100 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldReturnElementCorrectly(int[] values)
        {
            Database<int> database = new Database<int>(values);
            int[] result = database.Fetch();
            Type type = typeof(Database<int>);

            var field = (int[])type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "data")
                .GetValue(database);

            Assert.AreEqual(result,field);
        }
    }
}
