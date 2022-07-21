using AutoMapper;
using LmsApi.Modals;
using LmsApi.Repository.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee employee;
        private readonly IMapper mapper;
        public EmployeeController(IEmployee employee,IMapper mapper)
        {
            this.employee = employee;
            this.mapper = mapper;
            
        }
        [HttpGet("/EmployeeDetails/{id}")]
        public ActionResult<EmployeeModal> EmployeeDetails(int id)
        {

            var c = employee.Employedetails(id);
            if (c != null)
            {

                return (c);
            }
            else
            {
                return Ok("Invalid EmployeeId");
            }
        }
        [HttpGet("/ShowAllEmployees")]
        public ActionResult<List<EmployeeModal>> ShowAllEmployees()
        {
           return employee.ShowAllEmployee();
        }
    }
}
