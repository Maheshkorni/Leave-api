using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LmsApi.Repository.Employee
{
    public interface IEmployee
    {
        public ActionResult<EmployeeModal> Employedetails(int id);

        public ActionResult<List<EmployeeModal>> ShowAllEmployee();
    }
}
