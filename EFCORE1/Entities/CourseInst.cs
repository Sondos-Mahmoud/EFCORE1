﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCORE1.Entities
{
    public class CourseInst
    {
   
        public int Inst_ID { get; set; }

        public int Evaluate { get; set; }
        public int Course_ID { get; set; }
    }
}