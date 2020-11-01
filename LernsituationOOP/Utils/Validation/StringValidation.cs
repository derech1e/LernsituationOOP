using LernsituationOOP.Utils.Validation;
using System.Collections.Generic;
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

        public StringValidation IsNotNullEmptyAndWhiteSpace()
        {
            Statements.Add(!string.IsNullOrWhiteSpace(Input) && !string.IsNullOrEmpty(Input));
            return this;
        }

        public StringValidation IsNullOrWhiteSpace()
        {
            Statements.Add(string.IsNullOrWhiteSpace(Input));
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
            Statements.Add(Regex.IsMatch(Input, @"^[0-9]+$"));
            return this;
        }

        public StringValidation ContainsLetters()
        {
            Statements.Add(Regex.IsMatch(Input, @"^[a-zA-Z]+$"));
            return this;
        }

        public StringValidation ContainsUnderscore()
        {
            Statements.Add(Regex.IsMatch(Input, @"^[_]+$"));
            return this;
        }
    }
}
