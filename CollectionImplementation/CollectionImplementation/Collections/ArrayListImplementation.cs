using System;
using System.Collections;
namespace CollectionImplementation.Collections
{
    class ArrayListImplementation
    {
        public void ShowImplementation()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3.0);
            arrayList.Add("Four");
            arrayList.Add("Five");

            arrayList.Insert(4, 4.5);
            arrayList.RemoveAt(3);
            arrayList.Reverse();

            foreach(var data in arrayList)
                Console.WriteLine(data);
        }
    }
}
