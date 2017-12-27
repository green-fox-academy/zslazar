using MutualElements;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void MutualElements()
        {
            //Ha nem lenne static a method, akkor példányosítani kell az osztályt
            //Program program = new Program();

            //arrange
            List<int> first = new List<int>() { 2, 4, 6, 8, 1 };
            List<int> second = new List<int>() { 3, 5, 7, 9, 1 };
            List<int> expectedList = new List<int>() { 1 };

            //Ha nem lenne static a method, akkor példányosítani kell az osztályt
            //var result = program.FilterMutualElements(first, second);

            //egyébként így lehet elérni a methodot:
            //act
            var result = Program.FilterMutualElements(first, second);

            //assert
            Assert.AreEqual(expectedList, result);
        }

        [Test]
        public void NonMutualElements()
        {
            //arrange
            List<int> first = new List<int>() { 2, 4, 6, 8 };
            List<int> second = new List<int>() { 3, 5, 7, 9 };
            List<int> expectedList = new List<int>() { };

            //act
            var result = Program.FilterMutualElements(first, second);

            //assert
            Assert.AreEqual(expectedList, result);
        }

        [Test]
        public void SameListMutualElements()
        {
            //arrange
            List<int> first = new List<int>() { 1, 2, 1, 2, 3, 1, 2, 3, 1, 3, 2, 1, 2, 2, 3, 3 };
            List<int> second = new List<int>() { 1, 2, 1, 2, 3, 1, 2, 3, 1, 3, 2, 1, 2, 2, 3, 3 };
            List<int> expectedList = new List<int>() { 1, 2, 3 };

            //act
            var result = Program.FilterMutualElements(first, second);

            //assert
            Assert.AreEqual(expectedList, result);
        }
    }
}
