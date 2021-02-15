using LernsituationOOP.Personen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LernsituationOOP.de.tnuerk.gui.prüfung.Tests
{
    /// <summary>
    /// Dient zum Testen der AddMitarbeiter Klasse
    /// </summary>
    [TestClass()]
    public class AddMitarbeiterTests
    {
        private const string Expected_Vorname = "TestVorname";
        private const string Expected_Nachname = "TestNachname";
        private const string Expected_Adresse = "Test123";
        private readonly DateTime Expected_geb = DateTime.Today;
        private const string Expected_email = "test@test.de";
        private const string Expected_PW = "123";

        private readonly Mitarbeiter mitarbeiter = new Mitarbeiter("TestVorname", "TestNachname", "Test123",
            DateTime.Today, "test@test.de", Utils.Utils.GenerateID(), "123");

        [TestMethod()]
        public void ValidateVorname()
        {
            Assert.AreEqual(mitarbeiter.Vorname, Expected_Vorname);
        }

        [TestMethod()]
        public void ValidateNachname()
        {
            Assert.AreEqual(mitarbeiter.Nachname, Expected_Nachname);
        }

        [TestMethod()]
        public void ValidateAdresse()
        {
            Assert.AreEqual(mitarbeiter.Adresse, Expected_Adresse);
        }

        [TestMethod()]
        public void ValidateGeburtsdatum()
        {
            Assert.AreEqual(mitarbeiter.Geburtsdatum, Expected_geb);
        }

        [TestMethod()]
        public void ValidateEmail()
        {
            Assert.AreEqual(mitarbeiter.Email, Expected_email);
        }

        [TestMethod()]
        public void ValidateID()
        {
            Assert.IsFalse(Utils.Utils.ExsistID(mitarbeiter.ID));
        }

        [TestMethod()]
        public void ValidatePasswort()
        {
            Assert.AreEqual(mitarbeiter.Passwort, Expected_PW);
        }
    }
}