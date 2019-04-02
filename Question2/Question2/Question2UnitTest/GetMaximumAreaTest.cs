using NUnit.Framework;
using Question2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2UnitTest
{
    [TestFixture]
    public class GetMaximumAreaTest
    {
        [Test]
        [TestCase(7, new int[] {1, 1, 3, 3, 4, 5, 7})]
        public void Test1_GetMaxArea(int NumberOfPieces, int[] ListOfLength)
        {
            var result = Program.GetMaxArea(NumberOfPieces, ListOfLength.ToList());
            Assert.AreEqual(15, result);
        }

        [Test]
        [TestCase(7, new int[] { 1, 1, 1, 3, 4, 5, 7 })]
        public void Test2_GetMaxArea(int NumberOfPieces, int[] ListOfLength)
        {
            var result = Program.GetMaxArea(NumberOfPieces, ListOfLength.ToList());
            Assert.AreEqual(7, result);
        }

        [Test]
        [TestCase(5, new int[] { 1, 1, 1, 1, 1 })]
        public void Test3_GetMaxArea(int NumberOfPieces, int[] ListOfLength)
        {
            var result = Program.GetMaxArea(NumberOfPieces, ListOfLength.ToList());
            Assert.AreEqual(1, result);
        }

        [Test]
        [TestCase(5, new int[] { 1, 2, 1, 2, 1 })]
        public void Test4_GetMaxArea(int NumberOfPieces, int[] ListOfLength)
        {
            var result = Program.GetMaxArea(NumberOfPieces, ListOfLength.ToList());
            Assert.AreEqual(2, result);
        }

        [Test]
        [TestCase(7, new int[] { 9, 1, 9, 5, 6, 2, 10 })]
        [TestCase(7, new int[] { 9, 1, 9})]
        [TestCase(7, new int[] { 9, 1, 9, 9 })]
        [TestCase(7, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(7, new int[] { -1, 2, 3, 4, 5, 6, 7 })]
        public void Test_GetMaxArea_NA(int NumberOfPieces, int[] ListOfLength)
        {
            var result = Program.GetMaxArea(NumberOfPieces, ListOfLength.ToList());
            Assert.AreEqual(-1, result);
        }
    }
}
