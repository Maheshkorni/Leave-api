using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LmsApi.Modals;
using LmsApi.Helper;
using System.Collections.Generic;
using LmsApi.Repository.Leave;

namespace LmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ILeave leave;
        
        public LeaveController(IMapper mapper,ILeave leave)
        {
            this.leave=leave;
            this.mapper=mapper;
            
        }
        [HttpPost("/ApplyLeave")]
        public int ApplyLeave(LeaveModal leaveModal)
        {
            return leave.ApplyLeave(mapper.Map<LeaveDbModal>(leaveModal));
        }
        
        [HttpGet("Showleaves/{id}")]
        public ActionResult<List<LeaveModal>> ShowLeavesById(int id)
        {
           return leave.ShowLeavesById(id);
        }


    }
}
