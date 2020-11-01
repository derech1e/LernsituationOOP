using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LernsituationOOP.de.tnuerk.klassen.utils.Tests
{
    [TestClass()]
    public class JsonUtilsTests
    {
        [TestMethod()]
        public void ValidateSaveReservierungen()
        {
            if(!JsonUtils.SaveReservierungen())
            Assert.Fail();
        }

        [TestMethod()]
        public void ValidateMitarbeiter()
        {
            if (!JsonUtils.SaveMitarbeiter())
                Assert.Fail();
        }

        [TestMethod()]
        public void ValidateLoadReservierungen()
        {
            if (!JsonUtils.LoadReservierungen())
                Assert.Fail();
        }

        [TestMethod()]
        public void ValidateLoadMitarbeiter()
        {
            if (!JsonUtils.LoadMitarbeiter())
                Assert.Fail();
        }
    }
}