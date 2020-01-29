using System;

using System.Collections;

namespace CustomCollection
{
    public class CustomList : ICustomList, IEnumerable
    {
        private int _Length;

        private Node Head;
        private Node LastNode;
        public int Count { get { return _Length; } }


        public CustomList()
        {
            Head = null;
            _Length = 0;
        }

        public void Add(Object data)
        {
            Node NewNode = new Node(data);
            if (Head == null)
            {
                Head = NewNode;
                LastNode = NewNode;
            }
            else
            {
                LastNode.Next = NewNode;
                LastNode = NewNode;
            }
            _Length++;
        }
        public void AddFirst(Object data)
        {
            Node newNode = new Node(data);
            if (Head == null)
                Head = newNode;
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            _Length++;
        }

        public void Insert(int index, object data)
        {
            if (index == 0) { AddFirst(data); return; }

            if (index > _Length) throw new Exception("Index Out of Bound");
            Node current = Head, prev = null;

            while (current != null)
            {
                if (index == 0) break;
                prev = current;
                current = current.Next;
                index--;
            }
            Node newNode = new Node(data);
            prev.Next = newNode;
            newNode.Next = current;
            ++_Length;
        }

        public int IndexOf(object data)
        {
            Node current = Head;
            int count = 0;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return count;
                }
                current = current.Next;
                ++count;
            }
            return -1;
        }

        public bool Contains(object data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Sort()
        {
            var tempArray = new Object[_Length];
            Node temp = this.Head;
            var i = 0;
            while (temp != null)
            {
                tempArray[i++] = temp.Data;
                temp = temp.Next;
            }
            try
            {
                Array.Sort(tempArray);
            }
            catch (InvalidOperationException ex)
            {
                throw new FormatException("All Data Should be of Same Type");
            }

            this.Clear();
            foreach (var data in tempArray)
                this.Add(data);
        }

        public void Clear()
        {
            Head = null;
            _Length = 0;
        }

        public bool Remove(object data)
        {
            Node prev = null, current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    prev.Next = current.Next;
                    --_Length;
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            throw new Exception("Data Not Found");
        }

        public bool RemoveAt(int index)
        {
            Node prev = null, current = Head;
            if (index == 0 && _Length > 0)
            {
                Head = Head.Next;
                --_Length;
                return true;
            }

            while (current != null)
            {
                if (index == 0)
                {
                    prev.Next = current.Next;
                    --_Length;
                    return true;
                }
                --index;
                prev = current;
                current = current.Next;
            }
            throw new Exception("Index Out of Bound");
        }

        public object Get(int index)
        {
            if (index > _Length) throw new Exception("Index Out of Bound");
            Node current = Head;
            while (current != null)
            {
                if (index == 0)
                {
                    return current.Data;
                }
                index--;
                current = current.Next;
            }
            return null;
        }

        public void Reverse()
        {
            if (Head == null) return;
            Node prev = null, current = Head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomListEnumerator(Head);
        }

        class CustomListEnumerator : IEnumerator
        {
            private Node current, Head;
            public CustomListEnumerator(Node head)
            {
                this.current = null;
                this.Head = head;
            }
            public object Current => current.Data;

            public bool MoveNext()
            {
                if (current == null)
                {
                    current = Head;
                    return true;
                }
                if (this.current.Next == null) return false;

                else
                    this.current = this.current.Next;
                return true;

            }


            public void Reset() => current = Head;

        }
    }
}
