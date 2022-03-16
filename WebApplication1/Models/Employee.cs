using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Employee
    {

        [Key]
        public string? Emp_ID { get; set; }
        public string? Emp_Name { get; set; }
        public string? Designation { get; set; }
        public string? Location { get; set; }
        public DateTime Doj { get; set; }
        public DateTime Lwd { get; set; }
       public string? Vertical_L2 { get; set; }
        public string? Email_ID { get; set; }
        public string? Rm_Emp_ID { get; set; }
        public string? Band { get; set; }
        public string? Level { get; set; }



    }
}
