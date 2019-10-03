using System;
using System.Collections.Generic;
using NumTranslate.Models;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumTranslate.Tests
{
    [TestClass]
    public class TranslateTests
    {
        Translate newTranslate;
        string newString;

        [TestInitialize]
        public void Setup()
        {
            newString = "123456789";
            newTranslate = new Translate();
        }
        [TestCleanup]
        public void TearDown()
        {

        }

        [TestMethod]
        public void Constructor_ConstructorBuildsClassObject_Translate()
        {
            Assert.AreEqual(newTranslate.GetType(),typeof(Translate));
        }
        [TestMethod]
        public void ConvertStringToStringList_ConvertStringToStringList_StringList()
        {
            List<string> stringList = newTranslate.StringToStringList(newString);
            List<string> expectedList = new List<string>{"1","2","3","4","5","6","7","8","9"};
            bool correct = expectedList.SequenceEqual(stringList);
            Assert.AreEqual(true,correct);
        }
        [TestMethod]
        public void ReplaceFirstDigit_ReplaceFirstDigitWithString_String()
        {
            List<string> OneDigitString = new List<string>{"4"};
            string expected = "four";
            newTranslate.ReplaceFirstDigit(OneDigitString);
            Assert.AreEqual(expected,newTranslate.TextNumber[0]);
        }
        public void ReplaceSecondDigit_ReplaceSecondDigitWithString_String()
        {
            List<string> TwoDigitString = new List<string>{"2","4"};
            List<string> expectedString = new List<string>{"twenty","four"};
            newTranslate.ReplaceFirstDigit(TwoDigitString);
            newTranslate.ReplaceSecondDigit(TwoDigitString);
            Assert.AreEqual()
        }
    }
}