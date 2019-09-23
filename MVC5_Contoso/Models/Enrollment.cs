namespace MVC5_Contoso.Models
{
    public enum Grades
    {
        First,
        UpperSecond,
        LowerSecond,
        Third,
        Pass,
        Fail
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grades? Grade { get; set; }

        // A student enrolled on a course
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}