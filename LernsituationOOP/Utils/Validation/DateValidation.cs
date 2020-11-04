using System;

namespace LernsituationOOP.Utils.Validation
{
    public class DateValidation : IValidationBase
    {
        private readonly DateTime Input;

        public DateValidation(DateTime input)
        {
            Input = input;
        }

        public DateValidation IsGreaterThan(DateTime DateTime)
        {
            Statements.Add(Input.Date < DateTime.Date);
            return this;
        }

        public DateValidation IsGreater18()
        {
            Statements.Add(Input.Year <= DateTime.Today.Year - 18);
            return this;
        }
    }
}
