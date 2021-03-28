using System;
using CustomLinkedList;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private DynamicList<int> dynamicListInt;
        private const int initalCount = 0;

        [SetUp]
        public void Setup()
        {
            dynamicListInt = new DynamicList<int>();
        }

        [Test]
        public void IsInitialized()
        {
            Assert.IsNotNull(dynamicListInt, "DynamicList is Not initialized");
        }

        [Test]
        public void InitializeCorrectly()
        {
            int expectedCount = initalCount;
            int actiualCount = dynamicListInt.Count;
            Assert.AreEqual(expectedCount, actiualCount, "DynamicList is Not initialized Correctly");
        }

        [Test]
        public void IndexAccessShouldGetValue()
        {
            dynamicListInt.Add(13);
            int element = dynamicListInt[0];
            Assert.That(element, Is.EqualTo(13));
        }

        [Test]
        public void IndexAccessShouldSetValue()
        {
            dynamicListInt.Add(13);
            dynamicListInt[0] = 42;
            Assert.That(dynamicListInt[0], Is.EqualTo(42));
        }

        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        [TestCase(100)]
        public void WhenGetIndexOperatorShouldThrowArgumentOutOfRangeException(int index)
        {
            for (int i = 0; i < 10; i++)
            {
                dynamicListInt.Add(i);
            }
            int returnValue = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => returnValue = dynamicListInt[index]);
        }

        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        [TestCase(100)]
        public void WhenSetIndexOperatorShouldThrowArgumentOutOfRangeException(int index)
        {
            for (int i = 0; i < 10; i++)
            {
                dynamicListInt.Add(i);
            }
            int returnValue = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicListInt[index] = 100, "Message");
        }

        [Test]
        public void AddNodeToTheEndOfTheList()
        {
            dynamicListInt.Add(3);
            Assert.AreEqual(dynamicListInt[0], 3, "Add Method does not work");
            dynamicListInt.Add(4);
            Assert.AreEqual(dynamicListInt[1], 4, "Add method does not work");
        }

        [TestCase(0)]
        [TestCase(1)]
        public void RemoveAtTestShouldRemoveAtIndex(int index)
        {
            dynamicListInt.Add(3);
            dynamicListInt.Add(4);
            var element = dynamicListInt[index];
            var returnElement = dynamicListInt.RemoveAt(index);
            Assert.AreEqual(element, returnElement, "Return does Not give the proper value");
        }

        [TestCase(-1)]
        [TestCase(2)]
        public void RemoveAtTestShouldThrowArgumentOutOfRangeException(int index)
        {
            dynamicListInt.Add(3);
            dynamicListInt.Add(4);
            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicListInt.RemoveAt(index));
        }

        [TestCase(3)]
        [TestCase(4)]
        public void RemoveTestShouldRemoveTheElementAndReturnIndex(int element)
        {
            dynamicListInt.Add(3);
            dynamicListInt.Add(4);
            Assert.That(dynamicListInt.Remove(element) >= 0);
        }

        [TestCase(3)]
        [TestCase(4)]
        public void RemoveTestShouldNotRemoveAnythingIfElementDoesNotExists(int element)
        {
            dynamicListInt.Add(1);
            dynamicListInt.Add(2);
            Assert.That(dynamicListInt.Remove(element) < 0);
        }

        [TestCase(3)]
        public void IndexOfTestShouldReturnElementsIndex(int item)
        {
            dynamicListInt.Add(3);
            Assert.That(dynamicListInt.IndexOf(item) == 0);
        }

        [TestCase(4)]
        public void IndexOfTestShouldReturnMinusOneForNonExistingElement(int item)
        {
            dynamicListInt.Add(3);
            Assert.That(dynamicListInt.IndexOf(item) == -1);
        }

        [TestCase(3)]
        public void ContainsTestShouldReturnTrueIfElementExists(int item)
        {
            dynamicListInt.Add(3);
            Assert.That(dynamicListInt.Contains(item) == true);
        }

        [TestCase(4)]
        public void ContainsTestShouldReturnFalseIfElementDoesNotExist(int item)
        {
            dynamicListInt.Add(3);
            Assert.That(dynamicListInt.Contains(item) == false);
        }
    }
}