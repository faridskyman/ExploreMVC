﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exploreMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}