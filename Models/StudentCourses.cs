﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Models
{
    
    public class StudentCourses
    {
        public int StudentId { get; set; }
        public Students Student { get; set; }

        public int CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
