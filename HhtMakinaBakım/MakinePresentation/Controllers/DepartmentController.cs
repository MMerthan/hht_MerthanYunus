using MakineData.Repositories.Abstractions;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MakinePresentation.Controllers
{
	[AllowAnonymous]
	public class DepartmentController : Controller
	{
		private readonly IGenericRepository<Department> genericRepository;
		public DepartmentController(IGenericRepository<Department> genericRepository)
		{
			this.genericRepository = genericRepository;
		}
		[HttpGet]
		public async Task<IActionResult> AddDepartment()
		{
			var departments = await genericRepository.GetAllAsync();
			return View(departments);

		}
		[HttpPost]
		public async Task<IActionResult> AddDepartment(Department department)
		{
			await genericRepository.AddAsync(department = new Department
			{
				Name = department.Name,
				IsDeleted = department.IsDeleted
			});
			return RedirectToAction("AddDepartment", "Department");
		}
		[HttpGet]
		public async Task<IActionResult> Delete(int Id)
		{
			var department = await genericRepository.GetByIdAsync(Id);
			await genericRepository.DeleteAsync(department);
			return RedirectToAction("AddDepartment", "Department");
		}
		[HttpPost]
		public async Task<IActionResult> EditDepartment(int id, string editedDepartmentName, bool isDeleted)
		{
			var DepartmentToUpdate = await genericRepository.GetByIdAsync(id);
			if (DepartmentToUpdate != null)
			{
				DepartmentToUpdate.Name = editedDepartmentName;
				DepartmentToUpdate.IsDeleted = isDeleted;

				await genericRepository.UpdateAsync(DepartmentToUpdate);
			}

			return RedirectToAction("AddDepartment", "Department");
		}
	}
}
