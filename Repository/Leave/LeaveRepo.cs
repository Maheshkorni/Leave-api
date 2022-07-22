using AutoMapper;
using LmsApi.DataAccessLayer_;
using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LmsApi.Repository.Leave
{
    public class LeaveRepo : ILeave
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        private readonly IMapper mapper;
        public LeaveRepo(DataAccessLayer_LMS dataAccessLayer_LMS,IMapper mapper)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
            this.mapper = mapper;
        }
        public int ApplyLeave(LeaveDbModal leaveDbModal)
        {
            if (leaveDbModal != null)
            {
                var b = dataAccessLayer_LMS.Employee_table.Where(x=>x.EmployeeId == leaveDbModal.EmployeeId).First();
                leaveDbModal.ManagerId = b.ManagerId;
                dataAccessLayer_LMS.Leave_Table.Add(leaveDbModal);
                dataAccessLayer_LMS.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

       

        public ActionResult<List<LeaveModal>> ShowLeavesById(int id)
        {
            var c = dataAccessLayer_LMS.Leave_Table.Where(x => x.EmployeeId == id).ToList();
            return mapper.Map<List<LeaveModal>>(c);

        }


    }
}
