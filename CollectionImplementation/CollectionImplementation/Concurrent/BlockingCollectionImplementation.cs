using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Concurrent
{
    class BlockingCollectionImplementation
    {
        public void ShowImplementation()
        {
            BlockingCollection<int> blockingCollection = new BlockingCollection<int>(4);
            blockingCollection.Add(1);
            blockingCollection.Add(2);
            blockingCollection.Add(3);
            blockingCollection.Add(4);
            // blockingCollection.Add(5); //this will block the further execution of program

            
            foreach(var x in blockingCollection)
                Console.WriteLine(x);
        }
    }
}
