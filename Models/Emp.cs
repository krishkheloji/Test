using System.ComponentModel.DataAnnotations;

namespace AprilBatchCoreProject.Models
{
    public class Emp
    {
        [Required(ErrorMessage ="id is Required")]
        public int id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(10,MinimumLength =5,ErrorMessage ="Length Should be between 5-10")]
        public string? name { get; set; }

        [Required(ErrorMessage = "Salary is Required")]
        [Range(0,1000,ErrorMessage ="Salary should be not more than 1000")]
        public double salary { get; set; }
    }
}
