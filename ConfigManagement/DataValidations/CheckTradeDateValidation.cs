using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfigManagement.DataValidations
{
    class CheckTradeDateValidation : DataValidator
    {
        public override bool Validate()
        {
            if (Data.ContainsKey("TradeDate"))
                            return true;
            
            return false;
        }
    }

}
