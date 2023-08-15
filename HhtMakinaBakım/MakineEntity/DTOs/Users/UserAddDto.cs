using MakineEntity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MakineEntity.DTOs.Users
{
	public class UserAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [MinLength(5,ErrorMessage ="Lütfen 5 karakterden fazla giriş yapın ")]
        public string Password { get; set; }
        
		public string SelectedRole { get; set; }
		public string Role { get; set; }
		public IFormFile? ProfileImage { get; set; }


	}
}
