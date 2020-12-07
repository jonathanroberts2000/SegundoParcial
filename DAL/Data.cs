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

            var da = new SqlDataAdapter
            {
                SelectCommand = command
            };

            try
            {
                dbConnection.Open();
                da.Fill(dataTable);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                dbConnection.Close();
            }
            return dataTable;
        }

        public int ExecuteWithoutResult(string query, SqlParameter[] parameters)
        {
            int rowsAffected = 0;
            SqlCommand command = new SqlCommand(query, dbConnection);

            if(parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }

            try
            {
                dbConnection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                dbConnection.Close();
            }
            return rowsAffected;
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            object result = null;
            SqlCommand command = new SqlCommand(query, dbConnection);

            if(parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }

            try
            {
                dbConnection.Open();
                result = command.ExecuteScalar();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                dbConnection.Close();
            }
            return result;
        }
    }
}
