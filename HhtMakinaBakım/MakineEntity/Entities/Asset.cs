using MakineCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineEntity.Entities
{
    public class Asset : EntityBase
    {
        
        public string Description { get; set; }
        public int AssetCategoryId { get; set; }
        public int AssetDepartmentId { get; set; }
        public int? ImageId { get; set; }
        public AssetCategory AssetCategory { get; set; }
        public Department AssetDepartment { get; set; }
        public Image? Image { get; set; }
    }
}
