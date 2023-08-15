using AutoMapper;
using MakineEntity.DTOs.Users;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Mvc;
using MakineBussines.Services.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using MakineBussines.Helpers.Images;
using MakineData.Repositories.Abstractions;
using MakineData.Context;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MakinePresentation.ResultMessages.Messages;
using Microsoft.AspNetCore.Authorization;

namespace MakinePresentation.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{
		private readonly IUserService userService;
		private readonly IMapper mapper;
		private readonly RoleManager<AppRole> roleManager;
		private readonly UserManager<AppUser> _userManager;
		private readonly IImageHelper imageHelper;
		private readonly IGenericRepository<Image> genericRepository;
		private readonly IGenericRepository<AppUser> AppUsergenericRepository;

		AppUser appUser;
		AppDbContext dbContext;

		public RegisterController(IUserService userService, IMapper mapper, RoleManager<AppRole> _roleManager,
			UserManager<AppUser> _userManager, IImageHelper imageHelper, IGenericRepository<Image> genericRepository,IGenericRepository<AppUser> AppUsergenericRepository)
		{
			this.userService = userService;
			this.mapper = mapper;
			this.roleManager = _roleManager;
			this._userManager = _userManager;
			this.imageHelper = imageHelper;
			this.genericRepository = genericRepository;
			this.AppUsergenericRepository = AppUsergenericRepository;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			List<UserAddDto> userList = new List<UserAddDto>();

			foreach (var role in roleManager.Roles)
			{
				userList.Add(new UserAddDto { Role = role.Name });
			}

			return View(userList);
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserAddDto model, string role)
		{
			if (ModelState.IsValid)
			{
				var user = new AppUser
				{
					FirstName = model.FirstName,
					Email = model.Email,
					PhoneNumber = model.PhoneNumber,
					LastName = model.LastName,
					UserName = model.Email,
				};

				var result = await _userManager.CreateAsync(user, model.Password);

				if (result.Succeeded)
				{
					await _userManager.AddToRoleAsync(user, role);
                    return RedirectToAction("ImageUpload", "Register", new { Id = user.Id });
                }
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
			}

			
			List<SelectListItem> roles = roleManager.Roles.Select(role => new SelectListItem
			{
				Value = role.Name,
				Text = role.Name
			}).ToList();

			ViewBag.Roles = roles;

			return View(model);
		}
		public async Task<IActionResult> ImageUpload(string Id)
		{
            var user = await AppUsergenericRepository.GetByIdAsync(Id);
            return View(user);
		}
		[HttpPost]
		public async Task<IActionResult> ImageUpload(UserAddDto model,string Id)
		{
            var user = await AppUsergenericRepository.GetByIdAsync(Id);
            if (model.ProfileImage != null)
			{
				var uzanti = Path.GetExtension(model.ProfileImage.FileName);
				var yeniResimAd = Guid.NewGuid() + uzanti;
				var yuklenecekYer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + yeniResimAd);

				using (var stream = new FileStream(yuklenecekYer, FileMode.Create))
				{
					await model.ProfileImage.CopyToAsync(stream);
				}

				// Resmi veritabanına ekleyin ve kaydedilen resmin ID'sini alın
				var yeniResim = new Image
				{
					Name = yeniResimAd,
					FileType = uzanti,
					ImagePath = yuklenecekYer,
					IsDeleted = false
					
				};
				

				// Yeni resmi veritabanına ekleyin (örneğin, genericRepository.AddAsync)
				await genericRepository.AddAsync(yeniResim);
                
                if (model.ProfileImage == null)
                
                user.ImageId = yeniResim.Id; // Burada Id, veritabanında oluşturulan resmin benzersiz kimliğini temsil eder

                // Kullanıcıyı güncelleyin (örneğin, userRepository.Update)
                
                await AppUsergenericRepository.UpdateAsync(user);
			}
           
            return RedirectToAction("Index","register");
		}
	}
}
