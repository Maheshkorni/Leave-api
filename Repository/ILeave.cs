using LmsApi.Modals;
namespace LmsApi.Repository
{
    public interface ILeave
    {
        public int ApplyLeave(LeaveDbModal leaveDbModal);
    }
}
