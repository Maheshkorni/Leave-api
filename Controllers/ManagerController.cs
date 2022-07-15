using LmsApi.Modals;
using LmsApi.Repository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManager manager;
        public ManagerController(IManager manager)
        {
            this.manager = manager;
        }
        [HttpGet("Showleaves/{id}")]
        public ActionResult<List<LeaveModal>> ShowLeavesById(int id)
        {
            return manager.ShowLeavesById(id);
        }
        [HttpGet("/ManagerDetails/{id}")]
        public ActionResult<ManagerModal> EmployeeDetails(int id)
        {

            var c = manager.ShowDetails(id);
            if (c != null)
            {

                return (c);
            }
            else
            {
                return Ok("Invalid EmployeeId or No Manager Found");
            }
        }
    }


}
