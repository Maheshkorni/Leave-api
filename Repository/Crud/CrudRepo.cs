﻿using AutoMapper;
using LmsApi.DataAccessLayer_;
using LmsApi.Modals;
using System.Linq;

namespace LmsApi.Repository.Crud
{
    public class CrudRepo : ICrud
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        private readonly IMapper mapper;
        public CrudRepo(DataAccessLayer_LMS dataAccessLayer_LMS, IMapper mapper)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
            this.mapper = mapper;
        }

        public int ApproveDeny(StatusModal status)
        {
            var b= dataAccessLayer_LMS.Leave_Table.Where(x=>x.leaveId==status.Leaveid).First();
            if(b!=null && b.leaveId==status.Leaveid && status.status=="APPROVED")
            {
                b.status = "APPROVED";
                b.managerComments = status.managerComments;
                dataAccessLayer_LMS.Leave_Table.Update(b);
                dataAccessLayer_LMS.SaveChanges();
                return 1;
            }
            else if (b!=null && b.leaveId==status.Leaveid && status.status=="DENIED")
            {
                b.status = "DENIED";
                b.managerComments = status.managerComments;
                dataAccessLayer_LMS.Leave_Table.Update(b);
                dataAccessLayer_LMS.SaveChanges();
                return 2;
            }
            else
            {
                return 0;
            }

        }

        public int Login(LoginModal login)
        {
           var b= dataAccessLayer_LMS.Employee_table.Where(x => x.EmployeeId == login.EmployeeId).FirstOrDefault();
            if(b!=null && b.EmployeeId == login.EmployeeId && b.Password==login.Password)
            {
                return 1;
            }
            else { return 0; }
        }
    }
}
