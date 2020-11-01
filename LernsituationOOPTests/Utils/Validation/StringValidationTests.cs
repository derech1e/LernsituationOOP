using LernsituationOOP.Utils.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LernsituationOOP.de.tnuerk.utils.Tests
{
    [TestClass()]
    public class StringValidationTests
    {
        private StringValidation stringValidation = null;

        [TestMethod()]
        public void StringValidationTest_1()
        {
            stringValidation = new StringValidation("test@test.de");
            Assert.IsFalse(stringValidation.IsNotNullEmptyAndWhiteSpace().IsEmail().ContainsNumber().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_2()
        {
            stringValidation = new StringValidation("test@test.de");
            Assert.IsTrue(stringValidation.IsNotNullEmptyAndWhiteSpace().IsEmail().ContainsNumber().ValidateOR());
        }

        [TestMethod()]
        public void StringValidationTest_3()
        {
            stringValidation = new StringValidation(" ");
            Assert.IsFalse(stringValidation.IsNotNullEmptyAndWhiteSpace().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_4()
        {
            stringValidation = new StringValidation(" 12");
            Assert.IsFalse(stringValidation.IsNotNullEmptyAndWhiteSpace().ContainsNumber().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_5()
        {
            stringValidation = new StringValidation(" 12as");
            Assert.IsFalse(stringValidation.IsNotNullEmptyAndWhiteSpace().ContainsNumber().ContainsLetters().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_6()
        {
            stringValidation = new StringValidation(" 12");
            Assert.IsTrue(stringValidation.IsNotNullEmptyAndWhiteSpace().ContainsNumber().ContainsLetters().ValidateOR());
        }

        [TestMethod()]
        public void StringValidationTest_7()
        {
            stringValidation = new StringValidation(null);
            Assert.IsFalse(stringValidation.IsNotNullEmptyAndWhiteSpace().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_8()
        {
            stringValidation = new StringValidation(null);
            Assert.IsFalse(stringValidation.IsNotNullEmptyAndWhiteSpace().ValidateOR());
        }
    }
}