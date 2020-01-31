using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionImplementation.Concurrent
{
    class ConcurrentDictionaryImplementation
    {
        public static ConcurrentDictionary<int,string> concurrentDictionary = new ConcurrentDictionary<int, string>();
        public void ShowImplementation()
        {
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);

            thread1.Start();
            thread2.Start();

            Console.WriteLine("Cocnurrent dictionary size is : "+concurrentDictionary.Count);

        }

        public static void Method1()
        {
            for(var i = 0; i < 1000; ++i)
            {
                concurrentDictionary.TryAdd(i,"Method1");
            }
        }
        public static void Method2()
        {
            for (var i = 0; i < 1000; ++i)
            {
                concurrentDictionary.TryAdd(i, "Method2");
            }
        }

    }
}
