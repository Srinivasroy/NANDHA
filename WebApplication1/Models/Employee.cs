using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Employee
    {

        [Key]
        [Required]
        [Display(Name = "Employee ID")]
        public string? Emp_ID { get; set; }


        [Required(ErrorMessage = "Name Required")]
        [Display(Name = "Employee Name")]
        public string? Emp_Name { get; set; }


        [Required]
        public string? Designation { get; set; }
        [Required(ErrorMessage = "Location Required")]
        public string? Location { get; set; }


        [Required]
        [Display(Name = "Date of Joining")]
        public DateTime Doj { get; set; }


        
        [Display(Name = "Last Working Day")]
        public DateTime Lwd { get; set; }


        [Required]
        [Display(Name = "Vertical L2")]
        public string? Vertical_L2 { get; set; }



        [Required(ErrorMessage = "Email Required")]
        [Display(Name = "Email ID")]
        public string? Email_ID { get; set; }


        [Required]
        public string? Rm_Emp_ID { get; set; }


        [Required]
        public string? Band { get; set; }


        [Required]
        public string? Level { get; set; }


        [Required]
        public string? Role_ID { get; set; }

        public string? type { get; set; }


    }
}
