﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yemektariflerii.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public bool IsDeleted { get; set; }
    }
}