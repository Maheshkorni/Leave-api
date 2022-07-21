using LmsApi.DataAccessLayer_;
using LmsApi.Modals;
using LmsApi.Repository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManager manager;
        private readonly DataAccessLayer_LMS dataAccessLayer_Lms;
        public ManagerController(IManager manager, DataAccessLayer_LMS dataAccessLayer_Lms)
        {
            this.manager = manager;
            this.dataAccessLayer_Lms = dataAccessLayer_Lms;
        }
        [HttpGet("Showleaves/{id}")]
        public ActionResult<List<LeaveModal>> ShowLeavesById(int id)
        {
            var c = dataAccessLayer_Lms.Employee_table.Where(x => x.ManagerId == id).ToList();
            var b= manager.ShowLeavesById(id);
            if(b!=null && c.Count()>0)
            { return b; }
            else if(c.Count()==0){ return Ok("Not a manager"); }
            
            else { return Ok("No Leaves Found"); }
                
           
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
