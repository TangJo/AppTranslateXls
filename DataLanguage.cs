using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppTranslateXls
{
    public class DataLanguage
    {
        public string Key { get; set; }

        public List<string> Content { get; set; }

        public DataLanguage(string _key) {
            Key = _key;
            Content = new List<string>();
        }
    }
}
