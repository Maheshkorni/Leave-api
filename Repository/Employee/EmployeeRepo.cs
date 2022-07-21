using LmsApi.DataAccessLayer_;
using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
//using System.Data.Entity;
using System.Collections.Generic;

namespace LmsApi.Repository.Employee
{
    public class EmployeeRepo:IEmployee
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        private readonly IMapper mapper;

        public EmployeeRepo(DataAccessLayer_LMS dataAccessLayer_LMS, IMapper mapper)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
            this.mapper = mapper;   
        }

        public ActionResult<EmployeeModal> Employedetails(int id)
        {
            var b = dataAccessLayer_LMS.Employee_table.FirstOrDefault(x => x.EmployeeId == id);
            if (b != null && b.EmployeeId == id)
            {
                return mapper.Map<EmployeeModal>(b);
            }
            else
            {
                return null;
            }

        }

        public ActionResult<List<EmployeeModal>> ShowAllEmployee()
        {
           return  mapper.Map<List<EmployeeModal>>(dataAccessLayer_LMS.Employee_table.ToList());
        }
    }
}
