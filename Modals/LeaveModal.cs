
using System;
using System.ComponentModel.DataAnnotations;

namespace LmsApi.Modals
{
    public class LeaveModal
    {
       
        [Required]
        public int employeeId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime endDate { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime appliedDate { get; set; }

        [Required]
        public string reason { get; set; }
        [Required]
        public string leaveType { get; set; }
    }
}
