using AutoMapper;
using MakineEntity.Entities;
using MakineEntity.DTOs.WorkOrder;
namespace MakineBusiness.AutoMapper.WorkOrder
{
    public class WorkOrdersProfile : Profile
    {
        public WorkOrdersProfile()
        {
            CreateMap<WorkOrders, WorkOrdersUpdateDto>().ReverseMap();
        }

    }
}
