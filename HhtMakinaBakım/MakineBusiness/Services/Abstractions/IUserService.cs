using MakineEntity.DTOs.Users;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Identity;

namespace MakineBussines.Services.Abstractions
{
	public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersWithRoleAsync();
        Task<List<AppRole>> GetAllRolesAsync();
        Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto);
        Task<(IdentityResult identityResult, string? email)> DeleteUserAsync(string userId);
        Task<AppUser> GetAppUserByIdAsync(string userId);
        Task<string> GetUserRoleAsync(AppUser user);
        Task<UserProfileDto> GetUserProfileAsync();
        Task<bool> UserProfileUpdateAsync(UserProfileDto userProfileDto);
    }
}
