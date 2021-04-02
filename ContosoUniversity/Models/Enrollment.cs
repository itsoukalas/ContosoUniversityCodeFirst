namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        //primary key
        public int EnrollmentID { get; set; }

     
        public int StudentID { get; set; }

        //? - > the Grade property is nullable
        //nullable- > a grade isn't known or hasn't been assigned yet
        public Grade? Grade { get; set; }



        public virtual Course Course { get; set; }

        //Foreign key
        public int CourseID { get; set; }
        //navigation property,can only hold a single entity
        public virtual Student Student { get; set; }
    }
}