using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        public User GetUser(string userName, string password)
        {
            var userDAL = new UserDAL();
            var dt = userDAL.GetUserByInputData(userName, password);

            foreach(DataRow aux in dt.Rows)
            {
                return new User
                {
                    Id = Convert.ToInt32(aux["id"].ToString()),
                    Name = aux["name"].ToString(),
                    LastName = aux["last_name"].ToString(),
                    UserName = aux["user_name"].ToString(),
                    Password = aux["password"].ToString(),
                    Enabled = Convert.ToBoolean(aux["enabled"].ToString()),
                    ProfileType = (EProfile)Convert.ToInt32(aux["user_profile_id"].ToString()),
                };
            }
            return null;
        }
    }
}
