using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Collections.Generics
{
    class ListImplementation
    {
        public void ShowImplementation()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
                Console.WriteLine(item);

            Console.WriteLine("Sum of list items is : " + list.Sum());
            Console.WriteLine("Average of list is : "+list.Average());

        }
    }
}
