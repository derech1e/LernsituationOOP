using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LernsituationOOP.de.tnuerk.utils.Tests
{
    [TestClass()]
    public class ValidationUtilsTests
    {
        [TestMethod()]
        public void ValidateIsOlderThan18_Test_Equals()
        {
            Assert.IsTrue(ValidationUtils.IsOlderThan18(DateTime.Today.AddYears(-18)));
        }

        [TestMethod()]
        public void ValidateIsOlderThan18_Test_Above()
        {
            Assert.IsTrue(ValidationUtils.IsOlderThan18(DateTime.Today.AddYears(-80)));
        }

        [TestMethod()]
        public void ValidateIsOlderThan18_Test_Under()
        {
            Assert.IsFalse(ValidationUtils.IsOlderThan18(DateTime.Today.AddYears(-5)));
        }

        [TestMethod()]
        public void ValidateIsReservierungDateVaild_Test_Equal()
        {
            Assert.IsFalse(ValidationUtils.IsReservierungDateVaild(DateTime.Today, DateTime.Today));
        }

        [TestMethod()]
        public void ValidateIsReservierungDateVaild_Test_Above()
        {
            Assert.IsTrue(ValidationUtils.IsReservierungDateVaild(DateTime.Today, DateTime.Today.AddDays(1)));
        }

        [TestMethod()]
        public void ValidateIsReservierungDateVaild_Test_Under()
        {
            Assert.IsFalse(ValidationUtils.IsReservierungDateVaild(DateTime.Today, DateTime.Today.AddDays(-1)));
        }

        [TestMethod()]
        public void ValidateIsStringNotNull_Test_Empty()
        {
            Assert.IsFalse(ValidationUtils.IsStringNotNullOrEmpty(""));
        }

        [TestMethod()]
        public void ValidateIsStringNotNull_Test_Whitespace()
        {
            Assert.IsFalse(ValidationUtils.IsStringNotNullOrEmpty(" "));
        }

        [TestMethod()]
        public void ValidateIsStringNotNull_Test_Null()
        {
            Assert.IsFalse(ValidationUtils.IsStringNotNullOrEmpty(null));
        }

        [TestMethod()]
        public void ValidateIsStringNotNull_Test_Not_Null_Or_Empty()
        {
            Assert.IsTrue(ValidationUtils.IsStringNotNullOrEmpty("123"));
        }

        [TestMethod()]
        public void ValidateIsStringANumber_Test_Number()
        {
            Assert.IsTrue(ValidationUtils.IsStringANumber("12"));
        }

        [TestMethod()]
        public void ValidateIsStringANumber_Test_Negative_Number()
        {
            Assert.IsTrue(ValidationUtils.IsStringANumber("-12"));
        }

        [TestMethod()]
        public void ValidateIsStringANumber_Test_Null()
        {
            Assert.IsFalse(ValidationUtils.IsStringANumber(null));
        }

        [TestMethod()]
        public void ValidateIsStringANumber_Test_WhiteSpace()
        {
            Assert.IsFalse(ValidationUtils.IsStringANumber(" "));
        }

        [TestMethod()]
        public void ValidateIsStringANumber_Test_Empty()
        {
            Assert.IsFalse(ValidationUtils.IsStringANumber(""));
        }

        [TestMethod()]
        public void ValidateIsStringANumber_Test_Letters()
        {
            Assert.IsFalse(ValidationUtils.IsStringANumber("avc"));
        }

        [TestMethod()]
        public void ValidateIsEmailValid_Test_Null()
        {
            Assert.IsFalse(ValidationUtils.IsEmailValid(null, false));
        }

        [TestMethod()]
        public void ValidateIsEmailValid_Test_Empty()
        {
            Assert.IsFalse(ValidationUtils.IsEmailValid("", false));
        }

        [TestMethod()]
        public void ValidateIsEmailValid_Test_Can_Be_Empty()
        {
            Assert.IsTrue(ValidationUtils.IsEmailValid("", true));
        }

        [TestMethod()]
        public void ValidateIsEmailValid_Test_Whitespace()
        {
            Assert.IsFalse(ValidationUtils.IsEmailValid(" ", false));
        }

        [TestMethod()]
        public void ValidateIsEmailValid_Test_Email()
        {
            Assert.IsTrue(ValidationUtils.IsEmailValid("test@test.de", false));
            Assert.IsTrue(ValidationUtils.IsEmailValid("test@test.com", false));
            Assert.IsTrue(ValidationUtils.IsEmailValid("test@test.co", false));
        }

        [TestMethod()]
        public void ValidateIsEmailValid_Test_Half_Email()
        {
            Assert.IsFalse(ValidationUtils.IsEmailValid("test@test", false));

        }
    }
}