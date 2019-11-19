using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Display(Name = "Student Last Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        
        public string LastName { get; set; }
        [Display(Name = "Student First Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Column("FirstName")]
        [Required]
        
        public string FirstName { get; set; }
        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString= "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name= "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

