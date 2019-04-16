using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee.DataAccessLayer.DataAccessLayer
{
    public class DataAccess
    {
        public static readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Coffee;Integrated Security=True";
        public static void ExecuteSPWithNoResult(string procedureName, List<SPParam> paramList)
        {
            using (SqlConnection connection = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand command = new SqlCommand(procedureName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                for (int i = 0; i < paramList.Count; i++)
                {
                    command.Parameters.AddWithValue(paramList[i].Name, paramList[i].Value);
                }
                command.ExecuteNonQuery();
            }
        }

        public static void ExecuteSPWithNoParam(string procedureName)
        {
            using (SqlConnection connection = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand command = new SqlCommand(procedureName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
