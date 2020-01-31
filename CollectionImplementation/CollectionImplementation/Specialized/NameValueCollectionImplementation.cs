using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Specialized
{
    class NameValueCollectionImplementation
    {
        public void ShowImplementation()
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("One", "1");
            nameValueCollection.Add("Two", "2");
            nameValueCollection.Add("Three", "3");
            nameValueCollection.Add("Four", "4");

            Console.WriteLine("Traversal By key :");
            foreach (string key in nameValueCollection.Keys)
                Console.WriteLine(key + " , " + nameValueCollection[key]);

            Console.WriteLine("Traversal By Index :");
            for (var i = 0; i < nameValueCollection.Count; ++i)
                Console.WriteLine(i + " , " + nameValueCollection[i]);
        }
    }
}
