using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudCrud.Model
{
    [Table("Stud")]
    public class Student
    {
        public int studentId { get; set; }
        [Required(ErrorMessage = "Student Name is required")]
        public string studName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Mobile Number is required"),MinLength(10),MaxLength(10)]  
        public string mobileNo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required"),EmailAddress]
        public string email { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string state { get; set; } = string.Empty;
        public string pincode { get; set; } = string.Empty;
        public string addressLine1 { get; set; } = string.Empty;
        public string addressLine2 { get; set; } = string.Empty;
        
    }
}
