using System;
using System.ComponentModel.DataAnnotations;

namespace LmsApi.Modals
{
    public class EmployeeModal
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]

        public string FullName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]

        public long PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int LeaveBalance { get; set; }
        public int CasualLeaves { get; set; } 
        public int EarnedLeaves { get; set; } 
        public int MaternityLeaves { get; set; } 

    }

}
