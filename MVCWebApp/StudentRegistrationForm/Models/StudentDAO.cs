using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentRegistrationForm.Models
{
    public class StudentDAO
    {
        private static StudentDAO objStudentDAO=new StudentDAO(); 
        string ConnectionString = "Data Source=EPINHYDW00EF;Initial Catalog=Student;Integrated Security=true";
        private StudentDAO() {
            
            
        }

        public static StudentDAO GetInstance() => objStudentDAO;

        public bool AddStudent(Student student)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string insertQuery = "insert into StudentTB(RollNo,FirstName,LastName,Email,Address)values (@rollNo,@firstName,@lastName,@email,@address)";
                SqlCommand query = new SqlCommand(insertQuery, conn);
                query.Parameters.AddWithValue("@rollNo",student.RollNo);
                query.Parameters.AddWithValue("@firstName", student.FirstName);
                query.Parameters.AddWithValue("@lastName", student.LastName);
                query.Parameters.AddWithValue("@email", student.Email);
                query.Parameters.AddWithValue("@address", student.Address);
                int rowsAffected= query.ExecuteNonQuery();

                query.Dispose();
                conn.Close();
                if (rowsAffected < 1) return false;
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string selectQuery = "Select * from StudentTB";
            SqlCommand query = new SqlCommand(selectQuery, conn);
            SqlDataReader dataReader= query.ExecuteReader();
            while (dataReader.Read())
            {
                Student student = new Student();
                student.RollNo = dataReader.GetInt32(0);
                student.FirstName = dataReader.GetString(1);
                student.LastName = dataReader.GetString(2);
                student.Email = dataReader.GetString(3);
                student.Address = dataReader.GetString(4);
                students.Add(student);

            }
            return students;

        }
        public Student findStudentByRollNo(int rollNo)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string selectQuery = "Select * from StudentTB where RollNo=@roll";
            SqlCommand query = new SqlCommand(selectQuery, conn);
            query.Parameters.AddWithValue("@roll", rollNo);
            SqlDataReader dataReader = query.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                Student student = new Student();
                student.RollNo = dataReader.GetInt32(0);
                student.FirstName = dataReader.GetString(1);
                student.LastName = dataReader.GetString(2);
                student.Email = dataReader.GetString(3);
                student.Address = dataReader.GetString(4);

                return student;
            }
            return null;
        }
    }
}