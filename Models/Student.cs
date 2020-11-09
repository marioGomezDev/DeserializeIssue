using JsonApiDotNetCore.Resources.Annotations;

namespace DeserializeIssue.Models
{
    public class Student : Person
    {
        [Attr(PublicName = "student-prop")]
        public string StudentProp { get; set; }
    }
}
