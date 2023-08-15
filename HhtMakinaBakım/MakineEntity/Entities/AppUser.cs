using Microsoft.AspNetCore.Identity;

namespace MakineEntity.Entities
{
	public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
		public int? ImageId { get; set; } 
		public Image Image { get; set; }
	}
}
