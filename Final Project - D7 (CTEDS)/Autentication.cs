using Final_Project___D7__CTEDS_.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project___D7__CTEDS_
{
    public static class Autentication
    {
        private static readonly string connection_string = "Server=tcp:polibits-pegasus.database.windows.net,1433;Initial Catalog=DB;Persist Security Info=False;User ID=pegasus_adm;Password=#Minecraft123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private static List<User> Users = new List<User>();
        public static bool AutenticateUser(string useremail, string password)
        {
            LoadUsers();
            foreach (var user in Users)
            {
                if(user.UserEmail == useremail && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static void LoadUsers()
        {
            using(SqlConnection con = new SqlConnection(connection_string))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ID, Name, Username, Email, Password FROM USERS_CTEDS_D7", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Guid ID = (Guid) rdr["ID"];
                    string Name = rdr["Name"].ToString();
                    string Username = rdr["Username"].ToString();
                    string Email = rdr["Email"].ToString();
                    string Password = rdr["Password"].ToString();
                    Users.Add(new User(ID, Name, Username, Email, Password));
                }
            }
        }
    }
}
