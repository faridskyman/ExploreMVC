using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using exploreMVC.Models;

namespace exploreMVC.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student
                {
                    FirstName="Ibrahim",
                    LastName="Bin Farid",
                    EnrollmentDate=DateTime.Parse("2012-06-22")
                },
                  new Student
                {
                    FirstName="Insyirah",
                    LastName="Binte Farid",
                    EnrollmentDate=DateTime.Parse("2014-07-20")
                },
                    new Student
                {
                    FirstName="Nur Ruzana",
                    LastName="Binte Farid",
                    EnrollmentDate=DateTime.Parse("2006-05-07")
                },
                      new Student
                {
                    FirstName="Shafura",
                    LastName="Binte Kassim",
                    EnrollmentDate=DateTime.Parse("2005-01-15")
                },
                      new Student
                {
                    FirstName="Farid",
                    LastName="Mohd Ismail",
                    EnrollmentDate=DateTime.Parse("2005-01-15")
                },
                      new Student
                {
                    FirstName="Musamil",
                    LastName="Bin Daud",
                    EnrollmentDate=DateTime.Parse("2006-05-07")
                }
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course {CourseID=1050, Title="Chemistry", Credits=3 },
                new Course {CourseID=4022, Title="Microeconimic", Credits=3 },
                new Course {CourseID=4041, Title="Data Structures", Credits=3 },
                new Course {CourseID=1045, Title="C Programming", Credits=4 },
                new Course {CourseID=3141, Title="Database", Credits=4 },
                new Course {CourseID=2021, Title="Literature", Credits=3 },
                new Course {CourseID=2042, Title="Networking", Credits=4 },
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment {StudentID=1, CourseID=1050, Grade=Grade.A },
                new Enrollment {StudentID=1, CourseID=4022, Grade=Grade.C },
                new Enrollment {StudentID=1, CourseID=4041, Grade=Grade.B },
                new Enrollment {StudentID=2, CourseID=1045, Grade=Grade.B },
                new Enrollment {StudentID=2, CourseID=3141, Grade=Grade.F },
                new Enrollment {StudentID=2, CourseID=2021, Grade=Grade.F },
                new Enrollment {StudentID=3, CourseID=1050},
                new Enrollment {StudentID=4, CourseID=1050},
                new Enrollment {StudentID=4, CourseID=4022, Grade=Grade.F },
                new Enrollment {StudentID=5, CourseID=4041, Grade=Grade.C },
                new Enrollment {StudentID=6, CourseID=1045, Grade=Grade.C },
                new Enrollment {StudentID=6, CourseID=3141, Grade=Grade.A },

            };

            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

        }
    }
}
