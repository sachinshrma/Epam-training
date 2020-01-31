using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Specialized
{
    class HybridDictionaryImplementation
    {
        public void ShowImplementation()
        {
            HybridDictionary hybridDictionary = new HybridDictionary();
            hybridDictionary.Add("One", "1");
            hybridDictionary.Add("Two", "2");
            hybridDictionary.Add("Three", "3");
            hybridDictionary.Add("Four", "4");
            hybridDictionary.Add("Five", "5");
            hybridDictionary.Add("Six", "6");
            hybridDictionary.Add("Seven", "7");
            hybridDictionary.Add("Eight", "8");
            hybridDictionary.Add("Nine", "9");
            hybridDictionary.Add("Ten", "10");

            Console.WriteLine(hybridDictionary.GetType());

            hybridDictionary.Add("Eleven", "11");
            Console.WriteLine(hybridDictionary.GetType());
        }
    }
}
