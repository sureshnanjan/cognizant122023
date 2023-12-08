using System;
using NUnit.Framework;
using Application;

namespace ApplicationScenarios
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void BinarySearchTakeSortedArray()
        {
            /// Arrange
            int[] inputs = { 1, 2, 3, 4, 5 };
            int serchTerm = 5;
            /// Aact
            BinarySearcher mysearcher = new BinarySearcher(inputs, serchTerm);
            /// Assert // RED GREEN REFACTOR
            /// 
            Assert.That(mysearcher, Is.InstanceOf<BinarySearcher>());
        }

        [Test]
        public void BinarySearchReturnsIndexofExistingItem()
        {
            /// Arrange
            int[] inputs = { 1, 2, 3, 4, 5 };
            int serchTerm = 5;
            int expected = 4;
            BinarySearcher mysearcher = new BinarySearcher(inputs, serchTerm);
            /// Assert // RED GREEN REFACTOR
            int actual = mysearcher.search();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BinarySearchReturnsNegativeIfItemNotExists()
        {
            /// Arrange
            int[] inputs = { 1, 2, 3, 4, 5 };
            int serchTerm = 10;
            //int expected = -1;
            BinarySearcher mysearcher = new BinarySearcher(inputs, serchTerm);
            /// Assert // RED GREEN REFACTOR
            int actual = mysearcher.search();
            Assert.That(actual, Is.LessThan(0));
        }
        //If value is not found and value is less than one or more elements in array,
        //the negative number returned is the bitwise complement
        //of the index of the first element that is larger than value.  
        [Test]
        public void BinarySearchReturnsNegativeAndElementLessThan()
        {
            /// Arrange
            int[] inputs = { 1, 2, 3, 4, 6 };
            int serchTerm = 5;
            int expected = ~4;
            BinarySearcher mysearcher = new BinarySearcher(inputs, serchTerm);
            /// Assert // RED GREEN REFACTOR
            int actual = mysearcher.search();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
