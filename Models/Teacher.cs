using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeserializeIssue.Models
{
    public class Teacher : Person
    { 
        public Teacher() : base()
        {
        }

        [Attr("teacher-prop")]
        public string TeacherProp { get; set; }
    }
}
