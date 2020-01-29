using System;
using System.IO;

namespace Memory_Management_Task
{
    /// <summary>
    /// Class will implement the File Read Operation and disposing by Using Block
    /// </summary>
    class FileRead_Using
    {
        #region "Data Members"
        string _filePath = @"..\\..\\test.txt";
        #endregion

        #region "Member Functions"
        public string ReadFromFile()
        {
            using (StreamReader _objStreamReader = new StreamReader(_filePath))
            {
                return _objStreamReader.ReadLine();
            }
        }
        #endregion
    }
}
