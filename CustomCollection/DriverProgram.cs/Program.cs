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

            _objCustomList.Reverse();

            _objCustomList.Add("test");

            try
            {
                _objCustomList.Sort();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            foreach (var i in _objCustomList)
                Console.WriteLine(i);



        }
    }
}
