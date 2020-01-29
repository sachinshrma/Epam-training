using System;

namespace CustomCollection
{
    class Node
    {
        public Object Data;
        public Node Next;

        public Node(Object data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
