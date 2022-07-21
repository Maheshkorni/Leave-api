
using System;
using System.ComponentModel.DataAnnotations;

namespace LmsApi.Modals
{
    public class LeaveModal
    {
        public int leaveId { get; set; }

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
        public string status { get; set; }

        [Required]
        public string reason { get; set; }
        [Required]
        public string leaveType { get; set; }
    }
}
