using System;
using System.Collections;

namespace CompareInterfacesImplementatiions
{
    class DriverProgram
    {
        static void Main(string[] args)
        {

            //Dummy data for list
            StudentComparable Student = new StudentComparable("Sachin",1);
            StudentComparable Student2 = new StudentComparable("Ankit", 2);
            StudentComparable Student3 = new StudentComparable("Jitender", 3);
            StudentComparable Student4 = new StudentComparable("Praveen", 4);

            //Adding dummy data to list
            ArrayList StudentList = new ArrayList();
            StudentList.Add(Student);
            StudentList.Add(Student2);
            StudentList.Add(Student3);
            StudentList.Add(Student4);


            #region "Icomparable"

            Console.WriteLine("\nIcomparable implementation :");

            //Sorting the list using sort method which will sort the students according to IComaparable implementation
            StudentList.Sort();

            //Displaying students data
            Console.WriteLine("Sorted list according to Name");
            foreach (var stud in StudentList){
                Console.WriteLine(((StudentComparable)stud).Name + ", "+ ((StudentComparable)stud).Rollno);
            }
            Console.WriteLine();

            #endregion

            #region "Icomparer"

            Console.WriteLine("\nIcomparer implementation :");
            //Instantiating comparer which will sort the list based on student rollno
            StudentsRollNoAscendingComparer RollnoComparer = new StudentsRollNoAscendingComparer();

            //Sorting the list by passing custom rollno comparer to sort method
            StudentList.Sort(RollnoComparer);

            //Displaying students data
            Console.WriteLine("Sorted list according to rollno");
            foreach (var stud in StudentList)
            {
                Console.WriteLine(((StudentComparable)stud).Name + ", " + ((StudentComparable)stud).Rollno);
            }
            Console.WriteLine();


            //Instantiating comparer which will sort the list based on student name
            StudentsNameAscendingComparer NameComparer = new StudentsNameAscendingComparer();

            //Sorting the list by passing custom name comparer to sort method
            StudentList.Sort(NameComparer);

            //Displaying students data
            Console.WriteLine("Sorted list according to Name");
            foreach (var stud in StudentList)
            {
                Console.WriteLine(((StudentComparable)stud).Name + ", " + ((StudentComparable)stud).Rollno);
            }

            #endregion

            #region "IEquatable"

            Console.WriteLine("\nIEquatable implementation :");

            StudentComparable Student5 = new StudentComparable("Sachin", 1);

            if(Student.Equals(Student5))
                Console.WriteLine("Both students are same");
            else
                Console.WriteLine("Both students are not same");

            #endregion

        }
    }
}
