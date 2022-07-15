using System.ComponentModel.DataAnnotations;

namespace LmsApi.Modals
{
    public class ManagerModal
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
    }
}
