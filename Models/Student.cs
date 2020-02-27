using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeserializeIssue.Models
{
    public class Student : Person
    {
        public Student() : base()
        {
        }

        [Attr("student-prop")]
        public string StudentProp { get; set; }
    }
}
