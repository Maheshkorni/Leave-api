using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LmsApi.Modals
{
    public class EmployeeDbModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public long PhoneNumber { get; set; }

        public DateTime DateJoined { get; set; }

        public string Department { get; set; }


        public int LeaveBalance { get; set; }

        public int ManagerId { get; set; }

        public string Password { get; set; }

    }
}
