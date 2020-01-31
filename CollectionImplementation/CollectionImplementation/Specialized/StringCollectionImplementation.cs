using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Specialized
{
    class StringCollectionImplementation
    {
        public void ShowImplementation()
        {
            StringCollection stringCollection = new StringCollection();
            stringCollection.Add("One");
            stringCollection.Add("Two");
            stringCollection.Add("Three");
            stringCollection.Add("Four");
            stringCollection.Add("Five");

            stringCollection.Remove("Three");

            Console.WriteLine(stringCollection.Contains("Three"));
            foreach(var x in stringCollection)
                Console.WriteLine(x);

            stringCollection.Clear();
        }
    }
}
