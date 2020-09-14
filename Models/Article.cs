using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace DeserializeIssue.Models
{
    public class Article : Identifiable
    {
        [Attr(PublicName = "article-prop")]
        public string ArticleProp { get; set; }

        public int AuthorId { get; set; }

        [HasOne(PublicName = "author")]
        public Person Author{ get; set; }
    }
}
