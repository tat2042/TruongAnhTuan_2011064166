﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruongAnhTuan_2011064166.Models;

namespace TruongAnhTuan_2011064166.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourse { get; set; }
        public bool ShowAction { get; set; }
    }
}