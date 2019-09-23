namespace MVC5_Contoso.Migrations
{
    using MVC5_Contoso.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC5_Contoso.Data.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVC5_Contoso.Data.UniversityContext";
        }

        protected override void Seed(MVC5_Contoso.Data.UniversityContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=30,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=30,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=30,},
            new Course{CourseID=1045,Title="Calculus",Credits=10,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=20,},
            new Course{CourseID=2021,Title="Composition",Credits=15,},
            new Course{CourseID=2042,Title="Literature",Credits=15,}
            };

            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.First},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.LowerSecond},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.UpperSecond},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.UpperSecond},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.Fail},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.Fail},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.Fail},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.LowerSecond},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.First},
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s =>
                         s.Student.StudentID == e.StudentID &&
                         s.Course.CourseID == e.CourseID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();

        }
    }
}
