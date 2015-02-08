using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamRoster.Models
{
    public class Student
    {
        // EF will use any property labeled ID or classID as this entity's Primary Key
        public int ID { get; set; }

        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation Property: Holds entities related to this one.
        // If multiple entities can be related to this one, such as 
        // 1 student enrolling in >1 courses, we have to put these 
        // entities in a list that can be added/deleted/updated.
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}