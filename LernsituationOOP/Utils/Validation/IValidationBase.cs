using System.Collections.Generic;
using System.Linq;

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
            return Statements.Count(item => item) == Statements.Count;
        }

        public bool ValidateOR()
        {
            return Statements.Count(item => item) >= 1;
        }

    }
}
