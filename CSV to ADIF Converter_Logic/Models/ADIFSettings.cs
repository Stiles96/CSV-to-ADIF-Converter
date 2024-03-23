using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_ADIF_Converter_Logic
{
    public class ADIFSettings
    {
        public List<string> ADIFColumns { get; set; }
        public List<KeyValuePair<string, string>> ADIFDefaults { get; set; }
    }
}
