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
            Assert.IsFalse(stringValidation.IsNotNullOrEmpty().IsEmail().ContainsNumber().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_2()
        {
            stringValidation = new StringValidation("test@test.de");
            Assert.IsTrue(stringValidation.IsNotNullOrEmpty().IsEmail().ContainsNumber().ValidateOR());
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
            Assert.IsTrue(stringValidation.IsNotNullOrEmpty().ContainsNumber().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_5()
        {
            stringValidation = new StringValidation(" 12as");
            Assert.IsTrue(stringValidation.IsNotNullOrEmpty().ContainsNumber().ContainsLetters().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_6()
        {
            stringValidation = new StringValidation("as d 2");
            Assert.IsTrue(stringValidation.IsNullOrEmpty().ContainsNumber().ContainsLetters().ValidateOR());
        }

        [TestMethod()]
        public void StringValidationTest_7()
        {
            stringValidation = new StringValidation(null);
            Assert.IsFalse(stringValidation.IsNotNullOrEmpty().ValidateAND());
        }

        [TestMethod()]
        public void StringValidationTest_8()
        {
            stringValidation = new StringValidation(null);
            Assert.IsFalse(stringValidation.IsNotNullOrEmpty().ValidateOR());
        }
    }
}