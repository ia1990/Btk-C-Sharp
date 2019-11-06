using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class StudentAdap
    {
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ESchool;integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("select * from Student", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Tc = reader["Tc"].ToString(),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Bolum = reader["Department"].ToString(),
                    City = reader["City"].ToString()
                };
                students.Add(student);
            }

            sqlConnection.Close();
            return students;
        }
    }
}
