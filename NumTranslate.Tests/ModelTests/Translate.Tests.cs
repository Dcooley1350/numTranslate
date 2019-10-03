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

        [TestInitialize]
        public void Setup()
        {
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
        public void ConvertStringToStringArray_ConvertStringToStringArray_StringArray()
        {
            
        }
    }
}