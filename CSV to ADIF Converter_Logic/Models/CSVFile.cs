using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_ADIF_Converter_Logic.Models
{
    public class CSVFile
    {
        public string[] Header { get; set; }
        public List<string[]> Content { get; set; }
    }
}
