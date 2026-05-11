using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomesoSystem.Models
{
    public static class CurrentUser
    {
        public static int UserId { get; set; }
        public static string Login { get; set; }
        public static string FullName { get; set; }
        public static string UserRole { get; set; }

        public static bool IsAdmin => UserRole == "Admin";
        public static bool IsStorekeeper => UserRole == "Storekeeper";
        public static bool IsManager => UserRole == "Manager";

        public static void Clear()
        {
            UserId = 0;
            Login = string.Empty;
            FullName = string.Empty;
            UserRole = string.Empty;
        }
    }
}
