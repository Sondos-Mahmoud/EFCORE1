﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCORE1.Entities
{
    //public class StudCourse
    //{
    //    [Key]

    //    public int Stud_ID { get; set; }


    //    public int Course_ID { get; set; } 

    //    public int Grade { get; set; } 
    //}
    public class StudCourse
    {
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public int Grade { get; set; }

        // Navigation Properties
        [ForeignKey("Stud_ID")]
        public Student Student { get; set; }

        [ForeignKey("Course_ID")]
        public Course Course { get; set; }
    }
}