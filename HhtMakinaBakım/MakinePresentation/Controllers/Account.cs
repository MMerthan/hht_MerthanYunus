using MakineEntity.DTOs.Users;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MakinePresentation.Controllers
{
	[AllowAnonymous]
	public class Account : Controller
	{
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManager;

		public Account(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(UserLoginDto userLoginDto)
		{
			if (ModelState.IsValid)
			{
				var user = await userManager.FindByEmailAsync(userLoginDto.Email);
				if (user != null)
				{
					var result = await userManager.CheckPasswordAsync(user, userLoginDto.Password);
					if (result)
					{
						await signInManager.SignInAsync(user, true);
						return RedirectToAction("Index", "Home");
					}
					else
					{
						ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
						return View();
					}
				}
				else
				{
					ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
					return View();
				}
			}
			else
			{
				return View();
			}
		}
		public async Task<IActionResult> LogOut()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Login", "Account");
		}
	}
}
