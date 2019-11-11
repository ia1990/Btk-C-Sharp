using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ders1
{
    class UserAdap
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ESchool;integrated security=true");
        private void ConnectionControl()
        {

            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }

        public int LoginControl(string UserName, string Pass)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("select count(Id) from Users where UserName = @userName and Pass = @pass", _sqlConnection);
            sqlCommand.Parameters.AddWithValue("@userName", UserName);
            sqlCommand.Parameters.AddWithValue("@pass", Pass);
            int result = (int)sqlCommand.ExecuteScalar();
            return result;
        }
    }
}
