using DeserializeIssue.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace DeserializeIssue.Controllers
{
    //[Route("api/[controller]")]
    public class StudentsController : JsonApiController<Student>
    {
        public StudentsController(IJsonApiOptions options, ILoggerFactory loggerFactory, IResourceService<Student, int> resourceService) 
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}