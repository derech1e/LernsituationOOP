﻿using LernsituationOOP.Utils.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LernsituationOOP.de.tnuerk.utils.Tests
{
    /// <summary>
    /// Dient zum Testen der StringValidation Klasse
    /// </summary>
    [TestClass()]
    public class StringValidationTests
    {
        private StringValidation stringValidation = null;

        [TestMethod()]
        public void StringValidationTest_1()
        {
            stringValidation = new StringValidation("test@test.de");
            Assert.IsFalse(stringValidation.IsEmail().ContainsNumber().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_2()
        {
            stringValidation = new StringValidation("test@test.de");
            Assert.IsTrue(stringValidation.IsEmail().ContainsNumber().ValidateOR());
        }

        [TestMethod()]
        public void StringValidationTest_3()
        {
            stringValidation = new StringValidation(" ");
            Assert.IsFalse(!stringValidation.IsNullOrWhiteSpace().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_4()
        {
            stringValidation = new StringValidation(" 12");
            Assert.IsTrue(stringValidation.ContainsNumber().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_5()
        {
            stringValidation = new StringValidation(" 12as");
            Assert.IsTrue(stringValidation.ContainsNumber().ContainsLetter().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_6()
        {
            stringValidation = new StringValidation("as d 2");
            Assert.IsTrue(stringValidation.IsNullOrEmpty().ContainsNumber().ContainsLetter().ValidateOR());
        }

        [TestMethod()]
        public void StringValidationTest_7()
        {
            stringValidation = new StringValidation(null);
            Assert.IsFalse(!stringValidation.IsNullOrEmpty().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_8()
        {
            stringValidation = new StringValidation("");
            Assert.IsTrue(stringValidation.IsNullOrEmpty().ValidateOR());
        }

        [TestMethod()]
        public void StringValidationTest_9()
        {
            stringValidation = new StringValidation("test@test");
            Assert.IsFalse(stringValidation.IsEmail().ValidateOR());
        }
    }
}