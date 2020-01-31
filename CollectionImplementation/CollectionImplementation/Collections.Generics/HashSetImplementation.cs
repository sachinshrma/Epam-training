using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Collections.Generics
{
    class HashSetImplementation
    {
        public void ShowImplementation()
        {
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(4);
            hashSet.Add(5);
            hashSet.Add(2);
            hashSet.Add(3);

            foreach (var item in hashSet)
                Console.WriteLine(item);
        }
    }
}
