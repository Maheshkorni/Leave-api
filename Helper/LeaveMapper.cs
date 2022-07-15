using AutoMapper;
using LmsApi.Modals;

namespace LmsApi.Helper
{
    public class LeaveMapper:Profile
    {
        public LeaveMapper()
        {
            CreateMap<EmployeeModal, EmployeeDbModal>().ReverseMap();
            CreateMap<LeaveDbModal, LeaveModal>().ReverseMap();
            CreateMap<EmployeeDbModal,ManagerModal>().ReverseMap();
            
        }
        
    }
}
