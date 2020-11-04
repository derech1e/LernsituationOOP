using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LernsituationOOP.Utils.Validation.Tests
{
    [TestClass()]
    public class DateValidationTests
    {
        [TestMethod()]
        public void DateValidationTest_1()
        {
            Assert.IsTrue(new DateValidation(DateTime.Today.AddYears(-18)).IsGreater18().ValidateAND());
        }
    }
}