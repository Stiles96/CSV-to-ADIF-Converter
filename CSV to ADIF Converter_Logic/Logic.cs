using CSV_to_ADIF_Converter_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_ADIF_Converter_Logic
{
    public class Logic
    {
        protected CSVFile CSV;

        /// <summary>
        /// Gets the Mapping as Dictionary
        /// </summary>
        /// <param name="mapping">mappings of listboxes</param>
        /// <returns>Mappings as Dictionary</returns>
        protected Dictionary<string, int> GetColumnsMapping(string[,] mapping)
        {
            Dictionary<string, int> Columnsmapping = new Dictionary<string, int>();

            for (int i = 0; i < mapping.GetLength(0); i++)
            {
                int id = 0;
                for (int z = 0; z < CSV.Header.Length; z++)
                    if (CSV.Header[z] == mapping[i, 1])
                    {
                        id = z;
                        break;
                    }
                Columnsmapping.Add(mapping[i, 0], id);
            }
            return Columnsmapping;
        }

        public void LoadCSVFile(string Path, char CSVChar = ' ')
        {
            CSV = FileAccess.ReadCSVFile(Path, CSVChar);
        }

        public string[] GetCSVHeader()
        {
            if (CSV != null)
                return CSV.Header;
            else
                return null;
        }
    }
}
