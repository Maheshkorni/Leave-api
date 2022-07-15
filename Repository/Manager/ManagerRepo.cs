using AutoMapper;
using LmsApi.DataAccessLayer_;
using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LmsApi.Repository.Manager
{
    public class ManagerRepo : IManager
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        private readonly IMapper mapper;
        public ManagerRepo(DataAccessLayer_LMS dataAccessLayer_LMS, IMapper mapper)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
            this.mapper = mapper;
        }

        public ActionResult<ManagerModal> ShowDetails(int id)
        {
            var c=dataAccessLayer_LMS.Employee_table.Where(x=>x.EmployeeId==id).FirstOrDefault();
            var d= dataAccessLayer_LMS.Employee_table.Where(x=> x.EmployeeId==c.ManagerId).FirstOrDefault();
            return mapper.Map<ManagerModal>(d);
        }

        public ActionResult<List<LeaveModal>> ShowLeavesById(int id)
        {
            
                var c = dataAccessLayer_LMS.Leave_Table.Where(x => x.ManagerId == id).ToList();
                return mapper.Map<List<LeaveModal>>(c);

            
        }
    }
}
