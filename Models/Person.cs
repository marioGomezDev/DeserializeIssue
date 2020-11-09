using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace DeserializeIssue.Models
{
    public abstract class Person : Identifiable
    { 
        protected Person()
        {
        }

        [Attr(PublicName = "person-prop")]
        public string PersonProp { get; set; }
    }
}
