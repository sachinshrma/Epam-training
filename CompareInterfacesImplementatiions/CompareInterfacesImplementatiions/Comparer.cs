using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareInterfacesImplementatiions
{
    /// <summary>
    /// Student comparer sorts based on name property
    /// </summary>
    class StudentsNameAscendingComparer : IComparer
    {
        public int Compare(object x, object y) => ((StudentComparable)x).Name.CompareTo(((StudentComparable)y).Name);
        
    }

    /// <summary>
    /// Student comparer sorts based on Rollno property
    /// </summary>
    class StudentsRollNoAscendingComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (((StudentComparable)x).Rollno < ((StudentComparable)y).Rollno) return -1;
            if (((StudentComparable)x).Rollno > ((StudentComparable)y).Rollno) return 1;
            return 0;
        }
    }
}
