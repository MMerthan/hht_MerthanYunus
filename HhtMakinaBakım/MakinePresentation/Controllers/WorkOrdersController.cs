using MakineData.Context;
using MakineData.Repositories.Abstractions;
using MakineEntity.DTOs.Assets;
using MakineEntity.DTOs.WorkOrder;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MakinePresentation.Controllers
{
	[AllowAnonymous]
	public class WorkOrdersController : Controller
	{
		private readonly IGenericRepository<WorkOrders> WorkOrdersGenericRepository;
		private readonly IGenericRepository<AppUser> AppUserGenericRepository;
		private readonly AppDbContext appDbContext;

		public WorkOrdersController(IGenericRepository<WorkOrders> workOrdersGenericRepository, IGenericRepository<AppUser> AppUserGenericRepository, AppDbContext appDbContext)
		{
			this.WorkOrdersGenericRepository = workOrdersGenericRepository;
			this.AppUserGenericRepository = AppUserGenericRepository;
			this.appDbContext = appDbContext;
		}

		public async Task<IActionResult> Index()
		{
			var workOrders = await WorkOrdersGenericRepository.GetAllAsync(includeProperties:x=>x.AppUser);
			return View(workOrders);
		}
        public async Task<ActionResult> WorkOrdersUpdate(int id)
        {
           

            var viewModel = new WorkOrdersUpdateDto
			{
                workOrders = await WorkOrdersGenericRepository.GetByIdAsync(id)
            };
			return View(viewModel);
        }
        [HttpPost]
        public async Task<ActionResult> WorkOrdersUpdate(WorkOrders workOrders)
		{
			var _workOrders = await WorkOrdersGenericRepository.GetByIdAsync(workOrders.Id);
			_workOrders.Description = workOrders.Description;
			_workOrders.IsDeleted = workOrders.IsDeleted;
			_workOrders.AppUserId = workOrders.AppUserId;
			_workOrders.EndTime = workOrders.EndTime;
			await WorkOrdersGenericRepository.UpdateAsync(_workOrders);
			return RedirectToAction("Index","WorkOrders");
		}
		public async Task<IActionResult> WorkOrdersCreate()
		{
			var personal = await AppUserGenericRepository.GetAllAsync();
			return View(personal);
		}
		[HttpPost]
		public async Task<IActionResult> WorkOrdersCreate(WorkOrders workOrders)
		{
			await WorkOrdersGenericRepository.AddAsync(workOrders);
			return RedirectToAction("Index", "WorkOrders");
		}
        public async Task<IActionResult> Delete(int id)
        {
            var workOrders = await WorkOrdersGenericRepository.GetByIdAsync(id);
            await WorkOrdersGenericRepository.DeleteAsync(workOrders);
            return Json(new { success = true }); // JSON olarak başarılı sonucu döndür
        }

    }

}
