using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamRoster.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        // Primary Key. EF will use a property marked either ID or classID
        public int EnrollmentID { get; set; }

        // Foreign Keys. These properties reference the primary keys of other entities
        // EF Naming Convention: <Navigation Property Name><Primary Key Name>
        //      Here, it's CourseID because Navigation Property is Course, and
        //      the Course primary key is ID.
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        // The ? after Grade marks this property as nullable
        public Grade? Grade { get; set; }

        // Navigation Properties
        // The "type" references a class, i.e. TeamRoster.Models.Student
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}