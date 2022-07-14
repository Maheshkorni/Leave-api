using LmsApi.DataAccessLayer_;
using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
                dataAccessLayer_LMS.Leave_Table.Add(leaveDbModal);
                dataAccessLayer_LMS.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public ActionResult<EmployeeDbModal> Employedetails(int id)
        {
            var b=dataAccessLayer_LMS.Employee_table.Where(x => x.EmployeeId == id).FirstOrDefault();
            if(b != null && b.EmployeeId==id  )
            {
                return b;
            }
            else
            {
                return null;
            }
            
        }

        public ActionResult<List<LeaveDbModal>> ShowLeavesById(int id)
        {
            var c= dataAccessLayer_LMS.Leave_Table.Where(x=> x.EmployeeId==id).ToList();
            return c;
            
        }
    }
}
