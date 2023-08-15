using System.Security.Claims;

namespace MakineBussines.Extensions
{
    public static class LoggedInUserExtensions
    {
        public static string GetLoggedInUserId(this ClaimsPrincipal principal)
        {
            return principal.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public static string GetLoggedInEmail(this ClaimsPrincipal principal)
        {
            return principal.FindFirstValue(ClaimTypes.Email);
        }
    }
}
