using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Collections
{
    class SortedListImplementation
    {
        public void ShowImplementation()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(3, "Three");
            sortedList.Add(4, "Four");
            sortedList.Add(5,"Five");

            Console.WriteLine(sortedList.GetByIndex(0)); 

            foreach (DictionaryEntry entry in sortedList)
                Console.WriteLine(entry.Key + " , " + entry.Value);
        }
    }
}
