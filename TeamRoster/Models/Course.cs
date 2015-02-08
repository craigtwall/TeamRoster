using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamRoster.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        // Primary Key
        public int CourseID { get; set; }

        public string Title { get; set; }
        public int Credits { get; set; }

        // Navigation Property. 1-to-Many, so it's in a list
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}