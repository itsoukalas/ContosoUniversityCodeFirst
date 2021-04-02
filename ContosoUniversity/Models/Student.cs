using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {

        //primary key
        public int ID { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name ="First Name")]
        public string FirstMidName { get; set; }
        [Display(Name ="Date")]
        public DateTime EnrollmentDate { get; set; }


        //Nagigator property
        //virtual->lazy loading - https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/reading-related-data-with-the-entity-framework-in-an-asp-net-mvc-application
        //ICollection- > declare a list of entries

        [Display(Name ="Enrollment list")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}