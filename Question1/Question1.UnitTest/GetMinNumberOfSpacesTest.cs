using NUnit.Framework;
using Question1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.UnitTest
{
    [TestFixture]
    public class GetMinNumberOfSpacesTest
    {
        [Test]
        [TestCase("abcddefab", new string[] { "Abc", "def", "ab", "cd" })]
        [TestCase("tyeriu", new string[] { "Abc", "def", "ab", "cd" })]
        public void TestNASpaces_GetMinNumberOfSpaces(string InputString, string[] InputList)
        {
            var result = Program.GetMinNumberOfSpaces(InputString, InputList.ToList());
            Assert.AreEqual("N/A", result);
        }

        [TestCase("aaaaaa", new string[] { "aaaaaa" })]
        public void Test0Spaces_GetMinNumberOfSpaces(string InputString, string[] InputList)
        {
            var result = Program.GetMinNumberOfSpaces(InputString, InputList.ToList());
            Assert.AreEqual("0", result);
        }

        [Test]
        [TestCase("abcdefab", new string[] { "Abc", "def", "ab", "cd" })]
        public void Test2Spaces_GetMinNumberOfSpaces(string InputString, string[] InputList)
        {
            var result = Program.GetMinNumberOfSpaces(InputString, InputList.ToList());
            Assert.AreEqual("2", result);
        }

        [TestCase("abcddefab", new string[] { "Abc", "def", "ab", "cd", "d" })]
        [TestCase("aaaaaa", new string[] { "aa", "a", "aa", "a" })]
        public void Test3Spaces_GetMinNumberOfSpaces(string InputString, string[] InputList)
        {
            var result = Program.GetMinNumberOfSpaces(InputString, InputList.ToList());
            Assert.AreEqual("3", result);
        }

        [TestCase("aaaaaa  ", new string[] { "aa", "a", "a", "a", "a", "a", "  "})]
        public void Test5Spaces_GetMinNumberOfSpaces(string InputString, string[] InputList)
        {
            var result = Program.GetMinNumberOfSpaces(InputString, InputList.ToList());
            Assert.AreEqual("5", result);
        }

       


    }
}
