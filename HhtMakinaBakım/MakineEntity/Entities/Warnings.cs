using MakineCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineEntity.Entities
{
    public class Warnings : EntityBase
    {
        public string? Description { get; set; }
        public int RoutineMaintenanceId { get; set; }
        public int WorkOrdersId { get; set; }
        public RoutineMaintenance? RoutineMaintenance { get; set; }
        public WorkOrders? WorkOrders { get; set; }
    }
}
