using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            List<Student> results = new List<Student>();

            using (SqlConnection sqlconnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlconnection;

                sqlCommand.CommandText = "SELECT * FROM Students";

                sqlconnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    Student student = new Student();

                    student.Id = sqlDataReader.GetInt32(0);

                    student.Name = sqlDataReader.GetString(1);

                    student.IndexNumber = sqlDataReader.GetString(2);

                    student.AverageMark = sqlDataReader.GetDecimal(3);

                    results.Add(student);
                }
            }


            return results;
        }


        public int InsertStudent(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format( "INSERT INTO Students VALUES('{0}', '{1}', {2})", s.Name, s.IndexNumber, s.AverageMark);
                sqlConnection.Open();


                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
