using System.Collections.Generic;

namespace LernsituationOOP.Utils.Validation
{
    /// <summary>
    /// Abstrakte Basisklasse für eine neue Validierungsklasse
    /// </summary>
    public abstract class IValidationBase
    {
        public readonly List<bool> Statements;

        /// <summary>
        /// Konstruktor zur Initialisierung
        /// </summary>
        public IValidationBase()
        {
            Statements = new List<bool>();
        }

        /// <summary>
        /// Dient zur Überprüfung, ob alle Prüfungsargumente Wahr sind.
        /// </summary>
        /// <param name="invert">Invertiert die Aussage</param>
        /// <returns>Gibt einen Boolischen Wert zurück</returns>
        public bool ValidateAND(bool invert = false)
        {
            bool result = Statements.TrueForAll(item => item);
            return invert ? !result : result;
        }

        /// <summary>
        ///  Dient zur Überprüfung, ob mindestens ein Prüfungsargumente Wahr sind.
        /// </summary>
        /// <param name="invert">Invertiert die Aussage</param>
        /// <returns>Gibt einen Boolischen Wert zurück</returns>
        public bool ValidateOR(bool invert = false)
        {
            bool result = Statements.Contains(true);
            return invert ? !result : result;
        }
    }
}
