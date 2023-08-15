using AutoMapper;
using MakineData.Context;
using MakineData.Repositories.Abstractions;
using MakineEntity.DTOs.Assets;
using MakineEntity.DTOs.Users;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static MakinePresentation.ResultMessages.Messages;

namespace MakinePresentation.Controllers
{
	[AllowAnonymous]
	public class AssetController : Controller
	{
		private readonly IGenericRepository<Asset> AssetgenericRepository;
		private readonly IGenericRepository<Department> DepartmentRepository;
		private readonly IGenericRepository<Image> ImageGenericRepository;
		private readonly IGenericRepository<AssetCategory> AssetCategoryRepository;
		private readonly IMapper mapper;
		private readonly AppDbContext dbContext;

		public AssetController( IGenericRepository<Asset> AssetgenericRepository,IMapper mapper, IGenericRepository<Department> DepartmentRepository, IGenericRepository<Image> ImageGenericRepository, IGenericRepository<AssetCategory> AssetCategoryRepository,AppDbContext dbContext)
		{
			this.AssetgenericRepository = AssetgenericRepository;
			this.mapper = mapper;
			this.DepartmentRepository = DepartmentRepository;
			this.ImageGenericRepository = ImageGenericRepository;
			this.AssetCategoryRepository = AssetCategoryRepository;
			this.dbContext = dbContext;
		}
		public async Task<IActionResult> Create()
		{
			var viewModel = new AssetAddDto
			{
				Departments = await dbContext.Departments.ToListAsync(),
				AssetCategories = await dbContext.AssetCategories.ToListAsync(),

			};
			return View(viewModel);

		}
		[HttpPost]
		public async Task<IActionResult> Create(AssetAddDto model)
		{
			if (!ModelState.IsValid)
			{
				var viewModel = new AssetAddDto
				{
					Departments = await dbContext.Departments.ToListAsync(),
					AssetCategories = await dbContext.AssetCategories.ToListAsync(),
				};

				return View(viewModel);
			}

			if (model.Image != null)
			{
				var uzanti = Path.GetExtension(model.Image.FileName);
				var yeniResimAd = Guid.NewGuid() + uzanti;
				var yuklenecekYer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + yeniResimAd);

				using (var stream = new FileStream(yuklenecekYer, FileMode.Create))
				{
					await model.Image.CopyToAsync(stream);
				}

				var yeniResim = new Image
				{
					Name = yeniResimAd,
					FileType = uzanti,
					ImagePath = yuklenecekYer,
					IsDeleted = false
				};

				await ImageGenericRepository.AddAsync(yeniResim);
				model.Asset.ImageId = yeniResim.Id;
			}
			else
			{
				model.Asset.ImageId = 1;
			}

			var asset = model.Asset;

			await AssetgenericRepository.AddAsync(asset);

			return RedirectToAction("List", "Asset");
		}

        public async Task<IActionResult> List()
        {
            var assetList = await AssetgenericRepository.GetAllAsync(
                includeProperties: new Expression<Func<Asset, object>>[] { asset => asset.AssetCategory, asset => asset.AssetDepartment,asset => asset.Image });

            return View(assetList);
        }
        public async Task<string> GetImage(int id)
        {
            var asset = await AssetgenericRepository.GetByIdAsync(id);
            if (asset?.ImageId != null)
            {
                var image = await ImageGenericRepository.GetByIdAsync(asset.ImageId.Value);
                if (image != null)
                {
                    var imagePath = Path.Combine(image.Name);
                    return "/img/"+imagePath;
                }
            }

            return "";
        }
		public async Task<IActionResult> Edit(int id)
		{
			var viewModel = new AssetAddDto
			{
				Departments = await dbContext.Departments.ToListAsync(),
				AssetCategories = await dbContext.AssetCategories.ToListAsync(),
				Asset = dbContext.Assets.Where(c=>c.Id == id).First()
			};
			return View(viewModel);
		}
		[HttpPost]
        public async Task<IActionResult> Edit(AssetDto assetDto)
        {
            var Asset = await AssetgenericRepository.GetByIdAsync(assetDto.Id);
            Asset.Name = assetDto.Name;
            Asset.AssetCategoryId = assetDto.AssetCategoryId;
			Asset.AssetDepartmentId = assetDto.AssetDepartmentId;
			Asset.Description = assetDto.Description;
			Asset.IsDeleted = assetDto.IsDeleted;
			await AssetgenericRepository.UpdateAsync(Asset);
            return RedirectToAction("List","Asset");
        }
		public async Task<IActionResult> Delete(int id)
		{
			var asset = await AssetgenericRepository.GetByIdAsync(id);
			await AssetgenericRepository.DeleteAsync(asset);
			return RedirectToAction("List", "Asset");
		}

    }
}
