using LmsApi.DataAccessLayer_;
using LmsApi.Modals;

namespace LmsApi.Repository
{
    public class LeaveRepo : ILeave
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        public LeaveRepo(DataAccessLayer_LMS dataAccessLayer_LMS)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
        }
        public int ApplyLeave(LeaveDbModal leaveDbModal)
        {
            if(leaveDbModal!=null)
            {
                dataAccessLayer_LMS.Add(leaveDbModal);
                dataAccessLayer_LMS.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
