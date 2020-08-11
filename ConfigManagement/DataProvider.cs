using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigManagement
{
    public class DataProvider
    {
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();
        public validations ValidationConfigs { get; set; } = new validations();
        public List<string> ErrroList { get; set; } = new List<string>();
        public DataProvider()
        {
            Data.Add("AccountCode", "LABIF1");
        }
    }
}
