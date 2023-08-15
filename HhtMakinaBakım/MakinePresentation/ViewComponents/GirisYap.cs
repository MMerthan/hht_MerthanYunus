using MakineBussines.Services.Abstractions;
using MakineBussines.Services.concretes;
using Microsoft.AspNetCore.Mvc;

namespace hhtMerthan.ViewComponents
{
    public class GirisYap : ViewComponent
    {
        private readonly IUserService _userService;
        public GirisYap(IUserService _userService)
        {
            this._userService = _userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userService.GetUserProfileAsync();
            return View(user);
            
        }
    }
}
