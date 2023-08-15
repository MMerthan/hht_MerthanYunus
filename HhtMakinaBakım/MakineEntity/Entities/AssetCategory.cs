﻿using MakineCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineEntity.Entities
{
    public class AssetCategory : EntityBase
    {
        public ICollection<Asset> Assets { get; set; }
    }
}
