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

        public bool ValidateAND(bool invert = false)
        {
            bool result = Statements.TrueForAll(item => item);
            return invert ? !result : result;
        }

        public bool ValidateOR(bool invert = false)
        {
            bool result = Statements.Contains(true);
            return invert ? !result : result;
        }
    }
}
