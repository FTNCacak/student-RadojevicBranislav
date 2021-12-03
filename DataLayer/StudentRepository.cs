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

            using (SqlConnection sqlconnection = new SqlConnection(Constants.connString)
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlconnection;
            }


            return results;
        }
    }
}
