using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LmsApi.Repository.Employee
{
    public interface IEmployee
    {
        public ActionResult<EmployeeModal> Employedetails(int id);
    }
}
