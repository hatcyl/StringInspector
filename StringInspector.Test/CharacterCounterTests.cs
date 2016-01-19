using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringInspector.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInspector.Core.Tests
{
    [TestClass()]
    public class CharacterCounterTests
    {
        [TestMethod()]
        public void FindMostOccuringCharacterTest_EmptyString()
        {
            string value = "";
            CharacterCounter characterCounter = new CharacterCounter();
            var result = characterCounter.FindMostOccuringCharacter(value);

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod()]
        public void FindMostOccuringCharacterTest_OneResult()
        {
            string value = "aabaabbacdcd";
            CharacterCounter characterCounter = new CharacterCounter();
            var result = characterCounter.FindMostOccuringCharacter(value);

            Assert.AreEqual(1, result.Count());
            Assert.IsTrue(result.Contains('a'));
        }

        [TestMethod()]
        public void FindMostOccuringCharacterTest_MultipleResults()
        {
            string value = "aabaabbacdcdddd";
            CharacterCounter characterCounter = new CharacterCounter();
            var result = characterCounter.FindMostOccuringCharacter(value);

            Assert.AreEqual(2, result.Count());
            Assert.IsTrue(result.Contains('a'));
            Assert.IsTrue(result.Contains('d'));
        }

        [TestMethod()]
        public void FindMostOccuringCharacterTest_AllResults()
        {
            string value = "aabaabbacdcddddbbccc";
            CharacterCounter characterCounter = new CharacterCounter();
            var result = characterCounter.FindMostOccuringCharacter(value);

            Assert.AreEqual(4, result.Count());
            Assert.IsTrue(result.Contains('a'));
            Assert.IsTrue(result.Contains('b'));
            Assert.IsTrue(result.Contains('c'));
            Assert.IsTrue(result.Contains('d'));
        }
    }
}