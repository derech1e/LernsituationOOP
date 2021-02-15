using System.Linq;
using System.Text.RegularExpressions;

namespace LernsituationOOP.Utils.Validation
{
    public class StringValidation : IValidationBase
    {
        private readonly string Input;

        /// <summary>
        /// Konstruktor für die Validierung eines String X
        /// </summary>
        /// <param name="input">Der zu prüfende String</param>
        public StringValidation(string input)
        {
            Input = input;
        }

        /// <summary>
        /// Überprüft ob der String NULL ist oder ein Leerzeichen enthält 
        /// </summary>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurück</returns>
        public StringValidation IsNullOrWhiteSpace()
        {
            Statements.Add(string.IsNullOrWhiteSpace(Input));
            return this;
        }

        /// <summary>
        /// Überprüft ob der String NULL oder Leer ist
        /// </summary>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurück</returns>
        public StringValidation IsNullOrEmpty()
        {
            Statements.Add(string.IsNullOrEmpty(Input));
            return this;
        }

        /// <summary>
        /// Überprüft ob der String Nicht NULL oder Leer ist
        /// </summary>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurück</returns>
        public StringValidation IsNotNullOrEmpty()
        {
            Statements.Add(!string.IsNullOrEmpty(Input));
            return this;
        }

        /// <summary>
        /// Überprüft ob der String einem gültigem E-Mail format entspricht (siehe https://docs.microsoft.com/de-de/dotnet/standard/base-types/regular-expression-language-quick-reference)
        /// </summary>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurück</returns>
        public StringValidation IsEmail()
        {
            Statements.Add(Regex.IsMatch(Input,
                "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"));
            return this;
        }

        /// <summary>
        /// Überprüft ob der String mindestens eine Zahl enthält
        /// </summary>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurück</returns>
        public StringValidation ContainsNumber()
        {
            Statements.Add(Input.Any(char.IsDigit));
            return this;
        }

        /// <summary>
        /// Überprüft ob der String keine eine Zahl enthält
        /// </summary>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurück</returns>
        public StringValidation ContainsNoNumber()
        {
            Statements.Add(!Input.Any(char.IsDigit));
            return this;
        }

        /// <summary>
        /// Überprüft ob der String mindestens einen Buchstaben enthält
        /// </summary>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurück</returns>
        public StringValidation ContainsLetter()
        {
            Statements.Add(Input.Any(char.IsLetter));
            return this;
        }

        /// <summary>
        /// Überprüft ob der String mindestens einen Buchstaben enthält
        /// </summary>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurück</returns>
        public StringValidation ContainsNoLetters()
        {
            Statements.Add(!Input.Any(char.IsLetter));
            return this;
        }

        /// <summary>
        /// Überprüft ob der String eine mindestlänge X nicht unterschreitet
        /// </summary>
        /// <param name="length">Mindestlänge X</param>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurüc</returns>
        public StringValidation IsLongerThan(int length)
        {
            Statements.Add(Input.Length >= length);
            return this;
        }

        /// <summary>
        /// Überprüft ob der String eine maximallänge X nicht überschreitet
        /// </summary>
        /// <param name="length">Maximallänge X</param>
        /// <returns>Gibt diese Klasse für weitere Validierungsmöglichkeiten zurüc></returns>
        public StringValidation IsShorterThan(int length)
        {
            Statements.Add(Input.Length <= length);
            return this;
        }
    }
}