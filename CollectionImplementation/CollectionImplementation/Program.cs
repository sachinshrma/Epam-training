using CollectionImplementation.Collections;
using CollectionImplementation.Collections.Generics;
using CollectionImplementation.Concurrent;
using CollectionImplementation.ObjectModel;
using CollectionImplementation.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Collections"
            Console.WriteLine("----Collections----\n");

            Console.WriteLine("ArrayListImplementation :");
            new ArrayListImplementation().ShowImplementation(); // ArrayList

            Console.WriteLine("HashTableImplementation :");
            new HashTableImplementation().ShowImplementation(); //HashTable

            Console.WriteLine("SortedListImplementation :");
            new SortedListImplementation().ShowImplementation(); //SortedList

            Console.WriteLine("StackImplementation :");
            new StackImplementation().ShowImplementation(); // Stack

            Console.WriteLine("QueueImplementation :");
            new QueueImplementation().ShowImplementation(); //Queue
            #endregion

            #region "Generics"
            Console.WriteLine("----Generics----\n");

            Console.WriteLine("ListImplementation :");
            new ListImplementation().ShowImplementation(); //List<T>

            Console.WriteLine("DictionaryImplementation :");
            new DictionaryImplementation().ShowImplementation(); //Dictionary<T,T>

            Console.WriteLine("HashSetImplementation :");
            new HashSetImplementation().ShowImplementation(); //HashSet<T>
            #endregion

            #region "Concurrent"
            Console.WriteLine("----Concurrent----\n");

            Console.WriteLine("BlockingCollectionImplementation :");
            new BlockingCollectionImplementation().ShowImplementation(); //BlockingCollection<T>

            Console.WriteLine("ConcurrentDictionaryImplementation :");
            new ConcurrentDictionaryImplementation().ShowImplementation(); // ConcurrentQueueImplementation<T,T>
            #endregion

            #region "Specialized"
            Console.WriteLine("----Specialized----\n");

            Console.WriteLine("NameValueCollectionImplementation :");
            new NameValueCollectionImplementation().ShowImplementation(); //NameValueCollection

            Console.WriteLine("HybridDictionaryImplementation :");
            new HybridDictionaryImplementation().ShowImplementation(); //HybridDictionary

            Console.WriteLine("StringCollectionImplementation :");
            new StringCollectionImplementation().ShowImplementation();
            #endregion

            #region "Object Model"
            Console.WriteLine("ReadOnlyCollectionImplementation :");
            new ReadOnlyCollectionImplementation().ShowImplementation(); //ReadOnlyCollection<T>
            #endregion
        }
    }
}
