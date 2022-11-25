using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project___D7__CTEDS_
{
    public static class CurrentUser
    {
        public static string? LoginStatus { get; set; } = "not autenticated";
        public static Guid ID { get; set; }
        public static string? Name { get; set; }
        public static string? UserName { get; set; }
        public static string? UserEmail { get; set; }
    }
}
