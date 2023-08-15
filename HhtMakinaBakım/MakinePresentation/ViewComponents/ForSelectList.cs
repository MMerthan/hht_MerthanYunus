using MakineData.Repositories.Abstractions;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MakinePresentation.ViewComponents
{
    public class ForSelectList : ViewComponent
    {
        private readonly IGenericRepository<AppUser> genericRepository;
        public ForSelectList(IGenericRepository<AppUser> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var personel = await genericRepository.GetAllAsync();
            return View(personel);

        }
    }
}
