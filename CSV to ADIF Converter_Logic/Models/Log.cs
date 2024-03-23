using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_ADIF_Converter_Logic
{
    public class Log
    {
        public string MyCall { get; set; }
        public List<KeyValuePair<string, string>> DefaultFields { get; set; }
        public List<QSO> QSOs { get; set; }
        public List<string> TableHeaders { get; set; }
        public List<string> GetDefaultTableHeaders()
        {
            List<string> headers = new List<string>();
            if (DefaultFields != null)
                foreach (KeyValuePair<string, string> kvp in DefaultFields)
                    headers.Add(kvp.Key);
            return headers;
        }
    }
    
    public class QSO
    {
        public List<KeyValuePair<string, string>> Fields { get; set; }
    }
}
