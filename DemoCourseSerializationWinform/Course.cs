﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCourseSerializationWinform
{
    [Serializable]
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public int fees { get; set; }
    }
}
