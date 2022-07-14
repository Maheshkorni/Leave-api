using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LmsApi.Repository
{
    public interface ILeave
    {
        public int ApplyLeave(LeaveDbModal leaveDbModal);

        public ActionResult<EmployeeDbModal> Employedetails(int id);

        public ActionResult<List<LeaveDbModal>> ShowLeavesById(int id);
    }
}
