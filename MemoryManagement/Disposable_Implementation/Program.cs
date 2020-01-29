using System;

namespace Memory_Management_Task
{
    /// <summary>
    /// Class will implement all the major functionality of related to memory management
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region "Arrange"

            FileWriteOperation _objFileOperation = new FileWriteOperation(); 
            
            FileWriteOperation_Finalize _objFileReadWrite = new FileWriteOperation_Finalize();

            FileRead_Using _objFileRead = new FileRead_Using();

            #endregion

            #region "Act"

            //Dispose Methods
            _objFileOperation.WriteToFile("Hello C#");
            _objFileOperation.Dispose();

            //Finalize Method
            _objFileReadWrite.WriteToFile("YO! Dot Net FrameWork");            
            GC.Collect();
            _objFileReadWrite.Dispose();

            //Using Statement
            Console.WriteLine($"Data in File -- {_objFileRead.ReadFromFile()}");      

            #endregion

            Console.ReadLine();
        }
    }
}
