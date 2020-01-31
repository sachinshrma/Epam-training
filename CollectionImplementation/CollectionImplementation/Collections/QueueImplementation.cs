using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImplementation.Collections
{
    class QueueImplementation
    {
        public void ShowImplementation()
        {
            Queue queue = new Queue();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5.0);

            queue.Dequeue();

            foreach (var item in queue)
                Console.WriteLine(item);
        }
    }
}
