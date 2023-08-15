using AutoMapper;
using MakineBussines.Services.Abstractions;
using MakineData.Repositories.Abstractions;
using MakineEntity.DTOs.Users;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static MakinePresentation.ResultMessages.Messages;

namespace MakinePresentation.Controllers
{
	[AllowAnonymous]
	public class User : Controller
	{
		private readonly IUserService userService;
		private readonly IMapper mapper;
		private readonly IGenericRepository<AppUser> genericRepository;
		private readonly UserManager<AppUser> userManager;
		public User(IUserService userService,IMapper mapper,IGenericRepository<AppUser> genericRepository, UserManager<AppUser> userManager)
		{
			this.userService = userService;
			this.mapper = mapper;
			this.genericRepository = genericRepository;
			this.userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
		
			var user = await userService.GetUserProfileAsync();
			return View(user);
		}

		[HttpPost]
		public async Task<IActionResult> Index(string currentPassword, string newPassword, string Email)
		{
			// Şu anki kullanıcıyı bul
			var user = await userManager.GetUserAsync(User);

			// Kullanıcının mevcut şifresini doğrula
			var token = await userManager.GenerateChangeEmailTokenAsync(user, Email);
			var resultEmail = await userManager.ChangeEmailAsync(user, Email, token);
			

			if (resultEmail.Succeeded)
			{
				
				

				IdentityResult resultPassword = null;
				if (!string.IsNullOrEmpty(currentPassword) && !string.IsNullOrEmpty(newPassword))
				{
					resultPassword = await userManager.ChangePasswordAsync(user, currentPassword, newPassword);
				}

				if (resultEmail.Succeeded && (resultPassword == null || resultPassword.Succeeded))
				{
					
					return RedirectToAction("Index", "Home");
				}
				else
				{
					
					return View();
				}
			}
			else
			{
				// Şifre değiştirme işlemi başarısızsa burada yapılacak işlemler
				// Örneğin, hataları kullanıcıya göstermek için ModelState.AddModelError() kullanılabilir.
				return View();
			}
		}
		public async Task<IActionResult> UserList()
		{
			var users = await genericRepository.GetAllAsync();
			return View(users);
		}

		[HttpGet]
		public async Task<IActionResult> Delete(string id)
		{
			var user = await userManager.FindByIdAsync(id);
			if (user == null)
			{
				// Kullanıcı bulunamadıysa veya geçerli değilse hata işlemleri yapabilirsiniz.
				// Örneğin, kullanıcıya hata mesajı gösterebilir veya uygun bir hata sayfasına yönlendirebilirsiniz.
				return RedirectToAction("UserList", "User");
			}

			var result = await userManager.DeleteAsync(user);
			if (result.Succeeded)
			{
				// Kullanıcı başarıyla silindiği takdirde yapılacak işlemleri buraya ekleyebilirsiniz.
				return RedirectToAction("UserList", "User");
			}
			else
			{
				// Kullanıcı silme işlemi başarısız olduğunda hata işlemleri yapabilirsiniz.
				// Örneğin, kullanıcıya hata mesajı gösterebilir veya uygun bir hata sayfasına yönlendirebilirsiniz.
				return RedirectToAction("UserList", "User");
			}
		}
		public async Task<IActionResult> UserEdit(string Id)
		{
			var user = userManager.FindByIdAsync(Id);
			return View(user);
		}
		[HttpPost]
		public async Task<IActionResult> UserEdit(UserUpdateDto userUpdateDto)
		{
			await userService.UpdateUserAsync(userUpdateDto);
			
			return View();
		}

	}
}
