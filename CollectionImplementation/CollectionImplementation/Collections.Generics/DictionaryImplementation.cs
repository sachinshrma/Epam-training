using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Collections.Generics
{
    class DictionaryImplementation
    {
        public void ShowImplementation()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);
            dictionary.Add("Three",3);
            dictionary.Add("Four", 4);
            dictionary.Add("Five", 5);

            foreach (KeyValuePair<string, int> entry in dictionary)
                Console.WriteLine(entry.Key + " , " + entry.Value);
        }
    }
}
