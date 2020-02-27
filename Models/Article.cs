using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeserializeIssue.Models
{
    public class Article : Identifiable
    {
        [Attr("article-prop")]
        public string ArticleProp { get; set; }

        public int AuthorId { get; set; }

        [HasOne("author")]
        public Person Author{ get; set; }
    }
}
