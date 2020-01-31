using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.ObjectModel
{
    class ReadOnlyCollectionImplementation
    {
        public void ShowImplementation()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            ReadOnlyCollection<int> readOnlyCollection = new ReadOnlyCollection<int>(list);

            foreach(var x in readOnlyCollection)
                Console.WriteLine(x);

            //can't modifiy values using readOnlyCollection
           // no readOnlyCollection.Add() method is present
        }
    }
}
