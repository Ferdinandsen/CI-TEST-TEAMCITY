using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDHelpers
{
    class TestStringHelper
    {
        [Test]
        public void TestTrim()
        {
            StringHelper helper = new StringHelper();
            string test = "A string with spaces";
            Assert.AreEqual("Astringwithspaces", helper.RemoveSpaces(test));
            Assert.AreNotEqual(test, helper.RemoveSpaces(test));
        }

        [Test]
        public void TestContainsNumber()
        {
            StringHelper helper = new StringHelper();
            string test = " Dette er en lagn streng med 2 numre i. 1";
            Assert.IsTrue(helper.ContainsNumber(test));
             test = " Dette er en lagn streng med to numre i. en";
            Assert.IsFalse(helper.ContainsNumber(test));
        }

        [Test]
        public void TestNumberOfUpperCase()
        {
            StringHelper helper = new StringHelper();
            string test = " Dette er STOR sætning Med StoRe bogstaver i";
            string test2 = "uden uppercases";
            string test3 = "";
            string test4 = "567800";
            string test5 = null;
            Assert.AreEqual(8, helper.NumberOfUpperCases(test));
            Assert.AreEqual(0, helper.NumberOfUpperCases(test2));
            Assert.AreEqual(0, helper.NumberOfUpperCases(test3));
            Assert.AreEqual(0, helper.NumberOfUpperCases(test4));
            Assert.AreEqual(0, helper.NumberOfUpperCases(test5));
            Assert.AreNotEqual(7, helper.NumberOfUpperCases(test));
        }
        
    }
}
