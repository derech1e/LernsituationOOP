using System.Collections.Generic;

namespace LernsituationOOP.Utils.Validation
{
    public abstract class IValidationBase
    {
        public readonly List<bool> Statements;

        public IValidationBase()
        {
            Statements = new List<bool>();
        }

        public bool ValidateAND()
        {
            return Statements.TrueForAll(item => item ==true);
        }

        public bool ValidateOR()
        {
            return Statements.Contains(true);
        }

    }
}
