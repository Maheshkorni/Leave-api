using AutoMapper;
using LmsApi.Modals;

namespace LmsApi.Helper
{
    public class LeaveMapper:Profile
    {
        public LeaveMapper()
        {
            CreateMap<EmployeeDbModal, EmployeeModal>().ReverseMap();
            CreateMap<LeaveDbModal, LeaveModal>().ReverseMap();
            
        }
        
    }
}
