﻿using System.ComponentModel.DataAnnotations;

namespace EFCORE1.Entities
{

    public class Topic
    {
        [Key]
        public int Topic_ID { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public ICollection<Course> Courses { get; set; }
    }
}