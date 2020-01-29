using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    public interface ICustomList
    {        
        /// <summary>
        /// adding data at last
        /// </summary>
        /// <param name="data"></param>
        void Add(Object data);
        void AddFirst(Object data);
        void Insert(int index,Object data);

        int IndexOf(Object data);
        bool Contains(Object data);
        Object Get(int index);

        void Sort();
        void Clear();

        //TODO: set Count varaiable

        bool Remove(Object data);
        bool RemoveAt(int index);        
    }
}
