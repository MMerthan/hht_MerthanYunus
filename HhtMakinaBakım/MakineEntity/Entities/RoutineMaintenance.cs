using MakineCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineEntity.Entities
{
    public class RoutineMaintenance : EntityBase
    {
        public DateTime MaintenanceTime { get; set; }
        public string Description { get; set; }
        public int HowManyTimes { get; set; }
        public int Loop { get; set; }
        public string TimeName { get; set; }
        public int AssetId { get; set; }
		public Asset Asset { get; set; }
        public int RoutineMaintenanceDetailsId { get; set; }
        public RoutineMaintenanceDetail? RoutineMaintenanceDetail { get; set; }
	}
}

