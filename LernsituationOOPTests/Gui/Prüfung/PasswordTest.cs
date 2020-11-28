using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LernsituationOOP.de.tnuerk.gui.Tests
{    
    /// <summary>
     /// Dient zum Testen der Passowrtent -und verschlüsselung
     /// </summary>
    [TestClass()]
    public class PasswordTest
    {
        private const string Expected_Passwort_Decrypt = "1234_6789";
        private const string Expected_Passwort_Encrpty = "ÛØÙÞµÜÝÒÓ";

        [TestMethod()]
        public void ValidatePasswortEncryption()
        {
            Assert.AreEqual(Utils.Utils.EncryptDecryptPassword(Expected_Passwort_Decrypt), Expected_Passwort_Encrpty);
        }

        [TestMethod()]
        public void ValidatePasswortDecryption()
        {
            Assert.AreEqual(Utils.Utils.EncryptDecryptPassword(Expected_Passwort_Encrpty), Expected_Passwort_Decrypt);
        }
    }
}