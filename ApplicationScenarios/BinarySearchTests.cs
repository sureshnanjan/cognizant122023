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
            // Behaviour Driven Development
            // Gherkin -  English Like Statements 
            // Given When Then
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
        /// <summary>
        /// Test the binarysearch algorithm
        /// </summary>
        /// <param name="input"></param>
        /// <param name="searchTerm"></param>
        /// <param name="expected"></param>
        [TestCase(new int[]{1,2,3,4,5},10,5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, ~0)]
        public void DoBinarySerchTests(int[] input, int searchTerm, int expected) {
            BinarySearcher mysearcher = new BinarySearcher(input, searchTerm);
            int actual = mysearcher.search();
            Assert.That(actual, Is.EqualTo(expected));
        }

        
    }



}
