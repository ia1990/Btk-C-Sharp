using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ders1
{
    class StudentAdap
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ESchool;integrated security=true");
        private void ConnectionControl()
        {

            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }
        public List<StudentDto> GetAll()
        {
            List<StudentDto> students = new List<StudentDto>();
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("select * from Students", _sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                StudentDto student = new StudentDto
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

            _sqlConnection.Close();
            return students;
        }

        public int Add(StudentDto student)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "insert into Students(Tc,Name,Surname,Department,City) values(@tc,@name,@surname,@department,@city)", _sqlConnection);
            sqlCommand.Parameters.AddWithValue("@tc", student.Tc);
            sqlCommand.Parameters.AddWithValue("@name", student.Name);
            sqlCommand.Parameters.AddWithValue("@surname", student.Surname);
            sqlCommand.Parameters.AddWithValue("@department", student.Bolum);
            sqlCommand.Parameters.AddWithValue("@city", student.City);
            int i = 0;
            try
            {
                 i = sqlCommand.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException err)
            {
                //veri tabanı ile ilgili hatalar
                //Hata mesajı (err.Message) oluşturulacak log sistemine eklenerek sistem izlenebilir.
                string msj = err.Message;
                if (msj.IndexOf("UNIQUE KEY") > 0)//IndexOf metodu msj değişkenimizin içerisinde "UNIQUE KEY" ifadesi geçiyorsa bu ifadenin başladığı karakterin index numarasını döner, geçmiyorsa -1 döner
                {
                    i = -1;//Girilmek istenen Tc alanı daha önce eklenmiş
                }
                
            }
            catch (Exception err)
            {
                string msj = err.Message;
            }
            _sqlConnection.Close();
            return i;
        }

        public int Update(StudentDto student)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "update Students set Tc = @tc, Name = @name, Surname = @surname, Department = @department, City = @city where Id = @id", _sqlConnection);
            sqlCommand.Parameters.AddWithValue("@tc", student.Tc);
            sqlCommand.Parameters.AddWithValue("@name", student.Name);
            sqlCommand.Parameters.AddWithValue("@surname", student.Surname);
            sqlCommand.Parameters.AddWithValue("@department", student.Bolum);
            sqlCommand.Parameters.AddWithValue("@city", student.City);
            sqlCommand.Parameters.AddWithValue("@id", student.Id);

            int i = sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
            return i;
        }

        public int Delete(int Id)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("delete from Students where Id = @id", _sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", Id);
            int i = sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
            return i;
        }
    }
}
