using System.Linq;
using System.Text.RegularExpressions;

namespace LernsituationOOP.Utils.Validation
{
    public class StringValidation : IValidationBase
    {
        private readonly string Input;

        public StringValidation(string input)
        {
            Input = input;
        }

        public StringValidation IsNullOrWhiteSpace()
        {
            Statements.Add(string.IsNullOrWhiteSpace(Input));
            return this;
        }

        public StringValidation IsNotNullOrEmpty()
        {
            Statements.Add(!string.IsNullOrEmpty(Input));
            return this;
        }

        public StringValidation IsNullOrEmpty()
        {
            Statements.Add(string.IsNullOrEmpty(Input));
            return this;
        }

        public StringValidation IsEmail()
        {
            Statements.Add(Regex.IsMatch(Input, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"));
            return this;
        }

        public StringValidation ContainsNumber()
        {
            Statements.Add(Input.Any(char.IsDigit));
            return this;
        }

        public StringValidation ContainsLetters()
        {
            Statements.Add(Input.Any(char.IsLetter));
            return this;
        }
    }
}
