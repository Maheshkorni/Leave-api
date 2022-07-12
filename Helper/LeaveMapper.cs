using AutoMapper;
using LmsApi.Modals;

namespace LmsApi.Helper
{
    public class LeaveMapper:Profile
    {
        public LeaveMapper()
        {
            CreateMap<LeaveDbModal, LeaveModal>().ReverseMap();
        }
    }
}
