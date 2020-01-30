using System;
using System.Collections.Generic;
using System.IO;

namespace DelegatesImplementaion
{
    class DriverProgram
    {
        //Delegate for writing string 
        private delegate void WriteString(String st);
        static void Main(string[] args)
        {

            #region "Custom Delgate"
            //Delegate reference pointing to WriteToConsole method
            WriteString DelegateRef = new WriteString(WriteOperations.WriteToConsole);

            //Multicasting Delegate reference to point WriteToFile method
            DelegateRef += WriteOperations.WriteToFile;

            //Invoking multicast delegate
            DelegateRef("Hello world!!");
            #endregion


            #region "Comparison delegate"
            //Dummy student data
            List<Student> StudentList = new List<Student>();
            StudentList.Add(new Student("Sachin", 1));
            StudentList.Add(new Student("Jitender", 2));
            StudentList.Add(new Student("praveen", 3));

            Console.WriteLine("\n\nBefore sorting :\n");
            Display(StudentList);

            //Sorting using Comparison delegate
            StudentList.Sort(Student.StudentCompare);

            Console.WriteLine("\n\nAfter sorting :\n");
            Display(StudentList);
            #endregion

        }

        /// <summary>
        /// Method for displaying student data from list
        /// </summary>
        /// <param name="studentList"></param>
        private static void Display(List<Student> studentList)
        {
            foreach(var stud in studentList)
            {
                Console.WriteLine(stud.Name+" , "+stud.RollNo);
            }
        }
    }

    


    
    
}

