using MakineData.Context;
using MakineData.Repositories.Abstractions;
using MakineData.Repositories.Concretes;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakinePresentation.Controllers
{
    [AllowAnonymous]
	public class HomeController : Controller
    {
        private readonly IGenericRepository<WorkOrders> workOrdersGenericRepository;
        public HomeController(IGenericRepository<WorkOrders> workOrdersGenericRepository)
        {
            this.workOrdersGenericRepository = workOrdersGenericRepository;
        }

        public async Task<IActionResult> Index()
        {
            var workOrders = await workOrdersGenericRepository.GetAllAsync();
            return View(workOrders);
        }
    }
}
