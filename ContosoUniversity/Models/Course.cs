using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        /**
       * This attributes lets you enter the primary key for the course rather than
       * having the database generate it
       */
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //primary key
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //navigation property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}