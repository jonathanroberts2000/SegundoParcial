using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Data
    {
        SqlConnection dbConnection = new SqlConnection();

        public Data()
        {
            dbConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["isteaConnectionString"].ToString();
        }

        public DataTable ShowDataTable(string query, SqlParameter[] sqlParameters)
        {
            var dataTable = new DataTable();
            SqlCommand command = new SqlCommand(query, dbConnection);

            if(sqlParameters != null && sqlParameters.Length > 0)
            {
                command.Parameters.AddRange(sqlParameters);
            }

            var da = new SqlDataAdapter();
            da.SelectCommand = command;

            try
            {
                dbConnection.Open();
                da.Fill(dataTable);
            }
            catch (Exception)
            {

                throw;
            }finally
            {
                dbConnection.Close();
            }
            return dataTable;
        }
    }
}
