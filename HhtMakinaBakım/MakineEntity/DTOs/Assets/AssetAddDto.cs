using MakineEntity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineEntity.DTOs.Assets
{
    public class AssetAddDto
    {
        public Asset Asset { get; set; }
        public List<Department> Departments { get; set; }
        public List<AssetCategory> AssetCategories { get; set; }
        public IFormFile? Image { get; set; }

    }
}
