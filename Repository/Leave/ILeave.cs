using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LmsApi.Repository.Leave
{
    public interface ILeave
    {
        public int ApplyLeave(LeaveDbModal leaveDbModal);

        

        public ActionResult<List<LeaveModal>> ShowLeavesById(int id);
    }
}
