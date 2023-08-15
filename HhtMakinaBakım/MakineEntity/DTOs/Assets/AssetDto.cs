using MakineEntity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineEntity.DTOs.Assets
{
    public class AssetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int AssetCategoryId { get; set; }
        public int AssetDepartmentId { get; set; }
        public int? ImageId { get; set; }
        public List<Department> Departments { get; set; }
        public List<AssetCategory> AssetCategories { get; set; }
        public IFormFile? Image { get; set; }
    }
}
