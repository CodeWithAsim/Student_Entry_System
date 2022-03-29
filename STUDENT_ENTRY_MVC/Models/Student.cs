using System.ComponentModel.DataAnnotations;

namespace STUDENT_ENTRY_MVC.Models
{
    public class Student
    {
        [Required(ErrorMessage="Please enter the student name !")]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter the degree name !")]
        public string? Degree { get; set; }
        [Required(ErrorMessage = "Please enter the student's CGPA !")]
        [Range(1,4)]
        public string? CGPA { get; set; }
        [Required(ErrorMessage = "Please enter the semester name !")]
        [Range(1, 8)]
        public string? Semester { get; set; }

    }

}
