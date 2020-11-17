using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Checkpoint_17112020
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.InitialCatalog = "Campus";
            stringBuilder.DataSource = @"LOCALHOST\SQLEXPRESS";
            stringBuilder.IntegratedSecurity = true;
            DataAbstractionLayer.Connect(stringBuilder);

            Console.WriteLine("Afficher la liste de tous les étudiants du campus :");
            foreach (Student student in DataAbstractionLayer.SelectAllStudents())
            {
                Console.WriteLine(student.StudentId + " - " + student.LastName + " " + student.FirstName);
            }

            Console.WriteLine("Afficher un étudiant en fonction de son nom de famille :");
            foreach (Student student in DataAbstractionLayer.SelectStudentByLastname("Balboa"))
            {
                Console.WriteLine(student.StudentId + " - " + student.LastName + " " + student.FirstName);
            }

            Console.WriteLine("Afficher la liste de tous les étudiants du campus avec leur moyenne :");
            foreach (Student student in DataAbstractionLayer.SelectAllStudentsV2())
            {
                Console.WriteLine(student.LastName + " " + student.FirstName + " - Moyenne : " + Math.Round(student.Average,2)+"/20");
            }

            DataAbstractionLayer.Disconnect();
        }
    }
}
