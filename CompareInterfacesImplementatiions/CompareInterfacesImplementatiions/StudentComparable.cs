using System;

namespace CompareInterfacesImplementatiions
{
    class StudentComparable : IComparable,IEquatable<StudentComparable>
    {

        public string Name { get; set; }
        public int Rollno { get; set; }

        public StudentComparable(string tname,int trollno)
        {
            Name = tname;
            Rollno = trollno;
        }

        public int CompareTo(Object obj)
        {
            if (!(obj is StudentComparable))
                throw new Exception("Not comaparable types");

            return Name.CompareTo(((StudentComparable)obj).Name);
        }

        public bool Equals(StudentComparable other)
        {
            if (Name.Equals(other.Name) && Rollno == other.Rollno)
                return true;

            return false;
        }
    }
}
