using System;
using System.Collections;

namespace CustomCollection
{
    public class CustomList : ICustomList, IEnumerable
    {
        #region "Data Fields"        
        private int _Length;
        private Node Head;
        private Node LastNode;
        #endregion

        #region "Constructor"
        public CustomList()
        {
            Head = null;
            _Length = 0;
        }
        #endregion

        #region "Override Methods"
        /// <summary>
        /// Gets the number of elements actually contained in the CustomList.
        /// </summary>
        /// <returns>The number of elements actually contained in the CustomList </returns>
        public int Count => _Length;

        /// <summary>
        /// Add a new Object into the CustomList Collection
        /// </summary>
        /// <param name="data">Data: Element to be added in Collection</param>
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

        /// <summary>
        /// Add the Data at the begining of the CustomCollection
        /// </summary>
        /// <param name="data">Data:Element to be added in Collection</param>
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
       
        /// <summary>
        /// Insert the Data at the given position of the CustomCollection
        /// </summary>
        /// <param name="index">Position of the Element</param>
        /// <param name="data">Element need to be add</param>
        public void Insert(int index, object data)
        {
            if (index == 0) { AddFirst(data); return; }

            if (index > _Length) throw new IndexOutOfRangeException("Index Out of Bound");
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

        /// <summary>
        /// Get the Index of the element in the Collection
        /// </summary>
        /// <param name="data">Element whose position is required</param>
        /// <returns>Return the index of the Element</returns>
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

        /// <summary>
        /// Check Whether the given element is in the Collection or not
        /// </summary>
        /// <param name="data">Element which need to be checked</param>
        /// <returns>Boolean Value whether element is there or not</returns>
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

        /// <summary>
        /// Sort the Collection
        /// </summary>
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
            catch (InvalidOperationException _)
            {
                throw new FormatException("All Data Should be of Same Type");
            }

            this.Clear();

            foreach (var data in tempArray)
                this.Add(data);
        }

        /// <summary>
        /// Remove all the Elements from the Collection
        /// </summary>
        public void Clear()
        {
            Head = null;
            _Length = 0;
        }

        /// <summary>
        /// Remove the given element from the collection
        /// </summary>
        /// <param name="data">Element that need to be removed</param>
        /// <returns>Boolean value that represents whether element removed successfully or not</returns>
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

        /// <summary>
        /// Remove the Element from the given position
        /// </summary>
        /// <param name="index">Position in the Collection</param>
        /// <returns></returns>
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

        /// <summary>
        ///Get the given Element from the Collection
        /// </summary>
        /// <param name="index">Index of the element</param>
        /// <returns>Returns the element</returns>
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

        /// <summary>
        /// Reverse the Collection
        /// </summary>
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
        #endregion

        #region "Enumerator class"
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
        #endregion
    }
}
