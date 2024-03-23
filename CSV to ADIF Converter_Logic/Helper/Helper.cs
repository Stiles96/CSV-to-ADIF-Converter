using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSV_to_ADIF_Converter_Logic
{
    public static class Helper
    {
        public static string GetJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public static T GetObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
