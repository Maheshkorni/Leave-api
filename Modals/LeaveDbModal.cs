using System;
using System.ComponentModel.DataAnnotations;

namespace LmsApi.Modals
{
    public class LeaveDbModal
    {
        [Key]
        public int leaveId { get; set; }
        public int employeeId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        //public int Count{get; set;}
        public string status { get; set; }
        public string reason { get; set; }
        public string leaveType { get; set; }
        public string managerComments { get; set; }
        public DateTime appliedDate { get; set; }

    }
}
