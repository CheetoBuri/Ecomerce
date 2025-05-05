using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Models;

namespace DAL
{
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            using (var conn = DBHelper.GetConnection())
            {
                var cmd = new SqlCommand("SELECT * FROM Users", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserID = (int)reader["UserID"],
                        UserName = reader["UserName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString()
                    });
                }
            }
            return users;
        }
    }
}
