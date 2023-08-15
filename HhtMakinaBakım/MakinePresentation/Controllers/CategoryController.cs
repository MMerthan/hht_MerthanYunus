using MakineData.Repositories.Abstractions;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MakinePresentation.Controllers
{
	[AllowAnonymous]
	public class CategoryController : Controller
	{
		private readonly IGenericRepository<AssetCategory> genericRepository;
		public CategoryController(IGenericRepository<AssetCategory> genericRepository)
		{
			this.genericRepository = genericRepository;
		}
		[HttpGet]
		public async Task<IActionResult> AddCategory()
		{
			var Categories = await genericRepository.GetAllAsync();
			return View(Categories);

		}
		[HttpPost]
		public async Task<IActionResult> AddCategory(AssetCategory assetCategory)
		{
			await genericRepository.AddAsync(assetCategory = new AssetCategory
			{
				Name = assetCategory.Name,
				IsDeleted = assetCategory.IsDeleted
			});
			return RedirectToAction("AddCategory", "Category");
		}
		[HttpGet]
		public async Task<IActionResult> Delete(int Id)
		{
			var Category = await genericRepository.GetByIdAsync(Id);
			await genericRepository.DeleteAsync(Category);
			return RedirectToAction("AddCategory", "Category");
		}
		[HttpPost]
		public async Task<IActionResult> EditCategory(int id, string editedCategoryName, bool isDeleted)
		{
			var categoryToUpdate = await genericRepository.GetByIdAsync(id);
			if (categoryToUpdate != null)
			{
				categoryToUpdate.Name = editedCategoryName;
				categoryToUpdate.IsDeleted = isDeleted;

				await genericRepository.UpdateAsync(categoryToUpdate); // varsayılan olarak async/await kullanmayı tercih ediyorsanız
			}

			return RedirectToAction("AddCategory", "Category");
		}
	}
}

