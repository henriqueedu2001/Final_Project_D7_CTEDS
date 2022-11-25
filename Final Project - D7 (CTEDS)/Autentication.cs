using Final_Project___D7__CTEDS_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project___D7__CTEDS_
{
    public static class Autentication
    {
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
            User user = new User(new Guid(), "Cleito", "cleitin", "cleitin@usp.br", "cleito123");
            Users.Add(user);
        }
    }
}
