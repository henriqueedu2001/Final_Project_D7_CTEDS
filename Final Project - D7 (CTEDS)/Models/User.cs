using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project___D7__CTEDS_.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? Password { get; set; }
        public User(Guid id, string? name, string? username, string? useremail, string? password)
        {
            ID = id;
            Name = name;
            UserName = username;
            UserEmail = useremail;
            Password = password;
        }
    }
}
