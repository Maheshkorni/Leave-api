using LmsApi.Modals;
using LmsApi.Repository.Crud;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        private readonly ICrud crud;
        public CrudController(ICrud crud)
        {
            this.crud = crud;
        }
        [HttpPost()]
        public int Login(LoginModal login)
        {
            return crud.Login(login);   
        }
        [HttpPost("/status")]
        public ActionResult Action(StatusModal approvedeny)
        {
            int b = crud.ApproveDeny(approvedeny);
            if(b==0)
            {
                return Ok("Leave Not Found");
            }
            else if(b==1)
            {
                return Ok("Approved");
            }
            else
            {
                return Ok("Denied");
            }
        }

    }
}
