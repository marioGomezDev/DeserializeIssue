using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeserializeIssue.Models
{
    public abstract class Person : Identifiable
    { 
        protected Person()
        {
        }

        [Attr("person-prop")]
        public string PersonProp { get; set; }
    }
}
