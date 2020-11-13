using System;

namespace LernsituationOOP.Utils.Validation
{
    public class DateValidation : IValidationBase
    {
        private readonly DateTime Input;

        /// <summary>
        /// Konstruktor für die Validierung eines Datums
        /// </summary>
        /// <param name="input">Gibt das Datum an das Geprüft werden soll</param>
        public DateValidation(DateTime input)
        {
            Input = input;
        }

        /// <summary>
        /// Dient zur Überprüfung ob das Datum älter als Datum X ist
        /// </summary>
        /// <param name="DateTime">Datum X nach dem geprüft werden soll</param>
        /// <returns>Gibt die Aktuelle Klasse, für ein weiteres Prüfargument zurück</returns>
        public DateValidation IsGreaterThan(DateTime DateTime)
        {
            Statements.Add(Input.Date < DateTime.Date);
            return this;
        }

        /// <summary>
        /// Dient zur Überprüfung ob das Datum älter 18 Jahre ist
        /// </summary>
        /// <returns>Gibt die Aktuelle Klasse, für ein weiteres Prüfargument zurück</returns>
        public DateValidation IsGreater18()
        {
            Statements.Add(Input.Year <= DateTime.Today.Year - 18);
            return this;
        }
    }
}
