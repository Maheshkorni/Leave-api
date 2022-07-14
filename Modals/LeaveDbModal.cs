using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LmsApi.Modals
{
    public class LeaveDbModal
    {
        [Key]
      
        public int leaveId { get; set; }
        
        
       // public int EmployeeId { get; set; }

        
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        //public int Count{get; set;}
        public string status { get; set; }
        public string reason { get; set; }
        public string leaveType { get; set; }
        public string managerComments { get; set; }
        public DateTime appliedDate { get; set; }

        public int ManagerId { get; set; }
        public int? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual EmployeeDbModal Employee { get; set; }

    }
}
