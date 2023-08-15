using AutoMapper;
using MakineBussines.Extensions;
using MakineBussines.Helpers.Images;
using MakineEntity.DTOs.Users;
using MakineEntity.Entities;
using MakineEntity.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using MakineData.Repositories.Abstractions;
using MakineBussines.Services.Abstractions;

namespace MakineBussines.Services.concretes
{
	public class UserService : IUserService
	{
		private readonly IHttpContextAccessor httpContextAccessor;
		private readonly IMapper mapper;
		private readonly IImageHelper imageHelper;
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManager;
		private readonly RoleManager<AppRole> roleManager;
		private readonly ClaimsPrincipal _user;
		private readonly IGenericRepository<Image> genericRepository;

		public UserService(IHttpContextAccessor httpContextAccessor, IMapper mapper, IImageHelper imageHelper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager,IGenericRepository<Image> genericRepository)
		{
			this.httpContextAccessor = httpContextAccessor;
			_user = httpContextAccessor.HttpContext.User;
			this.mapper = mapper;
			this.imageHelper = imageHelper;
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.roleManager = roleManager;
			this.genericRepository = genericRepository;
		}


		public async Task<List<AppRole>> GetAllRolesAsync()
		{
			return await roleManager.Roles.ToListAsync();
		}

		public async Task<List<UserDto>> GetAllUsersWithRoleAsync()
		{
			var users = await userManager.Users.ToListAsync();
			var map = mapper.Map<List<UserDto>>(users);

			foreach (var item in map)
			{
				var findUser = await userManager.FindByIdAsync(item.Id.ToString());
				var role = string.Join("", await userManager.GetRolesAsync(findUser));
				item.Role = role;
			}

			return map;
		}

		public async Task<string> GetUserRoleAsync(AppUser user)
		{
			return string.Join("", await userManager.GetRolesAsync(user));
		}

		public async Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto)
		{
			var user = await GetAppUserByIdAsync(userUpdateDto.Id);
			user.FirstName = userUpdateDto.FirstName;
			user.LastName = userUpdateDto.LastName;
			user.PhoneNumber = userUpdateDto.PhoneNumber;
			user.Email = userUpdateDto.Email;

			var role = await GetUserRoleAsync(user);

			var result = await userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				await userManager.RemoveFromRoleAsync(user, role);
				var findRole = await roleManager.FindByIdAsync(userUpdateDto.role.ToString());
				await userManager.AddToRoleAsync(user, findRole.Name);
			}
			return result;
		}

		public async Task<UserProfileDto> GetUserProfileAsync()
		{
			var userId = _user.GetLoggedInUserId();

			// Eğer userId null veya boş ise, kullanıcı oturum açmamış demektir.
			// Bu durumda boş bir UserProfileDto nesnesi döndürebiliriz.
			if (string.IsNullOrEmpty(userId))
			{
				return new UserProfileDto();
			}

			var getUserWithImage = await userManager.Users.Include(x => x.Image).FirstOrDefaultAsync(x => x.Id == userId);

			// Eğer getUserWithImage null ise, verilen userId ile eşleşen kullanıcı bulunamamıştır.
			// Bu durumda yine boş bir UserProfileDto nesnesi döndürebiliriz.
			if (getUserWithImage == null)
			{
				
				return new UserProfileDto();
			}

			var map = mapper.Map<UserProfileDto>(getUserWithImage);
            
            // Kullanıcının resmi varsa, resmin dosya adını UserProfileDto nesnesine ekleyelim.
            if (getUserWithImage.Image?.Name != null)
			{
				map.Image.Name = getUserWithImage.Image.Name;
			}
           

            return map;
		}

		public async Task<bool> UserProfileUpdateAsync(UserProfileDto userProfileDto)
		{
			var userId = _user.GetLoggedInUserId();
			var user = await GetAppUserByIdAsync(userId);
			var isVerified = await userManager.CheckPasswordAsync(user, userProfileDto.CurrentPassword);

			if (isVerified && userProfileDto.NewPassword != null)
			{
				var result = await userManager.ChangePasswordAsync(user, userProfileDto.CurrentPassword, userProfileDto.NewPassword);
				if (result.Succeeded)
				{
					await userManager.UpdateSecurityStampAsync(user);
					await signInManager.SignOutAsync();
					await signInManager.PasswordSignInAsync(user, userProfileDto.NewPassword, true, false);

					mapper.Map(userProfileDto, user);

			

					await userManager.UpdateAsync(user);
					return true;
				}
				else
					return false;
			}
			else if (isVerified)
			{
				await userManager.UpdateSecurityStampAsync(user);
				mapper.Map(userProfileDto, user);

			
					

				await userManager.UpdateAsync(user);
				return true;
			}
			else
				return false;
		}

		public async Task<(IdentityResult identityResult, string? email)> DeleteUserAsync(string userId)
		{
			var user = await GetAppUserByIdAsync(userId);
			var result = await userManager.DeleteAsync(user);
			if (result.Succeeded)
				return (result, user.Email);
			else
				return (result, null);


			
		}
		

		public async Task<AppUser> GetAppUserByIdAsync(string userId)
		{
			return await userManager.FindByIdAsync(userId);
		}
	}
}