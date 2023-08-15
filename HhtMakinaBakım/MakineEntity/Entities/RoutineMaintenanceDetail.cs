using MakineCore.CoreEntities;

namespace MakineEntity.Entities
{
    public class RoutineMaintenanceDetail : EntityBase
    {
     
        public DateTime MaintenanceDate { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        
      
    }
}

