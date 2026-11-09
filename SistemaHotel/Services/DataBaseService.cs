using System.Data;
using System.Data.SqlClient;

namespace SistemaHotel.Services
{
    public class DataBaseService
    {
        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SistemaHotel;Integrated Security=SSPI;");
        }

        public int ExecuteSql(SqlCommand command)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                command.Connection = connection;
                return command.ExecuteNonQuery();
            }
        }

        public DataTable GetDataTable(SqlCommand command)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                command.Connection = connection;
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
