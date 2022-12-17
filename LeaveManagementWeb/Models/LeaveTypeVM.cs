using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name ="Name Of Leave Type")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number of Days")]
        [Range(1,100,ErrorMessage ="Please enter a valid number")]
        public int DefaultDays { get; set; }
    }
}
