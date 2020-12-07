using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        public DataTable GetUserByInputData(string userName, string password)
        {
            var data = new Data();

            var firstParameter = new SqlParameter("@pUserName", userName);
            var secondParameter = new SqlParameter("@pPassword", password);

            var allParams = new SqlParameter[] { firstParameter, secondParameter };
            return data.ShowDataTable("SELECT TOP 1 * FROM Users WHERE user_name = @pUserName AND password = @pPassword", allParams);
        }
    }
}
