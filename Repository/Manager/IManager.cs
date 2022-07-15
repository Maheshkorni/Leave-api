using LmsApi.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LmsApi.Repository.Manager
{
    public interface IManager
    {
        public ActionResult<List<LeaveModal>> ShowLeavesById(int id);

        public ActionResult<ManagerModal> ShowDetails(int id);
    }
}
