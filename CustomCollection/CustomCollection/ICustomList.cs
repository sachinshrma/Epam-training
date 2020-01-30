using System;

namespace CustomCollection
{
    public interface ICustomList
    {
        //
        // Summary:
        //     Gets the number of elements actually contained in the CustomList.
        //
        // Returns:
        //     The number of elements actually contained in the CustomList.
        int Count { get; }
        void Add(Object data);
        void AddFirst(Object data);
        void Insert(int index,Object data);

        int IndexOf(Object data);
        bool Contains(Object data);
        Object Get(int index);

        void Sort();
        void Clear();
        void Reverse();        

        bool Remove(Object data);
        bool RemoveAt(int index);        
    }
}
