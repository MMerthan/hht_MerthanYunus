using MakineData.Repositories.Abstractions;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace MakinePresentation.Controllers
{
	[AllowAnonymous]
	public class RoutineMaintenanceController : Controller
	{
		private readonly IGenericRepository<RoutineMaintenance> RoutineMaintenanceGenericRepository;
        public RoutineMaintenanceController(IGenericRepository<RoutineMaintenance> RoutineMaintenanceGenericRepository)
        {
			this.RoutineMaintenanceGenericRepository = RoutineMaintenanceGenericRepository;
        }

        public async Task<IActionResult> Index()
		{
			var Routine = await RoutineMaintenanceGenericRepository.GetAllAsync(
				includeProperties: new Expression<Func<RoutineMaintenance, object>>[] 
				{
					RoutineMaintenance => RoutineMaintenance.Asset,
					RoutineMaintenance => RoutineMaintenance.Asset.AssetDepartment,
					RoutineMaintenance => RoutineMaintenance.RoutineMaintenanceDetail
				});

			return View(Routine);
		}
		public async Task<IActionResult> RoutineMaintenanceUpdate(int id)
		{
			var routine = await RoutineMaintenanceGenericRepository.GetByIdAsync(id);
			return View(routine);
		}
		[HttpPost]
		public async Task<IActionResult> RoutineMaintenanceUpdate()
		{
			var routine = RoutineMaintenanceGenericRepository;
			return View(routine);
		}
		public async Task<IActionResult> RoutineMaintenanceCreate()
		{
			return View();
		}
	}
}
