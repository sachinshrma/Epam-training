using System;
using CustomCollection;

namespace DriverProgram.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList _objCustomList = new CustomList();
            for (var i = 0; i < 10; ++i)
                _objCustomList.Add(i);

            for (var i = 0; i < _objCustomList.Count; ++i)
                Console.WriteLine(_objCustomList.Get(i));

           // _objCustomList.Clear();
            _objCustomList.RemoveAt(_objCustomList.Count-1);
            Console.WriteLine();
            for (var i = 0; i < _objCustomList.Count; ++i)
                Console.WriteLine(_objCustomList.Get(i));
            


        }
    }
}
