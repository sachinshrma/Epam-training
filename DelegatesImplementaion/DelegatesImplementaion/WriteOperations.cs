using System;
using System.IO;

namespace DelegatesImplementaion
{
    /// <summary>
    /// Class containing methods for writing string to console and file
    /// </summary>
    class WriteOperations
    {
        //File path
        private const String PATH = @"..\..\Test.txt";

        /// <summary>
        /// Method to write string on console
        /// </summary>
        /// <param name="st">String to print on console</param>
        public static void WriteToConsole(String st)
        {
            Console.WriteLine(st); ;
        }

        /// <summary>
        /// Method to write string to file
        /// </summary>
        /// <param name="st">String to write to file</param>
        public static void WriteToFile(String st)
        {
            StreamWriter ObjStreamWriter = new StreamWriter(PATH);
            ObjStreamWriter.WriteLine(st);
            ObjStreamWriter.Flush();
            ObjStreamWriter.Close();

        }
    }
}
