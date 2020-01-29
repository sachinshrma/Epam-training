using System;
using System.IO;

namespace Memory_Management_Task
{
    /// <summary>
    /// Class Implementing the funtionality of Reading as well Writing into the File => Destructor
    /// </summary>
    class FileWriteOperation_Finalize : IDisposable
    {
        #region "Data Members"
        StreamWriter _objStreamWriter;

        string _filePath = @"..\\..\\Induction.txt";
        #endregion

        #region "Constructor"
        public FileWriteOperation_Finalize() { _objStreamWriter = new StreamWriter(_filePath); }
        #endregion

        #region "Override Methods"
        public void Dispose()
        {
            _objStreamWriter.Close();

            //To avoid calling the finalize method
            GC.SuppressFinalize(this);
        }
        #endregion

        #region "Destructor"
        ~FileWriteOperation_Finalize()
        {
            Console.WriteLine("Finalize called");            
            //_objStreamWriter.Close();            
        }
        #endregion

        #region "Member Functions"
        public void WriteToFile(String txt)
        {
            Console.WriteLine($"Writing--> {txt}");
            _objStreamWriter.WriteLine(txt);
            _objStreamWriter.Flush();
        }
        #endregion
    }
}
