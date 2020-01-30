using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesImplementaion
{
    /// <summary>
    /// Model class for list
    /// </summary>
    class Student
    {
        public int RollNo { get; }
        public String Name { get; }

        public Student(String name, int rollNo)
        {
            this.Name = name;
            this.RollNo = rollNo;
        }

        /// <summary>
        /// Method for comparison delegate
        /// </summary>
        /// <param name="obj1">first student object</param>
        /// <param name="obj2">second student object</param>
        /// <returns></returns>
        public static int StudentCompare(Student obj1, Student obj2)
        {
            return obj1.Name.CompareTo(obj2.Name);
        }
    }
}
