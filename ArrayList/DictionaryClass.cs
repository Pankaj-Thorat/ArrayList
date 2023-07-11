using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class DictionaryClass
    {
        public Dictionary<string, int> Mydict { get; }

        public static Dictionary<string, int> AddElements(Dictionary<string, int> dictionary)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("Pankaj", 95);
            dict.Add("Ankita", 91);
            dict.Add("Kiran", 92);

            return dict;
        }
    }
}
