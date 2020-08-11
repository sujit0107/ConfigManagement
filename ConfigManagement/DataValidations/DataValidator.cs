using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigManagement.DataValidations
{
    public abstract class DataValidator:DataProvider
    {
      
        public abstract bool Validate();
    }
}
