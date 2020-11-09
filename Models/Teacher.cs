using JsonApiDotNetCore.Resources.Annotations;

namespace DeserializeIssue.Models
{
    public class Teacher : Person
    {
        [Attr(PublicName = "teacher-prop")]
        public string TeacherProp { get; set; }
    }
}
