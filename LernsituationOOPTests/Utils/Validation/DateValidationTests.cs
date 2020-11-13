using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LernsituationOOP.Utils.Validation.Tests
{
    /// <summary>
    /// Dient zum Testen der DateValidation Klasse
    /// </summary>
    [TestClass()]
    public class DateValidationTests
    {
        [TestMethod()]
        public void DateValidationTest_Equals()
        {
            Assert.IsTrue(new DateValidation(DateTime.Today.AddYears(-18)).IsGreater18().ValidateAND());
        }

        [TestMethod()]
        public void DateValidationTest_Age_Above()
        {
            Assert.IsTrue(new DateValidation(DateTime.Today.AddYears(-80)).IsGreater18().ValidateAND());
        }

        [TestMethod()]
        public void DateValidationTest_Age_Under()
        {
            Assert.IsFalse(new DateValidation(DateTime.Today.AddYears(-5)).IsGreater18().ValidateAND());
        }

        [TestMethod()]
        public void DateValidationTest_Test_Equal()
        {
            Assert.IsFalse(new DateValidation(DateTime.Today).IsGreaterThan(DateTime.Today).ValidateAND());
        }

        [TestMethod()]
        public void DateValidationTest_Test_Above()
        {
            Assert.IsTrue(new DateValidation(DateTime.Today).IsGreaterThan(DateTime.Today.AddDays(1)).ValidateAND());
        }

        [TestMethod()]
        public void DateValidationTest_Test_Under()
        {
            Assert.IsFalse(new DateValidation(DateTime.Today).IsGreaterThan(DateTime.Today.AddDays(-1)).ValidateAND());
        }
    }
}