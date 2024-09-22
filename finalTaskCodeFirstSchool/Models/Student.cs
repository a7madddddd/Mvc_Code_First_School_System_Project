using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalTaskCodeFirstSchool.Models
{
   public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        // Foreign key property
        public int ClassId { get; set; }

        // Navigation property
        public virtual Class Class { get; set; }
    }

    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }

        // Navigation property
        public virtual Class Class { get; set; }
        public object ClassId { get; internal set; }
    }
}