using System;
using System.IO;

namespace Memory_Management_Task
{
    /// <summary>
    /// Class to Implement Write to File Operation
    /// </summary>
    class FileWriteOperation : IDisposable
    {
        #region "Constructor"
        public FileWriteOperation() { _objStreamWriter = new StreamWriter(_filePath); }
        #endregion

        #region "Data Members"
        StreamWriter _objStreamWriter;
        string _filePath = @"..\\..\\test.txt";
        #endregion

        #region "Member Functions"
        /// <summary>
        /// Append the string into the file 
        /// </summary>
        /// <param name="txt">Text which needs to be written in the file</param>
        public void WriteToFile(string txt)
        {
            Console.WriteLine($"Writing -- {txt}");
            _objStreamWriter.WriteLine(txt);
            _objStreamWriter.Flush();
        }
        #endregion

        #region "Override Methods"
        /// <summary>
        /// Disposing the Unmanaged code objects
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Dispose Method Called");
            _objStreamWriter.Close();
        }
        #endregion
    }
}
