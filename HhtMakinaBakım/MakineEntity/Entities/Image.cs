using MakineCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineEntity.Entities
{
    public class Image : EntityBase
    {
      
        public string ImagePath { get; set; }

		
		public string FileType { get; set; }
    }
}
