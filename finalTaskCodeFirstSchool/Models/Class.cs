using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace finalTaskCodeFirstSchool.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        // Navigation properties
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}