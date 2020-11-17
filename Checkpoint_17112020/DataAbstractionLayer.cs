using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Checkpoint_17112020
{
    public static class DataAbstractionLayer
    {
        private static SqlConnection _connection = new SqlConnection();

        public static void Connect(SqlConnectionStringBuilder stringBuilder)
        {
            _connection.ConnectionString = stringBuilder.ConnectionString;
            _connection.Open();
        }

        public static void Disconnect()
        {
            _connection.Close();
        }

        internal static IEnumerable<Student> SelectAllStudents()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT StudentId, StudentLastName, StudentFirstName FROM Student";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student newstudent = new Student
                {
                    StudentId = reader.GetInt32(0),
                    LastName = reader.GetString(1),
                    FirstName = reader.GetString(2),
                };
                students.Add(newstudent);
            }
            reader.Close();
            return students;
        }

        internal static IEnumerable<Student> SelectAllStudentsV2()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = @"SELECT StudentLastName, StudentFirstName, AVG(ExamNote) 
                                    FROM Exam
                                    INNER JOIN Student ON  StudentId = FK_StudentId
                                    GROUP BY StudentId, StudentLastName, StudentFirstName";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student newstudent = new Student
                {
                    LastName = reader.GetString(0),
                    FirstName = reader.GetString(1),
                    Average = reader.GetDecimal(2),
                };
                students.Add(newstudent);
            }
            reader.Close();
            return students;
        }

        internal static IEnumerable<Student> SelectStudentByLastname(String Lastname)
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT StudentId, StudentLastName, StudentFirstName FROM Student WHERE StudentLastName = '"+Lastname+"'";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student newstudent = new Student
                {
                    StudentId = reader.GetInt32(0),
                    LastName = reader.GetString(1),
                    FirstName = reader.GetString(2),
                };
                students.Add(newstudent);
            }
            reader.Close();
            return students;
        }
    }
}
