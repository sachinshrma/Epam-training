using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Collections
{
    class StackImplementation
    {
        public void ShowImplementation()
        {
            Stack stack = new Stack();
            stack.Push("One");
            stack.Push("Two");
            stack.Push(3);
            stack.Push(4);
            stack.Push(5.0);

            stack.Pop();

            foreach(var item in stack)
                Console.WriteLine(item);

        }

    }
}
