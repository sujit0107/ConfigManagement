using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigManagement.DataValidations
{
    public class CheckAccountCodeValidation : DataValidator
    {
        public override bool Validate()
        {
            if (Data.ContainsKey("AccountCode"))
                return true;
            return false;
        }
    }
}
