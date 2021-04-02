using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {

        //primary key
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }


        //Nagigator property
        //virtual->lazy loading - https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/reading-related-data-with-the-entity-framework-in-an-asp-net-mvc-application
        //ICollection- > declare a list of entries

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}