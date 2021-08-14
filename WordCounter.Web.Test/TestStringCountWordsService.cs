using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Web.Services;

namespace WordCounter.Web.Test
{
    [TestClass]
    public class TestStringCountWordsService
    {
        private readonly StringCountWordsService _stringCountWordsService;

        public TestStringCountWordsService()
        {
            _stringCountWordsService = new StringCountWordsService();
        }

        [TestMethod]
        public void TestNormalInput()
        {
            Dictionary<int, int> res = _stringCountWordsService.CountOccurrencesOfWordLengthInString("This is a simple test message");

            Assert.IsTrue(res.Count == 5, "Dictionary does not have 5 entries.");
            Assert.IsTrue(res[1] == 1);
            Assert.IsTrue(res[2] == 1);
            Assert.IsTrue(res[4] == 2);
            Assert.IsTrue(res[6] == 1);
            Assert.IsTrue(res[7] == 1);
        }

        [TestMethod]
        public void TestEmptyInput()
        {
            Dictionary<int, int> res = _stringCountWordsService.CountOccurrencesOfWordLengthInString("");
            Assert.IsTrue(res.Count == 0, "Dictionary does not have 0 entries.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullInput()
        {
            Dictionary<int, int> res = _stringCountWordsService.CountOccurrencesOfWordLengthInString(null);
        }
    }
}
