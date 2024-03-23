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

        string FormatQSOValue(string format, string data)
        {
            //Formats: #Time4: Time 4 chars HHmm - #Time6: Time 6 chars HHmmss - #Date: Date Format yyyyMMdd - #Freq: Frequenz in Hz
            try
            {
                switch (format.ToLower())
                {
                    case "time4":
                        data = Convert.ToDateTime(data).ToString("HHmm");
                        return data;
                    case "time6":
                        data = Convert.ToDateTime(data).ToString("HHmmss");
                        return data;
                    case "date":
                        data = Convert.ToDateTime(data).ToString("yyyyMMdd");
                        return data;
                    case "freq":
                        data = data.Replace(",", ".");
                        if (data.IndexOf(".") > -1)
                        {
                            return data;
                        }
                        else
                            return (Convert.ToDouble(data) / 1000000).ToString();
                    default:
                        return data;
                }
            }
            catch
            {
                return data;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapping">1. Columns in Store, 2. CSV Columns</param>
        /// <param name="progress">Progess for progessbar</param>
        public Log ImportCSV(string[,] mapping, IProgress<int> progress, List<KeyValuePair<string, string>> ADIFdefaultFieldsValues)
        {
            try
            {
                Dictionary<string, int> Columnsmapping = GetColumnsMapping(mapping); //ADIF Column Name - Column CSV ID

                Log log = new Log();
                log.DefaultFields = ADIFdefaultFieldsValues;
                log.QSOs = new List<QSO>();
                log.TableHeaders = new List<string>();

                foreach (KeyValuePair<string, int> map in Columnsmapping)
                {
                    string key = map.Key;

                    if (key.IndexOf("#") > -1)
                    {
                        key = key.Split('#')[0];
                    }
                    log.TableHeaders.Add(key);
                }

                int i = 0;
                foreach (string[] Values in CSV.Content)
                {
                    QSO qso = new QSO();
                    qso.Fields = new List<KeyValuePair<string, string>>();

                    foreach (KeyValuePair<string, int> map in Columnsmapping) 
                    {
                        string key = map.Key;
                        string value = Values[map.Value];

                        if (key.IndexOf("#") > -1)
                        {
                            string[] ram = key.Split('#');
                            if (ram.Length >= 2)
                                value = FormatQSOValue(ram[1], value);
                            key = ram[0];
                        }

                        qso.Fields.Add(new KeyValuePair<string, string>(key, value));
                    }

                    log.QSOs.Add(qso);
                    i++;
                    if (progress != null)
                        progress.Report(i * 100 / CSV.Content.Count);
                }
                return log;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void SaveADIFFile(Log log, IProgress<int> progress, string Path)
        {
            int i = 0;
            List<string> lines = new List<string>();
            lines.Add("CSV to ADIF Converter");
            lines.Add(AddParameter("PROGRAMID", "CSV-ADIF-Converter"));
            lines.Add("<EOH>");
            lines.Add("");

            foreach (QSO qso in log.QSOs)
            {
                foreach (KeyValuePair<string, string> field in qso.Fields)
                    lines.Add(AddParameter(field.Key, field.Value));

                if (log.DefaultFields != null)
                    foreach (KeyValuePair<string, string> field in log.DefaultFields)
                        lines.Add(AddParameter(field.Key, field.Value));
                lines.Add("<EOR>");
                lines.Add("");

                i++;
                if (progress != null)
                    progress.Report(i * 100 / log.QSOs.Count);
            }

            FileAccess.WriteCSVFile(Path, lines);
        }

        string AddParameter(string key, string value)
        {
            value = value.Trim();
            return "<" + key + ":" + value.Length + ">" + value;
        }
    }
}
