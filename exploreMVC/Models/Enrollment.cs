using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exploreMVC.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; } // foreign key
        public int StudentID { get; set; } //foreign key to student table
        public Grade? Grade { get; set; } //? means its nullable

        public virtual Course Course { get; set; } //
        public virtual Student Student { get; set; }
    }
}