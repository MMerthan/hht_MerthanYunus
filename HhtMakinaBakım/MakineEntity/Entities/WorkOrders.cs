using MakineCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineEntity.Entities
{
    public class WorkOrders : EntityBase
    {
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

    }
}
