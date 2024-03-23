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
        public List<KeyValuePair<string, string>> Header { get; set; }
        public List<QSO> QSOs { get; set; }
        public List<string> TableHeaders { get; set; }
    }
    
    public class QSO
    {
        public List<KeyValuePair<string, string>> Fields { get; set; }
    }
}
