using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Collections
{
    class HashTableImplementation
    {
        public void ShowImplementation()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "One");
            hashtable.Add(2.0, "Two");
            hashtable.Add("Three", "Three");
            hashtable.Add("Four", 4);
            hashtable.Add(5, 5);

            hashtable.Remove("Four");

            foreach(DictionaryEntry entry in hashtable )
                Console.WriteLine(entry.Key+" , "+entry.Value);
        }
    }
}
