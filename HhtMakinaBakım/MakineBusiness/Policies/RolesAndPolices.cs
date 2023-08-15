using System.Linq;

namespace MakineBussines
{
    public class RolesAndPolices
    {

        public static class Roles
        {
            public const string Admin = "Admin";
            public const string User = "User";
            public const string Superadmin = "Superadmin";
        }
        public static class Policies
        {
            public const string AdminOnly = "AdminOnly";
        }

       
    }

}